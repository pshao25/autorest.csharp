// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    internal partial class SecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionAtHost))
            {
                writer.WritePropertyName("encryptionAtHost");
                writer.WriteBooleanValue(EncryptionAtHost.Value);
            }
            writer.WriteEndObject();
        }

        internal static SecurityProfile DeserializeSecurityProfile(JsonElement element)
        {
            Optional<bool> encryptionAtHost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SecurityProfile(Optional.ToNullable(encryptionAtHost));
        }
    }
}
