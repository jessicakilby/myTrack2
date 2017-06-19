app.controller("HomeController", ["$scope", "$http", "$location", "$routeParams",
    function ($scope, $http, $location, $routeParams) {

        $scope.Logout = function () {
            sessionStorage.removeItem('token');
            $http.defaults.headers.common['Authorization'] = "";

            $location.path("/login");
        };

        $scope.addCategory = function () {
            console.log("clicked add category button");

            $http.post(`api/category`, {
                Title: $scope.categoryTitle,
                Description: $scope.categoryDescription,
                CatId: $scope.CatId
            }).then(function (response) {
                $scope.categoryTitle = "";
                $scope.categoryDescription = "";
                $scope.CatId;
            }, function (error) {
                debugger
            })

        };

        $http.get("api/category").then(function (response) {
            $scope.categories = response.data;
        })

    }
]);