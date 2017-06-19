app.controller("SubcategoryController", ["$scope", "$http", "$routeParams",
    function ($scope, $http, $routeParams) {

        $scope.addItem = function () {
            console.log("clicked add Item button");

            $http.post("api/subcategory/", {
                Title: $scope.itemTitle,
                Description: $scope.itemDescription
            }).then(function (response) {
                $scope.itemTitle = "";
                $scope.itemDescription = "";
            }, function(error){
                debugger
            })
        };

        $http.get("api/subcategory").then(function (resonse) {
            $scope.subcategory = response.data;
        })
       
    }
]);