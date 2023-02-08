// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Visibility.Automatic.Models
{
    public partial class VisibilityModelResponse
    {
        public VisibilityModelResponse(string readProp, string otherProp)
        {
            ReadProp = readProp;
            OtherProp = otherProp;
        }

        public string ReadProp { get; set; }
        public string OtherProp { get; set; }
    }
}
