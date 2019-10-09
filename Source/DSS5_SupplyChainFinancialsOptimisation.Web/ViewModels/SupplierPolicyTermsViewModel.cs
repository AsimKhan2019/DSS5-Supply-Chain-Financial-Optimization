// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.SupplierPolicyTerms;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForSlide;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForSlide;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms
{
    public class SupplierPolicyTermsViewModel : MasterPageForSlideViewModel
    {


        public SupplierPolicyTermsViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel))]
    public class SupplierPolicyTermsViewModelDTO : MasterPageForSlideViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel>
    {

        [JsonConstructor]
        public SupplierPolicyTermsViewModelDTO() { }
        public SupplierPolicyTermsViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel).FullName;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SupplierPolicyTerms.SupplierPolicyTermsViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
        }
    }



}
