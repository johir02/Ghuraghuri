app.controller("adminCtrl", function($scope, $http) {
    $scope.tinymceOptions = {
        plugins: 'link image code',
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
    };

    $scope.tinymceOptions = {
        plugins: 'link image code',
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
    };

    $scope.packageInfo = {
        Name: '',
        TourPlaces: '',
        DayCount: '',
        NightCount: '',
        Description: '',
        TourCode: '',
        OfferDuration: '',
        MonthlyInstallment: '',
        PaymentMethod: '',
        MinimumPerson: '',
        FeeIncludes: '',
        FeeExcludes: '',
        AdditionalInfo: '',
        Transports: '',
        Hotels: '',
        Seasons: '',
        DayDescriptions : [{ DayNumber: '', Description: '' }]

    };

    $scope.vendors = [];

    $http.get("/Admin/GetVendor")
        .success(function(data) {
            $scope.vendors = data;
        });

    $scope.createPackage = function () {
        for (var i = 0; i < $scope.packageInfo.DayDescriptions.length; i++) {
            console.log($scope.packageInfo.DayDescriptions[i]);
        }
        $http.post("/Admin/CreatePackage", $scope.packageInfo)
            .success(function(response) {
                console.log("ok");
            });
    }

    $scope.entryDay = function () {
        $scope.packageInfo.DayDescriptions = [];
        for (var i = 0; i < $scope.packageInfo.DayCount; i++) {
            $scope.packageInfo.DayDescriptions.push({
                DayNumber: i+1,
                Description: ''
            });
        }
    }

    $scope.setDayDescription = function() {
        
    }

    $scope.RoomCount = 0;

    $scope.rooms = [
        {
            MaximumOccupancy:0,
            Breakfast: false,
            Price: 0,
            Discount:0
        }
    ];

    $scope.entryRoom=function ()
    {
        $scope.rooms.push(
        {
            MaximumOccupancy: 1,
            Breakfast: false,
            Price: 0,
            Discount: 0
        });
    };
    
});