// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSS5_SupplyChainFinancialsOptimisation.Services.Supplier.DataContracts;

namespace DSS5_SupplyChainFinancialsOptimisation.Services
{
    [XmlSerializerFormat]
    [ServiceContract]
    public interface ISupplierService
    {
        [OperationContract]
        void Create(DSS5_SupplyChainFinancialsOptimisation.Services.Supplier.DataContracts.SupplierDTO _newSupplier, string _RequestSourceIp, string _UserName);

        [OperationContract]
        DSS5_SupplyChainFinancialsOptimisation.Services.Supplier.DataContracts.SupplierDTO Get(string userName, string _RequestSourceIp, string _UserName);

        [OperationContract]
        int? Count(string _RequestSourceIp, string _UserName);

        [OperationContract]
        System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.Services.Supplier.DataContracts.SupplierDTO> GetAll(int? _pageSize, int? _pageIndex, string _RequestSourceIp, string _UserName);

        [OperationContract]
        void Save(DSS5_SupplyChainFinancialsOptimisation.Services.Supplier.DataContracts.SupplierDTO supplier, string _RequestSourceIp, string _UserName);

        [OperationContract]
        void Delete(string userName, string _RequestSourceIp, string _UserName);

        [OperationContract]
        System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.Services.Supplier.DataContracts.SupplierDTO> Find(string _usern, string _RequestSourceIp, string _UserName);

        [OperationContract]
        bool IsSupplier(string _username, string _RequestSourceIp, string _UserName);

        [OperationContract]
        bool IsInRole(string _name, System.Collections.Generic.List<string> _roles, string _RequestSourceIp, string _UserName);


    }
}