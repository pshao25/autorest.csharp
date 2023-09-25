// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Property.Optionality.Models
{
    /// <summary> Model with union of int literal property. </summary>
    public partial class UnionIntLiteralProperty
    {
        /// <summary> Initializes a new instance of UnionIntLiteralProperty. </summary>
        public UnionIntLiteralProperty()
        {
        }

        /// <summary> Initializes a new instance of UnionIntLiteralProperty. </summary>
        /// <param name="property"> Property. </param>
        internal UnionIntLiteralProperty(UnionIntLiteralPropertyProperty? property)
        {
            Property = property;
        }

        /// <summary> Property. </summary>
        public UnionIntLiteralPropertyProperty? Property { get; set; }
    }
}
