var oObjs = [];
var app = angular.module("Homeapp", ['angular.filter']);

app.controller("HomeController", function ($scope, $http) {
    debugger;
    $http.get("/Home/GetData").then(function (d) {
        debugger;
        $scope.record = d.data;
        oObjs=d.data;
    }, function (error) {
        alert('Failed');
    });

    //$scope.GetSearchData = function() {
    //    debugger;
    //    if (txtSearch != "") {
    //        var finalAccrualRows = $scope.record.filter(function (object) {
    //            return object.CommentDetails == $scope.txtSearch ? false : true;
    //        });
    //        $scope.record = finalAccrualRows;
    //    } else {
    //        $scope.record = oObjs;
    //    }
        
    //};

});