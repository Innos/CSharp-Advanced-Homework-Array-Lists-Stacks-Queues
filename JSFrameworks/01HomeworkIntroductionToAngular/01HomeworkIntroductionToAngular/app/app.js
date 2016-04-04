'use strict';

angular.module('introductionApp', [
    'ngRoute',
    'introductionApp.student',
    'introductionApp.imgSrc'
])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.otherwise({redirectTo: '/student'});
    }]);