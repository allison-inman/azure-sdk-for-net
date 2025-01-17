// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Data Lake Store account name availability check parameters. </summary>
    public partial class DataLakeStoreAccountNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of DataLakeStoreAccountNameAvailabilityContent. </summary>
        /// <param name="name"> The Data Lake Store name to check availability for. </param>
        /// <param name="resourceType"> The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeStore/accounts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataLakeStoreAccountNameAvailabilityContent(string name, DataLakeStoreResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> The Data Lake Store name to check availability for. </summary>
        public string Name { get; }
        /// <summary> The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeStore/accounts. </summary>
        public DataLakeStoreResourceType ResourceType { get; }
    }
}
