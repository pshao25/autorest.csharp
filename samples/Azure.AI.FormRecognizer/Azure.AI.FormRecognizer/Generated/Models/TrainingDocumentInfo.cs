// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Report for a custom model training document. </summary>
    public partial class TrainingDocumentInfo
    {
        /// <summary> Training document name. </summary>
        public string DocumentName { get; set; }
        /// <summary> Total number of pages trained. </summary>
        public int Pages { get; set; }
        /// <summary> List of errors. </summary>
        public IList<ErrorInformation> Errors { get; set; } = new List<ErrorInformation>();
        /// <summary> Status of the training operation. </summary>
        public TrainStatus Status { get; set; }
    }
}
