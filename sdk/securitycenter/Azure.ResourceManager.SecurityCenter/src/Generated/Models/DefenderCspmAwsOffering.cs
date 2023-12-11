// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The CSPM P1 for AWS offering. </summary>
    public partial class DefenderCspmAwsOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOffering"/>. </summary>
        public DefenderCspmAwsOffering()
        {
            OfferingType = OfferingType.DefenderCspmAws;
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOffering"/>. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="vmScanners"> The Microsoft Defender for Server VM scanning configuration. </param>
        /// <param name="dataSensitivityDiscovery"> The Microsoft Defender Data Sensitivity discovery configuration. </param>
        /// <param name="databasesDspm"> The databases DSPM configuration. </param>
        /// <param name="ciem"> Defenders CSPM Cloud infrastructure entitlement management (CIEM) offering configurations. </param>
        /// <param name="mdcContainersImageAssessment"> The Microsoft Defender container image assessment configuration. </param>
        /// <param name="mdcContainersAgentlessDiscoveryK8S"> The Microsoft Defender container agentless discovery K8s configuration. </param>
        internal DefenderCspmAwsOffering(OfferingType offeringType, string description, DefenderCspmAwsOfferingVmScanners vmScanners, DefenderCspmAwsOfferingDataSensitivityDiscovery dataSensitivityDiscovery, DefenderCspmAwsOfferingDatabasesDspm databasesDspm, DefenderCspmAwsOfferingCiem ciem, DefenderCspmAwsOfferingMdcContainersImageAssessment mdcContainersImageAssessment, DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S) : base(offeringType, description)
        {
            VmScanners = vmScanners;
            DataSensitivityDiscovery = dataSensitivityDiscovery;
            DatabasesDspm = databasesDspm;
            Ciem = ciem;
            MdcContainersImageAssessment = mdcContainersImageAssessment;
            MdcContainersAgentlessDiscoveryK8S = mdcContainersAgentlessDiscoveryK8S;
            OfferingType = offeringType;
        }

        /// <summary> The Microsoft Defender for Server VM scanning configuration. </summary>
        public DefenderCspmAwsOfferingVmScanners VmScanners { get; set; }
        /// <summary> The Microsoft Defender Data Sensitivity discovery configuration. </summary>
        public DefenderCspmAwsOfferingDataSensitivityDiscovery DataSensitivityDiscovery { get; set; }
        /// <summary> The databases DSPM configuration. </summary>
        public DefenderCspmAwsOfferingDatabasesDspm DatabasesDspm { get; set; }
        /// <summary> Defenders CSPM Cloud infrastructure entitlement management (CIEM) offering configurations. </summary>
        public DefenderCspmAwsOfferingCiem Ciem { get; set; }
        /// <summary> The Microsoft Defender container image assessment configuration. </summary>
        public DefenderCspmAwsOfferingMdcContainersImageAssessment MdcContainersImageAssessment { get; set; }
        /// <summary> The Microsoft Defender container agentless discovery K8s configuration. </summary>
        public DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S MdcContainersAgentlessDiscoveryK8S { get; set; }
    }
}
