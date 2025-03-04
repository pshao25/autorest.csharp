// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Encode.Bytes
{
    // Data plane generated sub-client.
    /// <summary> The Header sub-client. </summary>
    public partial class Header
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Header for mocking. </summary>
        protected Header()
        {
        }

        /// <summary> Initializes a new instance of Header. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        internal Header(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Default.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='DefaultAsync(BinaryData,RequestContext)']/*" />
        public virtual async Task<Response> DefaultAsync(BinaryData value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Default");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDefaultRequest(value, context);
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
        /// [Protocol Method] Default.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Default(BinaryData,RequestContext)']/*" />
        public virtual Response Default(BinaryData value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Default");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDefaultRequest(value, context);
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
        /// [Protocol Method] Base 64.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Base64Async(BinaryData,RequestContext)']/*" />
        public virtual async Task<Response> Base64Async(BinaryData value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Base64");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBase64Request(value, context);
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
        /// [Protocol Method] Base 64.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Base64(BinaryData,RequestContext)']/*" />
        public virtual Response Base64(BinaryData value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Base64");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBase64Request(value, context);
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
        /// [Protocol Method] Base 64url.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Base64urlAsync(BinaryData,RequestContext)']/*" />
        public virtual async Task<Response> Base64urlAsync(BinaryData value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Base64url");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBase64urlRequest(value, context);
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
        /// [Protocol Method] Base 64url.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Base64url(BinaryData,RequestContext)']/*" />
        public virtual Response Base64url(BinaryData value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Base64url");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBase64urlRequest(value, context);
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
        /// [Protocol Method] Base 64url array.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Base64urlArrayAsync(IEnumerable{BinaryData},RequestContext)']/*" />
        public virtual async Task<Response> Base64urlArrayAsync(IEnumerable<BinaryData> value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Base64urlArray");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBase64urlArrayRequest(value, context);
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
        /// [Protocol Method] Base 64url array.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="value"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="BinaryData"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Base64urlArray(IEnumerable{BinaryData},RequestContext)']/*" />
        public virtual Response Base64urlArray(IEnumerable<BinaryData> value, RequestContext context = null)
        {
            Argument.AssertNotNull(value, nameof(value));

            using var scope = ClientDiagnostics.CreateScope("Header.Base64urlArray");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBase64urlArrayRequest(value, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateDefaultRequest(BinaryData value, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/bytes/header/default", false);
            request.Uri = uri;
            request.Headers.Add("value", value.ToArray(), "D");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateBase64Request(BinaryData value, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/bytes/header/base64", false);
            request.Uri = uri;
            request.Headers.Add("value", value.ToArray(), "D");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateBase64urlRequest(BinaryData value, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/bytes/header/base64url", false);
            request.Uri = uri;
            request.Headers.Add("value", value.ToArray(), "U");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateBase64urlArrayRequest(IEnumerable<BinaryData> value, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/bytes/header/base64url-array", false);
            request.Uri = uri;
            request.Headers.AddDelimited("value", value, ",", "U");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
