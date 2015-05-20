// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.RemoteApp;

namespace Microsoft.WindowsAzure.Management.RemoteApp
{
    /// <summary>
    /// RmoteApp management client
    /// </summary>
    public partial class RemoteAppManagementClient : ServiceClient<RemoteAppManagementClient>, IRemoteAppManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _rdfeNamespace;
        
        /// <summary>
        /// RDFE namespace for accessing test environments.
        /// </summary>
        public string RdfeNamespace
        {
            get { return this._rdfeNamespace; }
            set { this._rdfeNamespace = value; }
        }
        
        private IAccountsOperations _account;
        
        /// <summary>
        /// Operations related to RemoteApp account.
        /// </summary>
        public virtual IAccountsOperations Account
        {
            get { return this._account; }
        }
        
        private ICollectionOperations _collections;
        
        /// <summary>
        /// RemoteApp collection operations.
        /// </summary>
        public virtual ICollectionOperations Collections
        {
            get { return this._collections; }
        }
        
        private IOperationResultOperations _operationResults;
        
        /// <summary>
        /// Operations for long-running operation results
        /// </summary>
        public virtual IOperationResultOperations OperationResults
        {
            get { return this._operationResults; }
        }
        
        private IPrincipalOperations _principals;
        
        /// <summary>
        /// RemoteApp principal operations.
        /// </summary>
        public virtual IPrincipalOperations Principals
        {
            get { return this._principals; }
        }
        
        private IPublishingOperations _publishing;
        
        /// <summary>
        /// Operations related to publishing.
        /// </summary>
        public virtual IPublishingOperations Publishing
        {
            get { return this._publishing; }
        }
        
        private ITemplateImageOperations _templateImages;
        
        /// <summary>
        /// Operations to create, modify, list, and delete template images.
        /// </summary>
        public virtual ITemplateImageOperations TemplateImages
        {
            get { return this._templateImages; }
        }
        
        private IVNetOperations _vNet;
        
        /// <summary>
        /// RemoteApp virtual network operations.
        /// </summary>
        public virtual IVNetOperations VNet
        {
            get { return this._vNet; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoteAppManagementClient class.
        /// </summary>
        public RemoteAppManagementClient()
            : base()
        {
            this._account = new AccountsOperations(this);
            this._collections = new CollectionOperations(this);
            this._operationResults = new OperationResultOperations(this);
            this._principals = new PrincipalOperations(this);
            this._publishing = new PublishingOperations(this);
            this._templateImages = new TemplateImageOperations(this);
            this._vNet = new VNetOperations(this);
            this._rdfeNamespace = "remoteapp";
            this._apiVersion = "2014-09-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoteAppManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public RemoteAppManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoteAppManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public RemoteAppManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoteAppManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RemoteAppManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._account = new AccountsOperations(this);
            this._collections = new CollectionOperations(this);
            this._operationResults = new OperationResultOperations(this);
            this._principals = new PrincipalOperations(this);
            this._publishing = new PublishingOperations(this);
            this._templateImages = new TemplateImageOperations(this);
            this._vNet = new VNetOperations(this);
            this._rdfeNamespace = "remoteapp";
            this._apiVersion = "2014-09-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoteAppManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RemoteAppManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoteAppManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RemoteAppManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// RemoteAppManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of RemoteAppManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<RemoteAppManagementClient> client)
        {
            base.Clone(client);
            
            if (client is RemoteAppManagementClient)
            {
                RemoteAppManagementClient clonedClient = ((RemoteAppManagementClient)client);
                
                clonedClient._rdfeNamespace = this._rdfeNamespace;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
