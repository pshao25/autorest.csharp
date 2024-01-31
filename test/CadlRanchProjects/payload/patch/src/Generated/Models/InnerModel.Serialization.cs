// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Microsoft.Extensions.Options;

namespace Payload.JsonMergePatch.Models
{
    public partial class InnerModel : IUtf8JsonSerializable, IJsonModel<InnerModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InnerModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InnerModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" || options.Format == "JMP" ? ((IPersistableModel<InnerModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InnerModel)} does not support '{format}' format.");
            }

            if (options.Format == "W")
            {
                WriteJson(writer, options);
            }
            else if (options.Format == "JMP")
            {
                WritePatch(writer);
            }
        }

        internal void WriteJson(Utf8JsonWriter writer, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IntValue))
            {
                writer.WritePropertyName("intValue"u8);
                writer.WriteNumberValue(IntValue.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal void WritePatch(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (_descriptionChanged)
            {
                writer.WritePropertyName("description"u8);
                if (_description != null)
                {
                    writer.WriteStringValue(_description);
                }
                else
                {
                    writer.WriteNullValue();
                }
            }
            if (_intValueChanged)
            {
                writer.WritePropertyName("intValue"u8);
                if (_intValue != null)
                {
                    writer.WriteNumberValue(_intValue.Value);
                }
                else
                {
                    writer.WriteNullValue();
                }
            }
            writer.WriteEndObject();
        }

        InnerModel IJsonModel<InnerModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InnerModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InnerModel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInnerModel(document.RootElement, options);
        }

        internal static InnerModel DeserializeInnerModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            Optional<int> intValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intValue = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InnerModel(name, description.Value, Optional.ToNullable(intValue), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InnerModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" || options.Format == "JMP" ? ((IPersistableModel<InnerModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InnerModel)} does not support '{options.Format}' format.");
            }
        }

        InnerModel IPersistableModel<InnerModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InnerModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInnerModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InnerModel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InnerModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static InnerModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInnerModel(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
