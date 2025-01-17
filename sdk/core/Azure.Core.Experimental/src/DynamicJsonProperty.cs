﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Core.Dynamic
{
    /// <summary>
    /// Represents a single property on a dynamic JSON object.
    /// </summary>
    public readonly struct DynamicJsonProperty
    {
        internal DynamicJsonProperty(string name, DynamicJson value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets the name of this property.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the value of this property.
        /// </summary>
        public DynamicJson Value { get; }
    }
}
