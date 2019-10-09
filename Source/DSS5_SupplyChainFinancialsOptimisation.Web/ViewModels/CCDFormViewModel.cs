// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.CCDForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm
{
    public class CCDFormViewModel : MasterPageViewModel
    {
        public DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation CustomsClearingDocumentation;


        public CCDFormViewModel()
        {
            CustomsClearingDocumentation = new DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(CustomsClearingDocumentation))
            {
                manager.Session.Evict(CustomsClearingDocumentation);
            }
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel))]
    public class CCDFormViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel>
    {

        [JsonConstructor]
        public CCDFormViewModelDTO() { }
        public CCDFormViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            CustomsClearingDocumentation = original.CustomsClearingDocumentation == null ? null : new CustomsClearingDocumentation_CustomsClearingDocumentationDTO(original.CustomsClearingDocumentation);
        }
        public CustomsClearingDocumentation_CustomsClearingDocumentationDTO CustomsClearingDocumentation;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel).FullName;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.CCDForm.CCDFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.CustomsClearingDocumentation = CustomsClearingDocumentation == null
                                                    ? null
                                                    : CustomsClearingDocumentation.Convert();
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation))]
    public class CustomsClearingDocumentation_CustomsClearingDocumentationDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation>
    {

        [JsonConstructor]
        public CustomsClearingDocumentation_CustomsClearingDocumentationDTO() { }
        public CustomsClearingDocumentation_CustomsClearingDocumentationDTO(DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            BuyerName = original.BuyerName;
            CustomsClearingDate = original.CustomsClearingDate;
            ExportingCountry = original.ExportingCountry;
            Id = original.Id;
            ImportingCountry = original.ImportingCountry;
            Transaction = original.Transaction == null ? null : new CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO(original.Transaction);
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string BuyerName;
        public DateTime? CustomsClearingDate;
        public string ExportingCountry;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string ImportingCountry;
        public CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO Transaction;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation original)
        {
            if (original == null) return;
            original.BuyerName = BuyerName;
            original.CustomsClearingDate = CustomsClearingDate;
            original.ExportingCountry = ExportingCountry;
            original.Id = Id ?? 0;
            original.ImportingCountry = ImportingCountry;
            original.Transaction = Transaction == null
                                   ? null
                                   : Transaction.Convert();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static CustomsClearingDocumentation_CustomsClearingDocumentationDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CustomsClearingDocumentation>(parsedKey, true);
            if(foundEntry != null)
            {
                return new CustomsClearingDocumentation_CustomsClearingDocumentationDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    public class CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
    {

        [JsonConstructor]
        public CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO() { }
        public CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            FundedAmount = original.FundedAmount;
            Id = original.Id;
            TransactionDateOccured = original.TransactionDateOccured;
            TransactionValue = original.TransactionValue;
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
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, true);
            if(foundEntry != null)
            {
                return new CustomsClearingDocumentation_CustomsClearingDocumentation_Transaction_TransactionDTO(foundEntry);
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
                    var controller = new CCDFormController();
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

    #endregion

}
