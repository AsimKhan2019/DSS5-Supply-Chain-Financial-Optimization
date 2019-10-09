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
interface Window { scope_AgreementList: DSS5_SupplyChainFinancialsOptimisation.Controllers.IAgreementListScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const AgreementListConditionalFormattings = [
        ];
const AgreementListDataValidations = [
                                     ];
const AgreementListCalculatedExpressions = [
        ];

// Datasets Column Info
var AgreementListNoDT_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Supplier.Company",
caption: window._resourcesManager.getDataListColumnCaption("AgreementListNoDT", "Supplier.Company", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Investor.Company",
caption: window._resourcesManager.getDataListColumnCaption("AgreementListNoDT", "Investor.Company", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "DateTime",
dataTypeIsEnum: false,
name: "StartDate",
caption: window._resourcesManager.getDataListColumnCaption("AgreementListNoDT", "StartDate", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy' , 'excelFormat': 'dd/MM/yyyy' },
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "DateTime",
dataTypeIsEnum: false,
name: "EndDate",
caption: window._resourcesManager.getDataListColumnCaption("AgreementListNoDT", "EndDate", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy' , 'excelFormat': 'dd/MM/yyyy' },
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "decimal",
dataTypeIsEnum: false,
name: "FundedRate",
caption: window._resourcesManager.getDataListColumnCaption("AgreementListNoDT", "FundedRate", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'decimals': 2, 'groups': true, 'signed': false, 'showOnlyDecimalPart': false, 'dateFormat': '', 'backEndFormatting': '#,0.00;\'-\'#,0.00;\'0\'' , 'excelFormat': '#,##0.00;-#,##0.00;#,##0.00'},
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "CurrentAgreementStatus",
caption: window._resourcesManager.getDataListColumnCaption("AgreementListNoDT", "CurrentAgreementStatus", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["AgreementListNoDT_ColumnInfo"] = AgreementListNoDT_ColumnInfo;

// Datasets Projection Shemas
window["AgreementListNoDT_ProjectionScema"] = {};


export interface IAgreementListScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.AgreementList.AgreementListViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class AgreementListController {
private timeoutDelayLockModifyClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_AgreementList.model = window.scope_AgreementList.dehydrate();
        //window.scope_MasterPageForLists.model = window.scope_AgreementList.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.AgreementList.AgreementListViewModel._lightCast(window.scope_AgreementList.model);
        // Joove.Common.applyScope(window.scope_AgreementList);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IAgreementListScope, $timeout: ng.ITimeoutService) {
        window.scope_AgreementList = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.AgreementList.AgreementListViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageForLists._validations;
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

    init($scope: IAgreementListScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.AgreementList.AgreementListViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageForLists.model = $scope.model;

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
Retrieve:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("AgreementList", "Retrieve", "GET", [], {}, _modalOptions);
            },
DeleteSeclected:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'AgreementList', action: 'DeleteSeclected',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
        };
// Events
        $scope.eventCallbacks = {
ModifyClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockModifyClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockModifyClicked);
                }

                this.timeoutDelayLockModifyClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                        if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("AgreementForm", "EditAgreement", "GET", [Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItem($("[jb-id='AgreementListNoDT']"), e).Id, 0)], null, null, openInNewWindow);
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(AgreementListDataValidations);
        window._ruleEngine.addConditionalFormattings(AgreementListConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(AgreementListCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForLists as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("AgreementListController", ["$scope", "$timeout", AgreementListController] as Array<string>);
}
