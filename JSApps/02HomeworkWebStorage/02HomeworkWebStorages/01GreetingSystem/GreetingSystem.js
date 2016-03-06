if(!localStorage.user){

    var rowContainer = $("<div>");
    rowContainer.css({'margin':'auto','width':'25%'});

    var input = $('<input type="text">');
    input.attr("placeholder","Input name");
    input.css({'display':'inline-block','margin':'auto','font-size':"1.5em"});

    var login = $("<button>");
    login.text("Login");
    login.css({'display':'inline-block','margin-left':'10px','font-size':'1.3em'});
    login.on("click",function(){
        localStorage.user = input.val();
        var success = $("<p>Succesfully logged in!</p>");
        success.css({'text-align':'center'});
        $(document.body).append(success);
        location.reload();
    });

    rowContainer.append(input);
    rowContainer.append(login);

    var h1 = $("<h1>");
    h1.text("Welcome guest, input your name bellow");
    h1.css({'text-align':'center'});
    $(document.body).append(h1);
    $(document.body).append(rowContainer);
}
else{
    var h1 = $("<h1>");
    h1.text("Welcome back, " + localStorage.user);
    h1.css({'text-align':'center'});
    $(document.body).append(h1);

    var logout = $("<button>");
    logout.text("Log Out");
    logout.css({'display':'block','margin':'auto','font-size':'1.3em'});
    logout.on("click",function(){
        localStorage.removeItem('user');
        var success = $("<p>Succesfully logged out!</p>");
        success.css({'text-align':'center'});
        $(document.body).append(success);
        location.reload();
    });
    logout.appendTo($(document.body));
}

if(!sessionStorage.counter){
    sessionStorage.counter = 0;
}
else{
    var counter = Number(sessionStorage.getItem('counter'));
    counter++;
    sessionStorage.setItem('counter',counter);
}

var sessionVisits = $("<p>");
sessionVisits.text("Number of session visits: " + sessionStorage.counter);
sessionVisits.appendTo($(document.body));

if(!localStorage.counter){
    localStorage.counter = 0;
}else{
    var counter = Number(localStorage.getItem('counter'));
    counter++;
    localStorage.setItem('counter',counter);
}

var totalVisits = $("<p>");
totalVisits.text("Number of total visits: " + localStorage.counter);
totalVisits.appendTo($(document.body));
