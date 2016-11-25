//Define login controller
angular.module('AbsenceTrackerModule').controller('loginController', ['$scope', '$http', '$stateParams', '$window', '$state', '$location', loginController]);

//Define login function
function loginController($scope, $http, $stateParams, $window, $state, $location) {

    var user;

    $scope.loginModel = {
        UserName: undefined,
        PasswordHash: undefined
    };

    $http.get('/api/aspnetuser/get?id=574fb6ac-cc47-498b-9ed5-ef723a2c4951')
        .success(function (response) {
            user = response;
        })
        .error(function () {
            return "couldn't get aspnetusers.";
        });
    

    $scope.submit = function () {
        if ($scope.loginModel.UserName === user.UserName) {
            $location.path('/user')
        }
        else {
            $window.alert("Invalid user.")
        }
    }

    $scope.ispis = function () {
        if ($scope.loginModel.UserName === user.UserName) {
            $window.alert("isti su");
        }
        console.log(user.UserName);
       
    }
};