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
interface Window { scope_SupplierPaymentsList: DSS5_SupplyChainFinancialsOptimisation.Controllers.ISupplierPaymentsListScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const SupplierPaymentsListConditionalFormattings = [
        ];
const SupplierPaymentsListDataValidations = [
        ];
const SupplierPaymentsListCalculatedExpressions = [
        ];

// Datasets Column Info
var TransactionListNoDT_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "DateTime",
dataTypeIsEnum: false,
name: "TransactionDateOccured",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "TransactionDateOccured", false),
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
name: "TransactionValue",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "TransactionValue", false),
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
dataType: "decimal",
dataTypeIsEnum: false,
name: "FundedAmount",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "FundedAmount", false),
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
dataType: "decimal",
dataTypeIsEnum: false,
name: "ToBePaidAmount",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "ToBePaidAmount", false),
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
name: "PaymentStatus",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "PaymentStatus", false),
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
name: "PaymentDate",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "PaymentDate", false),
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
name: "RestPaymentAmount",
caption: window._resourcesManager.getDataListColumnCaption("TransactionListNoDT", "RestPaymentAmount", false),
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
})] as any;
window["TransactionListNoDT_ColumnInfo"] = TransactionListNoDT_ColumnInfo;

// Datasets Projection Shemas
window["TransactionListNoDT_ProjectionScema"] = {};


export interface ISupplierPaymentsListScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.SupplierPaymentsList.SupplierPaymentsListViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class SupplierPaymentsListController {


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_SupplierPaymentsList.model = window.scope_SupplierPaymentsList.dehydrate();
        //window.scope_MasterPageForLists.model = window.scope_SupplierPaymentsList.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.SupplierPaymentsList.SupplierPaymentsListViewModel._lightCast(window.scope_SupplierPaymentsList.model);
        // Joove.Common.applyScope(window.scope_SupplierPaymentsList);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: ISupplierPaymentsListScope, $timeout: ng.ITimeoutService) {
        window.scope_SupplierPaymentsList = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.SupplierPaymentsList.SupplierPaymentsListViewModel._initializeFrom($scope.model, context);
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

    init($scope: ISupplierPaymentsListScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.SupplierPaymentsList.SupplierPaymentsListViewModel._initializeFrom(window.viewDTO.Model);

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


                Joove.Core.executeRedirectControllerAction("SupplierPaymentsList", "Retrieve", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
        };

// Rules
        window._ruleEngine.addDataValidations(SupplierPaymentsListDataValidations);
        window._ruleEngine.addConditionalFormattings(SupplierPaymentsListConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(SupplierPaymentsListCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForLists as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("SupplierPaymentsListController", ["$scope", "$timeout", SupplierPaymentsListController] as Array<string>);
}
