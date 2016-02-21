define(['Item'],function(Item){
    var Section = (function (){
        function Section(title){
            checkTitle(title);
            this._title = title;
            this._domElement = this.buildDOM();
        }

        function checkTitle(title){
            if(!title){
                throw new Error("Title cannot be empty!");
            }
        }

        Section.prototype.buildDOM = function buildDOM(){
            var section = document.createElement("article"),
                items = document.createElement("div"),
                title = document.createElement("h2"),
                input = document.createElement("input"),
                button = document.createElement("button");

            section.className = "section";
            title.textContent = this._title;
            items.className = "items";

            input.type = "text";
            input.className = "listInput";
            input.placeholder = "Add Item...";

            button.textContent = "+";
            button.className = "button";
            button.addEventListener("click",createItem);

            items.appendChild(title);

            section.appendChild(items);
            section.appendChild(input);
            section.appendChild(button);

            return section;
        };

        Section.prototype.addToDOM = function addToDOM(parent){
            parent.appendChild(this._domElement);
        };

        function createItem(){
            var parent = this.parentNode,
                title = parent.querySelector(".listInput").value,
                item = new Item(title),
                items = parent.querySelector(".items");
            item.addToDOM(items);
        }
        return Section;
    })();

    return Section;
});