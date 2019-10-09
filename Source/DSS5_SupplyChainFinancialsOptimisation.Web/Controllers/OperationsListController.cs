// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OperationsList;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.OperationsList
{

    [RoutePrefix("OperationsList")]
    public class OperationsListController : ControllerBase<OperationsListViewModel, OperationsListViewModelDTO>
    {

        /*<Form:OperationsList:0/>*/
        public OperationsListController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(OperationsListController));
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

        public void SetModel(OperationsListViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(OperationsListViewModel));
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
        [CustomControllerActionFilter(CausesValidation=true, ActionName="Refresh", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("Refresh")]
        public ActionResult Refresh()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteRefresh();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="Retrieve", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Retrieve")]
        public ActionResult Retrieve()

        {
            @model = new OperationsListViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_OperationsList"] = "Retrieve";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Retrieve", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Retrieve")]
        public ActionResult _API_Retrieve()

        {
            @model = new OperationsListViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_OperationsList"] = "Retrieve";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRetrieve();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:Refresh:1/>*/
        public ActionResult ExecuteRefresh()
        {
            ActionResult _result = null;
            ClientCommand(ClientCommands.GRID_REFRESH, "Table");
            return _result;
        }
        /*<ControllerActionImplementation:Retrieve:1/>*/
        public ActionResult ExecuteRetrieve()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = BaseViewPage<string>.GetResourceValue("OperationsList", "RES_PAGETITLE_Retrieve").ToString();
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:Table:1/>*/
        /*<DataSourceFilter:Table:2/>*/
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation> Get_Table_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_Table_DatasourceQueryableImplementation(__request);
// Predefined Ordering
            if (!__request.OrderBy.Any() && !__request.GroupBy.Any())
            {
                __items = __items.OrderBy(@this => @this.ParentControllerName != null ? @this.ParentControllerName : null)
                          ;
            }
            return __items;
        }
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation> Get_Table_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>().AsQueryable();
            return __items.Where(@this => true);
        }


        /*<DataSourceGetFullRecordset:Table:1/>*/

        [HttpPost]
        [Route("Table_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult Table_GetFullRecordset()
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
            var queryable = Get_Table_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new List1DataSet_ApplicationOperationDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(OperationsListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "Table");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:Table:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("Table_Datasource")]
        public JsonResult Table_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_Table_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_Table_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_Table_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_Table_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
            response.Data = items.Select(i => new List1DataSet_ApplicationOperationDTO(i, true)).ToList();
            CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_List1DataSet", response.Data);
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }


        /*<Datasource:OperationsList_List1DataSet:1/>*/
        /*<DataSourceFilter:OperationsList_List1DataSet:2/>*/
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation> Get_OperationsList_List1DataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_OperationsList_List1DataSet_DatasourceQueryableImplementation(__request);
// Predefined Ordering
            if (!__request.OrderBy.Any() && !__request.GroupBy.Any())
            {
                __items = __items.OrderBy(@this => @this.ParentControllerName != null ? @this.ParentControllerName : null)
                          ;
            }
            return __items;
        }
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation> Get_OperationsList_List1DataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>().AsQueryable();
            return __items.Where(@this => true);
        }


        /*<DataSourceGetFullRecordset:OperationsList_List1DataSet:1/>*/

        [HttpPost]
        [Route("OperationsList_List1DataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult OperationsList_List1DataSet_GetFullRecordset()
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
            var queryable = Get_OperationsList_List1DataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new List1DataSet_ApplicationOperationDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(OperationsListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "OperationsList_List1DataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:OperationsList_List1DataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("OperationsList_List1DataSet_Datasource")]
        public JsonResult OperationsList_List1DataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_OperationsList_List1DataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_OperationsList_List1DataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_OperationsList_List1DataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_OperationsList_List1DataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>();
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
                var _modelDTO = new OperationsListViewModelDTO(@model);
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
            return View("OperationsList");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: OperationsList, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
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
