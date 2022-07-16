// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace CadlFirstTest
{
    /// <summary> The Demo service client. </summary>
    public partial class DemoClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DemoClient for mocking. </summary>
        protected DemoClient()
        {
        }

        /// <summary> Initializes a new instance of DemoClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="apiVersion"> The string to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DemoClient(Uri endpoint, string apiVersion) : this(endpoint, apiVersion, new DemoHelloworldClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DemoClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="apiVersion"> The string to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DemoClient(Uri endpoint, string apiVersion, DemoHelloworldClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));
            options ??= new DemoHelloworldClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> SayHiAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("DemoClient.SayHi");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSayHiRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response SayHi(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("DemoClient.SayHi");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSayHiRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateSayHiRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/partOfUri", false);
            uri.AppendPath("/hello", false);
            uri.AppendQuery("apiVersion", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
