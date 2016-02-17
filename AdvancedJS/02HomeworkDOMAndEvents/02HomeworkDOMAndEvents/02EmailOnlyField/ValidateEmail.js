var text = document.getElementById("textfield");
var div = document.getElementById("checker");
var button = document.getElementById("validate");
button.addEventListener("click",validate,false);

function validate(){
    div.textContent = text.value;
    var regex = /\w+@\w+\.\w+/;
    if(regex.exec(div.textContent)){
        div.style.backgroundColor = "lightgreen";
    }
    else{
        div.style.backgroundColor = "red";
    }
}
