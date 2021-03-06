// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.Services {
/**
 * Client for 'HomePageContact' Service
 */
export class HomePageContactServiceClient {

    /**
     * Base url for 'HomePageContact' Service
     */
    static baseUrl = "/api/HomePageContact/";

    /**
    *
    */
    public static HomePageContact(last_name?:any, email?:any, message?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { last_name: last_name,email: email,message: message };
                return axios.post(window._context.siteRoot + HomePageContactServiceClient.baseUrl + "HomePageContact",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.HomePageContact = DSS5_SupplyChainFinancialsOptimisation.Services.HomePageContactServiceClient;
