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
            views: {
                "root": {
                    controller: 'loginController',
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
            views: {
                "userview": {
                    controller: 'userEntriesController',
                    templateUrl: 'app/views/user/userentries.html'
                }
            }
        })
        .state('usertemplate.addentry', {
            url: '/useraddentry',
            views: {
                "userview": {
                    controller: 'userEntriesController',
                    templateUrl: 'app/views/user/useraddentry.html'
                }
            }
        })
        .state('usertemplate.addentry.vacation', {
            url: '/vacation',
            views: {
                "useraddentry": {
                    controller: 'userEntriesController',
                    templateUrl: 'app/views/user/addvacation.html'
                }
            }
        })
        .state('usertemplate.addentry.compensation', {
            url: '/compensation',
            views: {
                "useraddentry": {
                    controller: 'userEntriesController',
                    templateUrl: 'app/views/user/addcompensation.html'
                }
            }
        })
        .state('usertemplate.addentry.sickness', {
            url: '/sickness',
            views: {
                "useraddentry": {
                    controller: 'userEntriesController',
                    templateUrl: 'app/views/user/addsickness.html'
                }
            }
        })
        .state('usertemplate.signout', {
            url: '/usersignout',
      
            views: {
                "userview": {
                    controller: 'signOutController',
                    templateUrl: 'app/views/user/usersignout.html'
                }
            }
        })
        .state('admintemplate', {
            url: '/admin',
            views: {
                "root": {
                    controller: 'adminTemplateController',
                    templateUrl: 'app/views/admin/admintemplate.html'
                }
            }
        })
        .state('admintemplate.stats', {
            url: '/adminstats',
            views: {
                "adminview": {
                    controller: 'adminStatsController',
                    templateUrl: 'app/views/admin/adminstats.html'
                }
            }
        })
        .state('admintemplate.entries', {
            url: '/adminentries',
            views: {
                "adminview": {
                    controller: 'adminEntriesController',
                    templateUrl: 'app/views/admin/adminentries.html'
                }
            }
        })
        .state('admintemplate.reporting', {
            url: '/adminreporting',
            views: {
                "adminview": {
                    controller: 'adminReportingController',
                    templateUrl: 'app/views/admin/adminreporting.html'
                }
            }
        })
        .state('admintemplate.signout', {
            url: '/adminsignout',
            views: {
                "adminview": {
                    controller: 'signOutController',
                    templateUrl: 'app/views/admin/adminsignout.html'
                }
            }
        })
});

AbsenceTrackerModule.run(function run($rootScope, $http, $location, $localStorage, $state, AuthenticationService) {
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