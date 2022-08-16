// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace dpg_initial_LowLevel
{
    public partial class PostInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url");
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }

        internal static PostInput DeserializePostInput(JsonElement element)
        {
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new PostInput(url);
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static PostInput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePostInput(document.RootElement);
        }
    }
}
