app.controller("vendorCtrl", function ($scope, $http) {
    $scope.tinymceOptions = {
        plugins: 'link image code',
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
    };

    $scope.tinymceOptions = {
        plugins: 'link image code',
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
    };

    $scope.vendorInfo = {
        Name: '',
        Email: '',
        PhoneNumber: '',
        Description: '',
        Address: ''
       
    };


    $scope.addVendor = function () {
        $http.post("/Admin/CreateVendor", $scope.vendorInfo)
            .success(function (response) {
                console.log("ok");
            });
    }

});