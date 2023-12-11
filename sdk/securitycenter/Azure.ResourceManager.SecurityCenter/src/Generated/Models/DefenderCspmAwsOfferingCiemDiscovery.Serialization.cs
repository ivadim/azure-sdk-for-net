// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class DefenderCspmAwsOfferingCiemDiscovery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
            }
            writer.WriteEndObject();
        }

        internal static DefenderCspmAwsOfferingCiemDiscovery DeserializeDefenderCspmAwsOfferingCiemDiscovery(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cloudRoleArn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderCspmAwsOfferingCiemDiscovery(cloudRoleArn.Value);
        }
    }
}
