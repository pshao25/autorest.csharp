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

namespace CadlFirstTest
{
    // Data plane generated client. This is a sample cadl project.
    /// <summary> This is a sample cadl project. </summary>
    public partial class CadlFirstTestClient
    {
        private const string AuthorizationHeader = "x-ms-api-key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://api.example.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of CadlFirstTestClient for mocking. </summary>
        protected CadlFirstTestClient()
        {
        }

        /// <summary> Initializes a new instance of CadlFirstTestClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public CadlFirstTestClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:300"), new CadlfirsttestClientOptions())
        {
        }

        /// <summary> Initializes a new instance of CadlFirstTestClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public CadlFirstTestClient(TokenCredential credential) : this(credential, new Uri("http://localhost:300"), new CadlfirsttestClientOptions())
        {
        }

        /// <summary> Initializes a new instance of CadlFirstTestClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> Endpoint Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public CadlFirstTestClient(AzureKeyCredential credential, Uri endpoint, CadlfirsttestClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new CadlfirsttestClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Initializes a new instance of CadlFirstTestClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> Endpoint Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public CadlFirstTestClient(TokenCredential credential, Uri endpoint, CadlfirsttestClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new CadlfirsttestClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> top level method. </summary>
        /// <param name="action"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="action"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<Response<Thing>> TopActionValueAsync(string action, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.TopActionValue");
            scope.Start();
            try
            {
                RequestContext context = FromCancellationToken(cancellationToken);
                Response response = await TopActionAsync(action, context).ConfigureAwait(false);
                return Response.FromValue(Thing.FromResponse(response), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level method. </summary>
        /// <param name="action"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="action"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual Response<Thing> TopActionValue(string action, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.TopActionValue");
            scope.Start();
            try
            {
                RequestContext context = FromCancellationToken(cancellationToken);
                Response response = TopAction(action, context);
                return Response.FromValue(Thing.FromResponse(response), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level method. </summary>
        /// <param name="action"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="action"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call TopActionAsync with required parameters and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// Response response = await client.TopActionAsync("<action>");
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> TopActionAsync(string action, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.TopAction");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTopActionRequest(action, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level method. </summary>
        /// <param name="action"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="action"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call TopAction with required parameters and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// Response response = client.TopAction("<action>");
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response TopAction(string action, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.TopAction");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTopActionRequest(action, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level method2. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call TopAction2Async and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// Response response = await client.TopAction2Async();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> TopAction2Async(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.TopAction2");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTopAction2Request(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level method2. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call TopAction2 and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// Response response = client.TopAction2();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response TopAction2(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.TopAction2");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTopAction2Request(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level patch. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call PatchActionAsync with required request content and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// var data = new {
        ///     name = "<name>",
        /// };
        /// 
        /// Response response = await client.PatchActionAsync(RequestContent.Create(data));
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> PatchActionAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.PatchAction");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePatchActionRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> top level patch. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call PatchAction with required request content and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// var data = new {
        ///     name = "<name>",
        /// };
        /// 
        /// Response response = client.PatchAction(RequestContent.Create(data));
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response PatchAction(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.PatchAction");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePatchActionRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> body parameter without body decorator. </summary>
        /// <param name="thing"> The Thing to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="thing"/> is null. </exception>
        public virtual async Task<Response<Thing>> AnonymousBodyAsync(Thing thing, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(thing, nameof(thing));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await AnonymousBodyAsync(thing.ToRequestContent(), context).ConfigureAwait(false);
            return Response.FromValue(Thing.FromResponse(response), response);
        }

        /// <summary> body parameter without body decorator. </summary>
        /// <param name="thing"> The Thing to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="thing"/> is null. </exception>
        public virtual Response<Thing> AnonymousBody(Thing thing, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(thing, nameof(thing));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = AnonymousBody(thing.ToRequestContent(), context);
            return Response.FromValue(Thing.FromResponse(response), response);
        }

        /// <summary> body parameter without body decorator. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call AnonymousBodyAsync with required request content and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// var data = new {
        ///     name = "<name>",
        /// };
        /// 
        /// Response response = await client.AnonymousBodyAsync(RequestContent.Create(data));
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> AnonymousBodyAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.AnonymousBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnonymousBodyRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> body parameter without body decorator. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call AnonymousBody with required request content and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new CadlFirstTestClient(credential);
        /// 
        /// var data = new {
        ///     name = "<name>",
        /// };
        /// 
        /// Response response = client.AnonymousBody(RequestContent.Create(data));
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response AnonymousBody(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("CadlFirstTestClient.AnonymousBody");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnonymousBodyRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateTopActionRequest(string action, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/top/", false);
            uri.AppendPath(action, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateTopAction2Request(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/top2", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePatchActionRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/patch", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateAnonymousBodyRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/anonymousBody", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
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
