// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    internal partial class ProviderStatusList
    {
        internal static ProviderStatusList DeserializeProviderStatusList(JsonElement element)
        {
            Optional<IReadOnlyList<ProviderStatus>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProviderStatus> array = new List<ProviderStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderStatus.DeserializeProviderStatus(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ProviderStatusList(Optional.ToList(value), nextLink.Value);
        }
    }
}
