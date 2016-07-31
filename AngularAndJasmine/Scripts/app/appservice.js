MyModule.service('ApiCall', ['$http', function ($http) {
    var result;

    this.GetApiCall = function (controllerName, methodName) {
        var url = '';

        if (methodName)
            url = 'api/' + controllerName + '/' + methodName;
        else
            url = 'api/' + controllerName + '/';

        result = $http.get(url)
            .success(function (data, status) {
               // debugger;
                result = data;
            })
            .error(function () {
                alert('bad api result!');
            });
        return result;
    };
}
]);