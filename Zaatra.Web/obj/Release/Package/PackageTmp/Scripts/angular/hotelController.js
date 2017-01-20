app.controller("hotelController", function($scope, $http) {

    $http.get("/Hotel/GetAllHotels").success(function (response) {
        $scope.hotels = response;
        console.log(response);
    });

});