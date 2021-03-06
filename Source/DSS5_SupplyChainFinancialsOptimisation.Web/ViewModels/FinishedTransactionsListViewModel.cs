// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.FinishedTransactionsList;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForLists;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList
{
    public class FinishedTransactionsListViewModel : MasterPageForListsViewModel
    {
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>> TransactionListNoDTSelectedItems;


        public FinishedTransactionsListViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel))]
    public class FinishedTransactionsListViewModelDTO : MasterPageForListsViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel>
    {

        [JsonConstructor]
        public FinishedTransactionsListViewModelDTO() { }
        public FinishedTransactionsListViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            TransactionListNoDTSelectedItemKeys = original.TransactionListNoDTSelectedItems == null
                                                  ? null
                                                  : original.TransactionListNoDTSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel).FullName;
        public List<SelectedItemInfo<int?>> TransactionListNoDTSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.FinishedTransactionsList.FinishedTransactionsListViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.TransactionListNoDTSelectedItems = TransactionListNoDTSelectedItemKeys == null
                    ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>>()
                    : TransactionListNoDTSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(x.SelectedItems.Select(y => ViewModels.FinishedTransactionsList.TransactionDataSet_TransactionDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    [DataSetDTO]
    public class TransactionDataSet_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
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
        public TransactionDataSet_SupplierDTO Supplier;
        public TransactionDataSet_ImportedBuyerDTO ImportedBuyer;
        public DateTime? TransactionDateOccured;
        public decimal? TransactionValue;
        public decimal? FundedAmount;
        public string PaymentStatus;
        public DateTime? PaymentDate;


        [JsonConstructor]
        public TransactionDataSet_TransactionDTO() : base() {}
        public  static TransactionDataSet_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new FinishedTransactionsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TransactionDataSet_TransactionDTO(foundEntry);
            }
            return null;
        }
        public TransactionDataSet_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public TransactionDataSet_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original)
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
            Supplier = original.Supplier == null
                       ? null
                       : DTOHelper.GetDTOFromModel<TransactionDataSet_SupplierDTO>(original.Supplier as DSS5_SupplyChainFinancialsOptimisation.BO.Supplier);
            ImportedBuyer = original.ImportedBuyer == null
                            ? null
                            : DTOHelper.GetDTOFromModel<TransactionDataSet_ImportedBuyerDTO>(original.ImportedBuyer as DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer);
            TransactionDateOccured = original.TransactionDateOccured;
            TransactionValue = original.TransactionValue;
            FundedAmount = original.FundedAmount;
            PaymentStatus = original.PaymentStatus;
            PaymentDate = original.PaymentDate;
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
            model.Supplier = Supplier == null
                             ? null
                             : DTOHelper.GetModelFromDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(Supplier);
            model.ImportedBuyer = ImportedBuyer == null
                                  ? null
                                  : DTOHelper.GetModelFromDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(ImportedBuyer);
            model.TransactionDateOccured = TransactionDateOccured;
            model.TransactionValue = TransactionValue;
            model.FundedAmount = FundedAmount;
            model.PaymentStatus = PaymentStatus;
            model.PaymentDate = PaymentDate;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier))]
    [DataSetDTO]
    public class TransactionDataSet_SupplierDTO : TransactionDataSet_ApplicationUserDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier).FullName;
        public new string _runtimeType;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }
        public string Company;


        [JsonConstructor]
        public TransactionDataSet_SupplierDTO() : base() {}
        public new static TransactionDataSet_SupplierDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new FinishedTransactionsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TransactionDataSet_SupplierDTO(foundEntry);
            }
            return null;
        }
        public TransactionDataSet_SupplierDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public TransactionDataSet_SupplierDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.UserName == "") ? original._GetUniqueIdentifier() as object : original.UserName as object;
            _runtimeType = original?.GetType().FullName;
            UserName = original.UserName;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            Company = original.Company;
        }

        public new static DSS5_SupplyChainFinancialsOptimisation.BO.Supplier GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false);
        }
        public new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.UserName = UserName ?? "";
            model.Company = Company;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser))]
    [DataSetDTO]
    public class TransactionDataSet_ApplicationUserDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public TransactionDataSet_ApplicationUserDTO() : base() {}
        public  static TransactionDataSet_ApplicationUserDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new FinishedTransactionsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TransactionDataSet_ApplicationUserDTO(foundEntry);
            }
            return null;
        }
        public TransactionDataSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public TransactionDataSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.UserName == "") ? original._GetUniqueIdentifier() as object : original.UserName as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            UserName = original.UserName;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationUser GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.UserName = UserName ?? "";
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer))]
    [DataSetDTO]
    public class TransactionDataSet_ImportedBuyerDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Company;


        [JsonConstructor]
        public TransactionDataSet_ImportedBuyerDTO() : base() {}
        public  static TransactionDataSet_ImportedBuyerDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new FinishedTransactionsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TransactionDataSet_ImportedBuyerDTO(foundEntry);
            }
            return null;
        }
        public TransactionDataSet_ImportedBuyerDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public TransactionDataSet_ImportedBuyerDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original)
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
            Company = original.Company;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Company = Company;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    #endregion

}
