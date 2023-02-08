// Copyright(c) Microsoft Corporation.All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace ModelsVisibility.Generated.Models
{
    internal partial class VisibilityModelPutRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("createProp"u8);
            writer.WriteStringValue(CreateProp);
            writer.WritePropertyName("updateProp"u8);
            writer.WriteStringValue(UpdateProp);
            writer.WritePropertyName("otherProp"u8);
            writer.WriteStringValue(OtherProp);
            writer.WriteEndObject();
        }

        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
