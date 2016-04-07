'use strict';

angular.module('videoApp', [
    'ngRoute',
    'videoApp.Home',
    'videoApp.AddVideo',
    'videoApp.services.videos',
    'myFilters'
])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.otherwise({redirectTo: '/Home'});
    }]);