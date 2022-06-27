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
using ProtocolMethodsInRestClient.Models;

namespace ProtocolMethodsInRestClient
{
    /// <summary> The ThirdTemplate service client. </summary>
    public partial class ThirdTemplateClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ThirdTemplateRestClient RestClient { get; }

        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of ThirdTemplateClient for mocking. </summary>
        protected ThirdTemplateClient()
        {
        }

        /// <summary> Initializes a new instance of ThirdTemplateClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ThirdTemplateClient(AzureKeyCredential credential, Uri endpoint = null, TestServiceClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new TestServiceClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Fake-Subscription-Key"));
            RestClient = new ThirdTemplateRestClient(_clientDiagnostics, _pipeline, endpoint);
            Endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of ThirdTemplateClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal ThirdTemplateClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ThirdTemplateRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            Endpoint = endpoint;
        }

        /// <summary> Delete resource. </summary>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ThirdTemplateClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete resource. </summary>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ThirdTemplateClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about the resource. </summary>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Resource>> GetAsync(string resourceId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ThirdTemplateClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about the resource. </summary>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Resource> Get(string resourceId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ThirdTemplateClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update resource. </summary>
        /// <param name="resource"> Information about the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Resource>> CreateAsync(Resource resource = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ThirdTemplateClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(resource, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update resource. </summary>
        /// <param name="resource"> Information about the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Resource> Create(Resource resource = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ThirdTemplateClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(resource, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
