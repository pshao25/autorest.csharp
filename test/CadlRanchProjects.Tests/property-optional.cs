﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using System.Xml;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using Models.Property.Optional;
using NUnit.Framework;

namespace CadlRanchProjects.Tests
{
    public class PropertyOptionalTests : CadlRanchTestBase
    {
        [Test]
        public Task Models_Property_Optional_String_getAll() => Test(async (host) =>
        {
            Response response = await new StringClient(host, null).GetAllAsync();
            Assert.AreEqual("hello", StringProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Models_Property_Optional_String_getDefault() => Test(async (host) =>
        {
            Response response = await new StringClient(host, null).GetDefaultAsync();
            Assert.AreEqual(null, StringProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Models_Property_Optional_String_putAll() => Test(async (host) =>
        {
            StringProperty data = new()
            {
                Property = "hello"
            };
            Response response = await new StringClient(host, null).PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_String_putDefault() => Test(async (host) =>
        {
            Response response = await new StringClient(host, null).PutDefaultAsync(new StringProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_Bytes_getAll() => Test(async (host) =>
        {
            Response response = await new BytesClient(host, null).GetAllAsync();
            Assert.AreEqual(BinaryData.FromString("\"aGVsbG8sIHdvcmxkIQ==\"").ToString(), BytesProperty.FromResponse(response).Property.ToString());
        });

        [Test]
        public Task Models_Property_Optional_Bytes_getDefault() => Test(async (host) =>
        {
            Response response = await new BytesClient(host, null).GetDefaultAsync();
            Assert.AreEqual(null, BytesProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Models_Property_Optional_Bytes_putAll() => Test(async (host) =>
        {
            BytesProperty data = new()
            {
                Property = BinaryData.FromString("\"aGVsbG8sIHdvcmxkIQ==\"")
            };
            Response response = await new BytesClient(host, null).PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_Bytes_putDefault() => Test(async (host) =>
        {
            Response response = await new BytesClient(host, null).PutDefaultAsync(new BytesProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_Datetime_getAll() => Test(async (host) =>
        {
            Response response = await new DatetimeClient(host, null).GetAllAsync();
            Assert.AreEqual(DateTimeOffset.Parse("2022-08-26T18:38:00Z"), DatetimeProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Models_Property_Optional_Datetime_getDefault() => Test(async (host) =>
        {
            Response response = await new DatetimeClient(host, null).GetDefaultAsync();
            Assert.AreEqual(null, DatetimeProperty.FromResponse(response).Property);
        });

        [Test]
        [Ignore("Need cadl ranch fix")]
        public Task Models_Property_Optional_Datetime_putAll() => Test(async (host) =>
        {
            DatetimeProperty data = new()
            {
                Property = DateTimeOffset.Parse("2022-08-26T18:38:00Z")
            };
            Response response = await new DatetimeClient(host, null).PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_Datetime_putDefault() => Test(async (host) =>
        {
            Response response = await new DatetimeClient(host, null).PutDefaultAsync(new DatetimeProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_Duration_getAll() => Test(async (host) =>
        {
            Response response = await new DurationClient(host, null).GetAllAsync();
            Assert.AreEqual(XmlConvert.ToTimeSpan("P123DT22H14M12.011S"), DurationProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Models_Property_Optional_Duration_getDefault() => Test(async (host) =>
        {
            Response response = await new DurationClient(host, null).GetDefaultAsync();
            Assert.AreEqual(null, DurationProperty.FromResponse(response).Property);
        });

        [Test]
        public Task Models_Property_Optional_Duration_putAll() => Test(async (host) =>
        {
            DurationProperty data = new()
            {
                Property = XmlConvert.ToTimeSpan("P123DT22H14M12.011S")
            };
            Response response = await new DurationClient(host, null).PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_Duration_putDefault() => Test(async (host) =>
        {
            Response response = await new DurationClient(host, null).PutDefaultAsync(new DatetimeProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_CollectionsByte_getAll() => Test(async (host) =>
        {
            Response response = await new CollectionsByteClient(host, null).GetAllAsync();
            Assert.AreEqual(BinaryData.FromString("\"aGVsbG8sIHdvcmxkIQ==\"").ToString(), CollectionsByteProperty.FromResponse(response).Property[0].ToString());
            Assert.AreEqual(BinaryData.FromString("\"aGVsbG8sIHdvcmxkIQ==\"").ToString(), CollectionsByteProperty.FromResponse(response).Property[1].ToString());
        });

        [Test]
        public Task Models_Property_Optional_CollectionsByte_getDefault() => Test(async (host) =>
        {
            Response response = await new CollectionsByteClient(host, null).GetDefaultAsync();
            Assert.AreEqual(0, CollectionsByteProperty.FromResponse(response).Property.Count);
        });

        [Test]
        public Task Models_Property_Optional_CollectionsByte_putAll() => Test(async (host) =>
        {
            CollectionsByteProperty data = new();
            data.Property.Add(BinaryData.FromString("\"aGVsbG8sIHdvcmxkIQ==\""));
            data.Property.Add(BinaryData.FromString("\"aGVsbG8sIHdvcmxkIQ==\""));

            Response response = await new CollectionsByteClient(host, null).PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_CollectionsByte_putDefault() => Test(async (host) =>
        {
            Response response = await new CollectionsByteClient(host, null).PutDefaultAsync(new CollectionsByteProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });


        [Test]
        public Task Models_Property_Optional_CollectionsModel_getAll() => Test(async (host) =>
        {
            Response response = await new CollectionsModelClient(host, null).GetAllAsync();
            var result = CollectionsModelProperty.FromResponse(response);
            Assert.AreEqual("hello", result.Property[0].Property);
            Assert.AreEqual("world", result.Property[1].Property);
        });

        [Test]
        public Task Models_Property_Optional_CollectionsModel_getDefault() => Test(async (host) =>
        {
            Response response = await new CollectionsModelClient(host, null).GetDefaultAsync();
            Assert.AreEqual(0, CollectionsModelProperty.FromResponse(response).Property.Count);
        });

        [Test]
        public Task Models_Property_Optional_CollectionsModel_putAll() => Test(async (host) =>
        {
            CollectionsModelProperty data = new();
            data.Property.Add(new StringProperty("hello"));
            data.Property.Add(new StringProperty("world"));

            Response response = await new CollectionsModelClient(host, null).PutAllAsync(data.ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Models_Property_Optional_CollectionsModel_putDefault() => Test(async (host) =>
        {
            Response response = await new CollectionsModelClient(host, null).PutDefaultAsync(new CollectionsModelProperty().ToRequestContent());
            Assert.AreEqual(204, response.Status);
        });
    }
}
