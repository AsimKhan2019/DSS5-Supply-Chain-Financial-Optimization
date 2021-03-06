// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.EmailConfirmationFailure;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure
{
    public class EmailConfirmationFailureViewModel : MasterPageViewModel
    {


        public EmailConfirmationFailureViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel))]
    public class EmailConfirmationFailureViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel>
    {

        [JsonConstructor]
        public EmailConfirmationFailureViewModelDTO() { }
        public EmailConfirmationFailureViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel).FullName;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.EmailConfirmationFailure.EmailConfirmationFailureViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
        }
    }



}
