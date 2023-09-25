﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using System.Xml;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using NUnit.Framework;
using _Type.Property.Optionality;
using _Type.Property.Optionality.Models;

namespace CadlRanchProjects.Tests
{
    public class TypePropertyOptionalTests : CadlRanchTestBase
    {
        [Test]
        public Task Type_Property_Optional_String_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetStringClient().GetAllAsync(new RequestContext());
            Assert.AreEqual("hello", StringProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_String_getDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetStringClient().GetDefaultAsync(new RequestContext());
            Assert.AreEqual(null, StringProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_String_putAll() => Test(async (host) =>
        {
            StringProperty data = new()
            {
                Property = "hello"
            };
            Response response = await new OptionalClient(host, null).GetStringClient().PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_String_putDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetStringClient().PutDefaultAsync(new StringProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_Bytes_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetBytesClient().GetAllAsync(new RequestContext());
            Assert.AreEqual(BinaryData.FromString("hello, world!").ToString(), BytesProperty.FromResponse(response).Property.ToString());
        });

        [Test]
        public Task Type_Property_Optional_Bytes_getDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetBytesClient().GetDefaultAsync(new RequestContext());
            Assert.AreEqual(null, BytesProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_Bytes_putAll() => Test(async (host) =>
        {
            BytesProperty data = new()
            {
                Property = BinaryData.FromString("hello, world!")
            };
            Response response = await new OptionalClient(host, null).GetBytesClient().PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_Bytes_putDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetBytesClient().PutDefaultAsync(new BytesProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_Datetime_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetDatetimeClient().GetAllAsync(new RequestContext());
            Assert.AreEqual(DateTimeOffset.Parse("2022-08-26T18:38:00Z"), DatetimeProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_Datetime_getDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetDatetimeClient().GetDefaultAsync(new RequestContext());
            Assert.AreEqual(null, DatetimeProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_Datetime_putAll() => Test(async (host) =>
        {
            DatetimeProperty data = new()
            {
                Property = DateTimeOffset.Parse("2022-08-26T18:38:00Z")
            };
            Response response = await new OptionalClient(host, null).GetDatetimeClient().PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_Datetime_putDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetDatetimeClient().PutDefaultAsync(new DatetimeProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_Duration_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetDurationClient().GetAllAsync(new RequestContext());
            Assert.AreEqual(XmlConvert.ToTimeSpan("P123DT22H14M12.011S"), DurationProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_Duration_getDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetDurationClient().GetDefaultAsync(new RequestContext());
            Assert.AreEqual(null, DurationProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Type_Property_Optional_Duration_putAll() => Test(async (host) =>
        {
            DurationProperty data = new()
            {
                Property = XmlConvert.ToTimeSpan("P123DT22H14M12.011S")
            };
            Response response = await new OptionalClient(host, null).GetDurationClient().PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_Duration_putDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetDurationClient().PutDefaultAsync(new DatetimeProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_CollectionsByte_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetCollectionsByteClient().GetAllAsync(new RequestContext());
            Assert.AreEqual(BinaryData.FromString("hello, world!").ToString(), CollectionsByteProperty.FromResponse(response).Property[0].ToString());
            Assert.AreEqual(BinaryData.FromString("hello, world!").ToString(), CollectionsByteProperty.FromResponse(response).Property[1].ToString());
        });

        [Test]
        public Task Type_Property_Optional_CollectionsByte_getDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetCollectionsByteClient().GetDefaultAsync(new RequestContext());
            Assert.AreEqual(0, CollectionsByteProperty.FromResponse(response).Property.Count);
        });

        [Test]
        public Task Type_Property_Optional_CollectionsByte_putAll() => Test(async (host) =>
        {
            CollectionsByteProperty data = new();
            data.Property.Add(BinaryData.FromString("hello, world!"));
            data.Property.Add(BinaryData.FromString("hello, world!"));

            Response response = await new OptionalClient(host, null).GetCollectionsByteClient().PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_CollectionsByte_putDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetCollectionsByteClient().PutDefaultAsync(new CollectionsByteProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });


        [Test]
        public Task Type_Property_Optional_CollectionsModel_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetCollectionsModelClient().GetAllAsync(new RequestContext());
            var result = CollectionsModelProperty.FromResponse(response);
            Assert.AreEqual("hello", result.Property[0].Property);
            Assert.AreEqual("world", result.Property[1].Property);
        });

        [Test]
        public Task Type_Property_Optional_CollectionsModel_getDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetCollectionsModelClient().GetDefaultAsync(new RequestContext());
            Assert.AreEqual(0, CollectionsModelProperty.FromResponse(response).Property.Count);
        });

        [Test]
        public Task Type_Property_Optional_CollectionsModel_putAll() => Test(async (host) =>
        {
            CollectionsModelProperty data = new();
            data.Property.Add(new StringProperty("hello"));
            data.Property.Add(new StringProperty("world"));

            Response response = await new OptionalClient(host, null).GetCollectionsModelClient().PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_CollectionsModel_putDefault() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetCollectionsModelClient().PutDefaultAsync(new CollectionsModelProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_RequiredAndOptional_getAll() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetRequiredAndOptionalClient().GetAllAsync(new RequestContext());
            var result = RequiredAndOptionalProperty.FromResponse(response);
            Assert.AreEqual("hello", result.OptionalProperty);
            Assert.AreEqual(42, result.RequiredProperty);
        });

        [Test]
        public Task Type_Property_Optional_RequiredAndOptional_getRequiredOnly() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetRequiredAndOptionalClient().GetRequiredOnlyAsync(new RequestContext());
            var result = RequiredAndOptionalProperty.FromResponse(response);
            Assert.AreEqual(null, result.OptionalProperty);
            Assert.AreEqual(42, result.RequiredProperty);
        });

        [Test]
        public Task Type_Property_Optional_RequiredAndOptional_putAll() => Test(async (host) =>
        {
            var content = new RequiredAndOptionalProperty(42)
            {
                OptionalProperty = "hello"
            };

            Response response = await new OptionalClient(host, null).GetRequiredAndOptionalClient().PutAllAsync(content.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_RequiredAndOptional_putRequiredOnly() => Test(async (host) =>
        {
            Response response = await new OptionalClient(host, null).GetRequiredAndOptionalClient().PutRequiredOnlyAsync(new RequiredAndOptionalProperty(42));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_StringLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetStringLiteralClient().GetAllAsync();
            Assert.AreEqual("hello", response.Value.Property.ToString());
        });

        [Test]
        public Task Type_Property_Optional_StringLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetStringLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_StringLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetStringLiteralClient().PutAllAsync(new StringLiteralProperty("hello"));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_StringLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetStringLiteralClient().PutDefaultAsync(new StringLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_IntLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetIntLiteralClient().GetAllAsync();
            Assert.AreEqual(new IntLiteralPropertyProperty(1), response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_IntLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetIntLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_IntLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetIntLiteralClient().PutAllAsync(new IntLiteralProperty(1));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_IntLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetIntLiteralClient().PutDefaultAsync(new IntLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_FloatLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetFloatLiteralClient().GetAllAsync();
            Assert.AreEqual(new FloatLiteralPropertyProperty(1.2f), response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_FloatLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetFloatLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_FloatLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetFloatLiteralClient().PutAllAsync(new FloatLiteralProperty(1.2f));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_FloatLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetFloatLiteralClient().PutDefaultAsync(new FloatLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_BooleanLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetBooleanLiteralClient().GetAllAsync();
            Assert.AreEqual(true, response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_BooleanLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetBooleanLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_BooleanLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetBooleanLiteralClient().PutAllAsync(new BooleanLiteralProperty(true));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_BooleanLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetBooleanLiteralClient().PutDefaultAsync(new BooleanLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_UnionStringLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionStringLiteralClient().GetAllAsync();
            Assert.AreEqual("world", response.Value.Property.ToString());
        });

        [Test]
        public Task Type_Property_Optional_UnionStringLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionStringLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_UnionStringLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionStringLiteralClient().PutAllAsync(new UnionStringLiteralProperty("world"));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_UnionStringLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionStringLiteralClient().PutDefaultAsync(new UnionStringLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_UnionIntLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionIntLiteralClient().GetAllAsync();
            Assert.AreEqual(new UnionIntLiteralPropertyProperty(2), response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_UnionIntLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionIntLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_UnionIntLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionIntLiteralClient().PutAllAsync(new UnionIntLiteralProperty(2));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_UnionIntLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionIntLiteralClient().PutDefaultAsync(new UnionIntLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_UnionFloatLiteral_getAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionFloatLiteralClient().GetAllAsync();
            Assert.AreEqual(new UnionFloatLiteralPropertyProperty(2.3f), response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_UnionFloatLiteral_getDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionFloatLiteralClient().GetDefaultAsync();
            Assert.IsNull(response.Value.Property);
        });

        [Test]
        public Task Type_Property_Optional_UnionFloatLiteral_putAll() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionFloatLiteralClient().PutAllAsync(new UnionFloatLiteralProperty(2.3f));
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Type_Property_Optional_UnionFloatLiteral_putDefault() => Test(async (host) =>
        {
            var response = await new OptionalClient(host, null).GetUnionFloatLiteralClient().PutDefaultAsync(new UnionFloatLiteralProperty());
            Assert.AreEqual(204, response.Status);
        });
    }
}
