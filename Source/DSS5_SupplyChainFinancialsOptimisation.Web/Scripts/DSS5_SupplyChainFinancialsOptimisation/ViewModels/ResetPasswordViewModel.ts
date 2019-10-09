// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.ResetPassword {
export class ResetPasswordViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Code:
true,Email:
true,Password:
true,RepeatPassword:
                true
            }
        } else {
            this._members["Code"] = true;
            this._members["Email"] = true;
            this._members["Password"] = true;
            this._members["RepeatPassword"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: ResetPasswordViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ResetPasswordViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ResetPasswordViewModel = new ResetPasswordViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateResetPasswordViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateResetPasswordViewModel(original: ResetPasswordViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.Code !== undefined) this.Code = original.Code;
        if(original.Email !== undefined) this.Email = original.Email;
        if(original.Password !== undefined) this.Password = original.Password;
        if(original.RepeatPassword !== undefined) this.RepeatPassword = original.RepeatPassword;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ResetPasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            ResetPasswordViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ResetPasswordViewModel {
        var reduced = ResetPasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        ResetPasswordViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: ResetPasswordViewModel) {
        if (reduced == null) return;


        DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
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

public Code:
    any;
public Email:
    any;
public Password:
    any;
public RepeatPassword:
    any;
}

}
