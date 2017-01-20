app.controller("packagesController", function($scope, $http) {

    $scope.tags = [];
    $scope.searchString = "";
    /*$http.get("/Package/GetAllPackage").success(function (response) {
        $scope.packages = response;
        console.log(response);
    });*/

    $scope.myInit = function (tags, packages) {
        console.log(tags, "data");
        $scope.tags = tags;
        $scope.packages = packages;
    }

    

    function searchFilteredPackages(searchString)
    {
        console.log(searchString, "searchString");
        $http.get("/Package/GetFilteredPackage?searchString=" + searchString).success(function (response) {
            $scope.packages = response;
            console.log(response, "searchedPackage");
            $scope.searchString = "";
        });
    }

    $scope.filter = function () {
        console.log($scope.tags);
        for (var i = 0; i < $scope.tags.length; i++) {
            for (var j = 0; j < $scope.tags[i].TagViewModels.length; j++) {
                if ($scope.tags[i].TagViewModels[j].IsSelected) {
                    $scope.searchString = $scope.searchString + $scope.tags[i].TagViewModels[j].Name + ",";
                }
            }
        }
        $scope.searchString = $scope.searchString.substring(0, $scope.searchString.length - 1);
        searchFilteredPackages($scope.searchString);
    }

    $scope.loadMore = function() {
        alert("hbe");
    }
});