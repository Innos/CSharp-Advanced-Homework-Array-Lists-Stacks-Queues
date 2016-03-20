var app = app || {};

app.book = (function () {
    function Book(baseUrl, appId, credentials, requester) {
        this._requester = requester;
        this.serviceUrl = baseUrl + "/appdata/" + appId + "/books/";
        this.credentials = credentials;
    }

    Book.prototype.getAll = function () {
        return this._requester.get(this.serviceUrl, this.credentials.getHeaders(false, true));
    };

    Book.prototype.create = function (data) {
        return this._requester.post(this.serviceUrl, data, this.credentials.getHeaders(true, true));
    };

    Book.prototype.update = function (id,data) {
        var url = this.serviceUrl + id;
        return this._requester.put(url, data, this.credentials.getHeaders(true, true));
    };

    Book.prototype.deleteBook = function (id) {
        var url = this.serviceUrl + id;
        return this._requester.delete(url, this.credentials.getHeaders(false, true));
    };

    return {
        load: function (baseUrl, appId, credentials, requester) {
            return new Book(baseUrl, appId, credentials, requester);
        }

    }
}());