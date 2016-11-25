angular.module('AbsenceTrackerModule').factory('loginService', ['$http', '$cookieStore', '$rootScope', loginService]);



function loginService($http, $cookieStore, $rootScope) {

    var service = {};

        loginService.Login = function (username, password, callback) {


        /* Use this for real authentication
            ----------------------------------------------*/
            $http.post('/api/aspnetuserlogin/login', { UserName: username, Password: password })
            .success(function (response) {
                callback(response);
            });

        };

        service.SetCredentials = function (username, password) {

            $rootScope.globals = {
                currentUser: {
                    UserName: username,
                    Password: password
                }
            };

            $http.defaults.headers.common['Authorization'] = 'Basic ' + username + ',' + password; // jshint ignore:line
            $cookieStore.put('globals', $rootScope.globals);
        };

        service.ClearCredentials = function () {
            $rootScope.globals = {};
            $cookieStore.remove('globals');
            $http.defaults.headers.common.Authorization = 'Basic ';
        };

        return service;
    }