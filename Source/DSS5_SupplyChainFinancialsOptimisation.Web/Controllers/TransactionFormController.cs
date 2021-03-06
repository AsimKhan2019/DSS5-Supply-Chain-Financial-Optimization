// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TransactionForm;
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

namespace DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.TransactionForm
{

    [RoutePrefix("TransactionForm")]
    public class TransactionFormController : ControllerBase<TransactionFormViewModel, TransactionFormViewModelDTO>
    {

        /*<Form:TransactionForm:0/>*/
        public TransactionFormController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(TransactionFormController));
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

        public void SetModel(TransactionFormViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(TransactionFormViewModel));
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
            return SaveListView(postedData, "TransactionForm");
        }


        [Route("DeleteListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult DeleteListView()
        {
            var postedData = _ParsePostedData();
            return DeleteListView(postedData, "TransactionForm");
        }


        [Route("LoadListViews")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult LoadListViews()
        {
            var postedData = _ParsePostedData();
            return LoadListViews(postedData, "TransactionForm");
        }



        #region Controller Actions
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="AddTransaction", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("AddTransaction")]
        public ActionResult AddTransaction()

        {
            @model = new TransactionFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TransactionForm"] = "AddTransaction";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="AddTransaction", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_AddTransaction")]
        public ActionResult _API_AddTransaction()

        {
            @model = new TransactionFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TransactionForm"] = "AddTransaction";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteAddTransaction();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="EditTransaction", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("EditTransaction/{*id:int?}")]
        public ActionResult EditTransaction(int? id)

        {
            @model = new TransactionFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TransactionForm"] = "EditTransaction";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="EditTransaction", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_EditTransaction/{*id:int?}")]
        public ActionResult _API_EditTransaction(int? id)

        {
            @model = new TransactionFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_TransactionForm"] = "EditTransaction";
            PushToHistory();
            var _masterController = new DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteEditTransaction(id);
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="SaveTransaction", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SaveTransaction")]
        public ActionResult SaveTransaction()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteSaveTransaction();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, ActionName="DeleteTransaction", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("DeleteTransaction")]
        public ActionResult DeleteTransaction()

        {
            var _data = _LoadViewModel();
            var redirectInfo = ExecuteDeleteTransaction();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:AddTransaction:1/>*/
        public ActionResult ExecuteAddTransaction()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = "";
            @model.Transaction.TransactionDateOccured = DateTime.UtcNow;
            DSS5_SupplyChainFinancialsOptimisation.BO.Supplier transactionSupplier = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
            transactionSupplier = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>((a) => a.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName())?.FirstOrDefault();
            @model.Transaction.Supplier = transactionSupplier;
            DSS5_SupplyChainFinancialsOptimisation.BO.Supplier sup = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>((s) => s.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName())?.FirstOrDefault();
            if ((sup?.IsSupplier() ?? false))
            {
                @model.IsSupplier = true;
            }
            return _result;
        }
        /*<ControllerActionImplementation:EditTransaction:1/>*/
        public ActionResult ExecuteEditTransaction(int? id)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Transaction =  new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(id);
            @model.Title = " ";
            DSS5_SupplyChainFinancialsOptimisation.BO.Supplier sup = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>((s) => s.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName())?.FirstOrDefault();
            if ((sup?.IsSupplier() ?? false))
            {
                @model.IsSupplier = true;
            }
            if (@model.Transaction?.TransactionOverview == null)
            {
                @model.Transaction.TransactionOverview = new DSS5_SupplyChainFinancialsOptimisation.BO.TransactionOverview();
            }
            if ((@model.Transaction?.DeliveryNotes?.Count() ?? 0) > 0)
            {
                var _var0 = @model.Transaction?.Id;
                DSS5_SupplyChainFinancialsOptimisation.BO.DeliveryNote delNote = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.DeliveryNote>((a) => a.Transaction.Id == _var0)?.FirstOrDefault();
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "TransactionForm",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "****** " + (delNote?.Id?.ToString() ?? ""));
                @model.Transaction.TransactionOverview.DeliveryDate = (delNote?.DateIssued ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
            }
            if ((@model.Transaction?.Orders?.Count() ?? 0) > 0)
            {
                var _var1 = @model.Transaction?.Id;
                DSS5_SupplyChainFinancialsOptimisation.BO.Order order = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order>((a) => a.Transaction.Id == _var1)?.FirstOrDefault();
                @model.Transaction.TransactionOverview.OrderDate = (order?.DateOfOrder ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
                @model.Transaction.TransactionOverview.OrderQuantity = (order?.OrderAmount ?? 0);
            }
            if ((@model.Transaction?.Invoices?.Count() ?? 0) > 0)
            {
                var _var2 = @model.Transaction?.Id;
                DSS5_SupplyChainFinancialsOptimisation.BO.Invoice invoice = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Invoice>((a) => a.Transaction.Id == _var2)?.FirstOrDefault();
                @model.Transaction.TransactionOverview.InvoiceDate = (invoice?.DateIssued ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
                @model.Transaction.TransactionOverview.InvoiceId = (invoice?.Id ?? 0);
            }
            if (@model.Transaction?.CommercialAgreement?.Agreement != null)
            {
                var _var3 = @model.Transaction?.CommercialAgreement?.Agreement?.Id;
                DSS5_SupplyChainFinancialsOptimisation.BO.Agreement agreement = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>((a) => a.Id == _var3)?.FirstOrDefault();
                @model.Transaction.TransactionOverview.InterestRate = (agreement?.InterestRate ?? 0);
                @model.Transaction.TransactionOverview.FundedRate = (agreement?.FundedRate ?? 0);
            }
            var _var4 = @model.Transaction?.CommercialAgreement?.Agreement?.Id;
            DSS5_SupplyChainFinancialsOptimisation.BO.TransactionPayment transactionPayment = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.TransactionPayment>((a) => a.Agreement.Id == _var4)?.FirstOrDefault();
            if (transactionPayment != null)
            {
                @model.Transaction.TransactionOverview.PaymentId = (transactionPayment?.Id ?? 0);
                @model.Transaction.TransactionOverview.PayementDate = (transactionPayment?.PaymentDate ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
            }
            if ((@model.Transaction?.CreditNotes?.Count() ?? 0) > 0)
            {
                var _var5 = @model.Transaction?.Id;
                DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote creditNote = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote>((a) => a.Transaction.Id == _var5)?.FirstOrDefault();
                @model.Transaction.TransactionOverview.CreditNoteNumber = (creditNote?.CreditNoteNumber ?? "");
            }
            return _result;
        }
        /*<ControllerActionImplementation:SaveTransaction:1/>*/
        public ActionResult ExecuteSaveTransaction()
        {
            ActionResult _result = null;
            if (@model.Transaction?.ImportedBuyer == null)
            {
                DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer impBuyer = new DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer();
                impBuyer = @model.Transaction?.CommercialAgreement?.ImportedBuyer;
                @model.Transaction.ImportedBuyer = impBuyer;
            }
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Save<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(@model.Transaction);
            @model.Title = "";
            ClientCommand(ClientCommands.SHOW_MESSAGE, "Transaction was saved successfully.", MessageType.Success, (!string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"]) ?
                          System.Configuration.ConfigurationManager.AppSettings["ServerExternalPath"] : zAppDev.DotNet.Framework.Utilities.Web.GetApplicationPathUri(false)) +
                          "/TransactionsList/Retrieve");
            return _result;
        }
        /*<ControllerActionImplementation:DeleteTransaction:1/>*/
        public ActionResult ExecuteDeleteTransaction()
        {
            ActionResult _result = null;
            new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().DeleteTransaction(@model.Transaction);
            @model.Title = "";
            _result = CloseForm();
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:btnSelectCommercialAgreement:1/>*/
        /*<DataSourceFilter:btnSelectCommercialAgreement:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement> Get_btnSelectCommercialAgreement_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_btnSelectCommercialAgreement_DatasourceQueryableImplementation(__request);
            if (__request.ExcludeKeys != null && __request.ExcludeKeys.Any())
            {
                var keysToExclude = __request.ExcludeKeys.Select(x => x.ToString());
                __items = __items.Where(x => !keysToExclude.Contains(x.Id.ToString()));
            }
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement> Get_btnSelectCommercialAgreement_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>().AsQueryable();
            var _var0 = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName();
            return __items.Where(@this => @this.Supplier.UserName == _var0 && @this.Agreement.Id > 0);
        }


        /*<DataSourceGetFullRecordset:btnSelectCommercialAgreement:1/>*/

        [HttpPost]
        [Route("btnSelectCommercialAgreement_PickList_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "CommercialAgreementDataSource", ClaimType = ClaimTypes.Dataset)]
        public JsonResult btnSelectCommercialAgreement_PickList_GetFullRecordset()
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
            var queryable = Get_btnSelectCommercialAgreement_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new CommercialAgreementDataSource_CommercialAgreementDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(TransactionFormViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "btnSelectCommercialAgreement");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:btnSelectCommercialAgreement:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "CommercialAgreementDataSource", ClaimType = ClaimTypes.Dataset)]
        [Route("btnSelectCommercialAgreement_PickList_Datasource")]
        public JsonResult btnSelectCommercialAgreement_PickList_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_btnSelectCommercialAgreement_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_btnSelectCommercialAgreement_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_btnSelectCommercialAgreement_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_btnSelectCommercialAgreement_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.Select(i => new CommercialAgreementDataSource_CommercialAgreementDTO(i, true)).ToList();
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
                response.Data = items.Select(i => new CommercialAgreementDataSource_CommercialAgreementDTO(i, true)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        /*<DataSourceAggregators:btnSelectCommercialAgreement:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "CommercialAgreementDataSource", ClaimType = ClaimTypes.Dataset)]
        [Route("btnSelectCommercialAgreement_PickList_DatasourceAggregators")]
        public JsonResult btnSelectCommercialAgreement_PickList_DatasourceAggregators()
        {
            object aggregatorsResponse = null;
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_btnSelectCommercialAgreement_DatasourceQueryable(datasourceRequest);
            queryable = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            var formattings = new Dictionary<string, string>();
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
                var aggregatorsInfo = DeserializeAggregatorsRequest<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(postedData["aggregatorsRequest"].ToString());
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




        /*<Datasource:TransactionForm_CommercialAgreementDataSource:1/>*/
        /*<DataSourceFilter:TransactionForm_CommercialAgreementDataSource:2/>*/
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement> Get_TransactionForm_CommercialAgreementDataSource_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_TransactionForm_CommercialAgreementDataSource_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement> Get_TransactionForm_CommercialAgreementDataSource_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>().AsQueryable();
            var _var0 = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName();
            return __items.Where(@this => @this.Supplier.UserName == _var0 && @this.Agreement.Id > 0);
        }


        /*<DataSourceGetFullRecordset:TransactionForm_CommercialAgreementDataSource:1/>*/

        [HttpPost]
        [Route("TransactionForm_CommercialAgreementDataSource_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "CommercialAgreementDataSource", ClaimType = ClaimTypes.Dataset)]
        public JsonResult TransactionForm_CommercialAgreementDataSource_GetFullRecordset()
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
            var queryable = Get_TransactionForm_CommercialAgreementDataSource_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new CommercialAgreementDataSource_CommercialAgreementDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(TransactionFormViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "TransactionForm_CommercialAgreementDataSource");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:TransactionForm_CommercialAgreementDataSource:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "CommercialAgreementDataSource", ClaimType = ClaimTypes.Dataset)]
        [Route("TransactionForm_CommercialAgreementDataSource_Datasource")]
        public JsonResult TransactionForm_CommercialAgreementDataSource_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_TransactionForm_CommercialAgreementDataSource_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_TransactionForm_CommercialAgreementDataSource_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_TransactionForm_CommercialAgreementDataSource_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_TransactionForm_CommercialAgreementDataSource_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>();
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
                var _modelDTO = new TransactionFormViewModelDTO(@model);
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
            return View("TransactionForm");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: TransactionForm, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
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
