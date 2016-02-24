
app.config(function($routeProvider){
    $routeProvider.when("/Home",{
        templateUrl: 'Modules/Home/view/index.html',
        controller: 'HomeCtrl'
    }).when("/list",{
        templateUrl: 'Modules/List/view/list.html',
        controller: 'ListCtrl'
    }).when("/detail/:id",{
        templateUrl: 'Modules/List/view/detail.html',
        controller: 'DetailCtrl'
    }).otherwise({
        //设置默认跳转
        redirectTo: '/Home'
    });
});