define(['Q','Requester'], function (Q) {
    var CollectionRequester = (function () {
        function CollectionRequester(name,requester) {
            this._requester = requester;
            this.serviceUrl = requester.baseUrl + 'appdata/' + requester.appId + '/' + name;
        }

        CollectionRequester.prototype.getAll = function () {
            var defer = Q.defer();
            this._requester.makeRequest('GET', this.serviceUrl, null,true).then(function (success) {
                var result = success;
                defer.resolve(result);
            }, function (error) {
                console.error(error);
                defer.reject(error);
            }).done();

            return defer.promise;
        };

        CollectionRequester.prototype.Edit = function (id,item) {
            var defer = Q.defer();
            var resourceUrl = this.serviceUrl + '/' + id;
            this._requester.makeRequest('PUT', resourceUrl, item,true).then(function (success) {
                defer.resolve(success);
            }, function (error) {
                console.error(error);
                defer.reject(error);
            }).done();

            return defer.promise;
        };

        CollectionRequester.prototype.Add = function (item) {
            var defer = Q.defer();
            this._requester.makeRequest('POST', this.serviceUrl, item,true).then(function (success) {
                defer.resolve(success);
            }, function (error) {
                console.error(error);
                defer.reject(error);
            }).done();

            return defer.promise;
        };

        CollectionRequester.prototype.Delete = function (id) {
            var defer = Q.defer();
            var resourceUrl = this.serviceUrl + '/' + id;
            this._requester.makeDeleteRequest('DELETE', resourceUrl, null,true).then(function (success) {
                defer.resolve(success);
            }, function (error) {
                console.error(error);
                defer.reject(error);
            }).done();

            return defer.promise;
        };

        CollectionRequester.prototype.Query = function (query) {
            var defer = Q.defer();
            var resourceUrl = this.serviceUrl + '/' + "?query=" + JSON.stringify(query);
            this._requester.makeDeleteRequest('GET', resourceUrl, null,true).then(function (success) {
                defer.resolve(success);
            }, function (error) {
                console.error(error);
                defer.reject(error);
            }).done();

            return defer.promise;
        };


        return CollectionRequester;
    })();

    return CollectionRequester;
});
