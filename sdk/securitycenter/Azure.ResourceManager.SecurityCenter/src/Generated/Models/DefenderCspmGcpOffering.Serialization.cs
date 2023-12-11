// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmGcpOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CiemDiscovery))
            {
                writer.WritePropertyName("ciemDiscovery"u8);
                writer.WriteObjectValue(CiemDiscovery);
            }
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                writer.WriteObjectValue(VmScanners);
            }
            if (Optional.IsDefined(DataSensitivityDiscovery))
            {
                writer.WritePropertyName("dataSensitivityDiscovery"u8);
                writer.WriteObjectValue(DataSensitivityDiscovery);
            }
            if (Optional.IsDefined(MdcContainersImageAssessment))
            {
                writer.WritePropertyName("mdcContainersImageAssessment"u8);
                writer.WriteObjectValue(MdcContainersImageAssessment);
            }
            if (Optional.IsDefined(MdcContainersAgentlessDiscoveryK8S))
            {
                writer.WritePropertyName("mdcContainersAgentlessDiscoveryK8s"u8);
                writer.WriteObjectValue(MdcContainersAgentlessDiscoveryK8S);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static DefenderCspmGcpOffering DeserializeDefenderCspmGcpOffering(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderCspmGcpOfferingCiemDiscovery> ciemDiscovery = default;
            Optional<DefenderCspmGcpOfferingVmScanners> vmScanners = default;
            Optional<DefenderCspmGcpOfferingDataSensitivityDiscovery> dataSensitivityDiscovery = default;
            Optional<DefenderCspmGcpOfferingMdcContainersImageAssessment> mdcContainersImageAssessment = default;
            Optional<DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S> mdcContainersAgentlessDiscoveryK8s = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ciemDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciemDiscovery = DefenderCspmGcpOfferingCiemDiscovery.DeserializeDefenderCspmGcpOfferingCiemDiscovery(property.Value);
                    continue;
                }
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderCspmGcpOfferingVmScanners.DeserializeDefenderCspmGcpOfferingVmScanners(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSensitivityDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSensitivityDiscovery = DefenderCspmGcpOfferingDataSensitivityDiscovery.DeserializeDefenderCspmGcpOfferingDataSensitivityDiscovery(property.Value);
                    continue;
                }
                if (property.NameEquals("mdcContainersImageAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersImageAssessment = DefenderCspmGcpOfferingMdcContainersImageAssessment.DeserializeDefenderCspmGcpOfferingMdcContainersImageAssessment(property.Value);
                    continue;
                }
                if (property.NameEquals("mdcContainersAgentlessDiscoveryK8s"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersAgentlessDiscoveryK8s = DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S.DeserializeDefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderCspmGcpOffering(offeringType, description.Value, ciemDiscovery.Value, vmScanners.Value, dataSensitivityDiscovery.Value, mdcContainersImageAssessment.Value, mdcContainersAgentlessDiscoveryK8s.Value);
        }
    }
}
