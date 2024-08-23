// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> The MarketplaceOfferDetails. </summary>
    public partial class MarketplaceOfferDetails
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

        /// <summary> Initializes a new instance of <see cref="MarketplaceOfferDetails"/>. </summary>
        internal MarketplaceOfferDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceOfferDetails"/>. </summary>
        /// <param name="saasOfferId"></param>
        /// <param name="publisherId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MarketplaceOfferDetails(string saasOfferId, string publisherId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SaasOfferId = saasOfferId;
            PublisherId = publisherId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the saas offer id. </summary>
        public string SaasOfferId { get; }
        /// <summary> Gets the publisher id. </summary>
        public string PublisherId { get; }
    }
}
