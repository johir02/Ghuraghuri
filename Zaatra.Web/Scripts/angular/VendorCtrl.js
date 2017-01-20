app.controller("vendorCtrl", function ($scope, $http) {
    $scope.tinymceOptions = {
        plugins: 'link image code',
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
    };

    $scope.tinymceOptions = {
        plugins: 'link image code',
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
    };


    function initialize() {
        $scope.vendorInfo = {
            Name: '',
            Email: '',
            PhoneNumber: '',
            Description: '',
            Address: ''

        };
    }

    initialize();
    
    $scope.addVendor = function () {
        $http.post("/Admin/CreateVendor", $scope.vendorInfo)
            .success(function (response) {
                initialize();
                //window.location.href = "/Admin/";
                console.log("ok");
            });
    }

});