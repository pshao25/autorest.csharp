// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json;

namespace Payload.JsonMergePatch.Models
{
    /// <summary> The ExtendedModelSolution1. </summary>
    public partial class ExtendedModelSolution1Level3 : ExtendedModelSolution1
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedModelSolution1"/>. </summary>
        public ExtendedModelSolution1Level3()
        {
        }

        private string _extendedValueLevel3;
        private bool _extendedValueLevel3Changed = false;
        /// <summary> Gets or sets the extended value. </summary>
        public string ExtendedValueLevel3
        {
            get => _extendedValueLevel3;
            set
            {
                _extendedValueLevel3 = value;
                _extendedValueLevel3Changed = true;
                _isChanged = true;
            }
        }

        private bool _isChanged = false;
        public override bool IsChanged(string name = null)
        {
            if (name == null)
            {
                return _isChanged && base.IsChanged();
            }

            switch (name)
            {
                case "ExtendedValueLevel3":
                    return _extendedValueLevel3Changed;
                default:
                    return base.IsChanged(name);
            }
        }

        private void WritePatch(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (base.IsChanged(nameof(BaseDict)))
            {

            }
            writer.WriteEndObject();
        }
    }
}
