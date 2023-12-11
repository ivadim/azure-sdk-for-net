// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForDatabasesAwsOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                writer.WriteObjectValue(ArcAutoProvisioning);
            }
            if (Optional.IsDefined(Rds))
            {
                writer.WritePropertyName("rds"u8);
                writer.WriteObjectValue(Rds);
            }
            if (Optional.IsDefined(DatabasesDspm))
            {
                writer.WritePropertyName("databasesDspm"u8);
                writer.WriteObjectValue(DatabasesDspm);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static DefenderForDatabasesAwsOffering DeserializeDefenderForDatabasesAwsOffering(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderForDatabasesAwsOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForDatabasesAwsOfferingRds> rds = default;
            Optional<DefenderFoDatabasesAwsOfferingDatabasesDspm> databasesDspm = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForDatabasesAwsOfferingArcAutoProvisioning.DeserializeDefenderForDatabasesAwsOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("rds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rds = DefenderForDatabasesAwsOfferingRds.DeserializeDefenderForDatabasesAwsOfferingRds(property.Value);
                    continue;
                }
                if (property.NameEquals("databasesDspm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databasesDspm = DefenderFoDatabasesAwsOfferingDatabasesDspm.DeserializeDefenderFoDatabasesAwsOfferingDatabasesDspm(property.Value);
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
            return new DefenderForDatabasesAwsOffering(offeringType, description.Value, arcAutoProvisioning.Value, rds.Value, databasesDspm.Value);
        }
    }
}
