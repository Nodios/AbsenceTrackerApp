//Define entries controller
angular.module('AbsenceTrackerModule').controller('userEntriesController', ['$scope', '$http', '$stateParams', '$window', '$state', '$localStorage', 'AuthenticationService', userEntriesController]);

//Define entries function
function userEntriesController($scope, $http, $stateParams, $window, $state, $localStorage, AuthenticationService) {

    //Check if current user token has expired
    if ($localStorage.currentUser)
        AuthenticationService.Check();

    $scope.entryData = {
        
    }

    //get all absences
    $scope.getAllAbsences = function () {
        $http.get('api/absence/getall')
        .success(function (response) {
            $scope.absences = response;
        })
        .error(function () {
            return "Couldn't get response from server.";
        })
    }

    //get all absences with type sickness
    $scope.getAllSickness = function () {
        $http.get('api/absence/getallsickness')
        .success(function (response) {
            $scope.sickness = response;
        })
    }

    //get all absences with type vacation
    $scope.getAllVacation = function () {
        $http.get('api/absence/getallvacation')
        .success(function (response) {
            $scope.vacation = response;
        })
    }

    //get all absences with type compensation
    $scope.getAllCompensation = function () {
        $http.get('api/absence/getallcompensation')
        .success(function (response) {
            $scope.compensation = response;
        })
    }

    //change state when user clicks on Add entry
    $scope.changeState = function () {
        $state.go('usertemplate.addentry', {});
    }

    //change state when user change option on dropdown
    $scope.go = function (path) {
        $state.go(path, {});
    }
    $scope.ispis = function () {
        return $window.alert(getAllAbsences() + "da");
    }
    
};