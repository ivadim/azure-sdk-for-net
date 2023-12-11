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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="GitLabGroupResource"/> and their operations.
    /// Each <see cref="GitLabGroupResource"/> in the collection will belong to the same instance of <see cref="DevOpsConfigurationResource"/>.
    /// To get a <see cref="GitLabGroupCollection"/> instance call the GetGitLabGroups method from an instance of <see cref="DevOpsConfigurationResource"/>.
    /// </summary>
    public partial class GitLabGroupCollection : ArmCollection, IEnumerable<GitLabGroupResource>, IAsyncEnumerable<GitLabGroupResource>
    {
        private readonly ClientDiagnostics _gitLabGroupClientDiagnostics;
        private readonly GitLabGroupsRestOperations _gitLabGroupRestClient;
        private readonly ClientDiagnostics _gitLabSubgroupsClientDiagnostics;
        private readonly GitLabSubgroupsRestOperations _gitLabSubgroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GitLabGroupCollection"/> class for mocking. </summary>
        protected GitLabGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GitLabGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GitLabGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gitLabGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", GitLabGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GitLabGroupResource.ResourceType, out string gitLabGroupApiVersion);
            _gitLabGroupRestClient = new GitLabGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gitLabGroupApiVersion);
            _gitLabSubgroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _gitLabSubgroupsRestClient = new GitLabSubgroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevOpsConfigurationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevOpsConfigurationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns a monitored GitLab Group resource for a given fully-qualified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        public virtual async Task<Response<GitLabGroupResource>> GetAsync(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            using var scope = _gitLabGroupClientDiagnostics.CreateScope("GitLabGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _gitLabGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitLabGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitLab Group resource for a given fully-qualified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        public virtual Response<GitLabGroupResource> Get(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            using var scope = _gitLabGroupClientDiagnostics.CreateScope("GitLabGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _gitLabGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitLabGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of GitLab groups onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GitLabGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GitLabGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitLabGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _gitLabGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GitLabGroupResource(Client, GitLabGroupData.DeserializeGitLabGroupData(e)), _gitLabGroupClientDiagnostics, Pipeline, "GitLabGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of GitLab groups onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GitLabGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GitLabGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitLabGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _gitLabGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GitLabGroupResource(Client, GitLabGroupData.DeserializeGitLabGroupData(e)), _gitLabGroupClientDiagnostics, Pipeline, "GitLabGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets nested subgroups of given GitLab Group which are onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}/listSubgroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabSubgroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        /// <returns> An async collection of <see cref="GitLabGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GitLabGroupResource> GetGitLabSubgroupsAsync(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitLabSubgroupsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new GitLabGroupResource(Client, GitLabGroupData.DeserializeGitLabGroupData(e)), _gitLabSubgroupsClientDiagnostics, Pipeline, "GitLabGroupCollection.GetGitLabSubgroups", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets nested subgroups of given GitLab Group which are onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}/listSubgroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabSubgroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        /// <returns> A collection of <see cref="GitLabGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GitLabGroupResource> GetGitLabSubgroups(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitLabSubgroupsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new GitLabGroupResource(Client, GitLabGroupData.DeserializeGitLabGroupData(e)), _gitLabSubgroupsClientDiagnostics, Pipeline, "GitLabGroupCollection.GetGitLabSubgroups", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            using var scope = _gitLabGroupClientDiagnostics.CreateScope("GitLabGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _gitLabGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            using var scope = _gitLabGroupClientDiagnostics.CreateScope("GitLabGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _gitLabGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        public virtual async Task<NullableResponse<GitLabGroupResource>> GetIfExistsAsync(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            using var scope = _gitLabGroupClientDiagnostics.CreateScope("GitLabGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _gitLabGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GitLabGroupResource>(response.GetRawResponse());
                return Response.FromValue(new GitLabGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupFQName"> The GitLab group fully-qualified name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupFQName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupFQName"/> is null. </exception>
        public virtual NullableResponse<GitLabGroupResource> GetIfExists(string groupFQName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupFQName, nameof(groupFQName));

            using var scope = _gitLabGroupClientDiagnostics.CreateScope("GitLabGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _gitLabGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, groupFQName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GitLabGroupResource>(response.GetRawResponse());
                return Response.FromValue(new GitLabGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GitLabGroupResource> IEnumerable<GitLabGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GitLabGroupResource> IAsyncEnumerable<GitLabGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
