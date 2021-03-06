// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.TurnoverPerMonthForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm
{
    public class TurnoverPerMonthFormViewModel : MasterPageViewModel
    {
        public int? Year;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Supplier Supplier;
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>> ChartSelectedItems;


        public TurnoverPerMonthFormViewModel()
        {
            Supplier = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(Supplier))
            {
                manager.Session.Evict(Supplier);
            }
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel))]
    public class TurnoverPerMonthFormViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel>
    {

        [JsonConstructor]
        public TurnoverPerMonthFormViewModelDTO() { }
        public TurnoverPerMonthFormViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            Year = original.Year;
            Supplier = original.Supplier == null ? null : new Supplier_SupplierDTO(original.Supplier);
            ChartSelectedItemKeys = original.ChartSelectedItems == null
                                    ? null
                                    : original.ChartSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public int? Year;
        public Supplier_SupplierDTO Supplier;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel).FullName;
        public List<SelectedItemInfo<int?>> ChartSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverPerMonthForm.TurnoverPerMonthFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.Year = Year;
            original.Supplier = Supplier == null
                                ? null
                                : Supplier.Convert();
            original.ChartSelectedItems = ChartSelectedItemKeys == null
                                          ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>>()
                                          : ChartSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>(x.SelectedItems.Select(y => ViewModels.TurnoverPerMonthForm.TurnoverStatisticDataSet_TurnoverStatisticDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier))]
    public class Supplier_SupplierDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>
    {

        [JsonConstructor]
        public Supplier_SupplierDTO() { }
        public Supplier_SupplierDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.UserName as object;
            Company = original.Company;
            UserName = original.UserName;
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public string Company;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier).FullName;
        public override List<string> _baseClasses => new List<string> {typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser).FullName};
        public DSS5_SupplyChainFinancialsOptimisation.BO.Supplier GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            if (parsedKey == default(string) || Equals(parsedKey, default(string)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Supplier Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier original)
        {
            if (original == null) return;
            original.Company = Company;
            original.UserName = UserName ?? "";
        }
        public static Supplier_SupplierDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, true);
            if(foundEntry != null)
            {
                return new Supplier_SupplierDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic))]
    [DataSetDTO]
    public class TurnoverStatisticDataSet_TurnoverStatisticDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public int? Month;
        public decimal? TotalAmount;
        public decimal? TotalAmountFunded;


        [JsonConstructor]
        public TurnoverStatisticDataSet_TurnoverStatisticDTO() : base() {}
        public  static TurnoverStatisticDataSet_TurnoverStatisticDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new TurnoverPerMonthFormController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TurnoverStatisticDataSet_TurnoverStatisticDTO(foundEntry);
            }
            return null;
        }
        public TurnoverStatisticDataSet_TurnoverStatisticDTO(DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public TurnoverStatisticDataSet_TurnoverStatisticDTO(DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic original)
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
            Month = original.Month;
            TotalAmount = original.TotalAmount;
            TotalAmountFunded = original.TotalAmountFunded;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Month = Month;
            model.TotalAmount = TotalAmount;
            model.TotalAmountFunded = TotalAmountFunded;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
