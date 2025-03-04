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
using Client.Structure.Service.Models;

namespace Client.Structure.Service
{
    // Data plane generated client.
    /// <summary>
    /// Test that we can use @client and @operationGroup decorators to customize client side code structure, such as:
    /// 1. have everything as default.
    /// 2. to rename client or operation group
    /// 3. one client can have more than one operations groups
    /// 4. split one interface into two clients
    /// 5. have two clients with operations come from different interfaces
    /// 6. have two clients with a hierarchy relation.
    /// </summary>
    public partial class ServiceClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly ClientType _client;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }

        /// <summary> Initializes a new instance of ServiceClient. </summary>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="client"> Need to be set as 'default', 'multi-client', 'renamed-operation', 'two-operation-group' in client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ServiceClient(Uri endpoint, ClientType client) : this(endpoint, client, new ServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ServiceClient. </summary>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="client"> Need to be set as 'default', 'multi-client', 'renamed-operation', 'two-operation-group' in client. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ServiceClient(Uri endpoint, ClientType client, ServiceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _client = client;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] One.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ServiceClient.xml" path="doc/members/member[@name='OneAsync(RequestContext)']/*" />
        public virtual async Task<Response> OneAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServiceClient.One");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] One.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ServiceClient.xml" path="doc/members/member[@name='One(RequestContext)']/*" />
        public virtual Response One(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServiceClient.One");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Two.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ServiceClient.xml" path="doc/members/member[@name='TwoAsync(RequestContext)']/*" />
        public virtual async Task<Response> TwoAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServiceClient.Two");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTwoRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Two.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ServiceClient.xml" path="doc/members/member[@name='Two(RequestContext)']/*" />
        public virtual Response Two(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServiceClient.Two");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTwoRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private Baz _cachedBaz;
        private Qux _cachedQux;
        private Foo _cachedFoo;
        private Bar _cachedBar;

        /// <summary> Initializes a new instance of Baz. </summary>
        public virtual Baz GetBazClient()
        {
            return Volatile.Read(ref _cachedBaz) ?? Interlocked.CompareExchange(ref _cachedBaz, new Baz(ClientDiagnostics, _pipeline, _endpoint, _client), null) ?? _cachedBaz;
        }

        /// <summary> Initializes a new instance of Qux. </summary>
        public virtual Qux GetQuxClient()
        {
            return Volatile.Read(ref _cachedQux) ?? Interlocked.CompareExchange(ref _cachedQux, new Qux(ClientDiagnostics, _pipeline, _endpoint, _client), null) ?? _cachedQux;
        }

        /// <summary> Initializes a new instance of Foo. </summary>
        public virtual Foo GetFooClient()
        {
            return Volatile.Read(ref _cachedFoo) ?? Interlocked.CompareExchange(ref _cachedFoo, new Foo(ClientDiagnostics, _pipeline, _endpoint, _client), null) ?? _cachedFoo;
        }

        /// <summary> Initializes a new instance of Bar. </summary>
        public virtual Bar GetBarClient()
        {
            return Volatile.Read(ref _cachedBar) ?? Interlocked.CompareExchange(ref _cachedBar, new Bar(ClientDiagnostics, _pipeline, _endpoint, _client), null) ?? _cachedBar;
        }

        internal HttpMessage CreateOneRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/client/structure/", false);
            uri.AppendRaw(_client.ToSerialString(), true);
            uri.AppendPath("/one", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateTwoRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/client/structure/", false);
            uri.AppendRaw(_client.ToSerialString(), true);
            uri.AppendPath("/two", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
