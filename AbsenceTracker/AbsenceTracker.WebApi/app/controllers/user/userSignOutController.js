//Define sign out controller
angular.module('AbsenceTrackerModule').controller('userSignOutController', ['$scope', '$http', '$stateParams', '$window', '$state', 'AuthenticationService', userSignOutController]);

//Define sign out function
function userSignOutController($scope, $http, $stateParams, $window, $state, AuthenticationService) {

    AuthenticationService.Check();

};