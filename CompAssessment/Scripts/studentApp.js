var studentApp = angular.module("StudentApp", []);

var studentService = studentApp.service("StudentService", ['$http', function ($http) {
    var Service = {};
    Service.InsertStudent = function (student, success, error) {
        $http.post("/api/v1/student/insert", student, { success: success, error: error });
    }
    return Service;
}]);

var studentController = studentApp.controller("StudentController",
    ["StudentService",function ($scope,studentService) {
        studentService.InsertStudent($scope.Student, function (data) { }, function (error) { });
    }]);

