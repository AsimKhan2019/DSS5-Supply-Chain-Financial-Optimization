// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup((e) => {
    if (e.which === 13 && Joove.Common.eventPreventsDefaultFormAction(e as JQueryEventObject) === false && !$(e.target).parent().hasClass("search-element")) {
        window._popUpManager.previouslyFocusedElement = document.activeElement;
        $(":focus").blur();
        Joove.Core.getScope().eventCallbacks.cmdPaymentSaveClicked(e);
    }
});
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_PaymentForm: DSS5_SupplyChainFinancialsOptimisation.Controllers.IPaymentFormScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const PaymentFormConditionalFormattings = [
new Joove.JbRule({
name: "HideIfNewConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window._context.currentAction == "AddPayment", false);

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad],
isRelatedToDataValidation: false
}),
new Joove.JbRule({
name: "ConditionalFormattingConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return true;

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad,Joove.EvaluationTimes.OnSubmit,Joove.EvaluationTimes.OnChange],
isRelatedToDataValidation: false
}),
        ];
const PaymentFormDataValidations = [
                                   ];
const PaymentFormCalculatedExpressions = [
        ];
// Manual Data for txtPaymentMethod0
window["dataFortxtPaymentMethod0"] = [ {
_key: "Bank Transfer",
_text: window._resourcesManager.getComboBoxManualValueDisplay('PaymentMethod', '0', false , null),
_default: false
} ]
// Manual Data for txtExpirationMonth4
window["dataFortxtExpirationMonth4"] = [ {
    _key: 1,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '0', false , null),
_default: false
}, {
    _key: 2,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '1', false , null),
_default: false
}, {
    _key: 3,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '2', false , null),
_default: false
}, {
    _key: 4,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '3', false , null),
_default: false
}, {
    _key: 5,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '4', false , null),
_default: false
}, {
    _key: 6,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '5', false , null),
_default: false
}, {
    _key: 7,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '6', false , null),
_default: false
}, {
    _key: 8,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '7', false , null),
_default: false
}, {
    _key: 9,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '8', false , null),
_default: false
}, {
    _key: 10,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '9', false , null),
_default: false
}, {
    _key: 11,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '10', false , null),
_default: false
}, {
    _key: 12,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationMonth', '11', false , null),
_default: false
} ]
// Manual Data for txtExpirationYear5
window["dataFortxtExpirationYear5"] = [ {
    _key: 2017,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '0', false , null),
_default: false
}, {
    _key: 2018,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '1', false , null),
_default: false
}, {
    _key: 2019,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '2', false , null),
_default: false
}, {
    _key: 2020,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '3', false , null),
_default: false
}, {
    _key: 2021,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '4', false , null),
_default: false
}, {
    _key: 2022,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '5', false , null),
_default: false
}, {
    _key: 2023,
_text: window._resourcesManager.getComboBoxManualValueDisplay('ExpirationYear', '6', false , null),
_default: false
} ]

// Datasets Column Info
export var PaymentMethod_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null,  true)];
window["PaymentMethod_ColumnInfo"] = PaymentMethod_ColumnInfo;
export var ExpirationMonth_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null,  true)];
window["ExpirationMonth_ColumnInfo"] = ExpirationMonth_ColumnInfo;
export var ExpirationYear_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null,  true)];
window["ExpirationYear_ColumnInfo"] = ExpirationYear_ColumnInfo;

// Datasets Projection Shemas





export interface IPaymentFormScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.PaymentForm.PaymentFormViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,
txtPaymentMethod0: Joove.Validation.BindingEntry,txtCardholderName1: Joove.Validation.BindingEntry,txtCardNumber2: Joove.Validation.BindingEntry,txtCCV3: Joove.Validation.BindingEntry,txtExpirationMonth4: Joove.Validation.BindingEntry,txtExpirationYear5: Joove.Validation.BindingEntry,
    },
    _masterValidations?: any;
}

class PaymentFormController {
private timeoutDelayLockButtonClicked:
    any;
private timeoutDelayLockcmdPaymentSaveClicked:
    any;
private timeoutDelayLockcmdDeletePaymentClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_PaymentForm.model = window.scope_PaymentForm.dehydrate();
        //window.scope_MasterPage.model = window.scope_PaymentForm.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.PaymentForm.PaymentFormViewModel._lightCast(window.scope_PaymentForm.model);
        // Joove.Common.applyScope(window.scope_PaymentForm);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IPaymentFormScope, $timeout: ng.ITimeoutService) {
        window.scope_PaymentForm = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.PaymentForm.PaymentFormViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
        $scope._validations = { summary:
                                [],
                                txtPaymentMethod0:
                                { requiredControlId: 'txtPaymentMethod0', group: null },
                                txtCardholderName1:
                                { requiredControlId: 'txtCardholderName1', group: null },
                                txtCardNumber2:
                                { requiredControlId: 'txtCardNumber2', group: null },
                                txtCCV3:
                                { requiredControlId: 'txtCCV3', group: null },
                                txtExpirationMonth4:
                                { requiredControlId: 'txtExpirationMonth4', group: null },
                                txtExpirationYear5:
                                { requiredControlId: 'txtExpirationYear5', group: null },
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IPaymentFormScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.PaymentForm.PaymentFormViewModel._initializeFrom(window.viewDTO.Model);

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
AddPayment:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("PaymentForm", "AddPayment", "GET", [], {}, _modalOptions);
            },
EditPayment:
            async (id, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("PaymentForm", "EditPayment", "GET", [id], {}, _modalOptions);
            },
SavePayment:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'PaymentForm', action: 'SavePayment',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
DeletePayment:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'PaymentForm', action: 'DeletePayment',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
RegistrationPayment:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'PaymentForm', action: 'RegistrationPayment',
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
                        $scope.actions.SavePayment(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

cmdPaymentSaveClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockcmdPaymentSaveClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockcmdPaymentSaveClicked);
                }

                this.timeoutDelayLockcmdPaymentSaveClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.SavePayment(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

cmdDeletePaymentClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockcmdDeletePaymentClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockcmdDeletePaymentClicked);
                }

                this.timeoutDelayLockcmdDeletePaymentClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.DeletePayment(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(PaymentFormDataValidations);
        window._ruleEngine.addConditionalFormattings(PaymentFormConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(PaymentFormCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("PaymentFormController", ["$scope", "$timeout", PaymentFormController] as Array<string>);
}
