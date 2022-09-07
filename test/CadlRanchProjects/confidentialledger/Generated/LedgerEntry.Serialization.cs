// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace ConfidentialLedger
{
    public partial class LedgerEntry : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("contents");
            writer.WriteStringValue(Contents);
            writer.WriteEndObject();
        }

        internal static LedgerEntry DeserializeLedgerEntry(JsonElement element)
        {
            string contents = default;
            string collectionId = default;
            TransactionId transactionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contents"))
                {
                    contents = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionId"))
                {
                    collectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionId"))
                {
                    transactionId = TransactionId.DeserializeTransactionId(property.Value);
                    continue;
                }
            }
            return new LedgerEntry(contents, collectionId, transactionId);
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static LedgerEntry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLedgerEntry(document.RootElement);
        }
    }
}
