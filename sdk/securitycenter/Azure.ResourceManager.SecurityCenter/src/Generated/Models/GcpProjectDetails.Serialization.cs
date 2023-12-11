// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpProjectDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProjectNumber))
            {
                writer.WritePropertyName("projectNumber"u8);
                writer.WriteStringValue(ProjectNumber);
            }
            if (Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteStringValue(ProjectId);
            }
            writer.WriteEndObject();
        }

        internal static GcpProjectDetails DeserializeGcpProjectDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> projectNumber = default;
            Optional<string> projectId = default;
            Optional<string> workloadIdentityPoolId = default;
            Optional<string> projectName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectNumber"u8))
                {
                    projectNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    projectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityPoolId"u8))
                {
                    workloadIdentityPoolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
            }
            return new GcpProjectDetails(projectNumber.Value, projectId.Value, workloadIdentityPoolId.Value, projectName.Value);
        }
    }
}
