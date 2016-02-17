var checkbox = document.getElementById("invoiceCheckbox");
checkbox.addEventListener("click",display,false);
var invoice = document.getElementById("invoice");
function display(){
    if(checkbox.checked){
        invoice.style.visibility = "visible";
    }
    else{
        invoice.style.visibility = "hidden";
    }

}
