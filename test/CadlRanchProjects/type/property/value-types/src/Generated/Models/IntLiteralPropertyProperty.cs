// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace _Type.Property.ValueTypes.Models
{
    /// <summary> The IntLiteralProperty_property. </summary>
    internal readonly partial struct IntLiteralPropertyProperty : IEquatable<IntLiteralPropertyProperty>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="IntLiteralPropertyProperty"/>. </summary>
        public IntLiteralPropertyProperty(int value)
        {
            _value = value;
        }

        private const int _42Value = 42;

        /// <summary> 42. </summary>
        public static IntLiteralPropertyProperty _42 { get; } = new IntLiteralPropertyProperty(_42Value);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="IntLiteralPropertyProperty"/> values are the same. </summary>
        public static bool operator ==(IntLiteralPropertyProperty left, IntLiteralPropertyProperty right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntLiteralPropertyProperty"/> values are not the same. </summary>
        public static bool operator !=(IntLiteralPropertyProperty left, IntLiteralPropertyProperty right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntLiteralPropertyProperty"/>. </summary>
        public static implicit operator IntLiteralPropertyProperty(int value) => new IntLiteralPropertyProperty(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntLiteralPropertyProperty other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntLiteralPropertyProperty other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
