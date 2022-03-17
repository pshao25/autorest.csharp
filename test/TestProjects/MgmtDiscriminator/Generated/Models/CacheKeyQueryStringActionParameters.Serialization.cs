// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    public partial class CacheKeyQueryStringActionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeName.ToString());
            writer.WritePropertyName("queryStringBehavior");
            writer.WriteStringValue(QueryStringBehavior.ToString());
            if (Optional.IsDefined(QueryParameters))
            {
                if (QueryParameters != null)
                {
                    writer.WritePropertyName("queryParameters");
                    writer.WriteStringValue(QueryParameters);
                }
                else
                {
                    writer.WriteNull("queryParameters");
                }
            }
            writer.WriteEndObject();
        }

        internal static CacheKeyQueryStringActionParameters DeserializeCacheKeyQueryStringActionParameters(JsonElement element)
        {
            CacheKeyQueryStringActionParametersTypeName typeName = default;
            QueryStringBehavior queryStringBehavior = default;
            Optional<string> queryParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new CacheKeyQueryStringActionParametersTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryStringBehavior"))
                {
                    queryStringBehavior = new QueryStringBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        queryParameters = null;
                        continue;
                    }
                    queryParameters = property.Value.GetString();
                    continue;
                }
            }
            return new CacheKeyQueryStringActionParameters(typeName, queryStringBehavior, queryParameters.Value);
        }
    }
}
