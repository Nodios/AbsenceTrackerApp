//Declare module
var AbsenceTrackerModule = angular.module('AbsenceTrackerModule', ['ui.router', 'angularUtils.directives.dirPagination', 'ngMessages', 'ngStorage','ngRoute']);

//Configure routes
AbsenceTrackerModule.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

    //Default route
    $urlRouterProvider.otherwise('/login');

    //Define states
    $stateProvider
        .state('login', {
            url: '/login',
            controller: 'loginController',
            views: {
                "root": {
                    templateUrl: 'app/views/login/login.html'
                }
            }
        })
        .state('usertemplate', {
            url: '/user',
            views: {
                "root": {
                    templateUrl: 'app/views/user/usertemplate.html',
                    controller: 'userTemplateController'
                }
            }

        })
        .state('usertemplate.stats', {
            url: '/userstats',
            
            views: {
                "userview": {
                    templateUrl: 'app/views/user/userstats.html',
                    controller: 'userStatsController'
                }
            }
        })
        .state('usertemplate.entries', {
            url: '/userentries',
            controller: 'userEntriesController',
            views: {
                "userview": {
                    templateUrl: 'app/views/user/userentries.html'
                }
            }
        })
        .state('usertemplate.signout', {
            url: '/usersignout',
            controller: 'userSignOutController',
            views: {
                "userview": {
                    templateUrl: 'app/views/user/usersignout.html'
                }
            }
        })
        .state('admintemplate', {
            url: '/admin',
            controller: 'adminTemplateController',
            views: {
                "root": {
                    templateUrl: 'app/views/admin/admintemplate.html'
                }
            }
        })
        .state('admintemplate.stats', {
            url: '/adminstats',
            controller: 'adminStatsController',
            views: {
                "adminview": {
                    templateUrl: 'app/views/admin/adminstats.html'
                }
            }
        })
        .state('admintemplate.entries', {
            url: '/adminentries',
            controller: 'adminEntriesController',
            views: {
                "adminview": {
                    templateUrl: 'app/views/admin/adminentries.html'
                }
            }
        })
        .state('admintemplate.reporting', {
            url: '/adminreporting',
            controller: 'adminReportingController',
            views: {
                "adminview": {
                    templateUrl: 'app/views/admin/adminreporting.html'
                }
            }
        })
        .state('admintemplate.signout', {
            url: '/adminsignout',
            controller: 'adminSignOutController',
            views: {
                "adminview": {
                    templateUrl: 'app/views/admin/adminsignout.html'
                }
            }
        })
});

AbsenceTrackerModule.run(function run($rootScope, $http, $location, $localStorage, AuthenticationService) {
    // keep user logged in after page refresh
    if ($localStorage.currentUser) {
        $http.defaults.headers.common.Authorization = 'Bearer ' + $localStorage.currentUser.token;


        if ($http.defaults.headers.common.Authorization) {
            $location.path('/user');
        }
    }

    // redirect to login page if not logged in and trying to access a restricted page
    $rootScope.$on('$locationChangeStart', function (event, next, current) {
        var publicPages = ['/login'];
        var restrictedPage = publicPages.indexOf($location.path()) === -1;
        if (restrictedPage && !$localStorage.currentUser) {
            $location.path('/login');
        }
    });
});