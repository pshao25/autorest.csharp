// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Pagination
{
    /// <summary> A class representing the PageSizeInt32Model data model. </summary>
    public partial class PageSizeInt32ModelData
    {
        /// <summary> Initializes a new instance of PageSizeInt32ModelData. </summary>
        public PageSizeInt32ModelData()
        {
        }

        /// <summary> Initializes a new instance of PageSizeInt32ModelData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        internal PageSizeInt32ModelData(string id, string name, string resourceType)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string ResourceType { get; }
    }
}
