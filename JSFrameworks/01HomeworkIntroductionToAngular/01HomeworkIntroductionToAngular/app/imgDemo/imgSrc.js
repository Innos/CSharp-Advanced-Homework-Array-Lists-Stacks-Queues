'use strict';

angular.module('introductionApp.imgSrc',['ngRoute'])
    .config(['$routeProvider', function($routeProvider){
        $routeProvider.when("/imgSrc",{
            templateUrl:"imgDemo/imgSrc.html",
            controller:"ImageDemoController"
        });
    }])
    .controller("ImageDemoController",['$scope',function($scope){
        $scope.value = "https://s-media-cache-ak0.pinimg.com/736x/90/6e/80/906e80530ccb69ed9b67aff5f5c8eb19.jpg"
    }]);
