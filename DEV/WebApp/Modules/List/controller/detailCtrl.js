/**
 * Created by 82111 on 2016/2/24.
 */
app.controller('DetailCtrl',function($scope, $routeParams) {
    $scope.id = $routeParams.id;
    console.log($routeParams);
});