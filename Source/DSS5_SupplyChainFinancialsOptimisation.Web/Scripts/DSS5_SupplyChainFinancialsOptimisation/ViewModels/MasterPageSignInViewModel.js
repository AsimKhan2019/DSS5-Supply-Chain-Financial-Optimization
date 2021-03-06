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
        var MasterPageSignIn;
        (function (MasterPageSignIn) {
            var MasterPageSignInViewModel = (function (_super) {
                __extends(MasterPageSignInViewModel, _super);
                function MasterPageSignInViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {};
                    }
                    else {
                    }
                    return _this;
                }
                MasterPageSignInViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                MasterPageSignInViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new MasterPageSignInViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateMasterPageSignInViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                MasterPageSignInViewModel.prototype._hydrateMasterPageSignInViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = MasterPageSignInViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        MasterPageSignInViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                MasterPageSignInViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = MasterPageSignInViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    MasterPageSignInViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                MasterPageSignInViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                };
                MasterPageSignInViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return MasterPageSignInViewModel;
            }(BaseClass.ViewModel));
            MasterPageSignIn.MasterPageSignInViewModel = MasterPageSignInViewModel;
        })(MasterPageSignIn = ViewModels.MasterPageSignIn || (ViewModels.MasterPageSignIn = {}));
    })(ViewModels = DSS5_SupplyChainFinancialsOptimisation.ViewModels || (DSS5_SupplyChainFinancialsOptimisation.ViewModels = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
