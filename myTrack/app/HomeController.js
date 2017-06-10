app.controller("HomeController", ["$scope", "$http", "$location",
    function ($scope, $http, $location) {

        $scope.Logout = function () {
            console.log("you clicked logout");
            sessionStorage.removeItem('token');
            $http.defaults.headers.common['Authorization'] = "";

            $location.path("/login");
        }
    }
]);