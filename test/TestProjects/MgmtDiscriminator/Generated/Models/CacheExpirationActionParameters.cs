// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtDiscriminator.Models
{
    /// <summary> Defines the parameters for the cache expiration action. </summary>
    public partial class CacheExpirationActionParameters
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

        /// <summary> Initializes a new instance of <see cref="CacheExpirationActionParameters"/>. </summary>
        /// <param name="typeName"></param>
        /// <param name="cacheBehavior"> Caching behavior for the requests. </param>
        /// <param name="cacheType"> The level at which the content needs to be cached. </param>
        public CacheExpirationActionParameters(CacheExpirationActionParametersTypeName typeName, CacheBehavior cacheBehavior, CacheType cacheType)
        {
            TypeName = typeName;
            CacheBehavior = cacheBehavior;
            CacheType = cacheType;
        }

        /// <summary> Initializes a new instance of <see cref="CacheExpirationActionParameters"/>. </summary>
        /// <param name="typeName"></param>
        /// <param name="cacheBehavior"> Caching behavior for the requests. </param>
        /// <param name="cacheType"> The level at which the content needs to be cached. </param>
        /// <param name="cacheDuration"> The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CacheExpirationActionParameters(CacheExpirationActionParametersTypeName typeName, CacheBehavior cacheBehavior, CacheType cacheType, TimeSpan? cacheDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TypeName = typeName;
            CacheBehavior = cacheBehavior;
            CacheType = cacheType;
            CacheDuration = cacheDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CacheExpirationActionParameters"/> for deserialization. </summary>
        internal CacheExpirationActionParameters()
        {
        }

        /// <summary> Gets or sets the type name. </summary>
        [WirePath("typeName")]
        public CacheExpirationActionParametersTypeName TypeName { get; set; }
        /// <summary> Caching behavior for the requests. </summary>
        [WirePath("cacheBehavior")]
        public CacheBehavior CacheBehavior { get; set; }
        /// <summary> The level at which the content needs to be cached. </summary>
        [WirePath("cacheType")]
        public CacheType CacheType { get; set; }
        /// <summary> The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss. </summary>
        [WirePath("cacheDuration")]
        public TimeSpan? CacheDuration { get; set; }
    }
}
