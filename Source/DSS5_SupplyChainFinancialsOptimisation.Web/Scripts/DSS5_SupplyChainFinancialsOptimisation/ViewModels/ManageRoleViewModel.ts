// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.ManageRole {
export class ManageRoleViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
ApplicationRole:
                true
            }
        } else {
            this._members["ApplicationRole"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        if(instance.ApplicationRole != null)
            instance.ApplicationRole = ApplicationRole_ApplicationRoleViewModel._lightCast(instance.ApplicationRole);
        return instance;
    }

    public static _initializeFrom(original: ManageRoleViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ManageRoleViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ManageRoleViewModel = new ManageRoleViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateManageRoleViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateManageRoleViewModel(original: ManageRoleViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;


        if(original.ApplicationRole !== undefined) this.ApplicationRole = ApplicationRole_ApplicationRoleViewModel._initializeFrom(original.ApplicationRole, ignoreReadOnlyProperties, context);
        this.AddPermissionSelectedItemKeys = original.AddPermissionSelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ManageRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            ManageRoleViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ManageRoleViewModel {
        var reduced = ManageRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        ManageRoleViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: ManageRoleViewModel) {
        if (reduced == null) return;


        DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel._deleteDropDownInitialValues(reduced);
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public ApplicationRole:
    any;
public AddPermissionSelectedItemKeys:
    any[];
}

export class ApplicationRole_ApplicationRoleViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Description:
true,Id:
true,IsCustom:
true,Name:
true,Permissions:
                true
            }
        } else {
            this._members["Description"] = true;
            this._members["Id"] = true;
            this._members["IsCustom"] = true;
            this._members["Name"] = true;
            this._members["Permissions"] = true;
        }

        this.Permissions = new Array<any>();
    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;


        if(instance.Permissions != null) {
            for(let i = 0; i < instance.Permissions.length; i++) {
                instance.Permissions[i] = ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel._lightCast(instance.Permissions[i]);

            }
        }
        return instance;
    }

    public static _initializeFrom(original: ApplicationRole_ApplicationRoleViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ApplicationRole_ApplicationRoleViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ApplicationRole_ApplicationRoleViewModel = new ApplicationRole_ApplicationRoleViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateApplicationRole_ApplicationRoleViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateApplicationRole_ApplicationRoleViewModel(original: ApplicationRole_ApplicationRoleViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.Description !== undefined) this.Description = original.Description;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.IsCustom !== undefined) this.IsCustom = original.IsCustom;
        if(original.Name !== undefined) this.Name = original.Name;

        if(original.Permissions != null) {
            for(let i = 0; i < original.Permissions.length; i++) {
                this.Permissions.push(ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel._initializeFrom(original.Permissions[i], ignoreReadOnlyProperties, context));
            }
        }

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ApplicationRole_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ApplicationRole_ApplicationRoleViewModel {
        var reduced = ApplicationRole_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public Description:
    any;
public Id:
    any;
public IsCustom:
    any;
public Name:
    any;
public Permissions:
    Array<any>;
    public _versionTimestamp?: string;
}

export class ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Description:
true,Id:
true,IsCustom:
true,Name:
                true
            }
        } else {
            this._members["Description"] = true;
            this._members["Id"] = true;
            this._members["IsCustom"] = true;
            this._members["Name"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel = new ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel(original: ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.Description !== undefined) this.Description = original.Description;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.IsCustom !== undefined) this.IsCustom = original.IsCustom;
        if(original.Name !== undefined) this.Name = original.Name;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel {
        var reduced = ApplicationRole_ApplicationRole_Permissions_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public Description:
    any;
public Id:
    any;
public IsCustom:
    any;
public Name:
    any;
    public _versionTimestamp?: string;
}

}