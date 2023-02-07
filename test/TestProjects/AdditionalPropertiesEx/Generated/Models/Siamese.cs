// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace AdditionalPropertiesEx.Models
{
    /// <summary> The third level model in the normal multiple levels inheritance. </summary>
    internal partial class Siamese : Cat
    {
        /// <summary> Initializes a new instance of Siamese. </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="smart"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal Siamese(string name, int age, bool smart) : base(name, age)
        {
            Argument.AssertNotNull(name, nameof(name));

            Smart = smart;
        }

        /// <summary> Gets the smart. </summary>
        public bool Smart { get; }
    }
}
