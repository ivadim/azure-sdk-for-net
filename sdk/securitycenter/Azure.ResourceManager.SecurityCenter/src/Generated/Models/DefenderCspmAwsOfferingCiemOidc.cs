// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Defender CSPM CIEM AWS OIDC (open id connect) configuration. </summary>
    public partial class DefenderCspmAwsOfferingCiemOidc
    {
        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingCiemOidc"/>. </summary>
        public DefenderCspmAwsOfferingCiemOidc()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingCiemOidc"/>. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for CIEM oidc connection. </param>
        /// <param name="azureActiveDirectoryAppName"> the azure active directory app name used of authenticating against AWS. </param>
        internal DefenderCspmAwsOfferingCiemOidc(string cloudRoleArn, string azureActiveDirectoryAppName)
        {
            CloudRoleArn = cloudRoleArn;
            AzureActiveDirectoryAppName = azureActiveDirectoryAppName;
        }

        /// <summary> The cloud role ARN in AWS for CIEM oidc connection. </summary>
        public string CloudRoleArn { get; set; }
        /// <summary> the azure active directory app name used of authenticating against AWS. </summary>
        public string AzureActiveDirectoryAppName { get; set; }
    }
}
