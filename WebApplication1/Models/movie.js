var app = angular.module('movie', []);
app.controller('movieController', function ($scope ,$http) {
    $scope.searchString = '';
    $scope.postMovie = function () {
        var data = {
            id: $scope.searchString
        };
        console.log(data);
        $http.post('movies/Index', data)
            .then(function successCallback(data, status, headers, config) {
                console.log(data, status, headers, config);
            }, function errorCallback(data, status, headers, config) {
                console.log(data, status, headers, config);
            });
    }
});