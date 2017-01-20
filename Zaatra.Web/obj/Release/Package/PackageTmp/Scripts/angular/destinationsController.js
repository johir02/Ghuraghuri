app.controller("destinationsController", function ($scope, $http) {

    /*$http.get("/Destination/GetAllDestinations").success(function (response) {
        $scope.destinations = response;
        console.log(response);
    });*/

    $http.get("/Destination/GetPackagesGroupByDestination").success(function (response) {
        $scope.packages = response;
        console.log(response);
    });
})