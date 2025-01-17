// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor
{
    internal static partial class FeedbackQueryTimeModeExtensions
    {

        public static FeedbackQueryTimeMode ToFeedbackQueryTimeMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MetricTimestamp")) return FeedbackQueryTimeMode.MetricTimestamp;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "FeedbackCreatedTime")) return FeedbackQueryTimeMode.FeedbackCreatedOn;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FeedbackQueryTimeMode value.");
        }
    }
}
