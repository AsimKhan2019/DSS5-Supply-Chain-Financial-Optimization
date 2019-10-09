// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.PopUpDataAvailability {
export class PopUpDataAvailabilityViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {

            }
        } else {

        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: PopUpDataAvailabilityViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): PopUpDataAvailabilityViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        PopUpDataAvailabilityViewModel = new PopUpDataAvailabilityViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydratePopUpDataAvailabilityViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydratePopUpDataAvailabilityViewModel(original: PopUpDataAvailabilityViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;


        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = PopUpDataAvailabilityViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            PopUpDataAvailabilityViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): PopUpDataAvailabilityViewModel {
        var reduced = PopUpDataAvailabilityViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        PopUpDataAvailabilityViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: PopUpDataAvailabilityViewModel) {
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

}

}
