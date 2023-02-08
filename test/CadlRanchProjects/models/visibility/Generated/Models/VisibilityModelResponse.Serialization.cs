// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure;
using System.Text.Json;

namespace Models.Visibility.Automatic.Models
{
    public partial class VisibilityModelResponse
    {
        internal static VisibilityModelResponse DeserializeVisibilityModelResponse(JsonElement element)
        {
            string readProp = default;
            string otherProp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readProp"u8))
                {
                    readProp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("otherProp"u8))
                {
                    otherProp = property.Value.GetString();
                    continue;
                }
            }
            return new VisibilityModelResponse(readProp, otherProp);
        }

        internal static VisibilityModelResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeVisibilityModelResponse(document.RootElement);
        }
    }
}
