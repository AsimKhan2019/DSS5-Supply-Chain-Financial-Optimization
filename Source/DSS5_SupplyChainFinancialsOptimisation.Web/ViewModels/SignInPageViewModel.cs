// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.SignInPage;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage
{
    public class SignInPageViewModel : MasterPageViewModel
    {
        public string PasswordTextBox;
        public string UserNameTextBox;
        public bool RememberMeCB;
        public bool ShowConfirmEmail;


        public SignInPageViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel))]
    public class SignInPageViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel>
    {

        [JsonConstructor]
        public SignInPageViewModelDTO() { }
        public SignInPageViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            PasswordTextBox = original.PasswordTextBox;
            UserNameTextBox = original.UserNameTextBox;
            RememberMeCB = original.RememberMeCB;
            ShowConfirmEmail = original.ShowConfirmEmail;
        }
        public string PasswordTextBox;
        public string UserNameTextBox;
        public bool RememberMeCB;
        public bool ShowConfirmEmail;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel).FullName;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignInPage.SignInPageViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.PasswordTextBox = PasswordTextBox;
            original.UserNameTextBox = UserNameTextBox;
            original.RememberMeCB = RememberMeCB;
            original.ShowConfirmEmail = ShowConfirmEmail;
        }
    }



}
