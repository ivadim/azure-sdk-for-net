// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmGcpOfferingVmScannersConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScanningMode))
            {
                writer.WritePropertyName("scanningMode"u8);
                writer.WriteStringValue(ScanningMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExclusionTags))
            {
                writer.WritePropertyName("exclusionTags"u8);
                writer.WriteStartObject();
                foreach (var item in ExclusionTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static DefenderCspmGcpOfferingVmScannersConfiguration DeserializeDefenderCspmGcpOfferingVmScannersConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderForServersScanningMode> scanningMode = default;
            Optional<IDictionary<string, string>> exclusionTags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scanningMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scanningMode = new DefenderForServersScanningMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusionTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    exclusionTags = dictionary;
                    continue;
                }
            }
            return new DefenderCspmGcpOfferingVmScannersConfiguration(Optional.ToNullable(scanningMode), Optional.ToDictionary(exclusionTags));
        }
    }
}
