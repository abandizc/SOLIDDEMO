var app = angular.module("myapp", []);

app.controller("productCtrl", ["$scope", "repo", function ($scope, repo) {

    $scope.Products = [{
        ID: 1,
        ProductName: "Test",
        CompanyName: "companyTest",
        ProductType: "2"
    },
    {
        ID: 2,
        ProductName: "2",
        CompanyName: "companyTest2",
        ProductType: "3"
    }]

    $scope.Test = "Test";
    $scope.update = false;
    $scope.updateproducts = function () {
        repo.updateProducts($scope.Products)
        .success(function (data, status, header, config) {
            $scope.message = "Updated!";
            $scope.update = true;
        })
        .error(function (data, status, header, config) {
            $scope.message = "Failed!";
            $scope.update = false;
        });
    };

}]);

app.service("repo", ["$http", function ($http) {
    this.updateProducts = function (user) {
        var userdat = JSON.stringify(user);
        var config = { method: "POST", url: "/Product/Edit", data: { jsonstring: userdat } };
        return $http(config);
    }
}]);