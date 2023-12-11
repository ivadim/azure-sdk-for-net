// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The containers GCP offering. </summary>
    public partial class DefenderForContainersGcpOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of <see cref="DefenderForContainersGcpOffering"/>. </summary>
        public DefenderForContainersGcpOffering()
        {
            OfferingType = OfferingType.DefenderForContainersGcp;
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForContainersGcpOffering"/>. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="nativeCloudConnection"> The native cloud connection configuration. </param>
        /// <param name="dataPipelineNativeCloudConnection"> The native cloud connection configuration. </param>
        /// <param name="isAuditLogsAutoProvisioningEnabled"> Is audit logs data collection enabled. </param>
        /// <param name="isDefenderAgentAutoProvisioningEnabled"> Is Microsoft Defender for Cloud Kubernetes agent auto provisioning enabled. </param>
        /// <param name="isPolicyAgentAutoProvisioningEnabled"> Is Policy Kubernetes agent auto provisioning enabled. </param>
        /// <param name="mdcContainersImageAssessment"> The Microsoft Defender Container image assessment configuration. </param>
        /// <param name="mdcContainersAgentlessDiscoveryK8S"> The Microsoft Defender Container agentless discovery configuration. </param>
        internal DefenderForContainersGcpOffering(OfferingType offeringType, string description, DefenderForContainersGcpOfferingNativeCloudConnection nativeCloudConnection, DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection dataPipelineNativeCloudConnection, bool? isAuditLogsAutoProvisioningEnabled, bool? isDefenderAgentAutoProvisioningEnabled, bool? isPolicyAgentAutoProvisioningEnabled, DefenderForContainersGcpOfferingMdcContainersImageAssessment mdcContainersImageAssessment, DefenderForContainersGcpOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S) : base(offeringType, description)
        {
            NativeCloudConnection = nativeCloudConnection;
            DataPipelineNativeCloudConnection = dataPipelineNativeCloudConnection;
            IsAuditLogsAutoProvisioningEnabled = isAuditLogsAutoProvisioningEnabled;
            IsDefenderAgentAutoProvisioningEnabled = isDefenderAgentAutoProvisioningEnabled;
            IsPolicyAgentAutoProvisioningEnabled = isPolicyAgentAutoProvisioningEnabled;
            MdcContainersImageAssessment = mdcContainersImageAssessment;
            MdcContainersAgentlessDiscoveryK8S = mdcContainersAgentlessDiscoveryK8S;
            OfferingType = offeringType;
        }

        /// <summary> The native cloud connection configuration. </summary>
        public DefenderForContainersGcpOfferingNativeCloudConnection NativeCloudConnection { get; set; }
        /// <summary> The native cloud connection configuration. </summary>
        public DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection DataPipelineNativeCloudConnection { get; set; }
        /// <summary> Is audit logs data collection enabled. </summary>
        public bool? IsAuditLogsAutoProvisioningEnabled { get; set; }
        /// <summary> Is Microsoft Defender for Cloud Kubernetes agent auto provisioning enabled. </summary>
        public bool? IsDefenderAgentAutoProvisioningEnabled { get; set; }
        /// <summary> Is Policy Kubernetes agent auto provisioning enabled. </summary>
        public bool? IsPolicyAgentAutoProvisioningEnabled { get; set; }
        /// <summary> The Microsoft Defender Container image assessment configuration. </summary>
        public DefenderForContainersGcpOfferingMdcContainersImageAssessment MdcContainersImageAssessment { get; set; }
        /// <summary> The Microsoft Defender Container agentless discovery configuration. </summary>
        public DefenderForContainersGcpOfferingMdcContainersAgentlessDiscoveryK8S MdcContainersAgentlessDiscoveryK8S { get; set; }
    }
}
