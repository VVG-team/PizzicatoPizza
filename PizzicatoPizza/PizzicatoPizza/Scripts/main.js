var app = angular.module('App', []);
app.controller('homeCtrl', homeCtrl);
app.controller('manageCtrl', manageCtrl);

function homeCtrl($scope, $http) {

    $http.get('Home/GetPizzas').then(function (response) {
        $scope.pizzas = response.data;
    });

}

function manageCtrl($scope, $http) {

    $http.get('Manage/GetPizzas').then(function (response) {
        $scope.pizzas = response.data;
    });

    $scope.save = function (pizza) {
        $http.post('Manage/UpdatePizza', pizza).then(function (response) {
            alert('The changes have been saved');
        });
    }

    $scope.delete = function (pizza) {
        $http.post('Manage/DeletePizza', { id: pizza.Id }).then(function (response) {
            $http.get('Manage/GetPizzas').then(function (response) {
                $scope.pizzas = response.data;
            });
            alert('Pizza has been deleted');
        });
    }

}