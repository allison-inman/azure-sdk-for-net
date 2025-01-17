// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TensorFlowDistributionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ParameterServerCount))
            {
                writer.WritePropertyName("parameterServerCount"u8);
                writer.WriteNumberValue(ParameterServerCount.Value);
            }
            if (Optional.IsDefined(WorkerCount))
            {
                if (WorkerCount != null)
                {
                    writer.WritePropertyName("workerCount"u8);
                    writer.WriteNumberValue(WorkerCount.Value);
                }
                else
                {
                    writer.WriteNull("workerCount");
                }
            }
            writer.WritePropertyName("distributionType"u8);
            writer.WriteStringValue(DistributionType.ToString());
            writer.WriteEndObject();
        }

        internal static TensorFlowDistributionConfiguration DeserializeTensorFlowDistributionConfiguration(JsonElement element)
        {
            Optional<int> parameterServerCount = default;
            Optional<int?> workerCount = default;
            DistributionType distributionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameterServerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parameterServerCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workerCount = null;
                        continue;
                    }
                    workerCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("distributionType"u8))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
            }
            return new TensorFlowDistributionConfiguration(distributionType, Optional.ToNullable(parameterServerCount), Optional.ToNullable(workerCount));
        }
    }
}
