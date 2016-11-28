//Define stats controller
angular.module('AbsenceTrackerModule').controller('userStatsController', ['$scope', '$http', '$stateParams', '$window', '$state', '$localStorage', 'AuthenticationService', userStatsController]);

//Define stats function
function userStatsController($scope, $http, $stateParams, $window, $state, $localStorage, AuthenticationService) {

    if ($localStorage.currentUser)
        AuthenticationService.Check();

};