// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The CSPM (Cloud security posture management) monitoring for gitlab offering. </summary>
    public partial class CspmMonitorGitLabOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of <see cref="CspmMonitorGitLabOffering"/>. </summary>
        public CspmMonitorGitLabOffering()
        {
            OfferingType = OfferingType.CspmMonitorGitLab;
        }

        /// <summary> Initializes a new instance of <see cref="CspmMonitorGitLabOffering"/>. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        internal CspmMonitorGitLabOffering(OfferingType offeringType, string description) : base(offeringType, description)
        {
            OfferingType = offeringType;
        }
    }
}
