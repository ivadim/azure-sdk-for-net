// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_DevOpsConfigurationResource
    {
        // ListAvailable_AzureDevOpsOrgs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableAzureDevOpsOrgs_ListAvailableAzureDevOpsOrgs()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListAvailableAzureDevOpsOrgs_example.json
            // this example is just showing the usage of "AzureDevOpsOrgs_ListAvailable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation and iterate over the result
            await foreach (AzureDevOpsOrgResource item in devOpsConfiguration.GetAvailableAzureDevOpsOrgsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AzureDevOpsOrgData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get_DevOpsConfigurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDevOpsConfigurations()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetDevOpsConfigurations_example.json
            // this example is just showing the usage of "DevOpsConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            DevOpsConfigurationResource result = await devOpsConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate_DevOpsConfigurations_OnboardCurrentAndFuture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateDevOpsConfigurationsOnboardCurrentAndFuture()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/CreateOrUpdateDevOpsConfigurationsOnboardCurrentAndFuture_example.json
            // this example is just showing the usage of "DevOpsConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            DevOpsConfigurationData data = new DevOpsConfigurationData()
            {
                Properties = new DevOpsConfigurationProperties()
                {
                    AuthorizationCode = "00000000000000000000",
                    AutoDiscovery = AutoDiscovery.Enabled,
                },
            };
            ArmOperation<DevOpsConfigurationResource> lro = await devOpsConfiguration.CreateOrUpdateAsync(WaitUntil.Completed, data);
            DevOpsConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate_DevOpsConfigurations_OnboardCurrentOnly
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateDevOpsConfigurationsOnboardCurrentOnly()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/CreateOrUpdateDevOpsConfigurationsOnboardCurrentOnly_example.json
            // this example is just showing the usage of "DevOpsConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            DevOpsConfigurationData data = new DevOpsConfigurationData()
            {
                Properties = new DevOpsConfigurationProperties()
                {
                    AuthorizationCode = "00000000000000000000",
                    AutoDiscovery = AutoDiscovery.Disabled,
                },
            };
            ArmOperation<DevOpsConfigurationResource> lro = await devOpsConfiguration.CreateOrUpdateAsync(WaitUntil.Completed, data);
            DevOpsConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate_DevOpsConfigurations_OnboardSelected
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateDevOpsConfigurationsOnboardSelected()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/CreateOrUpdateDevOpsConfigurationsOnboardSelected_example.json
            // this example is just showing the usage of "DevOpsConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            DevOpsConfigurationData data = new DevOpsConfigurationData()
            {
                Properties = new DevOpsConfigurationProperties()
                {
                    AuthorizationCode = "00000000000000000000",
                    AutoDiscovery = AutoDiscovery.Disabled,
                    TopLevelInventoryList =
{
"org1","org2"
},
                },
            };
            ArmOperation<DevOpsConfigurationResource> lro = await devOpsConfiguration.CreateOrUpdateAsync(WaitUntil.Completed, data);
            DevOpsConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update_DevOpsConfigurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateDevOpsConfigurations()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/UpdateDevOpsConfigurations_example.json
            // this example is just showing the usage of "DevOpsConfigurations_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            DevOpsConfigurationData data = new DevOpsConfigurationData()
            {
                Properties = new DevOpsConfigurationProperties()
                {
                    AutoDiscovery = AutoDiscovery.Enabled,
                },
            };
            ArmOperation<DevOpsConfigurationResource> lro = await devOpsConfiguration.UpdateAsync(WaitUntil.Completed, data);
            DevOpsConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete_DevOpsConfigurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDevOpsConfigurations()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/DeleteDevOpsConfigurations_example.json
            // this example is just showing the usage of "DevOpsConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            await devOpsConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ListAvailable_GitHubOwners
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableGitHubOwners_ListAvailableGitHubOwners()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListAvailableGitHubOwners_example.json
            // this example is just showing the usage of "GitHubOwners_ListAvailable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation and iterate over the result
            await foreach (GitHubOwnerResource item in devOpsConfiguration.GetAvailableGitHubOwnersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GitHubOwnerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ListAvailable_GitLabGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableGitLabGroups_ListAvailableGitLabGroups()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListAvailableGitLabGroups_example.json
            // this example is just showing the usage of "GitLabGroups_ListAvailable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation and iterate over the result
            await foreach (GitLabGroupResource item in devOpsConfiguration.GetAvailableGitLabGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GitLabGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get_DevOpsOperationResults_Failed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDevOpsOperationResult_GetDevOpsOperationResultsFailed()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetDevOpsOperationResultsFailed_example.json
            // this example is just showing the usage of "DevOpsOperationResults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            string operationResultId = "8d4caace-e7b3-4b3e-af99-73f76829ebcf";
            OperationStatusResult result = await devOpsConfiguration.GetDevOpsOperationResultAsync(operationResultId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get_DevOpsOperationResults_Succeeded
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDevOpsOperationResult_GetDevOpsOperationResultsSucceeded()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetDevOpsOperationResultsSucceeded_example.json
            // this example is just showing the usage of "DevOpsOperationResults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // invoke the operation
            string operationResultId = "4e826cf1-5c36-4808-a7d2-fb4f5170978b";
            OperationStatusResult result = await devOpsConfiguration.GetDevOpsOperationResultAsync(operationResultId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
