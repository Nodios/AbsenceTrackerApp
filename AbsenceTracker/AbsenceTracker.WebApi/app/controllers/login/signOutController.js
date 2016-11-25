//Define sign out controller
angular.module('AbsenceTrackerModule').controller('signOutController', ['$scope', '$http', '$stateParams', '$window', '$state', '$location', 'AuthenticationService', signOutController]);

//Define sign out function
function signOutController($scope, $http, $stateParams, $window, $state, $location, AuthenticationService) {

    //AuthenticationService.Check();

    $scope.logout = function () {
        // reset login status
        console.log("usao u funkciju");
        AuthenticationService.Logout();
        $location.path('/login');
    };
};