// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSS5_SupplyChainFinancialsOptimisation.Services.Contact.DataContracts;

namespace DSS5_SupplyChainFinancialsOptimisation.Services
{
    [XmlSerializerFormat]
    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        DSS5_SupplyChainFinancialsOptimisation.Services.Contact.DataContracts.ContactDTO Contact(string _first_name, string _last_name, string _represents, string _company_name, string _email, string _phone, string _message, string _RequestSourceIp, string _UserName);


    }
}