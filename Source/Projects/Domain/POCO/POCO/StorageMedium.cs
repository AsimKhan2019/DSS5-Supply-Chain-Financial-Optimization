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
using zAppDev.DotNet.Framework.Data.Domain;

namespace DSS5_SupplyChainFinancialsOptimisation.BO
{
    /// <summary>
    /// The StorageMedium class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum StorageMedium
    {
        [DataMember(Name="FileSystem")]
        FileSystem,
        [DataMember(Name="DataBase")]
        DataBase,
    }
}