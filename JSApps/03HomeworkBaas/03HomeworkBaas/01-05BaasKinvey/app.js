(function () {
    require.config({
        baseUrl: "",
        paths: {
            "jquery": "libs/jquery/dist/jquery",
            "Q": "libs/q/q",
            "AppController": "Controllers/AppController",
            "Requester": "Controllers/Requester",
            "UsersRequester": "Controllers/Users",
            "CollectionRequester": "Controllers/CollectionRequester",
            "Town": "Models/Town",
            "Country": "Models/Country"
        }
    });
})();


require(['Town', 'Country', 'AppController'], function (Town, Country, AppController) {

        var countries = [];
        var towns = [];

        initializeCountries();
        initializeTowns();

        function initializeCountries() {
            AppController.GetAllCountries().then(function (success) {
                countries = success;
                buildCountriesDOM();

                //event listeners for editing countries
                $("#countryEdit").on("click", function () {
                    var country = countries.filter(function (el) {
                        return el.name === $("#countryEditInput").val();
                    });
                    if (country.length > 0) {
                        $("#countryEditName").val(country[0].name);
                        $("#countryEditOptions").css({'display': 'block'});
                    }
                });
                $("#countryEditConfirm").on("click", function () {
                    var country = countries.filter(function (el) {
                        return el.name === $("#countryEditInput").val();
                    });
                    if (country.length > 0) {
                        country[0].name = $("#countryEditName").val();
                        AppController.EditCountry(country[0]._id, new Country(country[0].name)).then(function (editedCountry) {
                            $("#countryEditOptions").css({'display': 'none'});
                            var editedCountryDOM = $("#" + editedCountry._id);
                            editedCountryDOM.text("Name: " + editedCountry.name);
                            editedCountryDOM.attr("name", editedCountry.name);
                        });
                    }
                });

                //event listener for adding countries
                $("#countryAdd").on("click", function () {
                    var countryToAdd = $("#countryAddInput").val();
                    if (countryToAdd) {
                        AppController.AddCountry(new Country(countryToAdd)).then(function (country) {
                            countries.push(country);
                            var ul = $("#countries ul");
                            var newCountry = $("<li>");
                            newCountry.text("Name: " + country.name);
                            newCountry.attr("id", country._id);
                            newCountry.attr("name", country.name);
                            newCountry.on("click", function (event) {
                                AppController.QueryTowns({'country': event.target.getAttribute('name')}).then(function (success) {
                                    towns = success;
                                    buildTownsDOM();
                                });
                            });
                            newCountry.appendTo(ul);
                        });
                    }
                });

                //event listener for deleting countries
                $("#countryDelete").on("click", function () {
                    var countryToDelete = countries.filter(function (el) {
                        return el.name === $("#countryDeleteInput").val();
                    });
                    if (countryToDelete.length > 0) {
                        AppController.DeleteCountry(countryToDelete[0]._id).then(function () {
                            countries = countries.filter(function (el) {
                                return el._id !== countryToDelete[0]._id;
                            });
                            var deletedCountry = $("#" + countryToDelete[0]._id);
                            deletedCountry.remove();
                        });
                    }
                });

            })
        }

        function initializeTowns() {
            AppController.GetAllTowns().then(function (success) {
                towns = success;
                buildTownsDOM();

                //event listeners for editing towns
                $("#townEdit").on("click", function () {
                    var town = towns.filter(function (el) {
                        return el.name === $("#townEditInput").val();
                    });
                    if (town.length > 0) {
                        $("#townEditName").val(town[0].name);
                        $("#townEditCountry").val(town[0].country);
                        $("#townEditOptions").css({'display': 'block'});
                    }
                });
                $("#townEditConfirm").on("click", function () {
                    var town = towns.filter(function (el) {
                        return el.name === $("#townEditInput").val();
                    });
                    if (town.length > 0) {
                        town[0].name = $("#townEditName").val();
                        town[0].country = $("#townEditCountry").val();
                        AppController.EditTown(town[0]._id, new Town(town[0].name, town[0].country)).then(function (editedTown) {
                            $("#townEditOptions").css({'display': 'none'});
                            $("#" + editedTown._id).text("Name: " + editedTown.name + ", Country: " + editedTown.country);
                        });
                    }
                });

                //event listener for adding towns
                $("#townAdd").on("click", function () {
                    var townNameToAdd = $("#townAddName").val();
                    var townCountryToAdd = $("#townAddCountry").val();
                    if (townNameToAdd && townCountryToAdd) {
                        AppController.AddTown(new Town(townNameToAdd, townCountryToAdd)).then(function (town) {
                            towns.push(town);
                            var ul = $("#towns ul");
                            var newTown = $("<li>");
                            newTown.text("Name: " + town.name + ", Country: " + town.country);
                            newTown.attr("id", town._id);
                            newTown.appendTo(ul);
                        });
                    }
                });

                //event listener for deleting towns
                $("#townDelete").on("click", function () {
                    var townToDelete = towns.filter(function (el) {
                        return el.name === $("#townDeleteInput").val();
                    });
                    if (townToDelete.length > 0) {
                        AppController.DeleteTown(townToDelete[0]._id).then(function () {
                            towns = towns.filter(function (el) {
                                return el._id !== townToDelete._id;
                            });
                            var deletedTown = $("#" + townToDelete[0]._id);
                            deletedTown.remove();
                        });
                    }
                });

            })
        }

        function buildCountriesDOM() {
            var countriesContainer = $("#countries");
            var countriesUl = $("<ul>");
            countriesContainer.empty();
            countries.forEach(function (country) {
                var countryLi = $("<li>");
                countryLi.text("Name: " + country.name);
                countryLi.attr("id", country._id);
                countryLi.attr("name", country.name);
                countryLi.on("click", function (event) {
                    AppController.QueryTowns({'country': event.target.getAttribute('name')}).then(function (success) {
                        towns = success;
                        buildTownsDOM();
                    })
                });
                countriesUl.append(countryLi);
            });
            countriesUl.appendTo(countriesContainer);
        }

        function buildTownsDOM() {
            var townsContainer = $("#towns");
            var townsUl = $("<ul>");
            townsContainer.empty();
            towns.forEach(function (town) {
                var townLi = $("<li>");
                townLi.text("Name: " + town.name + ", Country: " + town.country);
                townLi.attr("id", town._id);
                townsUl.append(townLi);
            });
            townsUl.appendTo(townsContainer);
        }

    }
)
;