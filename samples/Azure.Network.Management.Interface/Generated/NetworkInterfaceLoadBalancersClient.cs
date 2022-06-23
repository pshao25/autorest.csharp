// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Network.Management.Interface.Models;

namespace Azure.Network.Management.Interface
{
    /// <summary> The NetworkInterfaceLoadBalancers service client. </summary>
    public partial class NetworkInterfaceLoadBalancersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NetworkInterfaceLoadBalancersRestClient RestClient { get; }
        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of NetworkInterfaceLoadBalancersClient for mocking. </summary>
        protected NetworkInterfaceLoadBalancersClient()
        {
        }

        /// <summary> Initializes a new instance of NetworkInterfaceLoadBalancersClient. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public NetworkInterfaceLoadBalancersClient(string subscriptionId, TokenCredential credential, Uri endpoint = null, AzureNetworkManagementInterfaceClientOptions options = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("https://management.azure.com");

            options ??= new AzureNetworkManagementInterfaceClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "user_impersonation" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new NetworkInterfaceLoadBalancersRestClient(_clientDiagnostics, _pipeline, subscriptionId, endpoint, options.Version);
        }

        /// <summary> Initializes a new instance of NetworkInterfaceLoadBalancersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        internal NetworkInterfaceLoadBalancersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-11-01")
        {
            RestClient = new NetworkInterfaceLoadBalancersRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> List all load balancers in a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual AsyncPageable<LoadBalancer> ListAsync(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            async Task<Page<LoadBalancer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceLoadBalancersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceLoadBalancersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all load balancers in a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Pageable<LoadBalancer> List(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            Page<LoadBalancer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceLoadBalancersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkInterfaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceLoadBalancersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, networkInterfaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
