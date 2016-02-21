(function () {
    require.config({
        baseUrl: "Scripts",
        paths: {
            "Container": "Models/Container",
            "Section": "Models/Section",
            "Item": "Models/Item",
            "Factory": "Factories/Factory"
        }
    });
})();

//The API doesn't expose methods for manually creating Sections or Items, the creation is delegated to
//buttons in the DOM so the new objects know who their parent is and where in the DOM they belong
require(["Factories/Factory"], function (factory) {
    factory.createList("Tuesday TODO List");
    factory.createList("Wednesday TODO List");
});


