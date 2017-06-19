app.controller("CategoryController", ["$scope", "$http", "$location", "$routeParams",
    function ($scope, $http, $location, $routeParams) {

        $scope.addSubcategory = function () {
            console.log("clicked add Subcategory button");

            $http.post(`api/subcategory`, {
                Title: $scope.subcategoryTitle,
                Description: $scope.subcategoryDescription,
                SubcatId: $scope.SubcatId
            }).then(function (response) {
                $scope.subcategoryTitle = "";
                $scope.subcategoryDescription = "";
                $scope.SubcatId;
            }, function (error) {
                debugger
            })

        };

        $http.get("api/subcategory").then(function (response) {
            $scope.categories = response.data;
        });



    }
]);