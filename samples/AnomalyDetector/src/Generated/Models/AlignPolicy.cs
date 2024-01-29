// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AnomalyDetector.Models
{
    /// <summary> An optional field, indicating the manner to align multiple variables. </summary>
    public partial class AlignPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AlignPolicy"/>. </summary>
        public AlignPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AlignPolicy"/>. </summary>
        /// <param name="alignMode">
        /// An optional field, indicating how to align different variables to the same
        /// time-range. Either Inner or Outer.
        /// </param>
        /// <param name="fillNAMethod">
        /// An optional field, indicating how missing values will be filled. One of
        /// Previous, Subsequent, Linear, Zero, Fixed.
        /// </param>
        /// <param name="paddingValue"> An optional field. Required when fillNAMethod is Fixed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlignPolicy(AlignMode? alignMode, FillNAMethod? fillNAMethod, float? paddingValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AlignMode = alignMode;
            FillNAMethod = fillNAMethod;
            PaddingValue = paddingValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// An optional field, indicating how to align different variables to the same
        /// time-range. Either Inner or Outer.
        /// </summary>
        public AlignMode? AlignMode { get; set; }
        /// <summary>
        /// An optional field, indicating how missing values will be filled. One of
        /// Previous, Subsequent, Linear, Zero, Fixed.
        /// </summary>
        public FillNAMethod? FillNAMethod { get; set; }
        /// <summary> An optional field. Required when fillNAMethod is Fixed. </summary>
        public float? PaddingValue { get; set; }
    }
}
