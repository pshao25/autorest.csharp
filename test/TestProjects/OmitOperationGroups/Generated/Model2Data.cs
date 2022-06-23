// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using OmitOperationGroups.Models;

namespace OmitOperationGroups
{
    /// <summary> A class representing the Model2 data model. </summary>
    public partial class Model2Data : ResourceData
    {
        /// <summary> Initializes a new instance of Model2Data. </summary>
        public Model2Data()
        {
        }

        /// <summary> Initializes a new instance of Model2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="b"></param>
        /// <param name="modelx"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        internal Model2Data(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string b, ModelX modelx, string f, string g) : base(id, name, resourceType, systemData)
        {
            B = b;
            Modelx = modelx;
            F = f;
            G = g;
        }

        /// <summary> Gets or sets the b. </summary>
        public string B { get; set; }
        /// <summary> Gets or sets the modelx. </summary>
        public ModelX Modelx { get; set; }
        /// <summary> Gets the f. </summary>
        public string F { get; }
        /// <summary> Gets the g. </summary>
        public string G { get; }
    }
}
