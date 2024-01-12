// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using SingleTopLevelClientWithOperations_LowLevel;

namespace SingleTopLevelClientWithOperations_LowLevel.Samples
{
    public partial class Samples_Client2
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Operation_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Client2 client = new TopLevelClientWithOperationClient(null, credential).GetClient2Client();

            Response response = client.Operation(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Operation_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Client2 client = new TopLevelClientWithOperationClient(null, credential).GetClient2Client();

            Response response = await client.OperationAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Operation_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Client2 client = new TopLevelClientWithOperationClient(null, credential).GetClient2Client();

            Response response = client.Operation(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Operation_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Client2 client = new TopLevelClientWithOperationClient(null, credential).GetClient2Client();

            Response response = await client.OperationAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
