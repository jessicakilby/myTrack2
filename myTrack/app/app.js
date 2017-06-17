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
        .when("/category/:id",
        {
            templateUrl: "app/Partials/Category.html",
            controller: "CategoryController"
        })
        .when("/subcategory/:id",
        {
            templateUrl: "app/Partials/Subcategory.html",
            controller: "SubcategoryController"
        })
        .when("/item/:id",
        {
            templateUrl: "app/Partials/Item.html",
            controller: "ItemController"
        });

}]);

app.run(["$http", function ($http) {

    var token = sessionStorage.getItem('token');

    if (token)
        $http.defaults.headers.common['Authorization'] = `bearer ${token}`;
}]);