
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
	/// The DataQuality extensions
	/// </summary>
	public static class DataQualityExtensions
	{
        public static int? DataQuality(this BO.DataQuality @this, string UserName){using (new zAppDev.DotNet.Framework.Profiling.Profiler("DataQuality", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "DataQuality")) {
int? count = 0;
DSS5_SupplyChainFinancialsOptimisation.BO.Supplier supplier =  new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(UserName);
if ((supplier?.DataQuality?.Orders ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
if ((supplier?.DataQuality?.DeliveryNotes ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
if ((supplier?.DataQuality?.CustomsDocuments ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
if ((supplier?.DataQuality?.IntermediaryLogistics ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
if ((supplier?.DataQuality?.Invoices ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
if ((supplier?.DataQuality?.PoDs ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
if ((supplier?.DataQuality?.PaymentData ?? false)) {
count = count.GetValueOrDefault(0) + 1;}
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "DataQuality",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "count " + (count?.ToString() ?? ""));
return count;
}
}



        
	}
}