"use strict";

angular.module("introductionApp.student",['ngRoute'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/student',{
            templateUrl: 'students/student.html',
            controller: 'StudentController'
        });
    }])
    .controller('StudentController',['$scope',function($scope){
        $scope.student = {
            "name": "Pesho",
            "photo": "http://www.nakov.com/wp-content/uploads/2014/05/SoftUni-Logo.png",
            "grade": 5,
            "school": "High School of Mathematics",
            "teacher": "Gichka Pesheva"
        };
    }]);
