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
                getFunction();
                $scope.subcategoryTitle = "";
                $scope.subcategoryDescription = "";
                $scope.SubcatId;
            }, function (error) {
                debugger
            })

        };

        $scope.deleteSubcategory = function () {
            console.log("clicked delete subcategory button");

            $http.delete(`api/subcategory`).then(function () {
                getFunction();
            });
            
        };

        var getFunction = function () {
            $http.get(`api/subcategory/${$scope.CatId}`).then(function (response) {
                console.log(response.data);
                $scope.subcategories = response.data;
            });
        };

        getFunction();
    }
]);