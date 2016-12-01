//Define entries controller
angular.module('AbsenceTrackerModule').controller('adminEntriesController', ['$scope', '$http', '$stateParams', '$window', '$state', adminEntriesController]);

//Define entries function
function adminEntriesController($scope, $http, $stateParams, $window, $state) {

    //Check if current user token has expired
    if ($localStorage.currentUser)
        AuthenticationService.Check();


    $scope.getAllAbsences = function () {
        $http.get('api/absence/getall')
        .success(function (response) {
            $scope.absences = response;
        })
        .error(function () {
            return "Couldn't get response from server.";
        })
    }

    //getting all absences with type sickness
    $scope.getAllSickness = function () {
        $http.get('api/absence/getallsickness')
        .success(function (response) {
            $scope.sickness = response;
        })
    }

    //getting all absences with type vacation
    $scope.getAllVacation = function () {
        $http.get('api/absence/getallvacation')
        .success(function (response) {
            $scope.vacation = response;
        })
    }

    //getting all absences with type compensation
    $scope.getAllCompensation = function () {
        $http.get('api/absence/getallcompensation')
        .success(function (response) {
            $scope.compensation = response;
        })
    }

    //$scope.ispis = function () {
    //    return $window.alert(getAllAbsences() + "da");
    //}

};