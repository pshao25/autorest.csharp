// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace dpg_customization_LowLevel.Models
{
    /// <summary> The ProductResult. </summary>
    public partial class ProductResult
    {
        /// <summary> Initializes a new instance of ProductResult. </summary>
        internal ProductResult()
        {
            Values = new ChangeTrackingList<Product>();
        }

        /// <summary> Initializes a new instance of ProductResult. </summary>
        /// <param name="values"></param>
        /// <param name="nextLink"></param>
        internal ProductResult(IReadOnlyList<Product> values, string nextLink)
        {
            Values = values;
            NextLink = nextLink;
        }

        /// <summary> Gets the values. </summary>
        public IReadOnlyList<Product> Values { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
