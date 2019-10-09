// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS5_SupplyChainFinancialsOptimisation;
(function (DSS5_SupplyChainFinancialsOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'Contact' Service
         */
        var ContactServiceClient = (function () {
            function ContactServiceClient() {
            }
            /**
            *
            */
            ContactServiceClient.Contact = function (first_name, last_name, represents, company_name, email, phone, message) {
                var _data = { first_name: first_name, last_name: last_name, represents: represents, company_name: company_name, email: email, phone: phone, message: message };
                return axios.post(window._context.siteRoot + ContactServiceClient.baseUrl + "ContactUser", _data);
            };
            return ContactServiceClient;
        }());
        /**
         * Base url for 'Contact' Service
         */
        ContactServiceClient.baseUrl = "/api/Contact/";
        Services.ContactServiceClient = ContactServiceClient;
    })(Services = DSS5_SupplyChainFinancialsOptimisation.Services || (DSS5_SupplyChainFinancialsOptimisation.Services = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.Contact = DSS5_SupplyChainFinancialsOptimisation.Services.ContactServiceClient;
