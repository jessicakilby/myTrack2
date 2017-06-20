app.controller("CategoryController", ["$scope", "$http", "$location", "$routeParams",
    function ($scope, $http, $location, $routeParams) {

        $scope.CatId = $routeParams.id;

        $scope.addSubcategory = function () {
            console.log("clicked add Subcategory button");

            $http.post(`api/subcategory/${$scope.CatId}`, {
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

        $http.get(`api/subcategory`).then(function (response) {
            $scope.subcategories = response.data;
        });



    }
]);