var HTMLGen = (function (){
    function createParagraph(id,text){
        var parent = document.getElementById(id);
        var paragraph = document.createElement("p");
        paragraph.textContent = text;
        parent.appendChild(paragraph);
    }
    function createDiv(id,className){
        var parent = document.getElementById(id);
        var div = document.createElement("div");
        div.className = className;
        parent.appendChild(div);
    }
    function createLink(id,text,url) {
        var parent = document.getElementById(id);
        var link = document.createElement("a");
        link.textContent = text;
        link.href = url;
        parent.appendChild(link);
    }

    return{
        createParagraph: createParagraph,
        createDiv: createDiv,
        createLink: createLink
    }
})();

HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');

