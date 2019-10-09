// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.BuyerPaymentForm;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.BuyerPaymentForm
{

    [RoutePrefix("BuyerPaymentForm")]
    public class BuyerPaymentFormController : ControllerBase<BuyerPaymentFormViewModel, BuyerPaymentFormViewModelDTO>
    {

        /*<Form:BuyerPaymentForm:0/>*/
        public BuyerPaymentFormController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(BuyerPaymentFormController));
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

        public void SetModel(BuyerPaymentFormViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(BuyerPaymentFormViewModel));
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


        [Route("SaveListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult SaveListView()
        {
            var postedData = _ParsePostedData();
            return SaveListView(postedData, "BuyerPaymentForm");
        }


        [Route("DeleteListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult DeleteListView()
        {
            var postedData = _ParsePostedData();
            return DeleteListView(postedData, "BuyerPaymentForm");
        }


        [Route("LoadListViews")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult LoadListViews()
        {
            var postedData = _ParsePostedData();
            return LoadListViews(postedData, "BuyerPaymentForm");
        }



        #region Controller Actions
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Render")]
        public ActionResult Render()

        {
            @model = new BuyerPaymentFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_BuyerPaymentForm"] = "Render";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Render")]
        public ActionResult _API_Render()

        {
            @model = new BuyerPaymentFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_BuyerPaymentForm"] = "Render";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRender();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="Search", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("Search")]
        public ActionResult Search()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteSearch();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="Pay", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("Pay")]
        public ActionResult Pay()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecutePay();
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
            @model.Title = "Payments by Buyer";
            return _result;
        }
        /*<ControllerActionImplementation:Search:1/>*/
        public ActionResult ExecuteSearch()
        {
            ActionResult _result = null;
            @model.Searched = true;
            foreach (var ca in @model.Agreement?.CommercialAgreements ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>())
            {
                foreach (var tr in ca?.Transactions ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>())
                {
                    zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "BuyerPaymentForm",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "-----Transaction Id= " + (tr?.Id?.ToString() ?? "") + "Transaction value" + (tr?.TransactionValue ?? 0), true);
                    if (((tr?.PaymentStatus == "Funded Paid" || tr?.PaymentStatus == "Partially Paid by Buyer") && (tr?.TransactionValue ?? 0) > 0))
                    {
                        @model.Transactions?.Add(tr);
                        zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "BuyerPaymentForm",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "----- Added Transaction with value" + (tr?.TransactionValue ?? 0), true);
                    }
                    else
                    {
                    }
                }
            }
            @model.Transactions = @model.Transactions?.OrderBy((x) => x.InvoicedDate).ToList().ToList();
            return _result;
        }
        /*<ControllerActionImplementation:Pay:1/>*/
        public ActionResult ExecutePay()
        {
            ActionResult _result = null;
            int? i = 0;
            while (@model.PaymentAmount > 0)
            {
                DSS5_SupplyChainFinancialsOptimisation.BO.Transaction tr = zAppDev.DotNet.Framework.Utilities.Common.GetItemFromList(@model.Transactions, i.GetValueOrDefault(0));
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "BuyerPaymentForm",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "i= " + (i?.ToString() ?? "") + "! Model Transaction " + (tr?.Id?.ToString() ?? "") + "Value " + (tr?.TransactionValue?.ToString() ?? ""), true);
                if ((tr?.ToBePaidAmount != null && tr?.ToBePaidAmount != 0))
                {
                    if ((@model.PaymentAmount >= (tr?.ToBePaidAmount ?? 0)))
                    {
                        @model.PaymentAmount = @model.PaymentAmount.GetValueOrDefault(0) - (tr?.ToBePaidAmount ?? 0);
                        tr.ToBePaidAmount = 0;
                        tr.PaymentStatus = "Paid by Buyer";
                        tr.PaidByBuyer = true;
                    }
                    else
                    {
                        tr.ToBePaidAmount = (tr?.ToBePaidAmount ?? 0) - @model.PaymentAmount.GetValueOrDefault(0);
                        @model.PaymentAmount = 0;
                    }
                }
                else
                {
                    if ((@model.PaymentAmount >= (tr?.TransactionValue ?? 0)))
                    {
                        @model.PaymentAmount = @model.PaymentAmount.GetValueOrDefault(0) - (tr?.TransactionValue ?? 0);
                        tr.PaymentStatus = "Paid by Buyer";
                        tr.PaidByBuyer = true;
                        if ((tr?.TransactionStatus == null))
                        {
                            DSS5_SupplyChainFinancialsOptimisation.BO.TransactionStatus trSt = new DSS5_SupplyChainFinancialsOptimisation.BO.TransactionStatus();
                            trSt.PaymentStatus = true;
                            tr.TransactionStatus = trSt;
                        }
                        else
                        {
                            tr.TransactionStatus.PaymentStatus = true;
                        }
                    }
                    else
                    {
                        zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "BuyerPaymentForm",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "---  Else -----Transaction value: " + (tr?.TransactionValue?.ToString() ?? ""));
                        tr.ToBePaidAmount = (tr?.TransactionValue ?? 0) - @model.PaymentAmount.GetValueOrDefault(0);
                        @model.PaymentAmount = 0;
                        tr.PaymentStatus = "Partially Paid by Buyer";
                    }
                }
                tr.PaymentDate = @model.PaymentDate;
                new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(tr);
                i = i.GetValueOrDefault(0) + 1;
                if ((i == @model.Transactions?.Count()))
                {
                    break;
                }
            }
            DSS5_SupplyChainFinancialsOptimisation.BO.TransactionPayment payment = new DSS5_SupplyChainFinancialsOptimisation.BO.TransactionPayment();
            payment.PaymentAmount = @model.PaymentAmount;
            payment.PaymentDate = @model.PaymentDate;
            payment.Agreement = @model.Agreement;
            payment?.AddTransactions(@model.Transactions?.Where((t) => t.PaymentStatus == "Paid by Buyer").ToList());
            foreach (var tr in @model.Transactions?.Where((t) => t.PaymentStatus == "Paid by Buyer").ToList() ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>())
            {
                @model.Transactions?.Remove(tr);
            }
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:PickList:1/>*/
        /*<DataSourceFilter:PickList:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement> Get_PickList_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_PickList_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement> Get_PickList_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>().AsQueryable();
            var _var0 = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName();
            return __items.Where(@this => @this.Investor.UserName == _var0);
        }


        /*<DataSourceGetFullRecordset:PickList:1/>*/

        [HttpPost]
        [Route("PickList_PickList_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AgreementDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult PickList_PickList_GetFullRecordset()
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
            var queryable = Get_PickList_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new AgreementDataSet_AgreementDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(BuyerPaymentFormViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "PickList");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:PickList:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AgreementDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("PickList_PickList_Datasource")]
        public JsonResult PickList_PickList_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_PickList_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_PickList_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_PickList_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_PickList_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.Select(i => new AgreementDataSet_AgreementDTO(i, true)).ToList();
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
                response.Data = items.Select(i => new AgreementDataSet_AgreementDTO(i, true)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        /*<DataSourceAggregators:PickList:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AgreementDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("PickList_PickList_DatasourceAggregators")]
        public JsonResult PickList_PickList_DatasourceAggregators()
        {
            object aggregatorsResponse = null;
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_PickList_DatasourceQueryable(datasourceRequest);
            queryable = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            var formattings = new Dictionary<string, string>();
            formattings.Add("StartDate", "dd/MM/yyyy");
            formattings.Add("EndDate", "dd/MM/yyyy");
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
                var aggregatorsInfo = DeserializeAggregatorsRequest<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>(postedData["aggregatorsRequest"].ToString());
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




        /*<Datasource:BuyerPaymentForm_AgreementDataSet:1/>*/
        /*<DataSourceFilter:BuyerPaymentForm_AgreementDataSet:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement> Get_BuyerPaymentForm_AgreementDataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_BuyerPaymentForm_AgreementDataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement> Get_BuyerPaymentForm_AgreementDataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>().AsQueryable();
            var _var0 = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName();
            return __items.Where(@this => @this.Investor.UserName == _var0);
        }


        /*<DataSourceGetFullRecordset:BuyerPaymentForm_AgreementDataSet:1/>*/

        [HttpPost]
        [Route("BuyerPaymentForm_AgreementDataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AgreementDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult BuyerPaymentForm_AgreementDataSet_GetFullRecordset()
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
            var queryable = Get_BuyerPaymentForm_AgreementDataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new AgreementDataSet_AgreementDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(BuyerPaymentFormViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "BuyerPaymentForm_AgreementDataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:BuyerPaymentForm_AgreementDataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AgreementDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("BuyerPaymentForm_AgreementDataSet_Datasource")]
        public JsonResult BuyerPaymentForm_AgreementDataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_BuyerPaymentForm_AgreementDataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_BuyerPaymentForm_AgreementDataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_BuyerPaymentForm_AgreementDataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_BuyerPaymentForm_AgreementDataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>();
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
                var _modelDTO = new BuyerPaymentFormViewModelDTO(@model);
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
            return View("BuyerPaymentForm");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: BuyerPaymentForm, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
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
