//Define entries controller
angular.module('AbsenceTrackerModule').controller('userEntriesController', ['$scope', '$http', '$stateParams', '$window', '$state', '$localStorage', 'AuthenticationService', userEntriesController]);

//Define entries function
function userEntriesController($scope, $http, $stateParams, $window, $state, $localStorage, AuthenticationService) {

    if ($localStorage.currentUser)
        AuthenticationService.Check();
};