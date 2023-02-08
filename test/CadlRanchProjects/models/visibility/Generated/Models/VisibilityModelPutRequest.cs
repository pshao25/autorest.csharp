// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsVisibility.Generated.Models
{
    internal partial class VisibilityModelPutRequest
    {
        internal VisibilityModelPutRequest(string createProp, string updateProp, string otherProp)
        {
            CreateProp = createProp;
            UpdateProp = updateProp;
            OtherProp = otherProp;
        }

        public string CreateProp { get; set; }
        public string UpdateProp { get; set; }
        public string OtherProp { get; set; }
    }
}
