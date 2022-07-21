// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_complex_LowLevel
{
    /// <summary> The Basic service client. </summary>
    public partial class BasicClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of BasicClient for mocking. </summary>
        protected BasicClient()
        {
        }

        /// <summary> Initializes a new instance of BasicClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public BasicClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new AutoRestComplexTestServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of BasicClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public BasicClient(AzureKeyCredential credential, Uri endpoint, AutoRestComplexTestServiceClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new AutoRestComplexTestServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get complex type {id: 2, name: &apos;abc&apos;, color: &apos;YELLOW&apos;}. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetValidAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = await client.GetValidAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetValidAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetValidRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex type {id: 2, name: &apos;abc&apos;, color: &apos;YELLOW&apos;}. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetValid and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = client.GetValid();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetValid(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetValidRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Please put {id: 2, name: &apos;abc&apos;, color: &apos;Magenta&apos;}. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call PutValidAsync.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// var data = new {};
        /// 
        /// Response response = await client.PutValidAsync(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// This sample shows how to call PutValidAsync with all request content.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// var data = new {
        ///     id = 1234,
        ///     name = "<Name property with a very long description that does not fit on a single line and a line break.>",
        ///     color = "cyan",
        /// };
        /// 
        /// Response response = await client.PutValidAsync(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request payload.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> PutValidAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BasicClient.PutValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Please put {id: 2, name: &apos;abc&apos;, color: &apos;Magenta&apos;}. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call PutValid.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// var data = new {};
        /// 
        /// Response response = client.PutValid(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// This sample shows how to call PutValid with all request content.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// var data = new {
        ///     id = 1234,
        ///     name = "<Name property with a very long description that does not fit on a single line and a line break.>",
        ///     color = "cyan",
        /// };
        /// 
        /// Response response = client.PutValid(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request payload.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response PutValid(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BasicClient.PutValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type that is invalid for the local strong type. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetInvalidAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = await client.GetInvalidAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetInvalidAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetInvalid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetInvalidRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type that is invalid for the local strong type. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetInvalid and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = client.GetInvalid();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetInvalid(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetInvalid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetInvalidRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type that is empty. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetEmptyAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = await client.GetEmptyAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetEmptyAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetEmpty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEmptyRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type that is empty. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetEmpty and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = client.GetEmpty();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetEmpty(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetEmpty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEmptyRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type whose properties are null. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetNullAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = await client.GetNullAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetNullAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetNull");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNullRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type whose properties are null. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetNull and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = client.GetNull();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetNull(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetNull");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNullRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type while the server doesn&apos;t provide a response payload. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetNotProvidedAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = await client.GetNotProvidedAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetNotProvidedAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetNotProvided");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNotProvidedRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a basic complex type while the server doesn&apos;t provide a response payload. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetNotProvided and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new BasicClient(credential);
        /// 
        /// Response response = client.GetNotProvided();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("id").ToString());
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// Console.WriteLine(result.GetProperty("color").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Basic</c>:
        /// <code>{
        ///   id: number, # Optional. Basic Id
        ///   name: string, # Optional. Name property with a very long description that does not fit on a single line and a line break.
        ///   color: &quot;cyan&quot; | &quot;Magenta&quot; | &quot;YELLOW&quot; | &quot;blacK&quot;, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetNotProvided(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BasicClient.GetNotProvided");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetNotProvidedRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetValidRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/basic/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePutValidRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/basic/valid", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetInvalidRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/basic/invalid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetEmptyRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/basic/empty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetNullRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/basic/null", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetNotProvidedRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/basic/notprovided", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
