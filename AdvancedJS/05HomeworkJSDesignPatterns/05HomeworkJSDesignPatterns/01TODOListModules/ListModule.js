var ListModule = (function(){
    'use strict';

    function checkTitle(title){
        if(!title){
            throw new Error("Title cannot be empty!");
        }
    }

    var Container = (function () {
        function Container(title){
            checkTitle(title);
            this._title = title;
            this._domElement = this.buildDOM();
            this.addToDOM();
        }

        Container.prototype.buildDOM = function buildDOM(){
            var container = document.createElement("div"),
                title = document.createElement("h1"),
                sections = document.createElement("section"),
                input = document.createElement("input"),
                button = document.createElement("button");

            container.className = "list";
            title.textContent = this._title;
            sections.className = "sections";

            input.type = "text";
            input.className = "sectionInput";
            input.placeholder = "Title...";

            button.textContent = "Add new Section";
            button.className = "button";
            button.addEventListener("click",createSection);

            container.appendChild(title);
            container.appendChild(sections);
            container.appendChild(input);
            container.appendChild(button);

            return container;
        };

        Container.prototype.addToDOM = function addToDOM(){
            var parent = document.getElementById("wrapper");
            parent.appendChild(this._domElement);
        };

        function createSection(){
            var parent = this.parentNode,
                title = parent.querySelector(".sectionInput").value,
                section = new Section(title),
                sections = parent.querySelector(".sections");
            section.addToDOM(sections);
        }
        return Container;
    })();

    var Section = (function (){
        function Section(title){
            checkTitle(title);
            this._title = title;
            this._domElement = this.buildDOM();
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

        //find parent
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

    var Item = (function (){
        function Item(title){
            checkTitle(title);
            this._title = title;
            this._domElement = this.buildDOM();
        }

        Item.prototype.buildDOM = function buildDOM(){
            var container = document.createElement("div"),
                checkbox = document.createElement("input"),
                label = document.createElement("label");

            container.className = "line";

            checkbox.type = "checkbox";
            checkbox.className = "checkbox";
            checkbox.addEventListener("click",function(){
                if(this.checked){
                    this.nextSibling.style.backgroundColor = "lightgreen";
                }
                else{
                    this.nextSibling.style.backgroundColor = "white";
                }
            });

            label.textContent = this._title;
            label.className = "label";

            container.appendChild(checkbox);
            container.appendChild(label);
            return  container;
        };

        Item.prototype.addToDOM = function addToDOM(parent){
            parent.appendChild(this._domElement);
        };
        return Item;
    })();

    return {
        createList: function(title){
            var newList = new Container(title);
        }
    }
})();

ListModule.createList("Tuesday TODO List");
ListModule.createList("Wednesday TODO List");