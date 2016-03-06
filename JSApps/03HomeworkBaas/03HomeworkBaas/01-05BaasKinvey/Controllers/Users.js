define(['Q','Requester'], function (Q) {
    var Users = (function () {
        function Users(requester) {
            this._requester = requester;
            this.serviceUrl = requester.baseUrl + 'user/' + requester.appId;
        }

        Users.prototype.signUp = function (username, password) {
            var defer = Q.defer();
            var requestUrl = this.serviceUrl,
                data = {
                    username: username,
                    password: password,
                };
            this._requester.makeRequest('POST', requestUrl, data,false).then(function (success) {
                var result = success;
                sessionStorage['sessionAuth'] = result._kmd.authtoken;
                defer.resolve();
            }, function (error) {
                console.error(error);
                defer.reject();
            }).done();

            return defer.promise;
        };

        Users.prototype.login = function (username, password) {
            var defer = Q.defer();
            var requestUrl = this.serviceUrl + '/login',
                data = {
                    username: username,
                    password: password,
                };
            this._requester.makeRequest('POST', requestUrl, data,false).then(function (success) {
                var result = success;
                sessionStorage['sessionAuth'] = result._kmd.authtoken;
                defer.resolve();
            }, function (error) {
                console.error(error);
                defer.reject();
            }).done();

            return defer.promise;
        };


        return Users;
    })();

    return Users;
});