// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorOrdersList;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.InvestorOrdersList
{

    [RoutePrefix("InvestorOrdersList")]
    public class InvestorOrdersListController : ControllerBase<InvestorOrdersListViewModel, InvestorOrdersListViewModelDTO>
    {

        /*<Form:InvestorOrdersList:0/>*/
        public InvestorOrdersListController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(InvestorOrdersListController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }

        protected override void ViewModelLoaded()
        {
            var masterViewModel = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists.MasterPageForListsViewModel
            {
                Title = model.Title, Version = model.Version
            };
            _parentController = new MasterPageForLists.MasterPageForListsController(masterViewModel);
            _parentController.IsDirty = IsDirty;
        }

        public void SetModel(InvestorOrdersListViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(InvestorOrdersListViewModel));
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
            return FileHelper.PendingDownloadInstance.DownloadByKey("InvestorOrdersList", id);
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


        [Route("SaveListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult SaveListView()
        {
            var postedData = _ParsePostedData();
            return SaveListView(postedData, "InvestorOrdersList");
        }


        [Route("DeleteListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult DeleteListView()
        {
            var postedData = _ParsePostedData();
            return DeleteListView(postedData, "InvestorOrdersList");
        }


        [Route("LoadListViews")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult LoadListViews()
        {
            var postedData = _ParsePostedData();
            return LoadListViews(postedData, "InvestorOrdersList");
        }



        #region Controller Actions
        [CustomControllerActionFilter(LogEnabled=true, HasDefaultResultView=true, ActionName="Retrieve", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Retrieve")]
        public ActionResult Retrieve()

        {
            @model = new InvestorOrdersListViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_InvestorOrdersList"] = "Retrieve";
            return null;
        }

        [CustomControllerActionFilter(LogEnabled=true, FillDropDownInitialValues=true, ActionName="Retrieve", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Retrieve")]
        public ActionResult _API_Retrieve()

        {
            @model = new InvestorOrdersListViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_InvestorOrdersList"] = "Retrieve";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForLists.MasterPageForListsController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRetrieve();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="FindAgreement", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("FindAgreement")]
        public ActionResult FindAgreement()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteFindAgreement();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="DeleteSeclected", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("DeleteSeclected")]
        public ActionResult DeleteSeclected()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteDeleteSeclected();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:Retrieve:1/>*/
        public ActionResult ExecuteRetrieve()
        {
            if (_parentController == null) _parentController = new MasterPageForLists.MasterPageForListsController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists.MasterPageForListsViewModel());
            ((MasterPageForLists.MasterPageForListsController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = "";
            return _result;
        }
        /*<ControllerActionImplementation:FindAgreement:1/>*/
        public ActionResult ExecuteFindAgreement()
        {
            ActionResult _result = null;
            string userName = "";
            System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement> agreements = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>((a) => a.Investor.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentApplicationUser().UserName);
            System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Order> foundOrders = new System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Order>();
            foreach (var agr in agreements ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>())
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "InvestorOrdersList",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "-------2-------");
                userName = (agr?.Supplier?.UserName ?? "");
                foreach (var order in new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAll<DSS5_SupplyChainFinancialsOptimisation.BO.Order>() ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.Order>())
                {
                    if (order?.Transaction?.Supplier?.UserName == userName)
                    {
                        foundOrders?.Add(order);
                        zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "InvestorOrdersList",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "length foundOrders: " + (foundOrders?.Count().ToString() ?? ""));
                    }
                }
            }
            return _result;
        }
        /*<ControllerActionImplementation:DeleteSeclected:1/>*/
        public ActionResult ExecuteDeleteSeclected()
        {
            ActionResult _result = null;
            foreach (var selectedOrder in SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>.GetSelectedItems(Get_ListNoDT_DatasourceQueryable(null, false), @model.ListNoDTSelectedItems) ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.Order>())
            {
                new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().DeleteOrder(selectedOrder);
            }
            ClientCommand(ClientCommands.DATALIST_REFRESH, "ListNoDT");
            ClientCommand(ClientCommands.SHOW_MESSAGE, "Deleted Selected Order successfully!");
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:ListNoDT:1/>*/
        /*<DataSourceFilter:ListNoDT:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order> Get_ListNoDT_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_ListNoDT_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order> Get_ListNoDT_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = DSS5_SupplyChainFinancialsOptimisation.BO.OrderExtensions.FindAgreement().AsQueryable();
            return __items.Where(@this => @this.Transaction.Supplier.Roles.Any((a) => a.Name == "ActiveSupplier"));
        }


        /*<DataSourceGetFullRecordset:ListNoDT:1/>*/

        [HttpPost]
        [Route("ListNoDT_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "InvestorOrderDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult ListNoDT_GetFullRecordset()
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
            var queryable = Get_ListNoDT_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new InvestorOrderDataSet_OrderDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(InvestorOrdersListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "ListNoDT");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:ListNoDT:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "InvestorOrderDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("ListNoDT_Datasource")]
        public JsonResult ListNoDT_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_ListNoDT_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_ListNoDT_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_ListNoDT_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_ListNoDT_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.Select(i => new InvestorOrderDataSet_OrderDTO(i, true)).ToList();
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
                response.Data = items.Select(i => new InvestorOrderDataSet_OrderDTO(i, true)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        /*<DataSourceAggregators:ListNoDT:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "InvestorOrderDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("ListNoDT_DatasourceAggregators")]
        public JsonResult ListNoDT_DatasourceAggregators()
        {
            object aggregatorsResponse = null;
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_ListNoDT_DatasourceQueryable(datasourceRequest);
            queryable = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            var formattings = new Dictionary<string, string>();
            formattings.Add("DateOfOrder", "dd/MM/yyyy");
            formattings.Add("OrderAmount", "#,0.00;'-'#,0.00;'0'");
            formattings.Add("TotalPrice", "#,0.00;'-'#,0.00;'0'");
            if (datasourceRequest.GroupBy.Any()/* && datasourceRequest.GroupBy.First().GetGroupsClosed*/)
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData, true);
                GroupsHelper.FormatGroupedAggregators(groups, formattings);
                aggregatorsResponse = new ListResponse()
                {
                    Groups = groups
                };
            }
            else
            {
                var aggregatorsInfo = DeserializeAggregatorsRequest<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(postedData["aggregatorsRequest"].ToString());
                var aggregators = RuntimePredicateBuilder.BuildAggregatorPredicates(aggregatorsInfo);
                foreach (var a in aggregators)
                {
                    var formatting = formattings.ContainsKey(a.Column) ? formattings[a.Column] : null;
                    a.Calculate(queryable, formatting);
                }
                aggregatorsResponse = aggregators;
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(aggregatorsResponse)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }





        /*<Datasource:InvestorOrdersList_OrderDataSet:1/>*/
        /*<DataSourceFilter:InvestorOrdersList_OrderDataSet:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order> Get_InvestorOrdersList_OrderDataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_InvestorOrdersList_OrderDataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order> Get_InvestorOrdersList_OrderDataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order>().AsQueryable();
            return __items.Where(@this => true);
        }


        /*<DataSourceGetFullRecordset:InvestorOrdersList_OrderDataSet:1/>*/

        [HttpPost]
        [Route("InvestorOrdersList_OrderDataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "OrderDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult InvestorOrdersList_OrderDataSet_GetFullRecordset()
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
            var queryable = Get_InvestorOrdersList_OrderDataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new OrderDataSet_OrderDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(InvestorOrdersListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "InvestorOrdersList_OrderDataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:InvestorOrdersList_OrderDataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "OrderDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("InvestorOrdersList_OrderDataSet_Datasource")]
        public JsonResult InvestorOrdersList_OrderDataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_InvestorOrdersList_OrderDataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_InvestorOrdersList_OrderDataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_InvestorOrdersList_OrderDataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_InvestorOrdersList_OrderDataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<DSS5_SupplyChainFinancialsOptimisation.BO.Order>();
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


        /*<Datasource:InvestorOrdersList_InvestorOrderDataSet:1/>*/
        /*<DataSourceFilter:InvestorOrdersList_InvestorOrderDataSet:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order> Get_InvestorOrdersList_InvestorOrderDataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_InvestorOrdersList_InvestorOrderDataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order> Get_InvestorOrdersList_InvestorOrderDataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = DSS5_SupplyChainFinancialsOptimisation.BO.OrderExtensions.FindAgreement().AsQueryable();
            return __items.Where(@this => @this.Transaction.Supplier.Roles.Any((a) => a.Name == "ActiveSupplier"));
        }


        /*<DataSourceGetFullRecordset:InvestorOrdersList_InvestorOrderDataSet:1/>*/

        [HttpPost]
        [Route("InvestorOrdersList_InvestorOrderDataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "InvestorOrderDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult InvestorOrdersList_InvestorOrderDataSet_GetFullRecordset()
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
            var queryable = Get_InvestorOrdersList_InvestorOrderDataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new InvestorOrderDataSet_OrderDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(InvestorOrdersListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "InvestorOrdersList_InvestorOrderDataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:InvestorOrdersList_InvestorOrderDataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "InvestorOrderDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("InvestorOrdersList_InvestorOrderDataSet_Datasource")]
        public JsonResult InvestorOrdersList_InvestorOrderDataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_InvestorOrdersList_InvestorOrderDataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_InvestorOrdersList_InvestorOrderDataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_InvestorOrdersList_InvestorOrderDataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_InvestorOrdersList_InvestorOrderDataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<DSS5_SupplyChainFinancialsOptimisation.BO.Order>();
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
                var _modelDTO = new InvestorOrdersListViewModelDTO(@model);
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
            return View("InvestorOrdersList");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: InvestorOrdersList, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            var masterPageDataValidations = (_parentController as Controllers.MasterPageForLists.MasterPageForListsController).RunDataValidations();
            if (masterPageDataValidations?.Any() == true)
            {
                viewDTO.RuleEvaluations.DataValidations.AddRange(masterPageDataValidations);
            }
            return viewDTO.RuleEvaluations.DataValidations;
        }

        #endregion
    }
}
