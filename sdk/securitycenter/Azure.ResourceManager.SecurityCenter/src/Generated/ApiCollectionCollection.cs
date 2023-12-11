// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiCollectionResource"/> and their operations.
    /// Each <see cref="ApiCollectionResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ApiCollectionCollection"/> instance call the GetApiCollections method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ApiCollectionCollection : ArmCollection, IEnumerable<ApiCollectionResource>, IAsyncEnumerable<ApiCollectionResource>
    {
        private readonly ClientDiagnostics _apiCollectionAPICollectionsClientDiagnostics;
        private readonly APICollectionsRestOperations _apiCollectionAPICollectionsRestClient;
        private readonly string _serviceName;

        /// <summary> Initializes a new instance of the <see cref="ApiCollectionCollection"/> class for mocking. </summary>
        protected ApiCollectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiCollectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="serviceName"> The name of the API Management service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ApiCollectionCollection(ArmClient client, ResourceIdentifier id, string serviceName) : base(client, id)
        {
            _serviceName = serviceName;
            _apiCollectionAPICollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ApiCollectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiCollectionResource.ResourceType, out string apiCollectionAPICollectionsApiVersion);
            _apiCollectionAPICollectionsRestClient = new APICollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiCollectionAPICollectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Onboard an Azure API Management API to Microsoft Defender for APIs. The system will start monitoring the operations within the Azure Management API for intrusive behaviors and provide alerts for attacks that have been detected.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_OnboardAzureApiManagementApi</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiCollectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiCollectionAPICollectionsRestClient.OnboardAzureApiManagementApiAsync(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<ApiCollectionResource>(new ApiCollectionOperationSource(Client), _apiCollectionAPICollectionsClientDiagnostics, Pipeline, _apiCollectionAPICollectionsRestClient.CreateOnboardAzureApiManagementApiRequest(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Onboard an Azure API Management API to Microsoft Defender for APIs. The system will start monitoring the operations within the Azure Management API for intrusive behaviors and provide alerts for attacks that have been detected.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_OnboardAzureApiManagementApi</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual ArmOperation<ApiCollectionResource> CreateOrUpdate(WaitUntil waitUntil, string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiCollectionAPICollectionsRestClient.OnboardAzureApiManagementApi(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken);
                var operation = new SecurityCenterArmOperation<ApiCollectionResource>(new ApiCollectionOperationSource(Client), _apiCollectionAPICollectionsClientDiagnostics, Pipeline, _apiCollectionAPICollectionsRestClient.CreateOnboardAzureApiManagementApiRequest(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Azure API Management API if it has been onboarded to Microsoft Defender for APIs. If an Azure API Management API is onboarded to Microsoft Defender for APIs, the system will monitor the operations within the Azure API Management API for intrusive behaviors and provide alerts for attacks that have been detected.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_GetByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<Response<ApiCollectionResource>> GetAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiCollectionAPICollectionsRestClient.GetByAzureApiManagementServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiCollectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Azure API Management API if it has been onboarded to Microsoft Defender for APIs. If an Azure API Management API is onboarded to Microsoft Defender for APIs, the system will monitor the operations within the Azure API Management API for intrusive behaviors and provide alerts for attacks that have been detected.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_GetByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual Response<ApiCollectionResource> Get(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.Get");
            scope.Start();
            try
            {
                var response = _apiCollectionAPICollectionsRestClient.GetByAzureApiManagementService(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiCollectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Azure API Management APIs that have been onboarded to Microsoft Defender for APIs. If an Azure API Management API is onboarded to Microsoft Defender for APIs, the system will monitor the operations within the Azure API Management API for intrusive behaviors and provide alerts for attacks that have been detected.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_ListByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiCollectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiCollectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiCollectionAPICollectionsRestClient.CreateListByAzureApiManagementServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, _serviceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiCollectionAPICollectionsRestClient.CreateListByAzureApiManagementServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _serviceName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiCollectionResource(Client, ApiCollectionData.DeserializeApiCollectionData(e)), _apiCollectionAPICollectionsClientDiagnostics, Pipeline, "ApiCollectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Azure API Management APIs that have been onboarded to Microsoft Defender for APIs. If an Azure API Management API is onboarded to Microsoft Defender for APIs, the system will monitor the operations within the Azure API Management API for intrusive behaviors and provide alerts for attacks that have been detected.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_ListByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiCollectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiCollectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiCollectionAPICollectionsRestClient.CreateListByAzureApiManagementServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, _serviceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiCollectionAPICollectionsRestClient.CreateListByAzureApiManagementServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _serviceName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiCollectionResource(Client, ApiCollectionData.DeserializeApiCollectionData(e)), _apiCollectionAPICollectionsClientDiagnostics, Pipeline, "ApiCollectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_GetByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiCollectionAPICollectionsRestClient.GetByAzureApiManagementServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_GetByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual Response<bool> Exists(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiCollectionAPICollectionsRestClient.GetByAzureApiManagementService(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_GetByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiCollectionResource>> GetIfExistsAsync(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiCollectionAPICollectionsRestClient.GetByAzureApiManagementServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiCollectionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiCollectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/providers/Microsoft.Security/apiCollections/{apiId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>APICollections_GetByAzureApiManagementService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiId"> API revision identifier. Must be unique in the API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiId"/> is null. </exception>
        public virtual NullableResponse<ApiCollectionResource> GetIfExists(string apiId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiId, nameof(apiId));

            using var scope = _apiCollectionAPICollectionsClientDiagnostics.CreateScope("ApiCollectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiCollectionAPICollectionsRestClient.GetByAzureApiManagementService(Id.SubscriptionId, Id.ResourceGroupName, _serviceName, apiId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiCollectionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiCollectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiCollectionResource> IEnumerable<ApiCollectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiCollectionResource> IAsyncEnumerable<ApiCollectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
