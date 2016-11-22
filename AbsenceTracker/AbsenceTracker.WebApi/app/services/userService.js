anguar.module('AbsenceTrackerModule').factory('userService', function ($resource) {

    var currentUser;

    return {
        currentUser: function () { return currentUser; }
    };

});