
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DSS5_SupplyChainFinancialsOptimisation.DAL;

namespace DSS5_SupplyChainFinancialsOptimisation.BO
{
	/// <summary>
	/// The TurnoverStatistic extensions
	/// </summary>
	public static class TurnoverStatisticExtensions
	{
        public static System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> GetTurnoverStatisticsForSupplier(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier supplier){using (new zAppDev.DotNet.Framework.Profiling.Profiler("TurnoverStatistic", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetTurnoverStatisticsForSupplier")) {
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> stats = new System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>();
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction> transactions = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>((a) => a.Supplier.UserName == supplier.UserName);
System.Collections.Generic.List<int?> years = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>((a) => a.Supplier.UserName == supplier.UserName)?.Select((a) => a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Year).Select(_n => _n as int?).ToList().Distinct().ToList().OrderBy((a) => a.GetValueOrDefault(0).ToString()).ToList();
foreach (var year in years ?? Enumerable.Empty<int?>()) {
DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic stat = new DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic();
stat.Supplier = supplier;stat.TotalAmount = (transactions?.Where((a) => a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Year == year).Sum((a) => a.TransactionValue) ?? 0);stat.Year = year;stat.TotalAmountFunded = (transactions?.Where((a) => a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Year == year).Sum((a) => a.FundedAmount) ?? 0);stats?.Add(stat);
}
return stats;
}
}


public static System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> GetTurnoverStatisticsPerMonth(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier supplier, int? year){using (new zAppDev.DotNet.Framework.Profiling.Profiler("TurnoverStatistic", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetTurnoverStatisticsPerMonth")) {
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> stats = new System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>();
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction> transactions = new System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>();
System.Collections.Generic.List<int?> months = new System.Collections.Generic.List<int?>();
try {
transactions = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>((a) => a.Supplier.UserName == supplier.UserName && a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Year == year).ToList();months = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>((a) => a.Supplier.UserName == supplier.UserName)?.Select((a) => a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Month).Select(_n => _n as int?).ToList().Distinct().ToList().ToList();months = months.OrderBy((a) => a).ToList().ToList();foreach (var month in months ?? Enumerable.Empty<int?>()) {
DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic stat = new DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic();
stat.Supplier = supplier;stat.TotalAmount = (transactions?.Where((a) => a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Month == month).Sum((a) => a.TransactionValue) ?? 0);stat.TotalAmountFunded = (transactions?.Where((a) => a.TransactionDateOccured.GetValueOrDefault(System.Data.SqlTypes.SqlDateTime.MinValue.Value).Month == month).Sum((a) => a.FundedAmount) ?? 0);stat.Month = month;stats?.Add(stat);
}
}
catch (System.Exception e) {
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "TurnoverStatistic",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Error" + e.Message);
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "TurnoverStatistic",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "OH-OH!!!!" + transactions?.Count((a) => a != null) + "--------------" + months.Count((a) => a != null));
}
return stats;
}
}



        
	}
}
