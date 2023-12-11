// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GitHubOwnerProperties : IUtf8JsonSerializable
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

        internal static GitHubOwnerProperties DeserializeGitHubOwnerProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningStatusMessage = default;
            Optional<DateTimeOffset> provisioningStatusUpdateTimeUtc = default;
            Optional<DevOpsProvisioningState> provisioningState = default;
            Optional<Uri> ownerUrl = default;
            Optional<string> gitHubInternalId = default;
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
                if (property.NameEquals("ownerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gitHubInternalId"u8))
                {
                    gitHubInternalId = property.Value.GetString();
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
            return new GitHubOwnerProperties(provisioningStatusMessage.Value, Optional.ToNullable(provisioningStatusUpdateTimeUtc), Optional.ToNullable(provisioningState), ownerUrl.Value, gitHubInternalId.Value, Optional.ToNullable(onboardingState));
        }
    }
}
