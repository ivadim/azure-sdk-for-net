// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a GitHubOwner along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GitHubOwnerResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGitHubOwnerResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevOpsConfigurationResource"/> using the GetGitHubOwner method.
    /// </summary>
    public partial class GitHubOwnerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GitHubOwnerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="securityConnectorName"> The securityConnectorName. </param>
        /// <param name="ownerName"> The ownerName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _gitHubOwnerClientDiagnostics;
        private readonly GitHubOwnersRestOperations _gitHubOwnerRestClient;
        private readonly GitHubOwnerData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/securityConnectors/devops/gitHubOwners";

        /// <summary> Initializes a new instance of the <see cref="GitHubOwnerResource"/> class for mocking. </summary>
        protected GitHubOwnerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GitHubOwnerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GitHubOwnerResource(ArmClient client, GitHubOwnerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GitHubOwnerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GitHubOwnerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gitHubOwnerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string gitHubOwnerApiVersion);
            _gitHubOwnerRestClient = new GitHubOwnersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gitHubOwnerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GitHubOwnerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of GitHubRepositoryResources in the GitHubOwner. </summary>
        /// <returns> An object representing collection of GitHubRepositoryResources and their operations over a GitHubRepositoryResource. </returns>
        public virtual GitHubRepositoryCollection GetGitHubRepositories()
        {
            return GetCachedClient(client => new GitHubRepositoryCollection(client, Id));
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<GitHubRepositoryResource>> GetGitHubRepositoryAsync(string repoName, CancellationToken cancellationToken = default)
        {
            return await GetGitHubRepositories().GetAsync(repoName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<GitHubRepositoryResource> GetGitHubRepository(string repoName, CancellationToken cancellationToken = default)
        {
            return GetGitHubRepositories().Get(repoName, cancellationToken);
        }

        /// <summary>
        /// Returns a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GitHubOwnerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerResource.Get");
            scope.Start();
            try
            {
                var response = await _gitHubOwnerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GitHubOwnerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _gitHubOwnerClientDiagnostics.CreateScope("GitHubOwnerResource.Get");
            scope.Start();
            try
            {
                var response = _gitHubOwnerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
