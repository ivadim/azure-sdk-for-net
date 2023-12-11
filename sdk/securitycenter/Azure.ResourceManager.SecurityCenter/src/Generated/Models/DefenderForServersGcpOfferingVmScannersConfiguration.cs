// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> configuration for Microsoft Defender for Server VM scanning. </summary>
    public partial class DefenderForServersGcpOfferingVmScannersConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="DefenderForServersGcpOfferingVmScannersConfiguration"/>. </summary>
        public DefenderForServersGcpOfferingVmScannersConfiguration()
        {
            ExclusionTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForServersGcpOfferingVmScannersConfiguration"/>. </summary>
        /// <param name="scanningMode"> The scanning mode for the VM scan. </param>
        /// <param name="exclusionTags"> VM tags that indicate that VM should not be scanned. </param>
        internal DefenderForServersGcpOfferingVmScannersConfiguration(DefenderForServersScanningMode? scanningMode, IDictionary<string, string> exclusionTags)
        {
            ScanningMode = scanningMode;
            ExclusionTags = exclusionTags;
        }

        /// <summary> The scanning mode for the VM scan. </summary>
        public DefenderForServersScanningMode? ScanningMode { get; set; }
        /// <summary> VM tags that indicate that VM should not be scanned. </summary>
        public IDictionary<string, string> ExclusionTags { get; }
    }
}
