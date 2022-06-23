// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using validation.Models;

namespace validation
{
    /// <summary> The AutoRestValidationTest service client. </summary>
    public partial class AutoRestValidationTestClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AutoRestValidationTestRestClient RestClient { get; }
        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of AutoRestValidationTestClient for mocking. </summary>
        protected AutoRestValidationTestClient()
        {
        }

        /// <summary> Initializes a new instance of AutoRestValidationTestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        internal AutoRestValidationTestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "1.0.0")
        {
            RestClient = new AutoRestValidationTestRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Validates input parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Product>> ValidationOfMethodParametersAsync(string resourceGroupName, int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.ValidationOfMethodParameters");
            scope.Start();
            try
            {
                return await RestClient.ValidationOfMethodParametersAsync(resourceGroupName, id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validates input parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Product> ValidationOfMethodParameters(string resourceGroupName, int id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.ValidationOfMethodParameters");
            scope.Start();
            try
            {
                return RestClient.ValidationOfMethodParameters(resourceGroupName, id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validates body parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Product>> ValidationOfBodyAsync(string resourceGroupName, int id, Product body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.ValidationOfBody");
            scope.Start();
            try
            {
                return await RestClient.ValidationOfBodyAsync(resourceGroupName, id, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validates body parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Product> ValidationOfBody(string resourceGroupName, int id, Product body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.ValidationOfBody");
            scope.Start();
            try
            {
                return RestClient.ValidationOfBody(resourceGroupName, id, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetWithConstantInPathAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.GetWithConstantInPath");
            scope.Start();
            try
            {
                return await RestClient.GetWithConstantInPathAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetWithConstantInPath(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.GetWithConstantInPath");
            scope.Start();
            try
            {
                return RestClient.GetWithConstantInPath(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Product>> PostWithConstantInBodyAsync(Product body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.PostWithConstantInBody");
            scope.Start();
            try
            {
                return await RestClient.PostWithConstantInBodyAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Product> PostWithConstantInBody(Product body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoRestValidationTestClient.PostWithConstantInBody");
            scope.Start();
            try
            {
                return RestClient.PostWithConstantInBody(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
