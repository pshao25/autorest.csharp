// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class SampleUsage
    {
        internal static SampleUsage DeserializeSampleUsage(JsonElement element)
        {
            UsageUnit unit = default;
            int currentValue = default;
            long limit = default;
            SampleUsageName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"u8))
                {
                    unit = new UsageUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = SampleUsageName.DeserializeSampleUsageName(property.Value);
                    continue;
                }
            }
            return new SampleUsage(unit, currentValue, limit, name);
        }
    }
}
