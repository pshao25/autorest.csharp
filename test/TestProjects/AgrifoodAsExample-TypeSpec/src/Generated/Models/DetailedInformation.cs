// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Model to capture detailed information for Data Manager For AgricultureExtensions. </summary>
    public partial class DetailedInformation
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

        /// <summary> Initializes a new instance of <see cref="DetailedInformation"/>. </summary>
        internal DetailedInformation()
        {
            CustomParameters = new ChangeTrackingList<string>();
            PlatformParameters = new ChangeTrackingList<string>();
            ApiDefaultInputParameters = new ChangeTrackingList<string>();
            ApiInputParameters = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DetailedInformation"/>. </summary>
        /// <param name="apiName"> ApiName available for the Data Manager For Agriculture Extension. </param>
        /// <param name="apiDocsLink"> Extension provider's API documentation link. </param>
        /// <param name="apiType"> Type of Api in Extension. </param>
        /// <param name="customParameters"> List of customParameters. </param>
        /// <param name="platformParameters"> List of platformParameters. </param>
        /// <param name="apiDefaultInputParameters"> List of defaultParameters. </param>
        /// <param name="unitsSupported"> Unit systems info for the data provider. </param>
        /// <param name="apiInputParameters"> List of apiInputParameters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetailedInformation(string apiName, string apiDocsLink, string apiType, IReadOnlyList<string> customParameters, IReadOnlyList<string> platformParameters, IReadOnlyList<string> apiDefaultInputParameters, UnitSystemsInfo unitsSupported, IReadOnlyList<string> apiInputParameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiName = apiName;
            ApiDocsLink = apiDocsLink;
            ApiType = apiType;
            CustomParameters = customParameters;
            PlatformParameters = platformParameters;
            ApiDefaultInputParameters = apiDefaultInputParameters;
            UnitsSupported = unitsSupported;
            ApiInputParameters = apiInputParameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ApiName available for the Data Manager For Agriculture Extension. </summary>
        public string ApiName { get; }
        /// <summary> Extension provider's API documentation link. </summary>
        public string ApiDocsLink { get; }
        /// <summary> Type of Api in Extension. </summary>
        public string ApiType { get; }
        /// <summary> List of customParameters. </summary>
        public IReadOnlyList<string> CustomParameters { get; }
        /// <summary> List of platformParameters. </summary>
        public IReadOnlyList<string> PlatformParameters { get; }
        /// <summary> List of defaultParameters. </summary>
        public IReadOnlyList<string> ApiDefaultInputParameters { get; }
        /// <summary> Unit systems info for the data provider. </summary>
        public UnitSystemsInfo UnitsSupported { get; }
        /// <summary> List of apiInputParameters. </summary>
        public IReadOnlyList<string> ApiInputParameters { get; }
    }
}
