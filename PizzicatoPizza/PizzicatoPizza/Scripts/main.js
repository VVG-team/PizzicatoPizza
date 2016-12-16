var app = angular.module('App', []);
app.controller('homeCtrl', homeCtrl);
app.controller('manageCtrl', manageCtrl);
app.controller('addCtrl', addCtrl);

function homeCtrl($scope, $http) {

    $scope.order = function () {
        alert('Pizza has been ordered');
    };

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

function addCtrl($scope, $http) {
    $scope.pizza = {};
    $scope.add = function () {
        $scope.pizza.Image = 'Boston.png';
        $http.post('Add/AddPizza', $scope.pizza).then(function (response) {
            alert('Pizza has been added');
        });
    };
}