// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.PaymentForm;
using Identity = zAppDev.DotNet.Framework.Identity;
using log4net;
using Newtonsoft.Json;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Mvc;
using zAppDev.DotNet.Framework.Utilities;

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.PaymentForm
{

    [RoutePrefix("PaymentForm")]
    public class PaymentFormController : ControllerBase<PaymentFormViewModel, PaymentFormViewModelDTO>
    {

        /*<Form:PaymentForm:0/>*/
        public PaymentFormController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(PaymentFormController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }

        protected override void ViewModelLoaded()
        {
            var masterViewModel = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel
            {
                Title = model.Title, Version = model.Version
            };
            _parentController = new MasterPage.MasterPageController(masterViewModel);
            _parentController.IsDirty = IsDirty;
        }

        public void SetModel(PaymentFormViewModel m)
        {
            @model = m;
        }


        public override void CommitAllFiles()
        {
        }

        public override void CommitAllFilesLegacy()
        {
        }

        public override void ClearPendingFiles()
        {
        }






        [HttpGet]

        [Route("GetViewDTO")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ContentResult GetViewDTO(int hash)
        {
            return Content(GetViewFromViewDTOsDicSerialized(hash));
        }

        [HttpPost]

        [Route("UpdateInstance")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult UpdateInstance()
        {
            return PrepareUpdateInstanceResult(typeof(PaymentFormViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }


        [HttpGet]
        [Route("DownloadFileByPath")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFileByPath(string path, string defaultPath = null)
        {
            if (IdentityHelper.GetCurrentIdentityUser() == null) return null;
            if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(defaultPath))
            {
                throw new ApplicationException("Please provide a path.");
            }
            return FileHelper.PendingDownloadInstance.DownloadByPath(path, defaultPath);
        }




        #region Controller Actions
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="AddPayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("AddPayment")]
        public ActionResult AddPayment()

        {
            @model = new PaymentFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PaymentForm"] = "AddPayment";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="AddPayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_AddPayment")]
        public ActionResult _API_AddPayment()

        {
            @model = new PaymentFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PaymentForm"] = "AddPayment";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteAddPayment();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="EditPayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("EditPayment/{*id:int?}")]
        public ActionResult EditPayment(int? id)

        {
            @model = new PaymentFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PaymentForm"] = "EditPayment";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="EditPayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_EditPayment/{*id:int?}")]
        public ActionResult _API_EditPayment(int? id)

        {
            @model = new PaymentFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PaymentForm"] = "EditPayment";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteEditPayment(id);
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, ActionName="SavePayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SavePayment")]
        public ActionResult SavePayment()

        {
            var _data = _LoadViewModel();
            var redirectInfo = ExecuteSavePayment();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, ActionName="DeletePayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("DeletePayment")]
        public ActionResult DeletePayment()

        {
            var _data = _LoadViewModel();
            var redirectInfo = ExecuteDeletePayment();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="RegistrationPayment", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("RegistrationPayment")]
        public ActionResult RegistrationPayment()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteRegistrationPayment();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:AddPayment:1/>*/
        public ActionResult ExecuteAddPayment()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:EditPayment:1/>*/
        public ActionResult ExecuteEditPayment(int? id)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Payment =  new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Payment>(id);
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:SavePayment:1/>*/
        public ActionResult ExecuteSavePayment()
        {
            ActionResult _result = null;
            DSS5_SupplyChainFinancialsOptimisation.BO.Supplier supplier = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>((a) => a.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName())?.FirstOrDefault();
            supplier.Roles = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>((a) => a.Name == "PendingRegistered").ToList();
            supplier.SupplierStatus = "PendingRegistered";
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(supplier);
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<DSS5_SupplyChainFinancialsOptimisation.BO.Payment>(@model.Payment);
            @model.Title = "";
            ClientCommand(ClientCommands.SHOW_MESSAGE, "Thank you for buying registration. Please wait for Administrator's approval.", MessageType.Success, (!string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"]) ?
                          System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"] : zAppDev.DotNet.Framework.Utilities.Web.GetApplicationPathUri(false)) +
                          "/HomePage/Render");
            zAppDev.DotNet.Framework.Identity.Model.ApplicationUser administrator = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>((a) => a.UserName == "Administrator")?.FirstOrDefault();
            zAppDev.DotNet.Framework.Utilities.EMailMessage email = new zAppDev.DotNet.Framework.Utilities.EMailMessage();
            email.To = new List<string> { (administrator?.Email ?? "") } .ToList();
            email.Subject = "PAYMENTS";
            email.Body = "A payment has been placed";
            zAppDev.DotNet.Framework.Utilities.Email.SendMail(email, true);
            return _result;
        }
        /*<ControllerActionImplementation:DeletePayment:1/>*/
        public ActionResult ExecuteDeletePayment()
        {
            ActionResult _result = null;
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().DeletePayment(@model.Payment);
            @model.Title = "";
            _result = CloseForm();
            return _result;
        }
        /*<ControllerActionImplementation:RegistrationPayment:1/>*/
        public ActionResult ExecuteRegistrationPayment()
        {
            ActionResult _result = null;
            DSS5_SupplyChainFinancialsOptimisation.BO.Supplier supplier = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>((a) => a.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName())?.FirstOrDefault();
            supplier.Roles = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>((a) => a.Name == "PendingRegistered").ToList();
            supplier.SupplierStatus = "PendingRegistered";
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(supplier);
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:txtPaymentMethod0:1/>*/

        /*<Datasource:txtExpirationMonth4:1/>*/

        /*<Datasource:txtExpirationYear5:1/>*/

        #endregion

        public override ActionResult PreActionFilterHook(bool causesValidation, bool listenToEvent, string actionName)
        {
            System.Web.HttpContext.Current.Items["_currentControllerAction"] = actionName;
            if (listenToEvent) return null;
            return null;
        }
        public override ActionResult PostActionFilterHook(bool hasDefaultResultView, bool fillDropDownInitialValues = false)
        {
            if (HasClientResponse())
            {
                viewDTO.ClientResponse = GetClientResponse();
            }
            else
            {
                var _modelDTO = new PaymentFormViewModelDTO(@model);
                viewDTO.Model = _modelDTO;
            }
            if (!hasDefaultResultView)
            {
                var __result = Json(new
                {
                    Type = "Data",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            return View("PaymentForm");
        }

        #region Data Validations


        private ActionResult GetFailedDataValidationsResult()
        {
            try
            {
                RunDataValidations();
                if (!viewDTO.DataValidationsHaveFailed) return null;
                var __result = Json(new
                {
                    Type = "RuleEvaluation",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            catch (Exception e)
            {
                _logger.Error("!!! DANGER: Error while evaluating Data Validations !!!", e);
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: PaymentForm, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            var masterPageDataValidations = (_parentController as Controllers.MasterPage.MasterPageController).RunDataValidations();
            if (masterPageDataValidations?.Any() == true)
            {
                viewDTO.RuleEvaluations.DataValidations.AddRange(masterPageDataValidations);
            }
            return viewDTO.RuleEvaluations.DataValidations;
        }

        #endregion
    }
}
