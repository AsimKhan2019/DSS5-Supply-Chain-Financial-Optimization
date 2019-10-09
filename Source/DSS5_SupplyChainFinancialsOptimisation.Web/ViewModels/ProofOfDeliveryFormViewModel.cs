// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.ProofOfDeliveryForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm
{
    public class ProofOfDeliveryFormViewModel : MasterPageViewModel
    {
        public DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery ProofOfDelivery;
        public bool IsSupplier;
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>> SelectOrderSelectedItems;
        public List<SelectedItemInfo<string>> DropdownBoxSelectedItems;
        public List<SelectedItemInfo<string>> DropdownBox1SelectedItems;
        public List<SelectedItemInfo<string>> DropdownBox2SelectedItems;


        public ProofOfDeliveryFormViewModel()
        {
            ProofOfDelivery = new DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(ProofOfDelivery))
            {
                manager.Session.Evict(ProofOfDelivery);
            }
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel))]
    public class ProofOfDeliveryFormViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel>
    {

        [JsonConstructor]
        public ProofOfDeliveryFormViewModelDTO() { }
        public ProofOfDeliveryFormViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ProofOfDelivery = original.ProofOfDelivery == null ? null : new ProofOfDelivery_ProofOfDeliveryDTO(original.ProofOfDelivery);
            IsSupplier = original.IsSupplier;
            SelectOrderSelectedItemKeys = original.SelectOrderSelectedItems == null
                                          ? null
                                          : original.SelectOrderSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            DropdownBoxSelectedItemKeys = original.DropdownBoxSelectedItems == null
                                          ? null
                                          : original.DropdownBoxSelectedItems.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            DropdownBox1SelectedItemKeys = original.DropdownBox1SelectedItems == null
                                           ? null
                                           : original.DropdownBox1SelectedItems.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            DropdownBox2SelectedItemKeys = original.DropdownBox2SelectedItems == null
                                           ? null
                                           : original.DropdownBox2SelectedItems.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public ProofOfDelivery_ProofOfDeliveryDTO ProofOfDelivery;
        public bool IsSupplier;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel).FullName;
        public List<SelectedItemInfo<int?>> SelectOrderSelectedItemKeys;
        public List<SelectedItemInfo<string>> DropdownBoxSelectedItemKeys;
        public List<SelectedItemInfo<string>> DropdownBox1SelectedItemKeys;
        public List<SelectedItemInfo<string>> DropdownBox2SelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.ProofOfDeliveryForm.ProofOfDeliveryFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ProofOfDelivery = ProofOfDelivery == null
                                       ? null
                                       : ProofOfDelivery.Convert();
            original.IsSupplier = IsSupplier;
            original.SelectOrderSelectedItems = SelectOrderSelectedItemKeys == null
                                                ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>>()
                                                : SelectOrderSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(x.SelectedItems.Select(y => ViewModels.ProofOfDeliveryForm.SelectOrder_OrderDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.DropdownBoxSelectedItems = DropdownBoxSelectedItemKeys == null
                                                ? new List<SelectedItemInfo<string>>()
                                                : DropdownBoxSelectedItemKeys.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.DropdownBox1SelectedItems = DropdownBox1SelectedItemKeys == null
                                                 ? new List<SelectedItemInfo<string>>()
                                                 : DropdownBox1SelectedItemKeys.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.DropdownBox2SelectedItems = DropdownBox2SelectedItemKeys == null
                                                 ? new List<SelectedItemInfo<string>>()
                                                 : DropdownBox2SelectedItemKeys.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery))]
    public class ProofOfDelivery_ProofOfDeliveryDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery>
    {

        [JsonConstructor]
        public ProofOfDelivery_ProofOfDeliveryDTO() { }
        public ProofOfDelivery_ProofOfDeliveryDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Comments = original.Comments;
            DateIssued = original.DateIssued;
            DeliveryStatus = original.DeliveryStatus;
            Id = original.Id;
            PODAttachment = original.PODAttachment;
            PODNumber = original.PODNumber;
            QualityStatus = original.QualityStatus;
            QuantityStatus = original.QuantityStatus;
            Orders = original.Orders?.Select(x => new ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO(x)).ToList();
            Transaction = original.Transaction == null ? null : new ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO(original.Transaction);
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string Comments;
        public DateTime? DateIssued;
        public string DeliveryStatus;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string PODAttachment;
        public string PODNumber;
        public string QualityStatus;
        public string QuantityStatus;
        public List<ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO> Orders;
        public ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO Transaction;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery original)
        {
            if (original == null) return;
            original.Comments = Comments;
            original.DateIssued = DateIssued;
            original.DeliveryStatus = DeliveryStatus;
            original.Id = Id ?? 0;
            original.PODAttachment = PODAttachment;
            original.PODNumber = PODNumber;
            original.QualityStatus = QualityStatus;
            original.QuantityStatus = QuantityStatus;
            original.Orders = Orders == null
                              ? null
                              : Orders.Select(q => q.Convert()).ToList();
            original.Transaction = Transaction == null
                                   ? null
                                   : Transaction.Convert();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ProofOfDelivery_ProofOfDeliveryDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ProofOfDelivery>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ProofOfDelivery_ProofOfDeliveryDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order))]
    public class ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Order>
    {

        [JsonConstructor]
        public ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO() { }
        public ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            DateOfOrder = original.DateOfOrder;
            DeliveryTo = original.DeliveryTo;
            EstimatedDateOfDelivery = original.EstimatedDateOfDelivery;
            From = original.From;
            Id = original.Id;
            IntermediateParty = original.IntermediateParty;
            IsCancelled = original.IsCancelled;
            OrderAmount = original.OrderAmount;
            OrderAttachment = original.OrderAttachment;
            OrderNumber = original.OrderNumber;
            PaymentTerms = original.PaymentTerms;
            Status = original.Status;
            TotalPrice = original.TotalPrice;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public DateTime? DateOfOrder;
        public string DeliveryTo;
        public DateTime? EstimatedDateOfDelivery;
        public string From;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IntermediateParty;
        public bool IsCancelled;
        public decimal? OrderAmount;
        public string OrderAttachment;
        public string OrderNumber;
        public string PaymentTerms;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Status? Status;
        public decimal? TotalPrice;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.Order original)
        {
            if (original == null) return;
            original.DateOfOrder = DateOfOrder;
            original.DeliveryTo = DeliveryTo;
            original.EstimatedDateOfDelivery = EstimatedDateOfDelivery;
            original.From = From;
            original.Id = Id ?? 0;
            original.IntermediateParty = IntermediateParty;
            original.IsCancelled = IsCancelled;
            original.OrderAmount = OrderAmount;
            original.OrderAttachment = OrderAttachment;
            original.OrderNumber = OrderNumber;
            original.PaymentTerms = PaymentTerms;
            original.Status = Status;
            original.TotalPrice = TotalPrice;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ProofOfDelivery_ProofOfDelivery_Orders_OrderDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    public class ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
    {

        [JsonConstructor]
        public ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO() { }
        public ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            FundedAmount = original.FundedAmount;
            Id = original.Id;
            TransactionDateOccured = original.TransactionDateOccured;
            TransactionValue = original.TransactionValue;
            CommercialAgreement = original.CommercialAgreement == null ? null : new ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO(original.CommercialAgreement);
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public decimal? FundedAmount;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public DateTime? TransactionDateOccured;
        public decimal? TransactionValue;
        public ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO CommercialAgreement;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Transaction GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.Transaction();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Transaction Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.Transaction();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original)
        {
            if (original == null) return;
            original.FundedAmount = FundedAmount;
            original.Id = Id ?? 0;
            original.TransactionDateOccured = TransactionDateOccured;
            original.TransactionValue = TransactionValue;
            original.CommercialAgreement = CommercialAgreement == null
                                           ? null
                                           : CommercialAgreement.Convert();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ProofOfDelivery_ProofOfDelivery_Transaction_TransactionDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement))]
    public class ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>
    {

        [JsonConstructor]
        public ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO() { }
        public ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Id = original.Id;
            PaymentTerms = original.PaymentTerms;
            ProductCategory = original.ProductCategory;
            ImportedBuyer = original.ImportedBuyer == null ? null : new ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO(original.ImportedBuyer);
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string PaymentTerms;
        public string ProductCategory;
        public ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO ImportedBuyer;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement original)
        {
            if (original == null) return;
            original.Id = Id ?? 0;
            original.PaymentTerms = PaymentTerms;
            original.ProductCategory = ProductCategory;
            original.ImportedBuyer = ImportedBuyer == null
                                     ? null
                                     : ImportedBuyer.Convert();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer))]
    public class ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>
    {

        [JsonConstructor]
        public ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO() { }
        public ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            AddressOne = original.AddressOne;
            AddressTwo = original.AddressTwo;
            Code = original.Code;
            Company = original.Company;
            Id = original.Id;
            Phone = original.Phone;
            VATNumber = original.VATNumber;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string AddressOne;
        public string AddressTwo;
        public string Code;
        public string Company;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Phone;
        public string VATNumber;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original)
        {
            if (original == null) return;
            original.AddressOne = AddressOne;
            original.AddressTwo = AddressTwo;
            original.Code = Code;
            original.Company = Company;
            original.Id = Id ?? 0;
            original.Phone = Phone;
            original.VATNumber = VATNumber;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ProofOfDelivery_ProofOfDelivery_Transaction_Transaction_CommercialAgreement_CommercialAgreement_ImportedBuyer_ImportedBuyerDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs



    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order))]
    [DataSetDTO]
    public class SelectOrder_OrderDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Order>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string OrderNumber;


        [JsonConstructor]
        public SelectOrder_OrderDTO() : base() {}
        public  static SelectOrder_OrderDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new ProofOfDeliveryFormController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new SelectOrder_OrderDTO(foundEntry);
            }
            return null;
        }
        public SelectOrder_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public SelectOrder_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            OrderNumber = original.OrderNumber;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.Order GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.OrderNumber = OrderNumber;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
