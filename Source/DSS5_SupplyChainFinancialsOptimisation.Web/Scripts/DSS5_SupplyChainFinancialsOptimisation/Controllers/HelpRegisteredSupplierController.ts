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
interface Window { scope_HelpRegisteredSupplier: DSS5_SupplyChainFinancialsOptimisation.Controllers.IHelpRegisteredSupplierScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const HelpRegisteredSupplierConditionalFormattings = [
        ];
const HelpRegisteredSupplierDataValidations = [
        ];
const HelpRegisteredSupplierCalculatedExpressions = [
        ];

// Datasets Column Info

// Datasets Projection Shemas


export interface IHelpRegisteredSupplierScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.HelpRegisteredSupplier.HelpRegisteredSupplierViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class HelpRegisteredSupplierController {


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_HelpRegisteredSupplier.model = window.scope_HelpRegisteredSupplier.dehydrate();
        //window.scope_MasterPageForSlide.model = window.scope_HelpRegisteredSupplier.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.HelpRegisteredSupplier.HelpRegisteredSupplierViewModel._lightCast(window.scope_HelpRegisteredSupplier.model);
        // Joove.Common.applyScope(window.scope_HelpRegisteredSupplier);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IHelpRegisteredSupplierScope, $timeout: ng.ITimeoutService) {
        window.scope_HelpRegisteredSupplier = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.HelpRegisteredSupplier.HelpRegisteredSupplierViewModel._initializeFrom($scope.model, context);
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

    init($scope: IHelpRegisteredSupplierScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.HelpRegisteredSupplier.HelpRegisteredSupplierViewModel._initializeFrom(window.viewDTO.Model);

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


                Joove.Core.executeRedirectControllerAction("HelpRegisteredSupplier", "Render", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
        };

// Rules
        window._ruleEngine.addDataValidations(HelpRegisteredSupplierDataValidations);
        window._ruleEngine.addConditionalFormattings(HelpRegisteredSupplierConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(HelpRegisteredSupplierCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForSlide as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("HelpRegisteredSupplierController", ["$scope", "$timeout", HelpRegisteredSupplierController] as Array<string>);
}
