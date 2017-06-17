var app = angular.module("myTrack", ["ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.when("/",
        {
            templateUrl: "app/Partials/Login.html",
            controller: "LoginController"
        })
        .when("/home",
        {
            templateUrl: "app/Partials/Home.html",
            controller: "HomeController"
        })
        .when("/signUp",
        {
            templateUrl: "app/Partials/SignUp.html",
            controller: "SignUpController"
        })
        .when("/login",
        {
            templateUrl: "app/Partials/Login.html",
            controller: "LoginController"
        })
        .when("/category",
        {
            templateUrl: "app/Partials/Subcategory.html",
            controller: "CategoryController"
        })
        .when("/subcategory",
        {
            templateUrl: "app/Partials/Item.html",
            controller: "SubcategoryController"
        })
        .when("/item",
        {
            templateUrl: "app/Partials/Login.html",
            controller: "ItemController"
        });

}]);

app.run(["$http", function ($http) {

    var token = sessionStorage.getItem('token');

    if (token)
        $http.defaults.headers.common['Authorization'] = `bearer ${token}`;
}]);