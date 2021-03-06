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
        var BuyerForm;
        (function (BuyerForm) {
            var BuyerFormViewModel = (function (_super) {
                __extends(BuyerFormViewModel, _super);
                function BuyerFormViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Buyer: true
                        };
                    }
                    else {
                        _this._members["Buyer"] = true;
                    }
                    return _this;
                }
                BuyerFormViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Buyer != null)
                        instance.Buyer = Buyer_BuyerViewModel._lightCast(instance.Buyer);
                    return instance;
                };
                BuyerFormViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new BuyerFormViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateBuyerFormViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                BuyerFormViewModel.prototype._hydrateBuyerFormViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.Buyer !== undefined)
                        this.Buyer = Buyer_BuyerViewModel._initializeFrom(original.Buyer, ignoreReadOnlyProperties, context);
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = BuyerFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        BuyerFormViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                BuyerFormViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = BuyerFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    BuyerFormViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                BuyerFormViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                BuyerFormViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return BuyerFormViewModel;
            }(DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            BuyerForm.BuyerFormViewModel = BuyerFormViewModel;
            var Buyer_BuyerViewModel = (function (_super) {
                __extends(Buyer_BuyerViewModel, _super);
                function Buyer_BuyerViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            AddressOne: true, AddressTwo: true, AnnualTurnOver: true, Company: true, ContactPerson: true, CreditInsurance: true, Email: true, LegalRepresentative: true, Logo: true, PrimaryPhone: true, Rating: true, UserName: true, VatNumber: true
                        };
                    }
                    else {
                        _this._members["AddressOne"] = true;
                        _this._members["AddressTwo"] = true;
                        _this._members["AnnualTurnOver"] = true;
                        _this._members["Company"] = true;
                        _this._members["ContactPerson"] = true;
                        _this._members["CreditInsurance"] = true;
                        _this._members["Email"] = true;
                        _this._members["LegalRepresentative"] = true;
                        _this._members["Logo"] = true;
                        _this._members["PrimaryPhone"] = true;
                        _this._members["Rating"] = true;
                        _this._members["UserName"] = true;
                        _this._members["VatNumber"] = true;
                    }
                    return _this;
                }
                Buyer_BuyerViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                Buyer_BuyerViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Buyer_BuyerViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateBuyer_BuyerViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Buyer_BuyerViewModel.prototype._hydrateBuyer_BuyerViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.AddressOne !== undefined)
                        this.AddressOne = original.AddressOne;
                    if (original.AddressTwo !== undefined)
                        this.AddressTwo = original.AddressTwo;
                    if (original.AnnualTurnOver !== undefined)
                        this.AnnualTurnOver = original.AnnualTurnOver;
                    if (original.Company !== undefined)
                        this.Company = original.Company;
                    if (original.ContactPerson !== undefined)
                        this.ContactPerson = original.ContactPerson;
                    if (original.CreditInsurance !== undefined)
                        this.CreditInsurance = original.CreditInsurance;
                    if (original.Email !== undefined)
                        this.Email = original.Email;
                    if (original.LegalRepresentative !== undefined)
                        this.LegalRepresentative = original.LegalRepresentative;
                    if (original.Logo !== undefined)
                        this.Logo = original.Logo;
                    if (original.PrimaryPhone !== undefined)
                        this.PrimaryPhone = original.PrimaryPhone;
                    if (original.Rating !== undefined)
                        this.Rating = original.Rating;
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    if (original.VatNumber !== undefined)
                        this.VatNumber = original.VatNumber;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Buyer_BuyerViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Buyer_BuyerViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Buyer_BuyerViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Buyer_BuyerViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Buyer_BuyerViewModel;
            }(BaseClass.ViewModel));
            BuyerForm.Buyer_BuyerViewModel = Buyer_BuyerViewModel;
        })(BuyerForm = ViewModels.BuyerForm || (ViewModels.BuyerForm = {}));
    })(ViewModels = DSS5_SupplyChainFinancialsOptimisation.ViewModels || (DSS5_SupplyChainFinancialsOptimisation.ViewModels = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
