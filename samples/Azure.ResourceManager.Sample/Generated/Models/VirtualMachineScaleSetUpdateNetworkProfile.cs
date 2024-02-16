// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes a virtual machine scale set network profile.
    /// Serialized Name: VirtualMachineScaleSetUpdateNetworkProfile
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateNetworkProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateNetworkProfile"/>. </summary>
        public VirtualMachineScaleSetUpdateNetworkProfile()
        {
            NetworkInterfaceConfigurations = new ChangeTrackingList<VirtualMachineScaleSetUpdateNetworkConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateNetworkProfile"/>. </summary>
        /// <param name="healthProbe">
        /// A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'.
        /// Serialized Name: VirtualMachineScaleSetUpdateNetworkProfile.healthProbe
        /// </param>
        /// <param name="networkInterfaceConfigurations">
        /// The list of network configurations.
        /// Serialized Name: VirtualMachineScaleSetUpdateNetworkProfile.networkInterfaceConfigurations
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateNetworkProfile(WritableSubResource healthProbe, IList<VirtualMachineScaleSetUpdateNetworkConfiguration> networkInterfaceConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HealthProbe = healthProbe;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'.
        /// Serialized Name: VirtualMachineScaleSetUpdateNetworkProfile.healthProbe
        /// </summary>
        internal WritableSubResource HealthProbe { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("healthProbe.id")]
        public ResourceIdentifier HealthProbeId
        {
            get => HealthProbe is null ? default : HealthProbe.Id;
            set
            {
                if (HealthProbe is null)
                    HealthProbe = new WritableSubResource();
                HealthProbe.Id = value;
            }
        }

        /// <summary>
        /// The list of network configurations.
        /// Serialized Name: VirtualMachineScaleSetUpdateNetworkProfile.networkInterfaceConfigurations
        /// </summary>
        [WirePath("networkInterfaceConfigurations")]
        public IList<VirtualMachineScaleSetUpdateNetworkConfiguration> NetworkInterfaceConfigurations { get; }
    }
}
