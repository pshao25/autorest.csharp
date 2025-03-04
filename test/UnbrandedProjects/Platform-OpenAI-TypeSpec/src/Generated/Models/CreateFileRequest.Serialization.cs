// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateFileRequest : IJsonModel<CreateFileRequest>
    {
        void IJsonModel<CreateFileRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateFileRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateFileRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("file"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(global::System.BinaryData.FromStream(File));
#else
            using (JsonDocument document = JsonDocument.Parse(BinaryData.FromStream(File)))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("purpose"u8);
            writer.WriteStringValue(Purpose);
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

        CreateFileRequest IJsonModel<CreateFileRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateFileRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateFileRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateFileRequest(document.RootElement, options);
        }

        internal static CreateFileRequest DeserializeCreateFileRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Stream file = default;
            string purpose = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file"u8))
                {
                    file = BinaryData.FromString(property.Value.GetRawText()).ToStream();
                    continue;
                }
                if (property.NameEquals("purpose"u8))
                {
                    purpose = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CreateFileRequest(file, purpose, serializedAdditionalRawData);
        }

        private BinaryData SerializeMultipart(ModelReaderWriterOptions options)
        {
            using MultipartFormDataBinaryContent content = ToMultipartBinaryBody();
            using MemoryStream stream = new MemoryStream();
            content.WriteTo(stream);
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        internal virtual MultipartFormDataBinaryContent ToMultipartBinaryBody()
        {
            MultipartFormDataBinaryContent content = new MultipartFormDataBinaryContent();
            content.Add(File, "file", "file", "application/octet-stream");
            content.Add(Purpose, "purpose");
            return content;
        }

        BinaryData IPersistableModel<CreateFileRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateFileRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "MFD":
                    return SerializeMultipart(options);
                default:
                    throw new FormatException($"The model {nameof(CreateFileRequest)} does not support writing '{options.Format}' format.");
            }
        }

        CreateFileRequest IPersistableModel<CreateFileRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateFileRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateFileRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateFileRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateFileRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "MFD";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateFileRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateFileRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
