// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;
using Newtonsoft.Json.Linq;

namespace DSS5_SupplyChainFinancialsOptimisation.Web
{
    public class APIRegistryConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var logger = LogManager.GetLogger(typeof(APIRegistryConfig));
            try
            {
                var consulHost = ConfigurationManager.AppSettings["apiregistry:consulhost"];
                if (string.IsNullOrWhiteSpace(consulHost))
                {
                    logger.Warn("No {apiregistry:consulhost} found in configuration. Will not register with any API Registry.");
                    return;
                }
                // Register self to Consul
                var regUrl = $"{consulHost}/v1/agent/service/register";
                var uri = new Uri(regUrl);
                var externalIP = ConfigurationManager.AppSettings["ServerExternalIP"];
                var jsonObject = (dynamic)new JObject();
                jsonObject.id = "dss5_supplychainfinancialsoptimisation";
                jsonObject.name = "DSS5_SupplyChainFinancialsOptimisation";
                jsonObject.address = externalIP;
                jsonObject.port = 443;
                jsonObject.enableTagOverride = false;
                ;
                var check = (dynamic) new JObject();
                check.http = $"https://{externalIP}/api/_health/check";
                check.interval = "30s";
                check.timeout = "5s";
                jsonObject.checks = JArray.FromObject(new [] { check });
                using (var client = new HttpClient())
                {
                    //var byteArray = Encoding.ASCII.GetBytes("username:password1234");
                    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    var response = client.PutAsJsonAsync(uri, (JObject)jsonObject).Result;
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        logger.Warn($"Could not register with API Registry. Got: {response.StatusCode} - {response.Content.ReadAsStringAsync().Result}");
                    }
                    else
                    {
                        logger.Info($"Successfully registered with API Registry at: {regUrl}");
                    }
                }
            }
            catch (Exception e)
            {
                logger.Error("Error during API Registry registration!", e);
                throw;
            }
        }
    }
}