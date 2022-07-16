﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class MgmtReferenceType : MgmtObjectType
    {
        public MgmtReferenceType(ObjectSchema objectSchema)
            : base(objectSchema)
        {
        }

        public MgmtReferenceType(ObjectSchema objectSchema, string? name = default, string? nameSpace = default) : base(objectSchema, name, nameSpace)
        {
        }

        public override bool IncludeConverter => (ObjectSchema.Extensions?.MgmtPropertyReferenceType == true || ObjectSchema.Extensions?.MgmtTypeReferenceType == true) && ObjectSchema.Extensions?.MgmtReferenceType != true || base.IncludeConverter;

        protected override ObjectTypeProperty CreatePropertyType(ObjectTypeProperty objectTypeProperty)
        {
            ObjectTypeProperty propertyTypeToUse = objectTypeProperty;

            if (objectTypeProperty.ValueType is {IsFrameworkType: true})
            {
                propertyTypeToUse = ReferenceTypePropertyChooser.GetExactMatchForReferenceType(objectTypeProperty, objectTypeProperty.ValueType.FrameworkType, MgmtContext.Context) ?? propertyTypeToUse;
            }

            return propertyTypeToUse;
        }

        protected override CSharpType? CreateInheritedType()
        {
            return ObjectSchema.Extensions?.MgmtReferenceType == true ? CreateInheritedTypeWithNoExtraMatch() : base.CreateInheritedType();
        }
    }
}
