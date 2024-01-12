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
using RenameGetList;

namespace RenameGetList.Samples
{
    public partial class Samples_Deployments
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Deployment_GetDeployment_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            Response response = client.GetDeployment("<projectName>", "<deploymentName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Deployment_GetDeployment_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            Response response = await client.GetDeploymentAsync("<projectName>", "<deploymentName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Deployment_GetDeployment_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            Response response = client.GetDeployment("<projectName>", "<deploymentName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Deployment_GetDeployment_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            Response response = await client.GetDeploymentAsync("<projectName>", "<deploymentName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Deployment_GetDeployments_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            foreach (BinaryData item in client.GetDeployments("<projectName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Deployment_GetDeployments_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            await foreach (BinaryData item in client.GetDeploymentsAsync("<projectName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Deployment_GetDeployments_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            foreach (BinaryData item in client.GetDeployments("<projectName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Deployment_GetDeployments_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Deployments client = new RenameGetListClient(endpoint).GetDeploymentsClient();

            await foreach (BinaryData item in client.GetDeploymentsAsync("<projectName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }
    }
}
