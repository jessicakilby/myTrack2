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

            $scope.categoryTitle = "";
            $scope.categoryDescription = "";

            
        };

        $scope.postAddCategory = function () {
            console.log("clicked post add category after modal popup");

            $http({
                method: 'POST',
                url: "",
                headers: {},
                data: {
                    title: $scope.categoryTitle,
                    Description : $scope.categoryDescription
                }
            })

        }
    }
]);