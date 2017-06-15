app.controller("ItemController", ["$scope", "$http", "$location",
    function ($scope, $http, $location) {

        $scope.addItem = function () {
            console.log("clicked add item controller");
        };


    }
]);