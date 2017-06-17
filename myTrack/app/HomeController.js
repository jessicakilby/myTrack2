app.controller("HomeController", ["$scope", "$http", "$location",
    function ($scope, $http, $location) {

        $scope.Logout = function () {
            console.log("you clicked logout");
            sessionStorage.removeItem('token');
            $http.defaults.headers.common['Authorization'] = "";

            $location.path("/login");
        };

        $scope.addCategory = function () {
            console.log("clicked add category button");

            $http.post("api/category/", {
                Title: $scope.categoryTitle,
                Description: $scope.categoryDescription
            }).then(function (response) {
                $scope.categoryTitle = "";
                $scope.categoryDescription = "";
            }, function (error) {
                debugger
            })

        };

        $http.get("api/category").then(function (response) {
            $scope.categories = response.data;
        })

    }
]);