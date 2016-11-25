//Define stats controller
angular.module('AbsenceTrackerModule').controller('userStatsController', ['$scope', '$http', '$stateParams', '$window', '$state', 'AuthenticationService', userStatsController]);

//Define stats function
function userStatsController($scope, $http, $stateParams, $window, $state, AuthenticationService) {

    AuthenticationService.Check();



};