var app = angular.module('demo', []);
app.controller('demoController', function ($scope) {
    $scope.Message = "Lottery ";

});
app.controller('randomController', function ($scope, $interval) {
    $scope.randomNum = 0;
    $scope.min = 0;
    $scope.max = 10;
    $scope.start = function () {
        $scope.flag = false;
        $interval(function () {
            if ($scope.flag == false) {
                random();
            }
        }, 100);
    }
    $scope.stop = function () {
        $scope.flag = true;
    }
    function random() {
        $scope.randomNum = Math.floor(Math.random() * ($scope.max - $scope.min) + $scope.min);
    }
    $scope.checkNum = function () {
        if ($scope.max < $scope.min) {
            [$scope.max, $scope.min] = [$scope.min, $scope.max];
        }
        $scope.start();
    }
});
