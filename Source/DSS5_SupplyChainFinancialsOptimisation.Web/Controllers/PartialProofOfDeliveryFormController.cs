// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.PartialProofOfDeliveryForm;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.PartialProofOfDeliveryForm
{

    [RoutePrefix("PartialProofOfDeliveryForm")]
    public class PartialProofOfDeliveryFormController : ControllerBase<PartialProofOfDeliveryFormViewModel, PartialProofOfDeliveryFormViewModelDTO>
    {

        /*<Form:PartialProofOfDeliveryForm:0/>*/
        public PartialProofOfDeliveryFormController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(PartialProofOfDeliveryFormController));
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

        public void SetModel(PartialProofOfDeliveryFormViewModel m)
        {
            @model = m;
        }


        public override void CommitAllFiles()
        {
            FileHelper.PendingUploadInstance.CommitAllFilesNew("PartialProofOfDeliveryForm", @model);
        }

        public override void CommitAllFilesLegacy()
        {
            FileHelper.PendingUploadInstance.CommitAllLegacy("PartialProofOfDeliveryForm", @model);
        }

        public override void ClearPendingFiles()
        {
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
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
            return PrepareUpdateInstanceResult(typeof(PartialProofOfDeliveryFormViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }

        [HttpGet]
        [Route("DownloadFile")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFile(string id)
        {
            return FileHelper.PendingDownloadInstance.DownloadByKey("PartialProofOfDeliveryForm", id);
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
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="AddPartialProofOfDelivery", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("AddPartialProofOfDelivery")]
        public ActionResult AddPartialProofOfDelivery()

        {
            @model = new PartialProofOfDeliveryFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PartialProofOfDeliveryForm"] = "AddPartialProofOfDelivery";
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
            FileHelper.PendingDownloadInstance.Clear("PartialProofOfDeliveryForm");
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="AddPartialProofOfDelivery", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_AddPartialProofOfDelivery")]
        public ActionResult _API_AddPartialProofOfDelivery()

        {
            @model = new PartialProofOfDeliveryFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PartialProofOfDeliveryForm"] = "AddPartialProofOfDelivery";
            PushToHistory();
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
            FileHelper.PendingDownloadInstance.Clear("PartialProofOfDeliveryForm");
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteAddPartialProofOfDelivery();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="EditPartialProofOfDelivery", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("EditPartialProofOfDelivery/{*id:int?}")]
        public ActionResult EditPartialProofOfDelivery(int? id)

        {
            @model = new PartialProofOfDeliveryFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PartialProofOfDeliveryForm"] = "EditPartialProofOfDelivery";
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
            FileHelper.PendingDownloadInstance.Clear("PartialProofOfDeliveryForm");
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="EditPartialProofOfDelivery", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_EditPartialProofOfDelivery/{*id:int?}")]
        public ActionResult _API_EditPartialProofOfDelivery(int? id)

        {
            @model = new PartialProofOfDeliveryFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PartialProofOfDeliveryForm"] = "EditPartialProofOfDelivery";
            PushToHistory();
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
            FileHelper.PendingDownloadInstance.Clear("PartialProofOfDeliveryForm");
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteEditPartialProofOfDelivery(id);
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="SavePartialProofOfDelivery", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SavePartialProofOfDelivery")]
        public ActionResult SavePartialProofOfDelivery()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            FileHelper.PendingUploadInstance.UpdateModelWithFilesBinaryData("PartialProofOfDeliveryForm", @model);
            var redirectInfo = ExecuteSavePartialProofOfDelivery();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, ActionName="DeletePartialProofOfDelivery", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("DeletePartialProofOfDelivery")]
        public ActionResult DeletePartialProofOfDelivery()

        {
            var _data = _LoadViewModel();
            FileHelper.PendingUploadInstance.UpdateModelWithFilesBinaryData("PartialProofOfDeliveryForm", @model);
            var redirectInfo = ExecuteDeletePartialProofOfDelivery();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, HasDefaultResultView=true, ActionName="NewPPOD", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("NewPPOD/{*transactionId:int?}")]
        public ActionResult NewPPOD(int? transactionId)

        {
            @model = new PartialProofOfDeliveryFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PartialProofOfDeliveryForm"] = "NewPPOD";
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
            FileHelper.PendingDownloadInstance.Clear("PartialProofOfDeliveryForm");
            return null;
        }

        [CustomControllerActionFilter(LogEnabled=true, FillDropDownInitialValues=true, ActionName="NewPPOD", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_NewPPOD/{*transactionId:int?}")]
        public ActionResult _API_NewPPOD(int? transactionId)

        {
            @model = new PartialProofOfDeliveryFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_PartialProofOfDeliveryForm"] = "NewPPOD";
            PushToHistory();
            FileHelper.PendingUploadInstance.Clear("PartialProofOfDeliveryForm");
            FileHelper.PendingDownloadInstance.Clear("PartialProofOfDeliveryForm");
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteNewPPOD(transactionId);
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:AddPartialProofOfDelivery:1/>*/
        public ActionResult ExecuteAddPartialProofOfDelivery()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:EditPartialProofOfDelivery:1/>*/
        public ActionResult ExecuteEditPartialProofOfDelivery(int? id)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.PartialProofOfDelivery =  new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.PartialProofOfDelivery>(id);
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:SavePartialProofOfDelivery:1/>*/
        public ActionResult ExecuteSavePartialProofOfDelivery()
        {
            ActionResult _result = null;
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<DSS5_SupplyChainFinancialsOptimisation.BO.PartialProofOfDelivery>(@model.PartialProofOfDelivery);
            @model.Title = "";
            _result = CloseForm();
            return _result;
        }
        /*<ControllerActionImplementation:DeletePartialProofOfDelivery:1/>*/
        public ActionResult ExecuteDeletePartialProofOfDelivery()
        {
            ActionResult _result = null;
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().DeletePartialProofOfDelivery(@model.PartialProofOfDelivery);
            @model.Title = "";
            _result = CloseForm();
            return _result;
        }
        /*<ControllerActionImplementation:NewPPOD:1/>*/
        public ActionResult ExecuteNewPPOD(int? transactionId)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.PartialProofOfDelivery.Transaction =  new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(transactionId);
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:txtQualityStatus2:1/>*/

        /*<Datasource:txtQuantityStatus3:1/>*/

        /*<Datasource:txtDeliveryStatus4:1/>*/

        #endregion

        #region File Attachment controls

        private Func<object, int[], string> Get_txtPODAttachment5_RelativePath
        {
            get
            {
                return (object _model, int[] indexes) =>
                {
                    var @model = _model as PartialProofOfDeliveryFormViewModel;
                    return  Path.GetFileName(@model.PartialProofOfDelivery.PODAttachment);
                };
            }
        }

        [HttpPost]
        [Route("txtPODAttachment5_Download")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult txtPODAttachment5_Download()
        {
            var postedData = _LoadViewModel();
            var indexes = postedData["indexes"] == null
                          ? null
                          : postedData["indexes"].ToString()
                          .Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
            var key = "";
            var pending = FileHelper.PendingUploadInstance.Get("PartialProofOfDeliveryForm", "txtPODAttachment5", indexes);
            if (pending == null)
            {
                try
                {
                    key = FileHelper.PendingDownloadInstance.Add("PartialProofOfDeliveryForm", Get_txtPODAttachment5_RelativePath, @model, indexes);
                }
                catch (Exception x)
                {
                    _logger.Error($"Download failed. Possibly file not found. Control 'txtPODAttachment5'", x);
                    return Content(null);
                }
            }
            else
            {
                var relativeTargetPath = Get_txtPODAttachment5_RelativePath.Invoke(@model, indexes);
                var fileName = Path.GetFileName(relativeTargetPath);
                key = FileHelper.PendingDownloadInstance.Add("PartialProofOfDeliveryForm", pending.BinaryContents, fileName);
            }
            return Content(key);
        }

        [HttpPost]
        [Route("txtPODAttachment5_Upload")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult txtPODAttachment5_Upload()
        {
            var postedData = _LoadViewModel();
            var indexes = postedData["indexes"] == null
                          ? null
                          : postedData["indexes"].ToString()
                          .Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
            var __pendingFile = ExecutetxtPODAttachment5_Upload(indexes, HttpContext.Request.Files);
            var _result = Json(new
            {
                Legacy = true,
                Type = "FileUpload" ,

                Data = new
                {
                    FileName = @model.PartialProofOfDelivery.PODAttachment
                }

            }, JsonRequestBehavior.AllowGet);
            _result.MaxJsonLength = int.MaxValue;
            return _result;
        }

        public FileHelper.UploadInfo ExecutetxtPODAttachment5_Upload(int[] indexes, HttpFileCollectionBase files)
        {
            var file = files[0];
            var pendingFile = new FileHelper.UploadInfo(file, "PartialProofOfDeliveryForm", "txtPODAttachment5", indexes);
            pendingFile.GetRelativePath = Get_txtPODAttachment5_RelativePath;
            @model.PartialProofOfDelivery.PODAttachment = FileHelper.GetUtf8SafeFilename(file.FileName);
            IsDirty = true;
            FileHelper.PendingUploadInstance.Add(pendingFile);
            return pendingFile;
        }

        [HttpPost]
        [Route("txtPODAttachment5_Remove")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult txtPODAttachment5_Remove()
        {
            var postedData = _LoadViewModel();
            var removedAutomatically = postedData["removedAutomatically"]?.ToString() == true.ToString();
            var indexes = postedData["indexes"] == null
                          ? null
                          : postedData["indexes"].ToString()
                          .Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
            var pending = FileHelper.PendingUploadInstance.Get("PartialProofOfDeliveryForm", "txtPODAttachment5", indexes);
            if (pending != null)
            {
                try
                {
                    FileHelper.PendingUploadInstance.RemoveByKey("PartialProofOfDeliveryForm", "txtPODAttachment5", indexes);
                }
                catch (Exception x)
                {
                    _logger.Error($"Removing uploaded file failed. Possibly file not found. Control 'txtPODAttachment5'", x);
                    return Content(null);
                }
            }
            if (removedAutomatically) return Content(null); // Usually removed when user deletes grid row. No need to update model
            @model.PartialProofOfDelivery.PODAttachment = null;
            IsDirty = true;
            viewDTO.Model = new PartialProofOfDeliveryFormViewModelDTO(@model);
            var _result = Json(new
            {
                Type = "Data",
                Data = viewDTO.Serialize()
            }, JsonRequestBehavior.AllowGet);
            _result.MaxJsonLength = int.MaxValue;
            return _result;
        }
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
                var _modelDTO = new PartialProofOfDeliveryFormViewModelDTO(@model);
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
            return View("PartialProofOfDeliveryForm");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: PartialProofOfDeliveryForm, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
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
