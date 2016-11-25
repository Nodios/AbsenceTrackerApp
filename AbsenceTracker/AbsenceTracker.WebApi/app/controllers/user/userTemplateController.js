//Define template controller
angular.module('AbsenceTrackerModule').controller('userTemplateController', ['$scope', '$http', '$stateParams', '$window', '$state', 'AuthenticationService', userTemplateController]);

//Define template function
function userTemplateController($scope, $http, $stateParams, $window, $state, AuthenticationService) {

    AuthenticationService.Check();



};