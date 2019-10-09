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
        var LetterOfCreditForm;
        (function (LetterOfCreditForm) {
            var LetterOfCreditFormViewModel = (function (_super) {
                __extends(LetterOfCreditFormViewModel, _super);
                function LetterOfCreditFormViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            LetterOfCredit: true, IsSupplier: true
                        };
                    }
                    else {
                        _this._members["LetterOfCredit"] = true;
                        _this._members["IsSupplier"] = true;
                    }
                    return _this;
                }
                LetterOfCreditFormViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.LetterOfCredit != null)
                        instance.LetterOfCredit = LetterOfCredit_LetterOfCreditViewModel._lightCast(instance.LetterOfCredit);
                    return instance;
                };
                LetterOfCreditFormViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new LetterOfCreditFormViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateLetterOfCreditFormViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                LetterOfCreditFormViewModel.prototype._hydrateLetterOfCreditFormViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.LetterOfCredit !== undefined)
                        this.LetterOfCredit = LetterOfCredit_LetterOfCreditViewModel._initializeFrom(original.LetterOfCredit, ignoreReadOnlyProperties, context);
                    if (original.IsSupplier !== undefined)
                        this.IsSupplier = original.IsSupplier;
                    this.PickListSelectedItemKeys = original.PickListSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = LetterOfCreditFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        LetterOfCreditFormViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                LetterOfCreditFormViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = LetterOfCreditFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    LetterOfCreditFormViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                LetterOfCreditFormViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                LetterOfCreditFormViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return LetterOfCreditFormViewModel;
            }(DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            LetterOfCreditForm.LetterOfCreditFormViewModel = LetterOfCreditFormViewModel;
            var LetterOfCredit_LetterOfCreditViewModel = (function (_super) {
                __extends(LetterOfCredit_LetterOfCreditViewModel, _super);
                function LetterOfCredit_LetterOfCreditViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Calculated: true, DateOfExpiry: true, DateOfValidity: true, Detail: true, Id: true, IssuingBank: true, UploadOfScan: true, ValueOfLoC: true, Transaction: true, Orders: true
                        };
                    }
                    else {
                        _this._members["Calculated"] = true;
                        _this._members["DateOfExpiry"] = true;
                        _this._members["DateOfValidity"] = true;
                        _this._members["Detail"] = true;
                        _this._members["Id"] = true;
                        _this._members["IssuingBank"] = true;
                        _this._members["UploadOfScan"] = true;
                        _this._members["ValueOfLoC"] = true;
                        _this._members["Transaction"] = true;
                        _this._members["Orders"] = true;
                    }
                    _this.Orders = new Array();
                    return _this;
                }
                LetterOfCredit_LetterOfCreditViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.DateOfExpiry != null)
                        instance.DateOfExpiry = new Date(instance.DateOfExpiry);
                    if (instance.DateOfValidity != null)
                        instance.DateOfValidity = new Date(instance.DateOfValidity);
                    if (instance.Transaction != null)
                        instance.Transaction = LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel._lightCast(instance.Transaction);
                    if (instance.Orders != null) {
                        for (var i = 0; i < instance.Orders.length; i++) {
                            instance.Orders[i] = LetterOfCredit_LetterOfCredit_Orders_OrderViewModel._lightCast(instance.Orders[i]);
                        }
                    }
                    return instance;
                };
                LetterOfCredit_LetterOfCreditViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new LetterOfCredit_LetterOfCreditViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateLetterOfCredit_LetterOfCreditViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                LetterOfCredit_LetterOfCreditViewModel.prototype._hydrateLetterOfCredit_LetterOfCreditViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.Calculated !== undefined)
                        this.Calculated = original.Calculated;
                    if (!CLMS.Framework.String.IsNullOrEmpty(original.DateOfExpiry))
                        this.DateOfExpiry = new Date(original.DateOfExpiry);
                    if (!CLMS.Framework.String.IsNullOrEmpty(original.DateOfValidity))
                        this.DateOfValidity = new Date(original.DateOfValidity);
                    if (original.Detail !== undefined)
                        this.Detail = original.Detail;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.IssuingBank !== undefined)
                        this.IssuingBank = original.IssuingBank;
                    if (original.UploadOfScan !== undefined)
                        this.UploadOfScan = original.UploadOfScan;
                    if (original.ValueOfLoC !== undefined)
                        this.ValueOfLoC = original.ValueOfLoC;
                    if (original.Transaction !== undefined)
                        this.Transaction = LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel._initializeFrom(original.Transaction, ignoreReadOnlyProperties, context);
                    if (original.Orders != null) {
                        for (var i = 0; i < original.Orders.length; i++) {
                            this.Orders.push(LetterOfCredit_LetterOfCredit_Orders_OrderViewModel._initializeFrom(original.Orders[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = LetterOfCredit_LetterOfCreditViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                LetterOfCredit_LetterOfCreditViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = LetterOfCredit_LetterOfCreditViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                LetterOfCredit_LetterOfCreditViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return LetterOfCredit_LetterOfCreditViewModel;
            }(BaseClass.ViewModel));
            LetterOfCreditForm.LetterOfCredit_LetterOfCreditViewModel = LetterOfCredit_LetterOfCreditViewModel;
            var LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel = (function (_super) {
                __extends(LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel, _super);
                function LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            FundedAmount: true, Id: true, TransactionDateOccured: true, TransactionValue: true, CommercialAgreement: true, ImportedBuyer: true
                        };
                    }
                    else {
                        _this._members["FundedAmount"] = true;
                        _this._members["Id"] = true;
                        _this._members["TransactionDateOccured"] = true;
                        _this._members["TransactionValue"] = true;
                        _this._members["CommercialAgreement"] = true;
                        _this._members["ImportedBuyer"] = true;
                    }
                    return _this;
                }
                LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.TransactionDateOccured != null)
                        instance.TransactionDateOccured = new Date(instance.TransactionDateOccured);
                    if (instance.CommercialAgreement != null)
                        instance.CommercialAgreement = LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel._lightCast(instance.CommercialAgreement);
                    if (instance.ImportedBuyer != null)
                        instance.ImportedBuyer = LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel._lightCast(instance.ImportedBuyer);
                    return instance;
                };
                LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateLetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel.prototype._hydrateLetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.FundedAmount !== undefined)
                        this.FundedAmount = original.FundedAmount;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (!CLMS.Framework.String.IsNullOrEmpty(original.TransactionDateOccured))
                        this.TransactionDateOccured = new Date(original.TransactionDateOccured);
                    if (original.TransactionValue !== undefined)
                        this.TransactionValue = original.TransactionValue;
                    if (original.CommercialAgreement !== undefined)
                        this.CommercialAgreement = LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel._initializeFrom(original.CommercialAgreement, ignoreReadOnlyProperties, context);
                    if (original.ImportedBuyer !== undefined)
                        this.ImportedBuyer = LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel._initializeFrom(original.ImportedBuyer, ignoreReadOnlyProperties, context);
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel;
            }(BaseClass.ViewModel));
            LetterOfCreditForm.LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel = LetterOfCredit_LetterOfCredit_Transaction_TransactionViewModel;
            var LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel = (function (_super) {
                __extends(LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel, _super);
                function LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, PaymentTerms: true, ProductCategory: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["PaymentTerms"] = true;
                        _this._members["ProductCategory"] = true;
                    }
                    return _this;
                }
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateLetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel.prototype._hydrateLetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.PaymentTerms !== undefined)
                        this.PaymentTerms = original.PaymentTerms;
                    if (original.ProductCategory !== undefined)
                        this.ProductCategory = original.ProductCategory;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel;
            }(BaseClass.ViewModel));
            LetterOfCreditForm.LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel = LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementViewModel;
            var LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel = (function (_super) {
                __extends(LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel, _super);
                function LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            AddressOne: true, AddressTwo: true, Code: true, Company: true, Id: true, Phone: true, VATNumber: true
                        };
                    }
                    else {
                        _this._members["AddressOne"] = true;
                        _this._members["AddressTwo"] = true;
                        _this._members["Code"] = true;
                        _this._members["Company"] = true;
                        _this._members["Id"] = true;
                        _this._members["Phone"] = true;
                        _this._members["VATNumber"] = true;
                    }
                    return _this;
                }
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateLetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel.prototype._hydrateLetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.AddressOne !== undefined)
                        this.AddressOne = original.AddressOne;
                    if (original.AddressTwo !== undefined)
                        this.AddressTwo = original.AddressTwo;
                    if (original.Code !== undefined)
                        this.Code = original.Code;
                    if (original.Company !== undefined)
                        this.Company = original.Company;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.Phone !== undefined)
                        this.Phone = original.Phone;
                    if (original.VATNumber !== undefined)
                        this.VATNumber = original.VATNumber;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel;
            }(BaseClass.ViewModel));
            LetterOfCreditForm.LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel = LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerViewModel;
            var LetterOfCredit_LetterOfCredit_Orders_OrderViewModel = (function (_super) {
                __extends(LetterOfCredit_LetterOfCredit_Orders_OrderViewModel, _super);
                function LetterOfCredit_LetterOfCredit_Orders_OrderViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            DateOfOrder: true, DeliveryTo: true, EstimatedDateOfDelivery: true, From: true, Id: true, IntermediateParty: true, IsCancelled: true, OrderAmount: true, OrderAttachment: true, OrderNumber: true, PaymentTerms: true, Status: true, TotalPrice: true
                        };
                    }
                    else {
                        _this._members["DateOfOrder"] = true;
                        _this._members["DeliveryTo"] = true;
                        _this._members["EstimatedDateOfDelivery"] = true;
                        _this._members["From"] = true;
                        _this._members["Id"] = true;
                        _this._members["IntermediateParty"] = true;
                        _this._members["IsCancelled"] = true;
                        _this._members["OrderAmount"] = true;
                        _this._members["OrderAttachment"] = true;
                        _this._members["OrderNumber"] = true;
                        _this._members["PaymentTerms"] = true;
                        _this._members["Status"] = true;
                        _this._members["TotalPrice"] = true;
                    }
                    return _this;
                }
                LetterOfCredit_LetterOfCredit_Orders_OrderViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.DateOfOrder != null)
                        instance.DateOfOrder = new Date(instance.DateOfOrder);
                    if (instance.EstimatedDateOfDelivery != null)
                        instance.EstimatedDateOfDelivery = new Date(instance.EstimatedDateOfDelivery);
                    return instance;
                };
                LetterOfCredit_LetterOfCredit_Orders_OrderViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new LetterOfCredit_LetterOfCredit_Orders_OrderViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateLetterOfCredit_LetterOfCredit_Orders_OrderViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                LetterOfCredit_LetterOfCredit_Orders_OrderViewModel.prototype._hydrateLetterOfCredit_LetterOfCredit_Orders_OrderViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (!CLMS.Framework.String.IsNullOrEmpty(original.DateOfOrder))
                        this.DateOfOrder = new Date(original.DateOfOrder);
                    if (original.DeliveryTo !== undefined)
                        this.DeliveryTo = original.DeliveryTo;
                    if (!CLMS.Framework.String.IsNullOrEmpty(original.EstimatedDateOfDelivery))
                        this.EstimatedDateOfDelivery = new Date(original.EstimatedDateOfDelivery);
                    if (original.From !== undefined)
                        this.From = original.From;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.IntermediateParty !== undefined)
                        this.IntermediateParty = original.IntermediateParty;
                    if (original.IsCancelled !== undefined)
                        this.IsCancelled = original.IsCancelled;
                    if (original.OrderAmount !== undefined)
                        this.OrderAmount = original.OrderAmount;
                    if (original.OrderAttachment !== undefined)
                        this.OrderAttachment = original.OrderAttachment;
                    if (original.OrderNumber !== undefined)
                        this.OrderNumber = original.OrderNumber;
                    if (original.PaymentTerms !== undefined)
                        this.PaymentTerms = original.PaymentTerms;
                    if (original.Status !== undefined)
                        this.Status = original.Status;
                    if (original.TotalPrice !== undefined)
                        this.TotalPrice = original.TotalPrice;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = LetterOfCredit_LetterOfCredit_Orders_OrderViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                LetterOfCredit_LetterOfCredit_Orders_OrderViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = LetterOfCredit_LetterOfCredit_Orders_OrderViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                LetterOfCredit_LetterOfCredit_Orders_OrderViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return LetterOfCredit_LetterOfCredit_Orders_OrderViewModel;
            }(BaseClass.ViewModel));
            LetterOfCreditForm.LetterOfCredit_LetterOfCredit_Orders_OrderViewModel = LetterOfCredit_LetterOfCredit_Orders_OrderViewModel;
            var $Status;
            (function ($Status) {
                $Status[$Status["Initial"] = 0] = "Initial";
            })($Status = LetterOfCreditForm.$Status || (LetterOfCreditForm.$Status = {}));
        })(LetterOfCreditForm = ViewModels.LetterOfCreditForm || (ViewModels.LetterOfCreditForm = {}));
    })(ViewModels = DSS5_SupplyChainFinancialsOptimisation.ViewModels || (DSS5_SupplyChainFinancialsOptimisation.ViewModels = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
