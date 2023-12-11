// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Microsoft Defender Data Sensitivity discovery configuration. </summary>
    public partial class DefenderCspmGcpOfferingDataSensitivityDiscovery
    {
        /// <summary> Initializes a new instance of <see cref="DefenderCspmGcpOfferingDataSensitivityDiscovery"/>. </summary>
        public DefenderCspmGcpOfferingDataSensitivityDiscovery()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmGcpOfferingDataSensitivityDiscovery"/>. </summary>
        /// <param name="enabled"> Is Microsoft Defender Data Sensitivity discovery enabled. </param>
        /// <param name="workloadIdentityProviderId"> The workload identity provider id in GCP for this feature. </param>
        /// <param name="serviceAccountEmailAddress"> The service account email address in GCP for this feature. </param>
        internal DefenderCspmGcpOfferingDataSensitivityDiscovery(bool? enabled, string workloadIdentityProviderId, string serviceAccountEmailAddress)
        {
            Enabled = enabled;
            WorkloadIdentityProviderId = workloadIdentityProviderId;
            ServiceAccountEmailAddress = serviceAccountEmailAddress;
        }

        /// <summary> Is Microsoft Defender Data Sensitivity discovery enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The workload identity provider id in GCP for this feature. </summary>
        public string WorkloadIdentityProviderId { get; set; }
        /// <summary> The service account email address in GCP for this feature. </summary>
        public string ServiceAccountEmailAddress { get; set; }
    }
}
