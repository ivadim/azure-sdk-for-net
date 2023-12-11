// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Microsoft Defender Container image assessment configuration. </summary>
    public partial class DefenderCspmGcpOfferingMdcContainersImageAssessment
    {
        /// <summary> Initializes a new instance of <see cref="DefenderCspmGcpOfferingMdcContainersImageAssessment"/>. </summary>
        public DefenderCspmGcpOfferingMdcContainersImageAssessment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmGcpOfferingMdcContainersImageAssessment"/>. </summary>
        /// <param name="enabled"> Is Microsoft Defender container image assessment enabled. </param>
        /// <param name="workloadIdentityProviderId"> The workload identity provider id in GCP for this feature. </param>
        /// <param name="serviceAccountEmailAddress"> The service account email address in GCP for this feature. </param>
        internal DefenderCspmGcpOfferingMdcContainersImageAssessment(bool? enabled, string workloadIdentityProviderId, string serviceAccountEmailAddress)
        {
            Enabled = enabled;
            WorkloadIdentityProviderId = workloadIdentityProviderId;
            ServiceAccountEmailAddress = serviceAccountEmailAddress;
        }

        /// <summary> Is Microsoft Defender container image assessment enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The workload identity provider id in GCP for this feature. </summary>
        public string WorkloadIdentityProviderId { get; set; }
        /// <summary> The service account email address in GCP for this feature. </summary>
        public string ServiceAccountEmailAddress { get; set; }
    }
}
