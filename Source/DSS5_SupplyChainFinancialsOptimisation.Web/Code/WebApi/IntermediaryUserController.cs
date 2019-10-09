// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using zAppDev.DotNet.Framework.Mvc;
using AppCode;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
namespace DSS5_SupplyChainFinancialsOptimisation.Web.Code.WebApi
{


    [RoutePrefix("api/IntermediaryUser")]
    [WebApiThrottle.EnableThrottling()]
    public class IntermediaryUserController : BasicApiCtrl
    {

        /// <summary>
        /// Creates a new IntermediaryUser
        /// </summary>
        /// <returns>void</returns>
        [CustomWebApiActionFilter()]
        [CustomWebApiAuthorize(LogEnabled = false)]

        [Route("Create")]
        [HttpPost]
        public void Create([FromBody]DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUser.DataContracts.IntermediaryUserDTO newIntermediaryUser)
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).Create(newIntermediaryUser,_RequestSourceIp, _UserName);
        }

        /// <summary>
        /// Get an IntermediaryUser insance based on UserName
        /// </summary>
        /// <returns>IntermediaryUser</returns>
        [CustomWebApiActionFilter()]
        [CustomWebApiAuthorize(LogEnabled = false)]

        [Route("")]
        [HttpGet]
        public DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUser.DataContracts.IntermediaryUserDTO Get(string UserName = "")
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).Get(UserName,_RequestSourceIp, _UserName);
            return result;
        }

        /// <summary>
        /// Count all IntermediaryUsers
        /// </summary>
        /// <returns>int</returns>
        [CustomWebApiActionFilter()]
        [CustomWebApiAuthorize(LogEnabled = false)]

        [Route("count")]
        [HttpGet]
        public HttpResponseMessage Count()
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).Count(_RequestSourceIp, _UserName);
            return SendString(result);
        }

        /// <summary>
        /// Gets all IntermediaryUsers. Max pageSize is 50
        /// </summary>
        /// <returns>Collection</returns>
        [CustomWebApiActionFilter(AllowPartialResponse = true)]
        [CustomWebApiAuthorize(LogEnabled = false)]

        [Route("all")]
        [HttpGet]
        public System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUser.DataContracts.IntermediaryUserDTO> GetAll(int? pageSize = 0, int? pageIndex = 0)
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).GetAll(pageSize,pageIndex,_RequestSourceIp, _UserName);
            return result;
        }

        /// <summary>
        /// Saves a IntermediaryUser insance
        /// </summary>
        /// <returns>void</returns>
        [CustomWebApiActionFilter()]
        [CustomWebApiAuthorize(LogEnabled = false)]

        [Route("")]
        [HttpPost]
        public void Save([FromBody]DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUser.DataContracts.IntermediaryUserDTO IntermediaryUser)
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).Save(IntermediaryUser,_RequestSourceIp, _UserName);
        }

        /// <summary>
        /// Deletes a IntermediaryUser insance based on UserName
        /// </summary>
        /// <returns>void</returns>
        [CustomWebApiActionFilter()]
        [CustomWebApiAuthorize(LogEnabled = false)]

        [Route("")]
        [HttpDelete]
        public void Delete(string UserName = "")
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).Delete(UserName,_RequestSourceIp, _UserName);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>bool</returns>
        [CustomWebApiActionFilter(LogEnabled = true)]
        [CustomWebApiAuthorize(LogEnabled = true)]

        [Route("IsIntermediary")]
        [HttpGet]
        public HttpResponseMessage IsIntermediary(string username = "")
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserService()).IsIntermediary(username,_RequestSourceIp, _UserName);
            return SendString(result);
        }
    }
}
