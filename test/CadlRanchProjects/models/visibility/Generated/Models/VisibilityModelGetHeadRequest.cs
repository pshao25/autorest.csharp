// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace ModelsVisibility.Generated.Models
{
    internal partial class VisibilityModelGetHeadRequest
    {
        internal VisibilityModelGetHeadRequest(string queryProp, string otherProp)
        {
            QueryProp = queryProp;
            OtherProp = otherProp;
        }

        public string QueryProp { get; set; }
        public string OtherProp { get; set; }
    }
}
