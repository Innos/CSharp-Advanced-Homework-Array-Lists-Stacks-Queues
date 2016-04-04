'use strict';

angular.module('videoApp', [
    'ngRoute',
    'videoApp.Home',
    'myFilters'
])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.otherwise({redirectTo: '/Home'});
    }]);