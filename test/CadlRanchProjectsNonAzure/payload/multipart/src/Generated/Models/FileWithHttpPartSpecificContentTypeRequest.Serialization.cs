// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Payload.MultiPart.Models
{
    public partial class FileWithHttpPartSpecificContentTypeRequest : IJsonModel<FileWithHttpPartSpecificContentTypeRequest>
    {
        void IJsonModel<FileWithHttpPartSpecificContentTypeRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileWithHttpPartSpecificContentTypeRequest)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("profileImage"u8);
            writer.WriteObjectValue(ProfileImage, options);
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
        }

        FileWithHttpPartSpecificContentTypeRequest IJsonModel<FileWithHttpPartSpecificContentTypeRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileWithHttpPartSpecificContentTypeRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileWithHttpPartSpecificContentTypeRequest(document.RootElement, options);
        }

        internal static FileWithHttpPartSpecificContentTypeRequest DeserializeFileWithHttpPartSpecificContentTypeRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FileSpecificContentType profileImage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileImage"u8))
                {
                    profileImage = FileSpecificContentType.DeserializeFileSpecificContentType(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FileWithHttpPartSpecificContentTypeRequest(profileImage, serializedAdditionalRawData);
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
            content.Add(ModelReaderWriter.Write(ProfileImage, ModelSerializationExtensions.WireOptions), "profileImage");
            return content;
        }

        BinaryData IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "MFD":
                    return SerializeMultipart(options);
                default:
                    throw new FormatException($"The model {nameof(FileWithHttpPartSpecificContentTypeRequest)} does not support writing '{options.Format}' format.");
            }
        }

        FileWithHttpPartSpecificContentTypeRequest IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileWithHttpPartSpecificContentTypeRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileWithHttpPartSpecificContentTypeRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileWithHttpPartSpecificContentTypeRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "MFD";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static FileWithHttpPartSpecificContentTypeRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFileWithHttpPartSpecificContentTypeRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
