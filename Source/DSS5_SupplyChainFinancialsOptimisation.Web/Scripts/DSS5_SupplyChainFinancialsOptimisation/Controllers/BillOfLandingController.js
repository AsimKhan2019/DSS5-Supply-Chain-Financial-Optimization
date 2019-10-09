var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = y[op[0] & 2 ? "return" : op[0] ? "throw" : "next"]) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [0, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup(function (e) {
    if (e.which === 13 && Joove.Common.eventPreventsDefaultFormAction(e) === false && !$(e.target).parent().hasClass("search-element")) {
        window._popUpManager.previouslyFocusedElement = document.activeElement;
        $(":focus").blur();
        Joove.Core.getScope().eventCallbacks.cmdBillOfLandingSaveClicked(e);
    }
});
window.onbeforeunload = function (e) {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg; // Gecko, Trident, Chrome 34+
        return msg;
    }
};
var DSS5_SupplyChainFinancialsOptimisation;
(function (DSS5_SupplyChainFinancialsOptimisation) {
    var Controllers;
    (function (Controllers) {
        var _this = this;
        var BillOfLandingConditionalFormattings = [
            new Joove.JbRule({
                name: "HideIfNewConditional",
                type: Joove.RuleTypes.ConditionalFormatting,
                isDataSetRule: false,
                evaluatedAtServer: false,
                contextControlName: null,
                condition: function (_parents) { return __awaiter(_this, void 0, void 0, function () {
                    return __generator(this, function (_a) {
                        return [2 /*return*/, Joove.Common.nullSafe(function () { return window._context.currentAction == "AddBillOfLanding"; }, false)];
                    });
                }); },
                evaluationTimes: [Joove.EvaluationTimes.OnLoad],
                isRelatedToDataValidation: false
            }),
            new Joove.JbRule({
                name: "HideIfBuyerReceivingConditional",
                type: Joove.RuleTypes.ConditionalFormatting,
                isDataSetRule: false,
                evaluatedAtServer: false,
                contextControlName: null,
                condition: function (_parents) { return __awaiter(_this, void 0, void 0, function () {
                    return __generator(this, function (_a) {
                        return [2 /*return*/, Joove.Common.nullSafe(function () { return window["scope_BillOfLanding"].model.BillOfLanding.IsBuyerReceiving; }, false)];
                    });
                }); },
                evaluationTimes: [Joove.EvaluationTimes.OnLoad, Joove.EvaluationTimes.OnChange],
                isRelatedToDataValidation: false
            }),
        ];
        var BillOfLandingDataValidations = [];
        var BillOfLandingCalculatedExpressions = [
            new Joove.JbRule({
                name: "CalculateReceiverId",
                type: Joove.RuleTypes.CalculatedExpression,
                evaluatedAtServer: false,
                isDataSetRule: false,
                condition: function (_control) {
                    return __awaiter(this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            return [2 /*return*/, true];
                        });
                    });
                },
                expression: function (_parents) {
                    return __awaiter(this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            if ((Joove.Common.nullSafe(function () { return window["scope_BillOfLanding"].model.BillOfLanding.IsBuyerReceiving; }, false))) {
                                return [2 /*return*/, Joove.Common.nullSafe(function () { return window["scope_BillOfLanding"].model.BillOfLanding.Transaction.ImportedBuyer.Id; }, 0)];
                            }
                            else {
                                return [2 /*return*/, Joove.Common.nullSafe(function () { return window["scope_BillOfLanding"].model.ChoosenIntermediary.Id; }, 0)];
                            }
                            return [2 /*return*/];
                        });
                    });
                },
                evaluationTimes: [Joove.EvaluationTimes.OnLoad, Joove.EvaluationTimes.OnSubmit, Joove.EvaluationTimes.OnChange]
            }),
        ];
        // Datasets Column Info
        var PickList1_ColumnInfo = [
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "OrderNumber",
                caption: window._resourcesManager.getDataListColumnCaption("PickList1", "OrderNumber", true),
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
                name: "DateOfOrder",
                caption: window._resourcesManager.getDataListColumnCaption("PickList1", "DateOfOrder", true),
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
                formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy', 'excelFormat': 'dd/MM/yyyy' },
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "decimal",
                dataTypeIsEnum: false,
                name: "OrderAmount",
                caption: window._resourcesManager.getDataListColumnCaption("PickList1", "OrderAmount", true),
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
                dataType: "decimal",
                dataTypeIsEnum: false,
                name: "TotalPrice",
                caption: window._resourcesManager.getDataListColumnCaption("PickList1", "TotalPrice", true),
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
            })
        ];
        window["PickList1_ColumnInfo"] = PickList1_ColumnInfo;
        var PickList_ColumnInfo = [
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "Company",
                caption: window._resourcesManager.getDataListColumnCaption("PickList", "Company", true),
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
            })
        ];
        window["PickList_ColumnInfo"] = PickList_ColumnInfo;
        var btnSelectMeanOfTransport_ColumnInfo = [
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "LicensePlate",
                caption: window._resourcesManager.getDataListColumnCaption("btnSelectMeanOfTransport", "LicensePlate", true),
                groupable: true,
                searchable: false,
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
                name: "ContainerId",
                caption: window._resourcesManager.getDataListColumnCaption("btnSelectMeanOfTransport", "ContainerId", true),
                groupable: true,
                searchable: false,
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
                name: "ShipId",
                caption: window._resourcesManager.getDataListColumnCaption("btnSelectMeanOfTransport", "ShipId", true),
                groupable: true,
                searchable: false,
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
                name: "TrainId",
                caption: window._resourcesManager.getDataListColumnCaption("btnSelectMeanOfTransport", "TrainId", true),
                groupable: true,
                searchable: false,
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
            })
        ];
        window["btnSelectMeanOfTransport_ColumnInfo"] = btnSelectMeanOfTransport_ColumnInfo;
        // Datasets Projection Shemas
        window["PickList1_ProjectionScema"] = { TransactionId: {}
        };
        window["PickList_ProjectionScema"] = { TransactionId: {}
        };
        window["btnSelectMeanOfTransport_ProjectionScema"] = {};
        var BillOfLandingController = (function () {
            function BillOfLandingController($scope, $timeout) {
                this.$scope = $scope;
                this.controllerActionFinished = function (resetDirty) {
                    //window.scope_BillOfLanding.model = window.scope_BillOfLanding.dehydrate();
                    //window.scope_MasterPage.model = window.scope_BillOfLanding.model;
                    DSS5_SupplyChainFinancialsOptimisation.ViewModels.BillOfLanding.BillOfLandingViewModel._lightCast(window.scope_BillOfLanding.model);
                    // Joove.Common.applyScope(window.scope_BillOfLanding);
                    if (resetDirty) {
                        window._context.isDirty = false;
                    }
                    window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
                };
                window.scope_BillOfLanding = $scope;
                $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
                    Joove.Core.onChange(event.target, newValue, dontMakeDirty);
                };
                $scope.dehydrate = function (context) {
                    if (context === void 0) { context = null; }
                    return DSS5_SupplyChainFinancialsOptimisation.ViewModels.BillOfLanding.BillOfLandingViewModel._initializeFrom($scope.model, context);
                };
                $scope._validationsMaster = window.scope_MasterPage._validations;
                $scope._validations = { summary: []
                };
                this.init($scope, $timeout);
                $timeout(function () {
                    window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, function () {
                        $("body").fadeIn(200);
                    });
                });
            }
            BillOfLandingController.prototype.init = function ($scope, $timeout) {
                var _this = this;
                $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.BillOfLanding.BillOfLandingViewModel._initializeFrom(window.viewDTO.Model);
                window.scope_MasterPage.model = $scope.model;
                new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
                $scope.trackObject = function (obj) { return Joove.Common.trackObject(obj); };
                //}
                $.connection['eventsHub'].on('__connectedEvent');
                $.connection['eventsHub'].on('forcePageReload', function () {
                    window.onbeforeunload = null;
                    setTimeout(function () {
                        window.location.reload();
                    }, 3000);
                });
                $.connection.hub.start(function () {
                    Joove.Common.getScope().connectedToSignals();
                    Joove.Common.getMasterScope().connectedToSignals();
                });
                $scope.connectedToSignals = function () {
                };
                // Event Listeners
                $scope.events = {};
                $scope.expressions = {};
                // Dataset Handler
                $scope.datasets = {};
                // Controller actions
                $scope.actions = {
                    AddBillOfLanding: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("BillOfLanding", "AddBillOfLanding", "GET", [], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    EditBillOfLanding: function (id, _cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("BillOfLanding", "EditBillOfLanding", "GET", [id], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    SaveBillOfLanding: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    Joove.Common.autocompleteFix();
                                    return [4 /*yield*/, window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit)];
                                case 1:
                                    _a.sent();
                                    window._context.isDirty = false;
                                    Joove.Core.executeControllerActionNew({
                                        verb: 'POST', controller: 'BillOfLanding', action: 'SaveBillOfLanding',
                                        queryData: [], postData: { 'model': $scope.model },
                                        cb: _cb, modalOptions: _modalOptions, event: _e
                                    });
                                    return [2 /*return*/];
                            }
                        });
                    }); },
                    DeleteBillOfLanding: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            window._context.isDirty = false;
                            Joove.Core.executeControllerActionNew({
                                verb: 'POST', controller: 'BillOfLanding', action: 'DeleteBillOfLanding',
                                queryData: [], postData: { 'model': $scope.model },
                                cb: _cb, modalOptions: _modalOptions, event: _e
                            });
                            return [2 /*return*/];
                        });
                    }); },
                    NewBillOfLanding: function (transactionId, _cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("BillOfLanding", "NewBillOfLanding", "GET", [transactionId], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    OnOrderSelected: function (orders, _cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    Joove.Common.autocompleteFix();
                                    return [4 /*yield*/, window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit)];
                                case 1:
                                    _a.sent();
                                    window._context.isDirty = false;
                                    Joove.Core.executeControllerActionNew({
                                        verb: 'POST', controller: 'BillOfLanding', action: 'OnOrderSelected',
                                        queryData: [], postData: { 'model': $scope.model, 'orders': orders },
                                        cb: _cb, modalOptions: _modalOptions, event: _e
                                    });
                                    return [2 /*return*/];
                            }
                        });
                    }); }
                };
                // Events
                $scope.eventCallbacks = {
                    PickList1OnChange: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (_this.timeoutDelayLockPickList1OnChange != null) {
                            $timeout.cancel(_this.timeoutDelayLockPickList1OnChange);
                        }
                        _this.timeoutDelayLockPickList1OnChange = $timeout(function () {
                            if (e.target) {
                                Joove.Core.onChange(e.target, null, false);
                            }
                            else {
                                Joove.Core.onChange($("[jb-id='" + e + "']").get(0), null, false);
                            }
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                var p_FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel = Joove.Common.nullSafe(function () { return Joove.DatasourceManager.getSelectedItems($("[jb-id='PickList1']"), e); }, null);
                                if (eval("DSS5_SupplyChainFinancialsOptimisation.ViewModels.BillOfLanding.FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel") != null && eval("DSS5_SupplyChainFinancialsOptimisation.ViewModels.BillOfLanding.FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel._initializeFrom") != null) {
                                    var _initial = p_FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel;
                                    p_FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel = [];
                                    for (var _i = 0; _i < _initial.length; _i++) {
                                        var _temp = eval("DSS5_SupplyChainFinancialsOptimisation.ViewModels.BillOfLanding.FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel._initializeFrom(_initial[_i])");
                                        p_FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel.push(_temp);
                                    }
                                }
                                $scope.actions.OnOrderSelected(p_FormControls_BillOfLanding_FormControlsDefinition_PickList1_PickListControl_SelectedItems_OrderViewModel, null, null, e);
                            }, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    ButtonClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockButtonClicked != null) {
                            $timeout.cancel(_this.timeoutDelayLockButtonClicked);
                        }
                        _this.timeoutDelayLockButtonClicked = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("PartialProofOfDeliveryForm", "NewPPOD", "GET", [Joove.Common.nullSafe(function () { return window["scope_BillOfLanding"].model.TransactionId; }, 0)], {}, { mode: 'Slide', width: '80%', height: '80%' });
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    cmdBillOfLandingSaveClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockcmdBillOfLandingSaveClicked != null) {
                            $timeout.cancel(_this.timeoutDelayLockcmdBillOfLandingSaveClicked);
                        }
                        _this.timeoutDelayLockcmdBillOfLandingSaveClicked = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                $scope.actions.SaveBillOfLanding(null, null, e);
                            }, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                        }, 0);
                    },
                    cmdDeleteBillOfLandingClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockcmdDeleteBillOfLandingClicked != null) {
                            $timeout.cancel(_this.timeoutDelayLockcmdDeleteBillOfLandingClicked);
                        }
                        _this.timeoutDelayLockcmdDeleteBillOfLandingClicked = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                $scope.actions.DeleteBillOfLanding(null, null, e);
                            }, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    cmdExitClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        Joove.Common.setControlKeyPressed(e, 0);
                        window._commander.closeForm();
                    }
                };
                // Rules
                window._ruleEngine.addDataValidations(BillOfLandingDataValidations);
                window._ruleEngine.addConditionalFormattings(BillOfLandingConditionalFormattings);
                window._ruleEngine.addCalculatedExpressions(BillOfLandingCalculatedExpressions);
                window._commander.executeCommands(window.viewDTO.ClientCommands);
                window.viewDTO.ClientCommands = [];
                Joove.Common.setNumberLocalizationSettings();
                Joove.DeveloperApi.init($scope, window.scope_MasterPage);
                window.$formExtend && window.$formExtend();
                window.$onFormLoaded && window.$onFormLoaded();
            };
            return BillOfLandingController;
        }());
        angular.module("Application").controller("BillOfLandingController", ["$scope", "$timeout", BillOfLandingController]);
    })(Controllers = DSS5_SupplyChainFinancialsOptimisation.Controllers || (DSS5_SupplyChainFinancialsOptimisation.Controllers = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));