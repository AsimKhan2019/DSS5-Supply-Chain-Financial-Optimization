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
interface Window { scope_AdminDeliveryNoteList: DSS5_SupplyChainFinancialsOptimisation.Controllers.IAdminDeliveryNoteListScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const AdminDeliveryNoteListConditionalFormattings = [
        ];
const AdminDeliveryNoteListDataValidations = [
        ];
const AdminDeliveryNoteListCalculatedExpressions = [
        ];

// Datasets Column Info
var DeliveryNoteListNoDT_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Transaction.Id",
caption: window._resourcesManager.getDataListColumnCaption("DeliveryNoteListNoDT", "Transaction.Id", false),
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
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "DeliveryNoteNumber",
caption: window._resourcesManager.getDataListColumnCaption("DeliveryNoteListNoDT", "DeliveryNoteNumber", false),
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
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("DeliveryNoteListNoDT", "Description", false),
groupable: true,
searchable: true,
visible: false,
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
name: "DateIssued",
caption: window._resourcesManager.getDataListColumnCaption("DeliveryNoteListNoDT", "DateIssued", false),
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
name: "Amount",
caption: window._resourcesManager.getDataListColumnCaption("DeliveryNoteListNoDT", "Amount", false),
groupable: true,
searchable: true,
visible: false,
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
name: "Transaction.Supplier.Company",
caption: window._resourcesManager.getDataListColumnCaption("DeliveryNoteListNoDT", "Transaction.Supplier.Company", false),
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
window["DeliveryNoteListNoDT_ColumnInfo"] = DeliveryNoteListNoDT_ColumnInfo;

// Datasets Projection Shemas
window["DeliveryNoteListNoDT_ProjectionScema"] = {};


export interface IAdminDeliveryNoteListScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.AdminDeliveryNoteList.AdminDeliveryNoteListViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class AdminDeliveryNoteListController {
private timeoutDelayLockModifyClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_AdminDeliveryNoteList.model = window.scope_AdminDeliveryNoteList.dehydrate();
        //window.scope_MasterPageForLists.model = window.scope_AdminDeliveryNoteList.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.AdminDeliveryNoteList.AdminDeliveryNoteListViewModel._lightCast(window.scope_AdminDeliveryNoteList.model);
        // Joove.Common.applyScope(window.scope_AdminDeliveryNoteList);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IAdminDeliveryNoteListScope, $timeout: ng.ITimeoutService) {
        window.scope_AdminDeliveryNoteList = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.AdminDeliveryNoteList.AdminDeliveryNoteListViewModel._initializeFrom($scope.model, context);
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

    init($scope: IAdminDeliveryNoteListScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.AdminDeliveryNoteList.AdminDeliveryNoteListViewModel._initializeFrom(window.viewDTO.Model);

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


                Joove.Core.executeRedirectControllerAction("AdminDeliveryNoteList", "Retrieve", "GET", [], {}, _modalOptions);
            },
DeleteSeclected:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'AdminDeliveryNoteList', action: 'DeleteSeclected',
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
                        if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("DeliveryNoteForm", "EditDeliveryNote", "GET", [Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItem($("[jb-id='DeliveryNoteListNoDT']"), e).Id, 0)], null, null, openInNewWindow);
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(AdminDeliveryNoteListDataValidations);
        window._ruleEngine.addConditionalFormattings(AdminDeliveryNoteListConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(AdminDeliveryNoteListCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForLists as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("AdminDeliveryNoteListController", ["$scope", "$timeout", AdminDeliveryNoteListController] as Array<string>);
}
