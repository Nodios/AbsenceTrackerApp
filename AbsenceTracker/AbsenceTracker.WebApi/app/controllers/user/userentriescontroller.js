//Define entries controller
angular.module('AbsenceTrackerModule').controller('userEntriesController', ['$scope', '$http', '$stateParams', '$window', '$state', 'AuthenticationService', userEntriesController]);

//Define entries function
function userEntriesController($scope, $http, $stateParams, $window, $state, AuthenticationService) {

    AuthenticationService.Check();
};