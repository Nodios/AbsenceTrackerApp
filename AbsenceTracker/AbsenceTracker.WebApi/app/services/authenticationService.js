(function () {
    'use strict';

    angular.module('AbsenceTrackerModule').factory('AuthenticationService', Service);

    function Service($http, $localStorage) {
        var service = {};

        service.Login = Login;
        service.Logout = Logout;
        service.Check = Check;

        return service;

        function Login(username, password, callback) {
            var obj = { UserName: username, Password: password };
            console.log(obj);
            $http.post('/api/aspnetuserlogin/login', obj)
                .success(function (response) {
                    // login successful if there's a token in the response
                    if (response.Token) {
                        // store username and token in local storage to keep user logged in between page refreshes
                        //console.log(response.Token + response.UserName)
                        $localStorage.currentUser = { UserName: response.UserName, token: response.Token };
                        //console.log($localStorage.currentUser);

                        // add jwt token to auth header for all requests made by the $http service
                        $http.defaults.headers.common.Authorization = 'Bearer ' + response.Token;

                        // execute callback with true to indicate successful login
                        callback(true);
                    } else {
                        // execute callback with false to indicate failed login
                        callback(false);
                    }
                });
        }

        function Logout() {
            // remove user from local storage and clear http auth header
            delete $localStorage.currentUser;
            $http.defaults.headers.common.Authorization = '';
        }

        function Check() {
            var dateTime = new Date();
            var miliseconds = dateTime.getTime();
            //console.log($localStorage.currentUser);

            if ($localStorage.currentUser.token.ExpirationTime < miliseconds) {
                //console.log(currentUser + " usao u if");
                Logout();
            }
        }


    }
})();