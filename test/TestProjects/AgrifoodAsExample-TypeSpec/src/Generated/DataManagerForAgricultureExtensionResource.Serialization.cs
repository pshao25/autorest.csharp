// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class DataManagerForAgricultureExtensionResource : IJsonModel<DataManagerForAgricultureExtensionData>
    {
        void IJsonModel<DataManagerForAgricultureExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataManagerForAgricultureExtensionData>)Data).Write(writer, options);

        DataManagerForAgricultureExtensionData IJsonModel<DataManagerForAgricultureExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataManagerForAgricultureExtensionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataManagerForAgricultureExtensionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DataManagerForAgricultureExtensionData IPersistableModel<DataManagerForAgricultureExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataManagerForAgricultureExtensionData>(data, options);

        string IPersistableModel<DataManagerForAgricultureExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataManagerForAgricultureExtensionData>)Data).GetFormatFromOptions(options);
    }
}
