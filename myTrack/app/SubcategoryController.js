app.controller("SubcategoryController", ["$scope", "$http", "$routeParams",
    function ($scope, $http, $routeParams) {

        $scope.SubcatId = $routeParams.id;

        $scope.addItem = function () {
            console.log("clicked add Item button");

            $http.post(`api/item/${$scope.SubcatId}`, {
                Title: $scope.itemTitle,
                Status: $scope.itemStatus,
                Description: $scope.itemDescription,
                Frequency: $scope.itemFrequency,
                NextDate: $scope.itemNextDate

            }).then(function (response) {
                $scope.itemTitle = "";
                $scope.itemStatus = "";
                $scope.itemDescription = "";
                $scope.itemFrequency = "";
                $scope.itemNextDate = "";
            }, function(error){
                debugger
            })
        };

        $http.get(`api/item`).then(function (response) {
            $scope.items = response.data;
        });
       
    }
]);