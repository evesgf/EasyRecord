var app=angular.module("app",[]);
app.config(['$routeProvider'],function($routeProvider){
    $routeProvider.when("/list",{
        templateUrl: 'views/list.html',
        controller: 'ListCtl'
    }).when("/detail/:id",{
        templateUrl: 'views/detail.html',
        controller: 'DetailCtl'
    }).otherwise({
        redirectTo: '/list'
    });
});