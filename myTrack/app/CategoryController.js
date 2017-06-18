app.controller("CategoryController", ["$scope", "$http", "$routeParams",
    function ($scope, $http, $routeParams) {

        var CatId = $routeParams.CatId;

        $scope.addSubcategory = function () {
            console.log("clicked add subcategory controller");

            $http.post(`api/subcategory/${CatId}`, {
                Title: $scope.subcategoryTitle,
                Description: $scope.subcategoryDescription,
                Category_CatId: $scope.Category_CatId
            }).then(function (response) {
                $scope.subcategoryTitle = "";
                $scope.subcategoryDescription = "";
            }, function (error) {
                debugger
            });

            $http.get("api/subcategory").then(function (response) {
                console.log(response.data);
                $scope.subcategory = response.data;
            });

        };

        
        

    }
]);