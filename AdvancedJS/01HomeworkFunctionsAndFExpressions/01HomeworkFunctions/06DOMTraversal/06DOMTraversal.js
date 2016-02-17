function drawDOMTree(selector){
    var element = document.querySelector(selector);
    for(var j =0; j <element.childNodes.length;j++)
    {
        if(element.childNodes[j].nodeName !== "#text")
        {
            traverse(element.childNodes[j],"");
        }

    }

    function traverse(element,indent){

        var idSpan = element.id ? " id=\"" + element.id + "\"" : "";

        var classSpan = element.className ? " class=\"" + element.className + "\"" : "";

        console.log(indent + element.localName + ":" + idSpan + classSpan);

        for(var i = 0;i<element.childNodes.length;i++)
        {
            if(element.childNodes[i].nodeName !== "#text") {
                traverse(element.childNodes[i], indent + "  ");
            }
        }
    }
}

var selector = ".birds";
drawDOMTree(selector);
