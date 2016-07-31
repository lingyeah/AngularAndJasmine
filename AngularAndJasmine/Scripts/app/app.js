var MyModule = angular.module("App", []);

MyModule.controller('AppController', function ($scope, $http, ApiCall) {
    $scope.message = 'testing 123...';
    $scope.customers = [];

    $scope.GetAllCustomers = function()
    {
        ApiCall.GetApiCall('Customer', '')
        .success(function (data, status) {
           // debugger;
            //for (i = 0; i < data.length; i++)
            //    $scope.customers.push(data[i]);

            $scope.customers = [];
            Array.prototype.push.apply($scope.customers, data);

        });
    }
});