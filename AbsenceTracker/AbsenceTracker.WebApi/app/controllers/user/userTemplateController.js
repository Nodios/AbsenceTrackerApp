//Define template controller
angular.module('AbsenceTrackerModule').controller('userTemplateController', ['$scope', '$http', '$stateParams', '$window', '$state','$localStorage', 'AuthenticationService', userTemplateController]);

//Define template function
function userTemplateController($scope, $http, $stateParams, $window, $state, $localStorage, AuthenticationService) {

    if ($localStorage.currentUser)
        AuthenticationService.Check();

    $scope.changeStateToUserStats = function () {
        $state.go('usertemplate.stats');
        console.log("usao ng init")
    };


};