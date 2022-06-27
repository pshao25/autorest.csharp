// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    /// <summary> The XMsClientRequestId service client. </summary>
    public partial class XMsClientRequestIdClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal XMsClientRequestIdRestClient RestClient { get; }

        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of XMsClientRequestIdClient for mocking. </summary>
        protected XMsClientRequestIdClient()
        {
        }

        /// <summary> Initializes a new instance of XMsClientRequestIdClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal XMsClientRequestIdClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new XMsClientRequestIdRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            Endpoint = endpoint;
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("XMsClientRequestIdClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("XMsClientRequestIdClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ParamGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("XMsClientRequestIdClient.ParamGet");
            scope.Start();
            try
            {
                return await RestClient.ParamGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ParamGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("XMsClientRequestIdClient.ParamGet");
            scope.Start();
            try
            {
                return RestClient.ParamGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
