var domModule = (function () {

    function appendChild(child, parent) {
        addRemove(child, parent, true);
    }

    function removeChild(parent, child) {
        addRemove(child, parent, false);
    }

    function addHandler(element, eventType, eventHandler) {
        if (element instanceof HTMLElement) {
            element.addEventListener(eventType, eventHandler, false);
        }
        else {
            element = retrieveElements(element);
            for (var i = 0; i < element.length; i++) {
                element[i].addEventListener(eventType,eventHandler,false);
            }
        }
    }

    function retrieveElements(selector) {
        return document.querySelectorAll(selector);
    }

    function addRemove(child, parent, append) {
        if (parent instanceof HTMLElement) {
            if (child instanceof HTMLElement) {
                DOMtoDOM(child, parent, append);
            }
            else {
                SelectorToDOM(child, parent, append);
            }
        }
        else {
            parent = retrieveElements(parent);
            if (child instanceof HTMLElement) {
                DOMtoSelector(child, parent, append);
            }
            else {
                child = retrieveElements(child);
                SelectorToSelector(child, parent, append);
            }
        }
    }

    function DOMtoDOM(child, parent, append) {
        if (append) {
            parent.appendChild(child);
        }
        else {
            var children = Array.prototype.slice.call(parent.childNodes);
            if (children.indexOf(child) !== -1) {
                parent.removeChild(child);
            }

        }

    }

    function DOMtoSelector(child, parent, append) {
        if (append) {
            for (var i = 0; i < parent.length; i++) {
                parent[i].appendChild(child);
            }
        }
        else {
            for (var i = 0; i < parent.length; i++) {
                var children = Array.prototype.slice.call(parent[i].childNodes);
                if (children.indexOf(child) !== -1) {
                    parent[i].removeChild(child);
                }
            }
        }
    }

    function SelectorToDOM(child, parent, append) {
        if (append) {
            for (var i = 0; i < child.length; i++) {
                parent.appendChild(child[i]);
            }
        }
        else {
            var children = Array.prototype.slice.call(parent.childNodes);
            for (var i = 0; i < child.length; i++) {
                if (children.indexOf(child[i]) !== -1) {
                    parent.removeChild(child[i]);
                }
            }
        }

    }

    function SelectorToSelector(child, parent, append) {
        if (append) {
            for (var i = 0; i < parent.length; i++) {
                for (var j = 0; j < child.length; j++) {
                    parent[i].appendChild(child[j]);
                }
            }
        }
        else {
            for (var i = 0; i < parent.length; i++) {
                for (var j = 0; j < child.length; j++) {
                    var children = Array.prototype.slice.call(parent[i].childNodes);
                    if (children.indexOf(child[j]) !== -1) {
                        parent[i].removeChild(child[j]);
                    }
                }
            }
        }

    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    }

})();


var liElement = document.createElement("li");

// Appends a list item to ul.birds-list
domModule.appendChild(liElement, ".birds-list");
// Removes the first li child from the bird list
domModule.removeChild("ul.birds-list", "li:first-child");
// Adds a click event to all bird list items
//selector caught nothing (no <li>'s with class .birds) so i changed it
domModule.addHandler(".birds", 'click', function () {
    alert("I'm a bird!")
});
// Retrives all elements of class "bird"
var elements = domModule.retrieveElements(".bird");
console.log(elements);




