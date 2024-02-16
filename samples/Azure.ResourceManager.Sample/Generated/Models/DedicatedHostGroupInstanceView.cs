// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// The DedicatedHostGroupInstanceView.
    /// Serialized Name: DedicatedHostGroupInstanceView
    /// </summary>
    internal partial class DedicatedHostGroupInstanceView
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

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupInstanceView"/>. </summary>
        internal DedicatedHostGroupInstanceView()
        {
            Hosts = new ChangeTrackingList<DedicatedHostInstanceViewWithName>();
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupInstanceView"/>. </summary>
        /// <param name="hosts">
        /// List of instance view of the dedicated hosts under the dedicated host group.
        /// Serialized Name: DedicatedHostGroupInstanceView.hosts
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedHostGroupInstanceView(IReadOnlyList<DedicatedHostInstanceViewWithName> hosts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hosts = hosts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// List of instance view of the dedicated hosts under the dedicated host group.
        /// Serialized Name: DedicatedHostGroupInstanceView.hosts
        /// </summary>
        [WirePath("hosts")]
        public IReadOnlyList<DedicatedHostInstanceViewWithName> Hosts { get; }
    }
}
