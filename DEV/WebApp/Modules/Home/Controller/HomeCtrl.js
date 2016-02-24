/**
 * Created by 82111 on 2016/2/24.
 */

app.controller("HomeCtrl",function($scope,$http){
    $scope.tasks = [
        { title: '菜鸟教程' },
        { title: 'www.runoob.com' },
        { title: '菜鸟教程' },
        { title: 'www.runoob.com' }
    ];

    $scope.getClick=function(){
        var url="http://localhost:4928/api/Home/index";
        $http.get(url)
            .success(function(response) {
                console.log(response);
            });
    };
});