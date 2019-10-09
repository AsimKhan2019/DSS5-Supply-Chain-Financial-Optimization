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
interface Window { scope_SlideIntermidiary: DSS5_SupplyChainFinancialsOptimisation.Controllers.ISlideIntermidiaryScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const SlideIntermidiaryConditionalFormattings = [
new Joove.JbRule({
name: "ShowIfOtherConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window["scope_SlideIntermidiary"].model.ChosenIntermediaryType, "") == "Other";

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad,Joove.EvaluationTimes.OnSubmit,Joove.EvaluationTimes.OnChange],
isRelatedToDataValidation: false
}),
        ];
const SlideIntermidiaryDataValidations = [
        ];
const SlideIntermidiaryCalculatedExpressions = [
        ];
// Manual Data for DropdownBox
window["dataForDropdownBox"] = [ {
_key: "ThirdPartyLogisticsProvider",
_text: window._resourcesManager.getComboBoxManualValueDisplay('IntermediaryTypes', '0', false , null),
_default: false
}, {
_key: "TransportationCompany",
_text: window._resourcesManager.getComboBoxManualValueDisplay('IntermediaryTypes', '1', false , null),
_default: false
}, {
_key: "CustomsAgent",
_text: window._resourcesManager.getComboBoxManualValueDisplay('IntermediaryTypes', '2', false , null),
_default: false
}, {
_key: "ShippingAgent",
_text: window._resourcesManager.getComboBoxManualValueDisplay('IntermediaryTypes', '3', false , null),
_default: false
}, {
_key: "Other",
_text: window._resourcesManager.getComboBoxManualValueDisplay('IntermediaryTypes', '4', false , null),
_default: false
} ]

// Datasets Column Info
export var IntermediaryTypes_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null,  true)];
window["IntermediaryTypes_ColumnInfo"] = IntermediaryTypes_ColumnInfo;

// Datasets Projection Shemas



export interface ISlideIntermidiaryScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.SlideIntermidiary.SlideIntermidiaryViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class SlideIntermidiaryController {
private timeoutDelayLockButtonClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_SlideIntermidiary.model = window.scope_SlideIntermidiary.dehydrate();
        //window.scope_MasterPageForSlide.model = window.scope_SlideIntermidiary.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.SlideIntermidiary.SlideIntermidiaryViewModel._lightCast(window.scope_SlideIntermidiary.model);
        // Joove.Common.applyScope(window.scope_SlideIntermidiary);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: ISlideIntermidiaryScope, $timeout: ng.ITimeoutService) {
        window.scope_SlideIntermidiary = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.SlideIntermidiary.SlideIntermidiaryViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageForSlide._validations;
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

    init($scope: ISlideIntermidiaryScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.SlideIntermidiary.SlideIntermidiaryViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageForSlide.model = $scope.model;

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


                Joove.Core.executeRedirectControllerAction("SlideIntermidiary", "Render", "GET", [], {}, _modalOptions);
            },
Save:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'SlideIntermidiary', action: 'Save',
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
                        $scope.actions.Save(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(SlideIntermidiaryDataValidations);
        window._ruleEngine.addConditionalFormattings(SlideIntermidiaryConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(SlideIntermidiaryCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForSlide as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("SlideIntermidiaryController", ["$scope", "$timeout", SlideIntermidiaryController] as Array<string>);
}
