define(['Section'],function(Section){
    var Container = (function () {
        function Container(title){
            checkTitle(title);
            this._title = title;
            this._domElement = this.buildDOM();
            this.addToDOM();
        }

        function checkTitle(title){
            if(!title){
                throw new Error("Title cannot be empty!");
            }
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

    return Container;
});
