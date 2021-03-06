// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.LetterOfCreditForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm
{
    public class LetterOfCreditFormViewModel : MasterPageViewModel
    {
        public DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit LetterOfCredit;
        public bool IsSupplier;
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>> PickListSelectedItems;


        public LetterOfCreditFormViewModel()
        {
            LetterOfCredit = new DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(LetterOfCredit))
            {
                manager.Session.Evict(LetterOfCredit);
            }
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel))]
    public class LetterOfCreditFormViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel>
    {

        [JsonConstructor]
        public LetterOfCreditFormViewModelDTO() { }
        public LetterOfCreditFormViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            LetterOfCredit = original.LetterOfCredit == null ? null : new LetterOfCredit_LetterOfCreditDTO(original.LetterOfCredit);
            IsSupplier = original.IsSupplier;
            PickListSelectedItemKeys = original.PickListSelectedItems == null
                                       ? null
                                       : original.PickListSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public LetterOfCredit_LetterOfCreditDTO LetterOfCredit;
        public bool IsSupplier;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel).FullName;
        public List<SelectedItemInfo<int?>> PickListSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditForm.LetterOfCreditFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.LetterOfCredit = LetterOfCredit == null
                                      ? null
                                      : LetterOfCredit.Convert();
            original.IsSupplier = IsSupplier;
            original.PickListSelectedItems = PickListSelectedItemKeys == null
                                             ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>>()
                                             : PickListSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(x.SelectedItems.Select(y => ViewModels.LetterOfCreditForm.SelectOrder_OrderDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit))]
    public class LetterOfCredit_LetterOfCreditDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>
    {

        [JsonConstructor]
        public LetterOfCredit_LetterOfCreditDTO() { }
        public LetterOfCredit_LetterOfCreditDTO(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Calculated = original.Calculated;
            DateOfExpiry = original.DateOfExpiry;
            DateOfValidity = original.DateOfValidity;
            Detail = original.Detail;
            Id = original.Id;
            IssuingBank = original.IssuingBank;
            UploadOfScan = original.UploadOfScan;
            ValueOfLoC = original.ValueOfLoC;
            Transaction = original.Transaction == null ? null : new LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO(original.Transaction);
            Orders = original.Orders?.Select(x => new LetterOfCredit_LetterOfCredit_Orders_OrderDTO(x)).ToList();
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public decimal? Calculated;
        public DateTime? DateOfExpiry;
        public DateTime? DateOfValidity;
        public string Detail;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string IssuingBank;
        public string UploadOfScan;
        public decimal? ValueOfLoC;
        public LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO Transaction;
        public List<LetterOfCredit_LetterOfCredit_Orders_OrderDTO> Orders;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit original)
        {
            if (original == null) return;
            original.Calculated = Calculated;
            original.DateOfExpiry = DateOfExpiry;
            original.DateOfValidity = DateOfValidity;
            original.Detail = Detail;
            original.Id = Id ?? 0;
            original.IssuingBank = IssuingBank;
            original.UploadOfScan = UploadOfScan;
            original.ValueOfLoC = ValueOfLoC;
            original.Transaction = Transaction == null
                                   ? null
                                   : Transaction.Convert();
            original.Orders = Orders == null
                              ? null
                              : Orders.Select(q => q.Convert()).ToList();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static LetterOfCredit_LetterOfCreditDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(parsedKey, true);
            if(foundEntry != null)
            {
                return new LetterOfCredit_LetterOfCreditDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    public class LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
    {

        [JsonConstructor]
        public LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO() { }
        public LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            FundedAmount = original.FundedAmount;
            Id = original.Id;
            TransactionDateOccured = original.TransactionDateOccured;
            TransactionValue = original.TransactionValue;
            CommercialAgreement = original.CommercialAgreement == null ? null : new LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO(original.CommercialAgreement);
            ImportedBuyer = original.ImportedBuyer == null ? null : new LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO(original.ImportedBuyer);
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
        public LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO CommercialAgreement;
        public LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO ImportedBuyer;
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
            original.ImportedBuyer = ImportedBuyer == null
                                     ? null
                                     : ImportedBuyer.Convert();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, true);
            if(foundEntry != null)
            {
                return new LetterOfCredit_LetterOfCredit_Transaction_TransactionDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement))]
    public class LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>
    {

        [JsonConstructor]
        public LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO() { }
        public LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Id = original.Id;
            PaymentTerms = original.PaymentTerms;
            ProductCategory = original.ProductCategory;
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
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(parsedKey, true);
            if(foundEntry != null)
            {
                return new LetterOfCredit_LetterOfCredit_Transaction_Transaction_CommercialAgreement_CommercialAgreementDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer))]
    public class LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>
    {

        [JsonConstructor]
        public LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO() { }
        public LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original, bool parentIsDirty = false)
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
        public static LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, true);
            if(foundEntry != null)
            {
                return new LetterOfCredit_LetterOfCredit_Transaction_Transaction_ImportedBuyer_ImportedBuyerDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order))]
    public class LetterOfCredit_LetterOfCredit_Orders_OrderDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Order>
    {

        [JsonConstructor]
        public LetterOfCredit_LetterOfCredit_Orders_OrderDTO() { }
        public LetterOfCredit_LetterOfCredit_Orders_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original, bool parentIsDirty = false)
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
        public static LetterOfCredit_LetterOfCredit_Orders_OrderDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, true);
            if(foundEntry != null)
            {
                return new LetterOfCredit_LetterOfCredit_Orders_OrderDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    [DataSetDTO]
    public class TransactionDataSource_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public TransactionDataSource_TransactionDTO() : base() {}
        public  static TransactionDataSource_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new LetterOfCreditFormController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TransactionDataSource_TransactionDTO(foundEntry);
            }
            return null;
        }
        public TransactionDataSource_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public TransactionDataSource_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original)
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
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.Transaction GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Transaction Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Transaction();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

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
                    var controller = new LetterOfCreditFormController();
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
