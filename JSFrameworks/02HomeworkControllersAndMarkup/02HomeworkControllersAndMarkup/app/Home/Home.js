"use strict";

angular.module("videoApp.Home", ['ngRoute', 'myFilters'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/Home', {
            templateUrl: 'Home/Home.html',
            controller: 'HomeController'
        });
    }])
    .controller('HomeController', ['$scope', 'videos', function ($scope, videos) {

        $scope.videos = videos.getVideos();
		
		console.log($scope.videos[0].date);

        $scope.clearFilter = function () {
            this.currentFilter = undefined;
        };
		
		$scope.show = function(videodate){
			console.log(videodate);
		}


    }]);