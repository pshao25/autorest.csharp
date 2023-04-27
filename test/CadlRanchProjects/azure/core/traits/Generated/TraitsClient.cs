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
using _Specs_.Azure.Core.Traits.Models;

namespace _Specs_.Azure.Core.Traits
{
    // Data plane generated client.
    /// <summary> Illustrates Azure Core operation customizations by traits. </summary>
    public partial class TraitsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of TraitsClient. </summary>
        public TraitsClient() : this(new Uri("http://localhost:3000"), new TraitsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of TraitsClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public TraitsClient(Uri endpoint, TraitsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new TraitsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get a resource, sending and receiving headers. </summary>
        /// <param name="id"> The user&apos;s id. </param>
        /// <param name="foo"> header in request. </param>
        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="foo"/> is null. </exception>
        public virtual async Task<Response<User>> SmokeTestAsync(int id, string foo, RequestConditions requestConditions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(foo, nameof(foo));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await SmokeTestAsync(id, foo, requestConditions, context).ConfigureAwait(false);
            return Response.FromValue(User.FromResponse(response), response);
        }

        /// <summary> Get a resource, sending and receiving headers. </summary>
        /// <param name="id"> The user&apos;s id. </param>
        /// <param name="foo"> header in request. </param>
        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="foo"/> is null. </exception>
        public virtual Response<User> SmokeTest(int id, string foo, RequestConditions requestConditions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(foo, nameof(foo));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = SmokeTest(id, foo, requestConditions, context);
            return Response.FromValue(User.FromResponse(response), response);
        }

        /// <summary> Get a resource, sending and receiving headers. </summary>
        /// <param name="id"> The user&apos;s id. </param>
        /// <param name="foo"> header in request. </param>
        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="foo"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/TraitsClient.xml" path="doc/members/member[@name='SmokeTestAsync(int,string,global::Azure.RequestConditions,global::Azure.RequestContext)']/*" />
        public virtual async Task<Response> SmokeTestAsync(int id, string foo, RequestConditions requestConditions, RequestContext context)
        {
            Argument.AssertNotNull(foo, nameof(foo));

            using var scope = ClientDiagnostics.CreateScope("TraitsClient.SmokeTest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSmokeTestRequest(id, foo, requestConditions, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a resource, sending and receiving headers. </summary>
        /// <param name="id"> The user&apos;s id. </param>
        /// <param name="foo"> header in request. </param>
        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="foo"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/TraitsClient.xml" path="doc/members/member[@name='SmokeTest(int,string,global::Azure.RequestConditions,global::Azure.RequestContext)']/*" />
        public virtual Response SmokeTest(int id, string foo, RequestConditions requestConditions, RequestContext context)
        {
            Argument.AssertNotNull(foo, nameof(foo));

            using var scope = ClientDiagnostics.CreateScope("TraitsClient.SmokeTest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSmokeTestRequest(id, foo, requestConditions, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateSmokeTestRequest(int id, string foo, RequestConditions requestConditions, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/azure/core/traits/user/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("foo", foo);
            request.Headers.Add("Accept", "application/json");
            if (requestConditions != null)
            {
                request.Headers.Add(requestConditions, "O");
            }
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
