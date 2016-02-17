var idNode = document.getElementById("id");
var textNode = document.getElementById("text");
var button = document.getElementById("addParagraph");
button.addEventListener("click",function(){createParagraph(idNode.value,textNode.value)},false);

function createParagraph(id,text){
    var parent = document.getElementById(id);
    var paragraph = document.createElement("p");
    paragraph.textContent = text;
    parent.appendChild(paragraph);
}

