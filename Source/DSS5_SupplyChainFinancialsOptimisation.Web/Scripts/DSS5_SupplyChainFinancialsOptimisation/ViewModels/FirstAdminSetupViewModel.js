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
        var FirstAdminSetup;
        (function (FirstAdminSetup) {
            var FirstAdminSetupViewModel = (function (_super) {
                __extends(FirstAdminSetupViewModel, _super);
                function FirstAdminSetupViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            ApplicationUser: true
                        };
                    }
                    else {
                        _this._members["ApplicationUser"] = true;
                    }
                    return _this;
                }
                FirstAdminSetupViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.ApplicationUser != null)
                        instance.ApplicationUser = ApplicationUser_ApplicationUserViewModel._lightCast(instance.ApplicationUser);
                    return instance;
                };
                FirstAdminSetupViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new FirstAdminSetupViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateFirstAdminSetupViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                FirstAdminSetupViewModel.prototype._hydrateFirstAdminSetupViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.ApplicationUser !== undefined)
                        this.ApplicationUser = ApplicationUser_ApplicationUserViewModel._initializeFrom(original.ApplicationUser, ignoreReadOnlyProperties, context);
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = FirstAdminSetupViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        FirstAdminSetupViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                FirstAdminSetupViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = FirstAdminSetupViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    FirstAdminSetupViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                FirstAdminSetupViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                FirstAdminSetupViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return FirstAdminSetupViewModel;
            }(DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            FirstAdminSetup.FirstAdminSetupViewModel = FirstAdminSetupViewModel;
            var ApplicationUser_ApplicationUserViewModel = (function (_super) {
                __extends(ApplicationUser_ApplicationUserViewModel, _super);
                function ApplicationUser_ApplicationUserViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            UserName: true, Roles: true
                        };
                    }
                    else {
                        _this._members["UserName"] = true;
                        _this._members["Roles"] = true;
                    }
                    _this.Roles = new Array();
                    return _this;
                }
                ApplicationUser_ApplicationUserViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Roles != null) {
                        for (var i = 0; i < instance.Roles.length; i++) {
                            instance.Roles[i] = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._lightCast(instance.Roles[i]);
                        }
                    }
                    return instance;
                };
                ApplicationUser_ApplicationUserViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationUser_ApplicationUserViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationUser_ApplicationUserViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationUser_ApplicationUserViewModel.prototype._hydrateApplicationUser_ApplicationUserViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    if (original.Roles != null) {
                        for (var i = 0; i < original.Roles.length; i++) {
                            this.Roles.push(ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom(original.Roles[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationUser_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationUser_ApplicationUserViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationUser_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationUser_ApplicationUserViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationUser_ApplicationUserViewModel;
            }(BaseClass.ViewModel));
            FirstAdminSetup.ApplicationUser_ApplicationUserViewModel = ApplicationUser_ApplicationUserViewModel;
            var ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel = (function (_super) {
                __extends(ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel, _super);
                function ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, Name: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["Name"] = true;
                    }
                    return _this;
                }
                ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel.prototype._hydrateApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.Name !== undefined)
                        this.Name = original.Name;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel;
            }(BaseClass.ViewModel));
            FirstAdminSetup.ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel;
        })(FirstAdminSetup = ViewModels.FirstAdminSetup || (ViewModels.FirstAdminSetup = {}));
    })(ViewModels = DSS5_SupplyChainFinancialsOptimisation.ViewModels || (DSS5_SupplyChainFinancialsOptimisation.ViewModels = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
