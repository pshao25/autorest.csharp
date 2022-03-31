// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace httpInfrastructure_LowLevel
{
    /// <summary> The HttpFailure service client. </summary>
    public partial class HttpFailureClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of HttpFailureClient for mocking. </summary>
        protected HttpFailureClient()
        {
        }

        /// <summary> Initializes a new instance of HttpFailureClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public HttpFailureClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new AutoRestHttpInfrastructureTestServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of HttpFailureClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public HttpFailureClient(AzureKeyCredential credential, Uri endpoint, AutoRestHttpInfrastructureTestServiceClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new AutoRestHttpInfrastructureTestServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetEmptyErrorAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("HttpFailureClient.GetEmptyError");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEmptyErrorRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetEmptyError(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("HttpFailureClient.GetEmptyError");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEmptyErrorRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetNoModelErrorAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("HttpFailureClient.GetNoModelError");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNoModelErrorRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetNoModelError(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("HttpFailureClient.GetNoModelError");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNoModelErrorRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty response from server. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetNoModelEmptyAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("HttpFailureClient.GetNoModelEmpty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNoModelEmptyRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty response from server. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetNoModelEmpty(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("HttpFailureClient.GetNoModelEmpty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNoModelEmptyRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetEmptyErrorRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/http/failure/emptybody/error", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetNoModelErrorRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/http/failure/nomodel/error", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetNoModelEmptyRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/http/failure/nomodel/empty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
