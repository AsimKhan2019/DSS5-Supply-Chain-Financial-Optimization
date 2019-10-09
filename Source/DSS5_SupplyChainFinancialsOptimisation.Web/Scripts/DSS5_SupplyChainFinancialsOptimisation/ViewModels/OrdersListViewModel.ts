// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.OrdersList {
export class OrdersListViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPageForLists.MasterPageForListsViewModel {
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

    public static _initializeFrom(original: OrdersListViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): OrdersListViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        OrdersListViewModel = new OrdersListViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateOrdersListViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateOrdersListViewModel(original: OrdersListViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageForListsViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        this.OrderListNoDTSelectedItemKeys = original.OrderListNoDTSelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = OrdersListViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            OrdersListViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): OrdersListViewModel {
        var reduced = OrdersListViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        OrdersListViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: OrdersListViewModel) {
        if (reduced == null) return;


        DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPageForLists.MasterPageForListsViewModel._deleteDropDownInitialValues(reduced);
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

public OrderListNoDTSelectedItemKeys:
    any[];
}

}
