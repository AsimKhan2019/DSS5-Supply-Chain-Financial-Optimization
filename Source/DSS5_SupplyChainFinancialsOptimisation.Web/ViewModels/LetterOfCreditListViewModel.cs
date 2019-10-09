// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.LetterOfCreditList;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForLists;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList
{
    public class LetterOfCreditListViewModel : MasterPageForListsViewModel
    {
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>> LetterOfCreditListNoDTSelectedItems;


        public LetterOfCreditListViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel))]
    public class LetterOfCreditListViewModelDTO : MasterPageForListsViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel>
    {

        [JsonConstructor]
        public LetterOfCreditListViewModelDTO() { }
        public LetterOfCreditListViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            LetterOfCreditListNoDTSelectedItemKeys = original.LetterOfCreditListNoDTSelectedItems == null
                    ? null
                    : original.LetterOfCreditListNoDTSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel).FullName;
        public List<SelectedItemInfo<int?>> LetterOfCreditListNoDTSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.LetterOfCreditList.LetterOfCreditListViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.LetterOfCreditListNoDTSelectedItems = LetterOfCreditListNoDTSelectedItemKeys == null
                    ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>>()
                    : LetterOfCreditListNoDTSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(x.SelectedItems.Select(y => ViewModels.LetterOfCreditList.LetterOfCredit_LetterOfCreditDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit))]
    [DataSetDTO]
    public class LetterOfCredit_LetterOfCreditDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public decimal? ValueOfLoC;
        public DateTime? DateOfValidity;
        public DateTime? DateOfExpiry;
        public decimal? Calculated;


        [JsonConstructor]
        public LetterOfCredit_LetterOfCreditDTO() : base() {}
        public  static LetterOfCredit_LetterOfCreditDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new LetterOfCreditListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new LetterOfCredit_LetterOfCreditDTO(foundEntry);
            }
            return null;
        }
        public LetterOfCredit_LetterOfCreditDTO(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public LetterOfCredit_LetterOfCreditDTO(DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit original)
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
            ValueOfLoC = original.ValueOfLoC;
            DateOfValidity = original.DateOfValidity;
            DateOfExpiry = original.DateOfExpiry;
            Calculated = original.Calculated;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.LetterOfCredit>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.ValueOfLoC = ValueOfLoC;
            model.DateOfValidity = DateOfValidity;
            model.DateOfExpiry = DateOfExpiry;
            model.Calculated = Calculated;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
