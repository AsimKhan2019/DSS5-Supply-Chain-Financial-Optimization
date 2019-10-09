/* Copyright (c) CLMS. All rights reserved.
 * Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
 * This source file was autogenerated by zAppDev(r). */
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Joove;
(function (Joove) {
    var Widgets;
    (function (Widgets) {
        var JbProgress = (function (_super) {
            __extends(JbProgress, _super);
            function JbProgress() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return JbProgress;
        }(Joove.BaseAngularProvider));
        function jbProgress($timeout, $interval, ngRadio) {
            return {
                priority: 1001,
                restrict: "AE",
                scope: {
                    model: "=ngModel",
                    $showPercentage: "=?jbShowPercentage",
                    $min: "=jbMin",
                    $max: "=jbMax",
                    $colorize: "=?jbColorize",
                    $invertColors: "=?jbInverted",
                },
                link: function ($scope, $element, $attrs, ngModelCtrl) {
                    if (Joove.Common.directiveScopeIsReady($element))
                        return;
                    var classesForColors = [
                        "progress-bar-danger",
                        "progress-bar-warning",
                        "progress-bar-info",
                        "progress-bar-normal",
                        "progress-bar-success",
                    ];
                    $scope.init = function () {
                        $scope.$colorize = $scope.$colorize || false;
                        $scope.$showPercentage = $scope.$showPercentage || false;
                        $scope.$invertColors = $scope.$invertColors || false;
                        $element.addClass("progress");
                        $scope.$innerBar = $element.find(".inner-bar");
                        $scope.$percentageLabel = $("<span class='percentage'><span>");
                        $scope.$innerBar.addClass("progress-bar");
                        if ($scope.$showPercentage == true) {
                            $scope.$innerBar.append($scope.$percentageLabel);
                        }
                        if ($scope.$invertColors == true) {
                            classesForColors.reverse();
                        }
                        updateBar($scope.model);
                    };
                    $scope.init();
                    $scope.$watch("model", function (newValue, oldValue) {
                        if (newValue == oldValue)
                            return;
                        updateBar(newValue);
                    });
                    function updateBar(value) {
                        if (value == null || isNaN(value)) {
                            value = 0;
                        }
                        else {
                            value = parseFloat(value.toString());
                        }
                        var range = $scope.$max - $scope.$min;
                        var actualProgress = value - $scope.$min;
                        var percentage = (actualProgress / range) * 100;
                        if (percentage < 0) {
                            percentage = 0;
                        }
                        if (percentage > 100) {
                            percentage = 100;
                        }
                        var percentageStr = percentage.toFixed(0) + "%";
                        $scope.$innerBar.css("width", percentageStr);
                        if ($scope.$showPercentage == true) {
                            $scope.$percentageLabel.text(percentageStr);
                        }
                        if ($scope.$colorize == false)
                            return;
                        for (var i = 0; i < classesForColors.length; i++) {
                            $scope.$innerBar.removeClass(classesForColors[i]);
                        }
                        var cls = "";
                        if (percentage < 20) {
                            cls = classesForColors[0];
                        }
                        else if (percentage < 35) {
                            cls = classesForColors[1];
                        }
                        else if (percentage < 50) {
                            cls = classesForColors[2];
                        }
                        else if (percentage < 80) {
                            cls = classesForColors[3];
                        }
                        else {
                            cls = classesForColors[4];
                        }
                        $scope.$innerBar.addClass(cls);
                    }
                    Joove.Common.markDirectiveScopeAsReady($element);
                }
            };
        }
        angular
            .module("jbProgress", [])
            .provider("jbProgress", new JbProgress())
            .directive("jbProgress", ["$timeout", "$interval", "jbProgress", jbProgress]);
    })(Widgets = Joove.Widgets || (Joove.Widgets = {}));
})(Joove || (Joove = {}));
