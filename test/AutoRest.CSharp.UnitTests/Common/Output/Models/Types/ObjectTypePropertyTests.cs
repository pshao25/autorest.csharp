﻿using AutoRest.CSharp.Common.Input;
using NUnit.Framework;
using AutoRest.CSharp.Output.Models.Types;
using System.Collections.Generic;
using AutoRest.CSharp.Generation.Types;
using System;
using System.Globalization;
using System.Linq;
using AutoRest.CSharp.Generation.Writers;

namespace AutoRest.CSharp.Tests.Common.Output.Models.Types
{
    public class ObjectTypePropertyTests
    {
        private TypeFactory typeFactory;
        [SetUp]
        public void TestSetup()
        {
            typeFactory = new TypeFactory(null, typeof(BinaryData));
        }

        // Validates that the type string is constructed correctly for a given primitive type
        [Test]
        public void TestConstructDetailsForListType_PrimitiveType()
        {
            bool isNullable = false;
            bool isBaseElement = true;
            InputPrimitiveType type = new InputPrimitiveType(InputPrimitiveTypeKind.Boolean, isNullable);
            CSharpType cSharpType = typeFactory.CreateType(type);

            FormattableString result = ObjectTypeProperty.ConstructDetailsForListType(cSharpType, isBaseElement);
            FormattableString expectedResult = $"<see cref=\"bool\"/>";

            bool areStringsEqual = string.Compare(result.ToString(), expectedResult.ToString(), CultureInfo.CurrentCulture,
                CompareOptions.IgnoreSymbols) == 0;

            Assert.True(areStringsEqual);
        }

        // Validates that the type string is constructed correctly for a given list type
        [Test]
        public void TestConstructDetailsForListType_ListType()
        {
            bool isNullable = false;
            bool isBaseElement = true;
            InputType elementType = new InputPrimitiveType(InputPrimitiveTypeKind.Boolean, isNullable);
            InputListType type = new InputListType("InputListType", elementType, false, isNullable);

            CSharpType cSharpType = typeFactory.CreateType(type);

            FormattableString result = ObjectTypeProperty.ConstructDetailsForListType(cSharpType, isBaseElement);
            FormattableString expectedResult = $"<c>IList{{bool}}</c>";

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }

        // Validates that the type string is constructed correctly for a given nested list type
        [Test]
        public void TestConstructDetailsForListType_NestedListType()
        {
            bool isNullable = false;
            bool isBaseElement = true;
            InputType elementType = new InputPrimitiveType(InputPrimitiveTypeKind.Boolean, isNullable);
            InputType listElementType = new InputListType("InputListType1", elementType, false, isNullable);
            InputListType type = new InputListType("InputListType2", listElementType, false, isNullable);

            CSharpType cSharpType = typeFactory.CreateType(type);

            FormattableString result = ObjectTypeProperty.ConstructDetailsForListType(cSharpType, isBaseElement);
            FormattableString expectedResult = $"<c>IList{{IList{{bool}}}}</c>";

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }

        // Validates that the type string is constructed correctly for a list of dictionary type
        [Test]
        public void TestConstructDetailsForListType_ListOfDictType()
        {
            bool isNullable = false;
            bool isBaseElement = true;
            InputType keyType = new InputPrimitiveType(InputPrimitiveTypeKind.String, isNullable);
            InputType valueType = new InputPrimitiveType(InputPrimitiveTypeKind.Int32, isNullable);
            InputDictionaryType dictionaryType = new InputDictionaryType("InputDictionaryType", keyType, valueType, isNullable);
            InputType listElementType = new InputListType("InputListType1", dictionaryType, false, isNullable);

            CSharpType cSharpType = typeFactory.CreateType(listElementType);

            FormattableString result = ObjectTypeProperty.ConstructDetailsForListType(cSharpType, isBaseElement);
            FormattableString expectedResult = $"<c>IList{{IDictionary{{TKey, TValue}}}}</c>";

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }

        // Validates that the summary description string is constructed correctly for several types
        [Test]
        public void TestGetUnionTypesDescriptions()
        {
            bool isNullable = false;

            // dictionary type
            InputType keyType = new InputPrimitiveType(InputPrimitiveTypeKind.String, isNullable);
            InputType valueType = new InputPrimitiveType(InputPrimitiveTypeKind.Int32, isNullable);
            InputType dictionaryType = new InputDictionaryType("InputDictionaryType", keyType, valueType, isNullable);

            // literal types
            InputType literalValueType = new InputPrimitiveType(InputPrimitiveTypeKind.Int32, isNullable);
            InputLiteralType literalType = new InputLiteralType(literalValueType, 21, isNullable);

            InputType stringLiteralValueType = new InputPrimitiveType(InputPrimitiveTypeKind.String, isNullable);
            InputLiteralType stringLiteralType = new InputLiteralType(stringLiteralValueType, "test", isNullable);

            InputType boolLiteralValueType = new InputPrimitiveType(InputPrimitiveTypeKind.Boolean, isNullable);
            InputLiteralType boolLiteralType = new InputLiteralType(boolLiteralValueType, true, isNullable);

            var unionItems = new List<CSharpType>
            {
                typeFactory.CreateType(new InputPrimitiveType(InputPrimitiveTypeKind.Boolean, false)),
                typeFactory.CreateType(new InputPrimitiveType(InputPrimitiveTypeKind.Int32, false)),
                typeFactory.CreateType(dictionaryType),
                typeFactory.CreateType(literalType),
                typeFactory.CreateType(stringLiteralType),
                typeFactory.CreateType(boolLiteralType),
            };

            IReadOnlyList<FormattableString> descriptions = ObjectTypeProperty.GetUnionTypesDescriptions(unionItems);

            Assert.AreEqual(6, descriptions.Count);

            var codeWriter = new CodeWriter();
            codeWriter.AppendXmlDocumentation($"<test>", $"</test>", descriptions.ToList().Join(Environment.NewLine));
            var actual = codeWriter.ToString(false);

            var expected = string.Join(Environment.NewLine,
                "/// <test>",
                "/// <description><see cref=\"bool\"/></description>",
                "/// <description><see cref=\"int\"/></description>",
                "/// <description><see cref=\"global::System.Collections.Generic.IDictionary{TKey,TValue}\"/> where <c>TKey</c> is of type <see cref=\"string\"/>, where <c>TValue</c> is of type <see cref=\"int\"/></description>",
                "/// <description>21</description>",
                "/// <description>\"test\"</description>",
                "/// <description>True</description>",
                "/// </test>") + Environment.NewLine;

            Assert.AreEqual(expected, actual);
        }
    }

}
