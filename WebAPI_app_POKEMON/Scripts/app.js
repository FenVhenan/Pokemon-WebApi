//var pokemonApp = angular
//    .module('pokemonModule', [])
//    .controller('pokemonController', function ($scope, $http) {
//        $http.get("http://localhost:53610/api/values").then(function (response) {
//                $scope.pokemons = response.data;
//            });
//    });

var app = angular.module('pokemonApp', []);

app.controller('pokemonController', function ($scope, $http) {
    $http.get("http://localhost:53610/api/values/")
        .then(function (response) {

            $scope.results = response.data;

        });
});
