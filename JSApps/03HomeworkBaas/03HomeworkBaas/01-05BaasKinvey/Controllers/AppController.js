define(['Q', 'Requester', "UsersRequester", "CollectionRequester", "Town", "Country"], function (Q, Requester, UserModule, CollectionRequester, Town, Country) {
    var AppController = (function () {
        var requester = Requester.config('kid_-yB8zeMTAl', 'ce4b486edf1748e1a4e37eb98a09057f');
        var User = new UserModule(requester);
        var TownsRequester = new CollectionRequester("Towns", requester);
        var CountriesRequester = new CollectionRequester("Countries", requester);

        function GetAllTowns() {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    TownsRequester.getAll().then(function (success) {
                        defer.resolve(success);
                    }, function (error) {
                        console.error(error);
                        defer.reject();
                    }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function EditTown(id, town) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    TownsRequester.Edit(id, town).then(function (success) {
                        defer.resolve(success);
                    }, function (error) {
                        console.error(error);
                        defer.reject(error);
                    }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function AddTown(town) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    TownsRequester.Add(town)
                        .then(function (success) {
                            defer.resolve(success);
                        }, function (error) {
                            console.error(error);
                            defer.reject(error);
                        }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function DeleteTown(id) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    TownsRequester.Delete(id)
                        .then(function (success) {
                            defer.resolve(success);
                        }, function (error) {
                            console.error(error);
                            defer.reject(error);
                        }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function QueryTowns(query) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    TownsRequester.Query(query)
                        .then(function (success) {
                            defer.resolve(success);
                        }, function (error) {
                            console.error(error);
                            defer.reject(error);
                        }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function GetAllCountries() {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    CountriesRequester.getAll().then(function (success) {
                        defer.resolve(success);
                    }, function (error) {
                        console.error(error);
                        defer.reject(error);
                    }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function EditCountry(id, country) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    CountriesRequester.Edit(id, country).then(function (success) {
                        defer.resolve(success);
                    }, function (error) {
                        console.error(error);
                        defer.reject(error);
                    }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function AddCountry(country) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    CountriesRequester.Add(country)
                        .then(function (success) {
                            defer.resolve(success);
                        }, function (error) {
                            console.error(error);
                            defer.reject(error);
                        }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        function DeleteCountry(id) {
            var defer = Q.defer();
            User.login("Pesho", "123")
                .then(function () {
                    CountriesRequester.Delete(id)
                        .then(function (success) {
                            defer.resolve(success);
                        }, function (error) {
                            console.error(error);
                            defer.reject(error);
                        }).done();
                }, function (error) {
                    console.error(error);
                });
            return defer.promise;
        }

        return {
            GetAllTowns: GetAllTowns,
            GetAllCountries: GetAllCountries,
            EditCountry: EditCountry,
            EditTown: EditTown,
            AddCountry: AddCountry,
            AddTown: AddTown,
            DeleteCountry: DeleteCountry,
            DeleteTown: DeleteTown,
            QueryTowns: QueryTowns
        };
    })();

    return AppController;
});