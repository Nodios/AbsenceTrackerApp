//Define login controller
angular.module('AbsenceTrackerModule').controller('loginController', ['$scope', '$http', '$stateParams', '$window', '$state', '$location','$localStorage', 'AuthenticationService', loginController]);

//Define login function
function loginController($scope, $http, $stateParams, $window, $state, $location,$localStorage, AuthenticationService) {

    //if ($http.defaults.headers.common.Authorization) {
    //    $location.path('/user');
    //}

    $scope.login = function () {

        var username = $scope.vm.UserName;
        var password = $scope.vm.Password;

        $scope.vm.loading = true;
        AuthenticationService.Login(username, password, function (result) {
            if (result === true) {
                $location.path('/user/userstats')
            } else {
                $scope.vm.error = 'Username or password is incorrect';
                $scope.vm.loading = false;

                console.log($scope.vm.error);
            }
        });
    };

    //var user;

    //$scope.loginModel = {
    //    UserName: undefined,
    //    PasswordHash: undefined
    //};

    //$http.get('/api/aspnetuser/getall')
    //    .success(function (response) {
    //        user = response;
    //    })
    //    .error(function () {
    //        return "couldn't get aspnetusers.";
    //    });
    

    //$scope.submit = function () {
    //    if ($scope.loginModel.UserName === user.UserName) {
    //        $location.path('/user')
    //    }
    //    else {
    //        $window.alert("Invalid user.")
    //    }
    //}

    //$scope.ispis = function () {
    //    if ($scope.loginModel.UserName === user.UserName) {
    //        $window.alert("isti su");
    //    }
    //    console.log(user.UserName);
       
    //}
};