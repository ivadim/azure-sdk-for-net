// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class HealthDataClassification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Component))
            {
                writer.WritePropertyName("component"u8);
                writer.WriteStringValue(Component);
            }
            if (Optional.IsDefined(Scenario))
            {
                writer.WritePropertyName("scenario"u8);
                writer.WriteStringValue(Scenario);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            writer.WriteEndObject();
        }

        internal static HealthDataClassification DeserializeHealthDataClassification(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> component = default;
            Optional<string> scenario = default;
            Optional<string> scope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("component"u8))
                {
                    component = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scenario"u8))
                {
                    scenario = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
            }
            return new HealthDataClassification(component.Value, scenario.Value, scope.Value);
        }
    }
}
