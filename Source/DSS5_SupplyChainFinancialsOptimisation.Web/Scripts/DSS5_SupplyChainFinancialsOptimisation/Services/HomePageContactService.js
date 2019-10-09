// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS5_SupplyChainFinancialsOptimisation;
(function (DSS5_SupplyChainFinancialsOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'HomePageContact' Service
         */
        var HomePageContactServiceClient = (function () {
            function HomePageContactServiceClient() {
            }
            /**
            *
            */
            HomePageContactServiceClient.HomePageContact = function (last_name, email, message) {
                var _data = { last_name: last_name, email: email, message: message };
                return axios.post(window._context.siteRoot + HomePageContactServiceClient.baseUrl + "HomePageContact", _data);
            };
            return HomePageContactServiceClient;
        }());
        /**
         * Base url for 'HomePageContact' Service
         */
        HomePageContactServiceClient.baseUrl = "/api/HomePageContact/";
        Services.HomePageContactServiceClient = HomePageContactServiceClient;
    })(Services = DSS5_SupplyChainFinancialsOptimisation.Services || (DSS5_SupplyChainFinancialsOptimisation.Services = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.HomePageContact = DSS5_SupplyChainFinancialsOptimisation.Services.HomePageContactServiceClient;
