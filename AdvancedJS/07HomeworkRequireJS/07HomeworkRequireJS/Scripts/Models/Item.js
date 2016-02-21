define([],function(){
    var Item = (function (){
        function Item(title){
            checkTitle(title);
            this._title = title;
            this._domElement = this.buildDOM();
        }

        function checkTitle(title){
            if(!title){
                throw new Error("Title cannot be empty!");
            }
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

    return Item;
});