var app=angular.module("app",['ngRoute']);
app.config(function($routeProvider,$locationProvider){
    $routeProvider.when("/list",{
        templateUrl: 'views/list.html',
        controller: 'ListCtrl'
    }).when("/detail/:id",{
        templateUrl: 'views/detail.html',
        controller: 'DetailCtrl'
    }).otherwise({
        redirectTo: '/list'
    });
});