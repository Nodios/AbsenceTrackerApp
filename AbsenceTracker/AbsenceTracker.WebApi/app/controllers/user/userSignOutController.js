﻿//Define sign out controller
angular.module('AbsenceTrackerModule').controller('userSignOutController', ['$scope', '$http', '$stateParams', '$window', '$state','$localStorage', 'AuthenticationService', userSignOutController]);

//Define sign out function
function userSignOutController($scope, $http, $stateParams, $window, $state, $localStorage,AuthenticationService) {

    if ($localStorage.currentUser)
        AuthenticationService.Check();

};