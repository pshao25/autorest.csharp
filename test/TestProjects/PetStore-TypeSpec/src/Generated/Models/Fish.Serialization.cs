// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace PetStore.Models
{
    [PersistableModelProxy(typeof(UnknownFish))]
    public partial class Fish : IUtf8JsonSerializable, IJsonModel<Fish>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Fish>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<Fish>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Fish)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("size"u8);
            writer.WriteNumberValue(Size);
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

        Fish IJsonModel<Fish>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Fish)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFish(document.RootElement, options);
        }

        internal static Fish DeserializeFish(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "shark": return Shark.DeserializeShark(element, options);
                    case "tuna": return Tuna.DeserializeTuna(element, options);
                }
            }
            return UnknownFish.DeserializeUnknownFish(element, options);
        }

        BinaryData IPersistableModel<Fish>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Fish)} does not support writing '{options.Format}' format.");
            }
        }

        Fish IPersistableModel<Fish>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Fish>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFish(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Fish)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Fish>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Fish FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFish(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
