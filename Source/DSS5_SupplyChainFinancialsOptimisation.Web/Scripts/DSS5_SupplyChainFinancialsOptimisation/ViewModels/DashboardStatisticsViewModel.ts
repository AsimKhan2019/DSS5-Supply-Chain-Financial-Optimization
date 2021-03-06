// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.DashboardStatistics {
export class DashboardStatisticsViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel {
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

    public static _initializeFrom(original: DashboardStatisticsViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): DashboardStatisticsViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        DashboardStatisticsViewModel = new DashboardStatisticsViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateDashboardStatisticsViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateDashboardStatisticsViewModel(original: DashboardStatisticsViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        this.ChartDataAvailability1SelectedItemKeys = original.ChartDataAvailability1SelectedItemKeys;
        this.ChartDataAvailabilitySelectedItemKeys = original.ChartDataAvailabilitySelectedItemKeys;
        this.ChartSelectedItemKeys = original.ChartSelectedItemKeys;
        this.ChartTurnoverSelectedItemKeys = original.ChartTurnoverSelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = DashboardStatisticsViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            DashboardStatisticsViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): DashboardStatisticsViewModel {
        var reduced = DashboardStatisticsViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        DashboardStatisticsViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: DashboardStatisticsViewModel) {
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

public ChartDataAvailability1SelectedItemKeys:
    any[];
public ChartDataAvailabilitySelectedItemKeys:
    any[];
public ChartSelectedItemKeys:
    any[];
public ChartTurnoverSelectedItemKeys:
    any[];
}

}
