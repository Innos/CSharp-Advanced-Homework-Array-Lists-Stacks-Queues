var app = app || {};

(function () {
    app.router = Sammy(function () {
        var wrapper = "#wrapper";

        this.get('#/', function () {
            var list = $("<ul>");
            list.append($('<li><a href="#/Sam">Sam</a></li>'));
            list.append($('<li><a href="#/Bob">Bob</a></li>'));
            list.append($('<li><a href="#/Jichka">Jichka</a></li>'));
            list.append($('<li><a href="#/Penka">Penka</a></li>'));
            list.appendTo(wrapper);
        });

        this.get('#/Sam', function () {
            ShowGreeting(wrapper,"Sam");
        });

        this.get('#/Bob', function () {
            ShowGreeting(wrapper,"Bob");
        });

        this.get('#/Jichka', function () {
            ShowGreeting(wrapper,"Jichka");
        });

        this.get('#/Penka', function () {
            ShowGreeting(wrapper,"Penka");
        });
    });
    app.router.run('#/');
})();

function ShowGreeting(selector, name) {
    var h2 = $("#title");
    h2.html("Hello, " + name);
    h2.prependTo(selector);
}