"use strict";

angular.module("videoApp.Home",['ngRoute','myFilters'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/Home',{
            templateUrl: 'Home/Home.html',
            controller: 'HomeController'
        });
    }])
    .controller('HomeController',['$scope',function($scope){
        var video = new Video('Course introduction','http://newtrend.bg/wp-content/uploads/2015/03/SoftUni-Logo.png','3:32:01','IT',3,new Date(2014,12,15),false);
        var video2 = new Video('JS Frameworks','http://code-maven.com/img/angularjs.png','1:30:12','Java Script',21,new Date(2016,4,1),true);
        var video3 = new Video('Applications JS','http://newtrend.bg/wp-content/uploads/2015/03/SoftUni-Logo.png','2:15:17','Java Script',48,new Date(2016,5,2),true);
        video2.addComment(new Comment("Gosho","Damn Hard. Need more info.",new Date(2016, 4, 4, 12, 30, 0),'https://softuni.bg'));
        video2.addComment(new Comment("Pesho","De si be Gosho, che mi grumna glavata ot toq Angular da piem po edna bira!",new Date(2016, 4, 5, 22, 30, 0),'http://www.pesho.pl/'));
        video.addComment(new Comment("Pesho","Congratulations Nakov",new Date(2016, 11, 9, 12, 30, 0),'http://www.pesho.pl/'));
        $scope.videos = [video,video2,video3];
    }]);