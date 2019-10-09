
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
	/// The CommercialAgreement extensions
	/// </summary>
	public static class CommercialAgreementExtensions
	{
        public static System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer> FindSupplierBuyers(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("CommercialAgreement", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "FindSupplierBuyers")) {
string supUsername = "";
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement> supplierAgreements = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>((a) => a.Supplier.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentApplicationUser().UserName);
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer> foundBuyers = new System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>();
foreach (var supAgreement in supplierAgreements ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>()) {
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "CommercialAgreement",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "buyer: " + (supAgreement?.ImportedBuyer?.Code ?? "") + "c.a. " + (supAgreement?.Id?.ToString() ?? ""));
foundBuyers?.Add(supAgreement?.ImportedBuyer);
}
return foundBuyers?.Distinct().ToList();
}
}



        
	}
}
