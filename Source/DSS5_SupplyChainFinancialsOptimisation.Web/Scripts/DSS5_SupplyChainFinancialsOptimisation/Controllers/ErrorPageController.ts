// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_ErrorPage: DSS5_SupplyChainFinancialsOptimisation.Controllers.IErrorPageScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const ErrorPageConditionalFormattings = [
                                        ];
const ErrorPageDataValidations = [
                                 ];
const ErrorPageCalculatedExpressions = [
                                       ];

// Datasets Column Info

// Datasets Projection Shemas


export interface IErrorPageScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.ErrorPage.ErrorPageViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class ErrorPageController {
private timeoutDelayLockButtonClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_ErrorPage.model = window.scope_ErrorPage.dehydrate();
        //window.scope_MasterPage.model = window.scope_ErrorPage.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.ErrorPage.ErrorPageViewModel._lightCast(window.scope_ErrorPage.model);
        // Joove.Common.applyScope(window.scope_ErrorPage);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IErrorPageScope, $timeout: ng.ITimeoutService) {
        window.scope_ErrorPage = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.ErrorPage.ErrorPageViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IErrorPageScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.ErrorPage.ErrorPageViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPage.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("ErrorPage", "Render", "GET", [], {}, _modalOptions);
            },
SendErrorToAdministrator:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'ErrorPage', action: 'SendErrorToAdministrator',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
        };
// Events
        $scope.eventCallbacks = {
ButtonClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButtonClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButtonClicked);
                }

                this.timeoutDelayLockButtonClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.SendErrorToAdministrator(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(ErrorPageDataValidations);
        window._ruleEngine.addConditionalFormattings(ErrorPageConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(ErrorPageCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("ErrorPageController", ["$scope", "$timeout", ErrorPageController] as Array<string>);
}
