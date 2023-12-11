// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GitLabGroupProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(OnboardingState))
            {
                writer.WritePropertyName("onboardingState"u8);
                writer.WriteStringValue(OnboardingState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static GitLabGroupProperties DeserializeGitLabGroupProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningStatusMessage = default;
            Optional<DateTimeOffset> provisioningStatusUpdateTimeUtc = default;
            Optional<DevOpsProvisioningState> provisioningState = default;
            Optional<string> fullyQualifiedName = default;
            Optional<string> fullyQualifiedFriendlyName = default;
            Optional<Uri> url = default;
            Optional<OnboardingState> onboardingState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningStatusMessage"u8))
                {
                    provisioningStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatusUpdateTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatusUpdateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevOpsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fullyQualifiedName"u8))
                {
                    fullyQualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullyQualifiedFriendlyName"u8))
                {
                    fullyQualifiedFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onboardingState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onboardingState = new OnboardingState(property.Value.GetString());
                    continue;
                }
            }
            return new GitLabGroupProperties(provisioningStatusMessage.Value, Optional.ToNullable(provisioningStatusUpdateTimeUtc), Optional.ToNullable(provisioningState), fullyQualifiedName.Value, fullyQualifiedFriendlyName.Value, url.Value, Optional.ToNullable(onboardingState));
        }
    }
}
