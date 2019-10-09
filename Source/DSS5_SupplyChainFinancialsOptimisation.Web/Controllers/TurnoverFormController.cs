// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TurnoverForm;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.TurnoverForm
{

    [RoutePrefix("TurnoverForm")]
    public class TurnoverFormController : ControllerBase<TurnoverFormViewModel, TurnoverFormViewModelDTO>
    {

        /*<Form:TurnoverForm:0/>*/
        public TurnoverFormController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(TurnoverFormController));
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

        public void SetModel(TurnoverFormViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(TurnoverFormViewModel));
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
            @model = new TurnoverFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TurnoverForm"] = "Render";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Render")]
        public ActionResult _API_Render()

        {
            @model = new TurnoverFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TurnoverForm"] = "Render";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRender();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="RenderSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("RenderSupplier/{*username?}")]
        public ActionResult RenderSupplier(string username)

        {
            @model = new TurnoverFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TurnoverForm"] = "RenderSupplier";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="RenderSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_RenderSupplier/{*username?}")]
        public ActionResult _API_RenderSupplier(string username)

        {
            @model = new TurnoverFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TurnoverForm"] = "RenderSupplier";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRenderSupplier(username);
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
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:RenderSupplier:1/>*/
        public ActionResult ExecuteRenderSupplier(string username)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = "";
            @model.Supplier =  new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(username);
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:Chart:1/>*/
        /*<DataSourceFilter:Chart:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> Get_Chart_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_Chart_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> Get_Chart_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatisticExtensions.GetTurnoverStatisticsForSupplier(@model.Supplier).AsQueryable();
            return __items.Where(@this => true);
        }


        /*<DataSourceEntryPoint:Chart:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "TurnoverStatisticDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("Chart_Datasource")]
        public JsonResult Chart_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_Chart_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_Chart_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_Chart_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_Chart_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                IDictionary<string, string> groupLabels = new Dictionary<string, string>()
                { { "totalamount", "Total Amount" }, { "totalamountfunded", "Total Amount Funded" }
                };
                var data = new List<ChartHelper.ChartResult>();
                foreach (var group in groups.SubGroups)
                {
                    var result = new ChartHelper.ChartResult();
                    result.Label = group.KeyFormatted;
                    foreach (var aggr in group.Aggregates)
                    {
                        if (aggr.Column == "__Count") continue;
                        result.Values.Add(aggr.Value);
                        if (groupLabels.ContainsKey(aggr.Column.ToLower()))
                        {
                            result.ValueLabels.Add(groupLabels[aggr.Column.ToLower()]);
                        }
                        else
                        {
                            result.ValueLabels.Add(aggr.Column);
                        }
                    }
                    data.Add(result);
                }
                response.Data = data;
//Fix for total items in GetGroupsClosed
                if (datasourceRequest.GroupBy.FirstOrDefault().GetGroupsClosed)
                {
                    response.TotalRows = DatasourceRetriever.GetTotalGroups(groups);
                }
            }
            else
            {
                var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
                var _dtos = items.Select(i => new TurnoverStatisticDataSet_TurnoverStatisticDTO(i, true)).ToList();
                var chartData = new List<ChartHelper.ChartResult>();
                foreach(var _dto in _dtos)
                {
                    chartData.Add(new ChartHelper.ChartResult(_dto, _dto?.Year, new List<object> { _dto?.TotalAmount, _dto?.TotalAmountFunded }, new List<object> { "Total Amount", "Total Amount Funded" }, new List<object> {  }));
                }
                response.Data = chartData;
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }


        /*<Datasource:TurnoverForm_TurnoverStatisticDataSet:1/>*/
        /*<DataSourceFilter:TurnoverForm_TurnoverStatisticDataSet:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> Get_TurnoverForm_TurnoverStatisticDataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_TurnoverForm_TurnoverStatisticDataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic> Get_TurnoverForm_TurnoverStatisticDataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatisticExtensions.GetTurnoverStatisticsForSupplier(@model.Supplier).AsQueryable();
            return __items.Where(@this => true);
        }


        /*<DataSourceGetFullRecordset:TurnoverForm_TurnoverStatisticDataSet:1/>*/

        [HttpPost]
        [Route("TurnoverForm_TurnoverStatisticDataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "TurnoverStatisticDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult TurnoverForm_TurnoverStatisticDataSet_GetFullRecordset()
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
            var queryable = Get_TurnoverForm_TurnoverStatisticDataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new TurnoverStatisticDataSet_TurnoverStatisticDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(TurnoverFormViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "TurnoverForm_TurnoverStatisticDataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:TurnoverForm_TurnoverStatisticDataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "TurnoverStatisticDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("TurnoverForm_TurnoverStatisticDataSet_Datasource")]
        public JsonResult TurnoverForm_TurnoverStatisticDataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_TurnoverForm_TurnoverStatisticDataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_TurnoverForm_TurnoverStatisticDataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_TurnoverForm_TurnoverStatisticDataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_TurnoverForm_TurnoverStatisticDataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<DSS5_SupplyChainFinancialsOptimisation.BO.TurnoverStatistic>();
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
                var _modelDTO = new TurnoverFormViewModelDTO(@model);
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
            return View("TurnoverForm");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: TurnoverForm, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
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
