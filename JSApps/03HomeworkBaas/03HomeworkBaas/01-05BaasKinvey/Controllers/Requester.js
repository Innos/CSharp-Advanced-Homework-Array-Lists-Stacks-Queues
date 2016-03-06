define(['Q','jquery'], function(Q){
    var Requester = (function(){
        function Requester(appId, appSecret){
            this.appId = appId;
            this.appSecret = appSecret;
            this.baseUrl = "https://baas.kinvey.com/";
        }

        Requester.prototype.makeRequest = function(method,url,data,useSession){
            var token,
                defer = Q.defer(),
                options = {
                    method: method,
                    url: url,
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    data: JSON.stringify(data),
                    success: function(data){
                        defer.resolve(data);
                    },
                    error: function(error){
                        defer.reject(error);
                    }
                };

            if(!useSession){
                token = this.appId + ":" + this.appSecret;
                options.beforeSend = function(xhr){
                    xhr.setRequestHeader('Authorization','Basic ' + btoa(token));
                };
            }
            else{
                token = sessionStorage['sessionAuth'];
                options.beforeSend = function(xhr){
                    xhr.setRequestHeader('Authorization','Kinvey ' + token);
                };
            }


            $.ajax(options);

            return defer.promise;
        };

        Requester.prototype.makeDeleteRequest = function(method,url,data,useSession){
            var token,
                defer = Q.defer(),
                options = {
                    method: method,
                    url: url,
                    data: JSON.stringify(data),
                    success: function(data){
                        defer.resolve(data);
                    },
                    error: function(error){
                        defer.reject(error);
                    }
                };

            if(!useSession){
                token = this.appId + ":" + this.appSecret;
                options.beforeSend = function(xhr){
                    xhr.setRequestHeader('Authorization','Basic ' + btoa(token));
                };
            }
            else{
                token = sessionStorage['sessionAuth'];
                options.beforeSend = function(xhr){
                    xhr.setRequestHeader('Authorization','Kinvey ' + token);
                };
            }


            $.ajax(options);

            return defer.promise;
        };

        return {
            config: function(appId,appSecret){
                return new Requester(appId,appSecret);
            }
        };
    })();

    return Requester;
});