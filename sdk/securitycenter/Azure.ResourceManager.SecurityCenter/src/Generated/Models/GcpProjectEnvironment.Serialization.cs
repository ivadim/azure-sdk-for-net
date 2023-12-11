// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpProjectEnvironment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OrganizationalData))
            {
                writer.WritePropertyName("organizationalData"u8);
                writer.WriteObjectValue(OrganizationalData);
            }
            if (Optional.IsDefined(ProjectDetails))
            {
                writer.WritePropertyName("projectDetails"u8);
                writer.WriteObjectValue(ProjectDetails);
            }
            if (Optional.IsDefined(ScanInterval))
            {
                writer.WritePropertyName("scanInterval"u8);
                writer.WriteNumberValue(ScanInterval.Value);
            }
            writer.WritePropertyName("environmentType"u8);
            writer.WriteStringValue(EnvironmentType.ToString());
            writer.WriteEndObject();
        }

        internal static GcpProjectEnvironment DeserializeGcpProjectEnvironment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GcpOrganizationalInfo> organizationalData = default;
            Optional<GcpProjectDetails> projectDetails = default;
            Optional<long> scanInterval = default;
            EnvironmentType environmentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationalData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    organizationalData = GcpOrganizationalInfo.DeserializeGcpOrganizationalInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("projectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectDetails = GcpProjectDetails.DeserializeGcpProjectDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("scanInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scanInterval = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("environmentType"u8))
                {
                    environmentType = new EnvironmentType(property.Value.GetString());
                    continue;
                }
            }
            return new GcpProjectEnvironment(environmentType, organizationalData.Value, projectDetails.Value, Optional.ToNullable(scanInterval));
        }
    }
}
