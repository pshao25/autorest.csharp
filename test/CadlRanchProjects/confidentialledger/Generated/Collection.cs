// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Security.ConfidentialLedger
{
    /// <summary> Identifier for collections. </summary>
    public partial class Collection
    {
        /// <summary> Initializes a new instance of Collection. </summary>
        /// <param name="collectionId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionId"/> is null. </exception>
        public Collection(string collectionId)
        {
            Argument.AssertNotNull(collectionId, nameof(collectionId));

            CollectionId = collectionId;
        }

        public string CollectionId { get; set; }
    }
}
