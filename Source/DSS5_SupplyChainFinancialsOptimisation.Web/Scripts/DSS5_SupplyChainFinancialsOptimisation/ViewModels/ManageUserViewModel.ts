// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.ManageUser {
export class ManageUserViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
ApplicationUser:
true,Password:
true,PasswordRetype:
                true
            }
        } else {
            this._members["ApplicationUser"] = true;
            this._members["Password"] = true;
            this._members["PasswordRetype"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        if(instance.ApplicationUser != null)
            instance.ApplicationUser = ApplicationUser_ApplicationUserViewModel._lightCast(instance.ApplicationUser);
        return instance;
    }

    public static _initializeFrom(original: ManageUserViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ManageUserViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ManageUserViewModel = new ManageUserViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateManageUserViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateManageUserViewModel(original: ManageUserViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;


        if(original.ApplicationUser !== undefined) this.ApplicationUser = ApplicationUser_ApplicationUserViewModel._initializeFrom(original.ApplicationUser, ignoreReadOnlyProperties, context);
        if(original.Password !== undefined) this.Password = original.Password;
        if(original.PasswordRetype !== undefined) this.PasswordRetype = original.PasswordRetype;
        this.Button1SelectedItemKeys = original.Button1SelectedItemKeys;
        this.Button2SelectedItemKeys = original.Button2SelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ManageUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            ManageUserViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ManageUserViewModel {
        var reduced = ManageUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        ManageUserViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: ManageUserViewModel) {
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

public ApplicationUser:
    any;
public Password:
    any;
public PasswordRetype:
    any;
public Button1SelectedItemKeys:
    any[];
public Button2SelectedItemKeys:
    any[];
}

export class ApplicationUser_ApplicationUserViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
AccessFailedCount:
true,Email:
true,LockoutEnabled:
true,Name:
true,UserName:
true,Permissions:
true,Roles:
                true
            }
        } else {
            this._members["AccessFailedCount"] = true;
            this._members["Email"] = true;
            this._members["LockoutEnabled"] = true;
            this._members["Name"] = true;
            this._members["UserName"] = true;
            this._members["Permissions"] = true;
            this._members["Roles"] = true;
        }

        this.Permissions = new Array<any>();
        this.Roles = new Array<any>();
    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;


        if(instance.Permissions != null) {
            for(let i = 0; i < instance.Permissions.length; i++) {
                instance.Permissions[i] = ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel._lightCast(instance.Permissions[i]);

            }
        }

        if(instance.Roles != null) {
            for(let i = 0; i < instance.Roles.length; i++) {
                instance.Roles[i] = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._lightCast(instance.Roles[i]);

            }
        }
        return instance;
    }

    public static _initializeFrom(original: ApplicationUser_ApplicationUserViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ApplicationUser_ApplicationUserViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ApplicationUser_ApplicationUserViewModel = new ApplicationUser_ApplicationUserViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateApplicationUser_ApplicationUserViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateApplicationUser_ApplicationUserViewModel(original: ApplicationUser_ApplicationUserViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.AccessFailedCount !== undefined) this.AccessFailedCount = original.AccessFailedCount;
        if(original.Email !== undefined) this.Email = original.Email;
        if(original.LockoutEnabled !== undefined) this.LockoutEnabled = original.LockoutEnabled;
        if(original.Name !== undefined) this.Name = original.Name;
        if(original.UserName !== undefined) this.UserName = original.UserName;

        if(original.Permissions != null) {
            for(let i = 0; i < original.Permissions.length; i++) {
                this.Permissions.push(ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel._initializeFrom(original.Permissions[i], ignoreReadOnlyProperties, context));
            }
        }

        if(original.Roles != null) {
            for(let i = 0; i < original.Roles.length; i++) {
                this.Roles.push(ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom(original.Roles[i], ignoreReadOnlyProperties, context));
            }
        }

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ApplicationUser_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ApplicationUser_ApplicationUserViewModel {
        var reduced = ApplicationUser_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);

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

public AccessFailedCount:
    any;
public Email:
    any;
public LockoutEnabled:
    any;
public Name:
    any;
public UserName:
    any;
public Permissions:
    Array<any>;
public Roles:
    Array<any>;
    public _versionTimestamp?: string;
}

export class ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Description:
true,Id:
true,Name:
                true
            }
        } else {
            this._members["Description"] = true;
            this._members["Id"] = true;
            this._members["Name"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel = new ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel(original: ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.Description !== undefined) this.Description = original.Description;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.Name !== undefined) this.Name = original.Name;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel {
        var reduced = ApplicationUser_ApplicationUser_Permissions_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);

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
public Name:
    any;
    public _versionTimestamp?: string;
}

export class ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Description:
true,Id:
true,Name:
                true
            }
        } else {
            this._members["Description"] = true;
            this._members["Id"] = true;
            this._members["Name"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel = new ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel(original: ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.Description !== undefined) this.Description = original.Description;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.Name !== undefined) this.Name = original.Name;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel {
        var reduced = ApplicationUser_ApplicationUser_Roles_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);

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
public Name:
    any;
    public _versionTimestamp?: string;
}

}
