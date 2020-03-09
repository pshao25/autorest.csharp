// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> The restriction because of which SKU cannot be used. </summary>
    public partial class Restriction
    {
        /// <summary> The type of restrictions. As of now only possible value for this is location. </summary>
        public string Type { get; internal set; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        public IList<string> Values { get; internal set; }
        /// <summary> The reason for the restriction. As of now this can be &quot;QuotaId&quot; or &quot;NotAvailableForSubscription&quot;. Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The &quot;NotAvailableForSubscription&quot; is related to capacity at DC. </summary>
        public ReasonCode? ReasonCode { get; set; }
    }
}
