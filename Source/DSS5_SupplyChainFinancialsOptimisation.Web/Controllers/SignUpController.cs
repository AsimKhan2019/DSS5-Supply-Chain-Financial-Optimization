// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.SignUp
{

    [RoutePrefix("SignUp")]
    public class SignUpController : ControllerBase<SignUpViewModel, SignUpViewModelDTO>
    {

        /*<Form:SignUp:0/>*/
        public SignUpController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(SignUpController));
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

        public void SetModel(SignUpViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(SignUpViewModel));
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
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Render")]
        public ActionResult Render()

        {
            @model = new SignUpViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SignUp"] = "Render";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Render")]
        public ActionResult _API_Render()

        {
            @model = new SignUpViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SignUp"] = "Render";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRender();
            return redirectInfo;
        }

        [CustomControllerActionFilter(CausesValidation=true, ActionName="SignUp", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SignUp")]
        public ActionResult SignUp()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteSignUp();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="IntermediaryRender", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("IntermediaryRender/{*id?}")]
        public ActionResult IntermediaryRender(string id)

        {
            @model = new SignUpViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SignUp"] = "IntermediaryRender";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="IntermediaryRender", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_IntermediaryRender/{*id?}")]
        public ActionResult _API_IntermediaryRender(string id)

        {
            @model = new SignUpViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SignUp"] = "IntermediaryRender";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteIntermediaryRender(id);
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:Render:1/>*/
        public ActionResult ExecuteRender()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.IsIntermediary = false;
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:SignUp:1/>*/
        public ActionResult ExecuteSignUp()
        {
            ActionResult _result = null;
            if ((@model.PasswordTextBox != @model.RetypePass))
            {
                ClientCommand(ClientCommands.SHOW_MESSAGE, "Passwords do not match", MessageType.Warning);
                return null;
            }
            zAppDev.DotNet.Framework.Identity.Model.ApplicationUser userToRegister = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            System.Collections.Generic.List<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole> roleToAdd = new System.Collections.Generic.List<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>();
            if ((@model.ChoosenRole == null))
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "SignUp",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "User did not select a Role.");
                ClientCommand(ClientCommands.SHOW_MESSAGE, "Please choose a role you wish to sign up as.", MessageType.Warning);
                return null;
            }
            if (@model.ChoosenRole == "Supplier")
            {
                DSS5_SupplyChainFinancialsOptimisation.BO.Supplier newSupplier = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
                newSupplier.UserName = @model.UserName;
                newSupplier.Email = @model.Email;
                if ((((((newSupplier?.Email ?? "") == null ? false : CSharpVerbalExpressions.VerbalExpressions.DefaultExpression.Add(CSharpVerbalExpressions.CommonRegex.Email).Test((newSupplier?.Email ?? "")))) == false)))
                {
                    ClientCommand(ClientCommands.SHOW_MESSAGE, "Please enter a valid e-mail address", MessageType.Warning);
                    return null;
                }
                newSupplier.Company = @model.CompanyName;
                userToRegister = newSupplier;
                roleToAdd = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>((a) => a.Name == "GuestSupplier").ToList();
            }
            if (@model.ChoosenRole == "Buyer")
            {
                DSS5_SupplyChainFinancialsOptimisation.BO.Buyer newBuyer = new DSS5_SupplyChainFinancialsOptimisation.BO.Buyer();
                newBuyer.UserName = @model.UserName;
                newBuyer.Email = @model.Email;
                if ((((((newBuyer?.Email ?? "") == null ? false : CSharpVerbalExpressions.VerbalExpressions.DefaultExpression.Add(CSharpVerbalExpressions.CommonRegex.Email).Test((newBuyer?.Email ?? "")))) == false)))
                {
                    ClientCommand(ClientCommands.SHOW_MESSAGE, "Please enter a valid e-mail address", MessageType.Warning);
                    return null;
                }
                newBuyer.Company = @model.CompanyName;
                userToRegister = newBuyer;
                roleToAdd = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>((a) => a.Name == "Buyer").ToList();
            }
            if (@model.ChoosenRole == "Investor")
            {
                DSS5_SupplyChainFinancialsOptimisation.BO.Investor newInvestor = new DSS5_SupplyChainFinancialsOptimisation.BO.Investor();
                newInvestor.UserName = @model.UserName;
                newInvestor.Email = @model.Email;
                if ((((((newInvestor?.Email ?? "") == null ? false : CSharpVerbalExpressions.VerbalExpressions.DefaultExpression.Add(CSharpVerbalExpressions.CommonRegex.Email).Test((newInvestor?.Email ?? "")))) == false)))
                {
                    ClientCommand(ClientCommands.SHOW_MESSAGE, "Please enter a valid e-mail address", MessageType.Warning);
                    return null;
                }
                newInvestor.Company = @model.CompanyName;
                newInvestor.InvestorStatus = "GuestInvestor";
                userToRegister = newInvestor;
                roleToAdd = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>((a) => a.Name == "GuestInvestor").ToList();
            }
            if ((@model.ChoosenRole == "Intermediary"))
            {
                DSS5_SupplyChainFinancialsOptimisation.BO.IntermediaryUser newIntermediaryUser = new DSS5_SupplyChainFinancialsOptimisation.BO.IntermediaryUser();
                newIntermediaryUser.UserName = @model.UserName;
                newIntermediaryUser.Email = @model.Email;
                if ((((((newIntermediaryUser?.Email ?? "") == null ? false : CSharpVerbalExpressions.VerbalExpressions.DefaultExpression.Add(CSharpVerbalExpressions.CommonRegex.Email).Test((newIntermediaryUser?.Email ?? "")))) == false)))
                {
                    ClientCommand(ClientCommands.SHOW_MESSAGE, "Please enter a valid e-mail address", MessageType.Warning);
                    return null;
                }
                newIntermediaryUser.Intermediary = @model.Intermediary;
                userToRegister = newIntermediaryUser;
                roleToAdd = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>((a) => a.Name == "Intermediary").ToList();
            }
            if ((new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>((a) => a.UserName == @model.UserName)).Count() > 0)
            {
                ClientCommand(ClientCommands.SHOW_MESSAGE, "Please choose a different Username", MessageType.Warning);
                return null;
            }
            string error = zAppDev.DotNet.Framework.Identity.IdentityHelper.CreateUser(userToRegister, @model.PasswordTextBox);
            if ((((error == null || error == "")) == false))
            {
                ClientCommand(ClientCommands.SHOW_MESSAGE, error, MessageType.Warning);
                return null;
            }
            string code = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetUserManager().GenerateEmailConfirmationTokenAsync(userToRegister.UserName).Result;
            string link = (!string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"]) ?
                           System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"] : zAppDev.DotNet.Framework.Utilities.Web.GetApplicationPathUri(false)) +
                          "/EmailConfirmation/Confirm"+ "?email=" + System.Web.HttpUtility.UrlEncode((userToRegister?.Email ?? ""))+ "&code=" + System.Web.HttpUtility.UrlEncode(code);
            zAppDev.DotNet.Framework.Utilities.EMailMessage emailMessage = new zAppDev.DotNet.Framework.Utilities.EMailMessage();
            emailMessage.To = new List<string> { (userToRegister?.Email ?? "") } .ToList();
            emailMessage.Subject = "Account Activation";
            emailMessage.Body = "Please click <a href='" + link + "'>here</a> to activate your account";
            emailMessage.IsBodyHtml = true;
            zAppDev.DotNet.Framework.Utilities.Email.SendMail(emailMessage, true);
            userToRegister.Roles = roleToAdd.ToList();
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(userToRegister);
            ClientCommand(ClientCommands.SHOW_MESSAGE, "Please activate your account using the link sent to your email.", MessageType.Success, (!string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"]) ?
                          System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"] : zAppDev.DotNet.Framework.Utilities.Web.GetApplicationPathUri(false)) +
                          "/HomePage/Render");
            return _result;
        }
        /*<ControllerActionImplementation:IntermediaryRender:1/>*/
        public ActionResult ExecuteIntermediaryRender(string id)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "SignUp",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "guid " + id);
            if (((id == null || id == "")))
            {
                _result = GetRedirectInfo("ErrorPage", "Render", new  RouteValueDictionary(new {  }));
            }
            DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary intermediary = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>((i) => i.GUID == id)?.FirstOrDefault();
            if ((intermediary == null))
            {
                _result = GetRedirectInfo("ErrorPage", "Render", new  RouteValueDictionary(new {  }));
            }
            @model.Intermediary = intermediary;
            @model.CompanyName = (intermediary?.Company ?? "");
            @model.IsIntermediary = true;
            @model.ChoosenRole = "Intermediary";
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:txtChoosenRole:1/>*/

        /*<Datasource:SignUp_IntermediaryDataSet:1/>*/
        /*<DataSourceFilter:SignUp_IntermediaryDataSet:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary> Get_SignUp_IntermediaryDataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_SignUp_IntermediaryDataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary> Get_SignUp_IntermediaryDataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>().AsQueryable();
            return __items.Where(@this => true);
        }


        /*<DataSourceGetFullRecordset:SignUp_IntermediaryDataSet:1/>*/

        [HttpPost]
        [Route("SignUp_IntermediaryDataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "IntermediaryDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult SignUp_IntermediaryDataSet_GetFullRecordset()
        {
            var postedData = _ParsePostedData();
            var dataType = postedData["dataType"].ToString();
            var keysToExclude = postedData["keys"] == null
                                ? new List<object>()
                                : postedData["keys"].ToString()
                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => x as object)
                                .ToList();
            var indexes = postedData["indexes"] == null
                          ? null
                          : postedData["indexes"].ToString()
                          .Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
            var postedDatasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            _LoadViewModel();
            var datasourceRequest = new DatasourceRequest(0, 2147483647, postedDatasourceRequest.Filters, null, keysToExclude, indexes);
            var queryable = Get_SignUp_IntermediaryDataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new IntermediaryDataSet_IntermediaryDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(SignUpViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "SignUp_IntermediaryDataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:SignUp_IntermediaryDataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "IntermediaryDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("SignUp_IntermediaryDataSet_Datasource")]
        public JsonResult SignUp_IntermediaryDataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_SignUp_IntermediaryDataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_SignUp_IntermediaryDataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_SignUp_IntermediaryDataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_SignUp_IntermediaryDataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>();
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.ToList().Select(i => _convertionMethod(i)).ToList();
                response.Groups = groups;
//Fix for total items in GetGroupsClosed
                if (datasourceRequest.GroupBy.FirstOrDefault().GetGroupsClosed)
                {
                    response.TotalRows = DatasourceRetriever.GetTotalGroups(groups);
                }
            }
            else
            {
                var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
                response.Data = items.ToList().Select(i => _convertionMethod(i)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
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
                var _modelDTO = new SignUpViewModelDTO(@model);
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
            return View("SignUp");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: SignUp, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
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
