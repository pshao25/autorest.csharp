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

namespace CustomizationsInTsp.Models
{
    public partial class RootModel : IUtf8JsonSerializable, IJsonModel<RootModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RootModel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RootModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RootModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RootModel)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PropertyExtensibleEnum))
            {
                writer.WritePropertyName("propertyExtensibleEnum"u8);
                writer.WriteStringValue(PropertyExtensibleEnum.Value.ToString());
            }
            if (Optional.IsDefined(PropertyModelToMakeInternal))
            {
                writer.WritePropertyName("propertyModelToMakeInternal"u8);
                writer.WriteObjectValue<ModelToMakeInternal>(PropertyModelToMakeInternal, options);
            }
            if (Optional.IsDefined(PropertyModelToRename))
            {
                writer.WritePropertyName("propertyModelToRename"u8);
                writer.WriteObjectValue(PropertyModelToRename, options);
            }
            if (Optional.IsDefined(PropertyModelToChangeNamespace))
            {
                writer.WritePropertyName("propertyModelToChangeNamespace"u8);
                writer.WriteObjectValue(PropertyModelToChangeNamespace, options);
            }
            if (Optional.IsDefined(PropertyModelWithCustomizedProperties))
            {
                writer.WritePropertyName("propertyModelWithCustomizedProperties"u8);
                writer.WriteObjectValue(PropertyModelWithCustomizedProperties, options);
            }
            if (Optional.IsDefined(PropertyEnumToRename))
            {
                writer.WritePropertyName("propertyEnumToRename"u8);
                writer.WriteStringValue(PropertyEnumToRename.Value.ToSerialString());
            }
            if (Optional.IsDefined(PropertyEnumWithValueToRename))
            {
                writer.WritePropertyName("propertyEnumWithValueToRename"u8);
                writer.WriteStringValue(PropertyEnumWithValueToRename.Value.ToSerialString());
            }
            if (Optional.IsDefined(PropertyEnumToBeMadeExtensible))
            {
                writer.WritePropertyName("propertyEnumToBeMadeExtensible"u8);
                writer.WriteStringValue(PropertyEnumToBeMadeExtensible.Value.ToString());
            }
            if (Optional.IsDefined(PropertyModelToAddAdditionalSerializableProperty))
            {
                writer.WritePropertyName("propertyModelToAddAdditionalSerializableProperty"u8);
                writer.WriteObjectValue(PropertyModelToAddAdditionalSerializableProperty, options);
            }
            if (Optional.IsDefined(PropertyToMoveToCustomization))
            {
                writer.WritePropertyName("propertyToMoveToCustomization"u8);
                writer.WriteStringValue(PropertyToMoveToCustomization.Value.ToString());
            }
            if (Optional.IsDefined(PropertyModelStruct))
            {
                writer.WritePropertyName("propertyModelStruct"u8);
                writer.WriteObjectValue(PropertyModelStruct, options);
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
        }

        RootModel IJsonModel<RootModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RootModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RootModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRootModel(document.RootElement, options);
        }

        internal static RootModel DeserializeRootModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtensibleEnumWithOperator? propertyExtensibleEnum = default;
            ModelToMakeInternal propertyModelToMakeInternal = default;
            RenamedModel propertyModelToRename = default;
            ModelToChangeNamespace propertyModelToChangeNamespace = default;
            ModelWithCustomizedProperties propertyModelWithCustomizedProperties = default;
            RenamedEnum? propertyEnumToRename = default;
            EnumWithValueToRename? propertyEnumWithValueToRename = default;
            EnumToBeMadeExtensible? propertyEnumToBeMadeExtensible = default;
            ModelToAddAdditionalSerializableProperty propertyModelToAddAdditionalSerializableProperty = default;
            NormalEnum? propertyToMoveToCustomization = default;
            ModelStruct? propertyModelStruct = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyExtensibleEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyExtensibleEnum = new ExtensibleEnumWithOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyModelToMakeInternal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyModelToMakeInternal = ModelToMakeInternal.DeserializeModelToMakeInternal(property.Value, options);
                    continue;
                }
                if (property.NameEquals("propertyModelToRename"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyModelToRename = RenamedModel.DeserializeRenamedModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("propertyModelToChangeNamespace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyModelToChangeNamespace = ModelToChangeNamespace.DeserializeModelToChangeNamespace(property.Value, options);
                    continue;
                }
                if (property.NameEquals("propertyModelWithCustomizedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyModelWithCustomizedProperties = ModelWithCustomizedProperties.DeserializeModelWithCustomizedProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("propertyEnumToRename"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyEnumToRename = property.Value.GetString().ToRenamedEnum();
                    continue;
                }
                if (property.NameEquals("propertyEnumWithValueToRename"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyEnumWithValueToRename = property.Value.GetString().ToEnumWithValueToRename();
                    continue;
                }
                if (property.NameEquals("propertyEnumToBeMadeExtensible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyEnumToBeMadeExtensible = new EnumToBeMadeExtensible(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyModelToAddAdditionalSerializableProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyModelToAddAdditionalSerializableProperty = ModelToAddAdditionalSerializableProperty.DeserializeModelToAddAdditionalSerializableProperty(property.Value, options);
                    continue;
                }
                if (property.NameEquals("propertyToMoveToCustomization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyToMoveToCustomization = new NormalEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyModelStruct"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyModelStruct = ModelStruct.DeserializeModelStruct(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RootModel(
                propertyExtensibleEnum,
                propertyModelToMakeInternal,
                propertyModelToRename,
                propertyModelToChangeNamespace,
                propertyModelWithCustomizedProperties,
                propertyEnumToRename,
                propertyEnumWithValueToRename,
                propertyEnumToBeMadeExtensible,
                propertyModelToAddAdditionalSerializableProperty,
                propertyToMoveToCustomization,
                propertyModelStruct,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RootModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RootModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RootModel)} does not support writing '{options.Format}' format.");
            }
        }

        RootModel IPersistableModel<RootModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RootModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRootModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RootModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RootModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RootModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRootModel(document.RootElement);
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
