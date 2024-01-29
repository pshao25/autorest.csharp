// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using ResourceClients_LowLevel;

namespace ResourceClients_LowLevel.Tests
{
    public partial class ResourceGroupTests : ResourceClients_LowLevelTestBase
    {
        public ResourceGroupTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetGroup_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ResourceGroup client = CreateResourceServiceClient(endpoint, "<GroupId>", null, credential).GetResourceGroup();

            Response response = await client.GetGroupAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetGroup_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ResourceGroup client = CreateResourceServiceClient(endpoint, "<GroupId>", null, credential).GetResourceGroup();

            Response response = await client.GetGroupAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetItems_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ResourceGroup client = CreateResourceServiceClient(endpoint, "<GroupId>", null, credential).GetResourceGroup();

            await foreach (BinaryData item in client.GetItemsAsync(null))
            {
            }
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetItems_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ResourceGroup client = CreateResourceServiceClient(endpoint, "<GroupId>", null, credential).GetResourceGroup();

            await foreach (BinaryData item in client.GetItemsAsync(null))
            {
            }
        }
    }
}
