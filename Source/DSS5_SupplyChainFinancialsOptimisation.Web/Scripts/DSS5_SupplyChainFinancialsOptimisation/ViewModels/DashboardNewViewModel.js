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
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS5_SupplyChainFinancialsOptimisation;
(function (DSS5_SupplyChainFinancialsOptimisation) {
    var ViewModels;
    (function (ViewModels) {
        var DashboardNew;
        (function (DashboardNew) {
            var DashboardNewViewModel = (function (_super) {
                __extends(DashboardNewViewModel, _super);
                function DashboardNewViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            TotalOnTime: true, TotalAsOrdered: true, TotalInFull: true, TotalImpeachments: true, Top5Sellers: true
                        };
                    }
                    else {
                        _this._members["TotalOnTime"] = true;
                        _this._members["TotalAsOrdered"] = true;
                        _this._members["TotalInFull"] = true;
                        _this._members["TotalImpeachments"] = true;
                        _this._members["Top5Sellers"] = true;
                    }
                    _this.Top5Sellers = new Array();
                    return _this;
                }
                DashboardNewViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Top5Sellers != null) {
                        for (var i = 0; i < instance.Top5Sellers.length; i++) {
                            instance.Top5Sellers[i] = Top5Sellers_SupplierStatisticViewModel._lightCast(instance.Top5Sellers[i]);
                        }
                    }
                    return instance;
                };
                DashboardNewViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new DashboardNewViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateDashboardNewViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                DashboardNewViewModel.prototype._hydrateDashboardNewViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.TotalOnTime !== undefined)
                        this.TotalOnTime = original.TotalOnTime;
                    if (original.TotalAsOrdered !== undefined)
                        this.TotalAsOrdered = original.TotalAsOrdered;
                    if (original.TotalInFull !== undefined)
                        this.TotalInFull = original.TotalInFull;
                    if (original.TotalImpeachments !== undefined)
                        this.TotalImpeachments = original.TotalImpeachments;
                    if (original.Top5Sellers != null) {
                        for (var i = 0; i < original.Top5Sellers.length; i++) {
                            this.Top5Sellers.push(Top5Sellers_SupplierStatisticViewModel._initializeFrom(original.Top5Sellers[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    this.Chart1SelectedItemKeys = original.Chart1SelectedItemKeys;
                    this.Chart11SelectedItemKeys = original.Chart11SelectedItemKeys;
                    this.Chart1112SelectedItemKeys = original.Chart1112SelectedItemKeys;
                    this.Chart1111SelectedItemKeys = original.Chart1111SelectedItemKeys;
                    this.Chart2SelectedItemKeys = original.Chart2SelectedItemKeys;
                    this.Chart3SelectedItemKeys = original.Chart3SelectedItemKeys;
                    this.ChartSelectedItemKeys = original.ChartSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = DashboardNewViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        DashboardNewViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                DashboardNewViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = DashboardNewViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    DashboardNewViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                DashboardNewViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                DashboardNewViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return DashboardNewViewModel;
            }(DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            DashboardNew.DashboardNewViewModel = DashboardNewViewModel;
            var Top5Sellers_SupplierStatisticViewModel = (function (_super) {
                __extends(Top5Sellers_SupplierStatisticViewModel, _super);
                function Top5Sellers_SupplierStatisticViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            CurrentTurnover: true, Id: true, Supplier: true
                        };
                    }
                    else {
                        _this._members["CurrentTurnover"] = true;
                        _this._members["Id"] = true;
                        _this._members["Supplier"] = true;
                    }
                    return _this;
                }
                Top5Sellers_SupplierStatisticViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Supplier != null)
                        instance.Supplier = Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel._lightCast(instance.Supplier);
                    return instance;
                };
                Top5Sellers_SupplierStatisticViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Top5Sellers_SupplierStatisticViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateTop5Sellers_SupplierStatisticViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Top5Sellers_SupplierStatisticViewModel.prototype._hydrateTop5Sellers_SupplierStatisticViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.CurrentTurnover !== undefined)
                        this.CurrentTurnover = original.CurrentTurnover;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.Supplier !== undefined)
                        this.Supplier = Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel._initializeFrom(original.Supplier, ignoreReadOnlyProperties, context);
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Top5Sellers_SupplierStatisticViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Top5Sellers_SupplierStatisticViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Top5Sellers_SupplierStatisticViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Top5Sellers_SupplierStatisticViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Top5Sellers_SupplierStatisticViewModel;
            }(BaseClass.ViewModel));
            DashboardNew.Top5Sellers_SupplierStatisticViewModel = Top5Sellers_SupplierStatisticViewModel;
            var Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel = (function (_super) {
                __extends(Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel, _super);
                function Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Company: true, UserName: true, SupplierContactInformation: true
                        };
                    }
                    else {
                        _this._members["Company"] = true;
                        _this._members["UserName"] = true;
                        _this._members["SupplierContactInformation"] = true;
                    }
                    return _this;
                }
                Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.SupplierContactInformation != null)
                        instance.SupplierContactInformation = Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel._lightCast(instance.SupplierContactInformation);
                    return instance;
                };
                Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateTop5Sellers_SupplierStatistic_Supplier_SupplierViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel.prototype._hydrateTop5Sellers_SupplierStatistic_Supplier_SupplierViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.Company !== undefined)
                        this.Company = original.Company;
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    if (original.SupplierContactInformation !== undefined)
                        this.SupplierContactInformation = Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel._initializeFrom(original.SupplierContactInformation, ignoreReadOnlyProperties, context);
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel;
            }(BaseClass.ViewModel));
            DashboardNew.Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel = Top5Sellers_SupplierStatistic_Supplier_SupplierViewModel;
            var Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel = (function (_super) {
                __extends(Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel, _super);
                function Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, ManagingDirector: true, Telephone: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["ManagingDirector"] = true;
                        _this._members["Telephone"] = true;
                    }
                    return _this;
                }
                Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateTop5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel.prototype._hydrateTop5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.ManagingDirector !== undefined)
                        this.ManagingDirector = original.ManagingDirector;
                    if (original.Telephone !== undefined)
                        this.Telephone = original.Telephone;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel;
            }(BaseClass.ViewModel));
            DashboardNew.Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel = Top5Sellers_SupplierStatistic_Supplier_Supplier_SupplierContactInformation_SupplierContactInformationViewModel;
        })(DashboardNew = ViewModels.DashboardNew || (ViewModels.DashboardNew = {}));
    })(ViewModels = DSS5_SupplyChainFinancialsOptimisation.ViewModels || (DSS5_SupplyChainFinancialsOptimisation.ViewModels = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
