// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    internal partial class AutomaticOSUpgradeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("automaticOSUpgradeSupported");
            writer.WriteBooleanValue(AutomaticOSUpgradeSupported);
            writer.WriteEndObject();
        }

        internal static AutomaticOSUpgradeProperties DeserializeAutomaticOSUpgradeProperties(JsonElement element)
        {
            bool automaticOSUpgradeSupported = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automaticOSUpgradeSupported"))
                {
                    automaticOSUpgradeSupported = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AutomaticOSUpgradeProperties(automaticOSUpgradeSupported);
        }
    }
}
