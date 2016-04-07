"use strict";

angular.module("videoApp.Home", ['ngRoute', 'myFilters'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/Home', {
            templateUrl: 'Home/Home.html',
            controller: 'HomeController'
        });
    }])
    .controller('HomeController', ['$scope', 'videos', function ($scope, videos) {

        $scope.createLengthSort = function () {
            $scope.currentSort = ["length.hours", "length.minutes", "length.seconds"]
        };

        $scope.videos = videos.getVideos();

        $scope.clearFilter = function () {
            this.currentFilter = undefined;
        };


    }]);