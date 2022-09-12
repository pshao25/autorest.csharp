// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Security.ConfidentialLedger
{
    public partial class TransactionStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("state");
            writer.WriteStringValue(State.ToString());
            writer.WritePropertyName("transactionId");
            writer.WriteStringValue(TransactionId);
            writer.WriteEndObject();
        }

        internal static TransactionStatus DeserializeTransactionStatus(JsonElement element)
        {
            TransactionState state = default;
            string transactionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    state = new TransactionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transactionId"))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
            }
            return new TransactionStatus(state, transactionId);
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static TransactionStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTransactionStatus(document.RootElement);
        }
    }
}
