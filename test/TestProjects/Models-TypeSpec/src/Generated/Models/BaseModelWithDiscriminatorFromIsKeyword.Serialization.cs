// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    [PersistableModelProxy(typeof(UnknownBaseModelWithDiscriminatorFromIsKeyword))]
    public partial class BaseModelWithDiscriminatorFromIsKeyword : IUtf8JsonSerializable, IJsonModel<BaseModelWithDiscriminatorFromIsKeyword>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BaseModelWithDiscriminatorFromIsKeyword>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BaseModelWithDiscriminatorFromIsKeyword>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorFromIsKeyword)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(OptionalString))
            {
                writer.WritePropertyName("optionalString"u8);
                writer.WriteStringValue(OptionalString);
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

        BaseModelWithDiscriminatorFromIsKeyword IJsonModel<BaseModelWithDiscriminatorFromIsKeyword>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorFromIsKeyword)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBaseModelWithDiscriminatorFromIsKeyword(document.RootElement, options);
        }

        internal static BaseModelWithDiscriminatorFromIsKeyword DeserializeBaseModelWithDiscriminatorFromIsKeyword(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "A": return DerivedWithDiscriminatorFromIsKeyword.DeserializeDerivedWithDiscriminatorFromIsKeyword(element, options);
                }
            }
            return UnknownBaseModelWithDiscriminatorFromIsKeyword.DeserializeUnknownBaseModelWithDiscriminatorFromIsKeyword(element, options);
        }

        BinaryData IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorFromIsKeyword)} does not support writing '{options.Format}' format.");
            }
        }

        BaseModelWithDiscriminatorFromIsKeyword IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBaseModelWithDiscriminatorFromIsKeyword(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BaseModelWithDiscriminatorFromIsKeyword)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BaseModelWithDiscriminatorFromIsKeyword>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BaseModelWithDiscriminatorFromIsKeyword FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBaseModelWithDiscriminatorFromIsKeyword(document.RootElement);
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
