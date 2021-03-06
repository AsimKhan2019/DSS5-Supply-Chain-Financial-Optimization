// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.Services {
/**
 * Client for 'IntermediaryUser' Service
 */
export class IntermediaryUserServiceClient {

    /**
     * Base url for 'IntermediaryUser' Service
     */
    static baseUrl = "/api/IntermediaryUser/";

    /**
    * Creates a new IntermediaryUser
    */
    public static Create(newIntermediaryUser?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = newIntermediaryUser;
                return axios.post(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl + "Create",_data);
            }
            /**
            * Get an IntermediaryUser insance based on UserName
            */
            public static Get(UserName?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { params: { UserName: UserName } };
                return axios.get(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl,_data);
            }
            /**
            * Count all IntermediaryUsers
            */
            public static Count(): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { params: {  } };
                return axios.get(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl + "count",_data);
            }
            /**
            * Gets all IntermediaryUsers. Max pageSize is 50
            */
            public static GetAll(pageSize?:any, pageIndex?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { params: { pageSize: pageSize,pageIndex: pageIndex } };
                return axios.get(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl + "all",_data);
            }
            /**
            * Saves a IntermediaryUser insance
            */
            public static Save(IntermediaryUser?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = IntermediaryUser;
                return axios.post(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl,_data);
            }
            /**
            * Deletes a IntermediaryUser insance based on UserName
            */
            public static Delete(UserName?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { params: { UserName: UserName } };
                return axios.delete(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl,_data);
            }
            /**
            *
            */
            public static IsIntermediary(username?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { params: { username: username } };
                return axios.get(window._context.siteRoot + IntermediaryUserServiceClient.baseUrl + "IsIntermediary",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.IntermediaryUser = DSS5_SupplyChainFinancialsOptimisation.Services.IntermediaryUserServiceClient;
