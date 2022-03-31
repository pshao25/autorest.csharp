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
    /// <summary> The Polymorphism service client. </summary>
    public partial class PolymorphismClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PolymorphismClient for mocking. </summary>
        protected PolymorphismClient()
        {
        }

        /// <summary> Initializes a new instance of PolymorphismClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public PolymorphismClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new AutoRestComplexTestServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of PolymorphismClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public PolymorphismClient(AzureKeyCredential credential, Uri endpoint, AutoRestComplexTestServiceClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new AutoRestComplexTestServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fishtype: string,
        ///   species: string,
        ///   length: number,
        ///   siblings: [Fish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetValidAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetValid");
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

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fishtype: string,
        ///   species: string,
        ///   length: number,
        ///   siblings: [Fish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetValid(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetValid");
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

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [Fish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> PutValidAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutValid");
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

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [Fish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response PutValid(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutValid");
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

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fish.type: string,
        ///   species: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetDotSyntaxAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetDotSyntax");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDotSyntaxRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fish.type: string,
        ///   species: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetDotSyntax(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetDotSyntax");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDotSyntaxRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   sampleSalmon: {
        ///     fish.type: string,
        ///     species: string,
        ///     location: string,
        ///     iswild: boolean
        ///   },
        ///   salmons: [DotSalmon],
        ///   sampleFish: {
        ///     fish.type: string,
        ///     species: string
        ///   },
        ///   fishes: [DotFish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetComposedWithDiscriminatorAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithDiscriminator");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetComposedWithDiscriminatorRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   sampleSalmon: {
        ///     fish.type: string,
        ///     species: string,
        ///     location: string,
        ///     iswild: boolean
        ///   },
        ///   salmons: [DotSalmon],
        ///   sampleFish: {
        ///     fish.type: string,
        ///     species: string
        ///   },
        ///   fishes: [DotFish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetComposedWithDiscriminator(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithDiscriminator");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetComposedWithDiscriminatorRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   sampleSalmon: {
        ///     fish.type: string,
        ///     species: string,
        ///     location: string,
        ///     iswild: boolean
        ///   },
        ///   salmons: [DotSalmon],
        ///   sampleFish: {
        ///     fish.type: string,
        ///     species: string
        ///   },
        ///   fishes: [DotFish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetComposedWithoutDiscriminatorAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithoutDiscriminator");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetComposedWithoutDiscriminatorRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   sampleSalmon: {
        ///     fish.type: string,
        ///     species: string,
        ///     location: string,
        ///     iswild: boolean
        ///   },
        ///   salmons: [DotSalmon],
        ///   sampleFish: {
        ///     fish.type: string,
        ///     species: string
        ///   },
        ///   fishes: [DotFish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetComposedWithoutDiscriminator(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithoutDiscriminator");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetComposedWithoutDiscriminatorRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fishtype: string,
        ///   species: string,
        ///   length: number,
        ///   siblings: [
        ///     {
        ///       fishtype: string,
        ///       species: string,
        ///       length: number,
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetComplicatedAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetComplicated");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetComplicatedRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fishtype: string,
        ///   species: string,
        ///   length: number,
        ///   siblings: [
        ///     {
        ///       fishtype: string,
        ///       species: string,
        ///       length: number,
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetComplicated(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.GetComplicated");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetComplicatedRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [
        ///     {
        ///       fishtype: string (required),
        ///       species: string,
        ///       length: number (required),
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> PutComplicatedAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutComplicated");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutComplicatedRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [
        ///     {
        ///       fishtype: string (required),
        ///       species: string,
        ///       length: number (required),
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response PutComplicated(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutComplicated");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutComplicatedRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [
        ///     {
        ///       fishtype: string (required),
        ///       species: string,
        ///       length: number (required),
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fishtype: string,
        ///   species: string,
        ///   length: number,
        ///   siblings: [
        ///     {
        ///       fishtype: string,
        ///       species: string,
        ///       length: number,
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> PutMissingDiscriminatorAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutMissingDiscriminator");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutMissingDiscriminatorRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [
        ///     {
        ///       fishtype: string (required),
        ///       species: string,
        ///       length: number (required),
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   fishtype: string,
        ///   species: string,
        ///   length: number,
        ///   siblings: [
        ///     {
        ///       fishtype: string,
        ///       species: string,
        ///       length: number,
        ///       siblings: [Fish]
        ///     }
        ///   ],
        ///   location: string,
        ///   iswild: boolean
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response PutMissingDiscriminator(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutMissingDiscriminator");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutMissingDiscriminatorRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [Fish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> PutValidMissingRequiredAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutValidMissingRequired");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidMissingRequiredRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   fishtype: string (required),
        ///   species: string,
        ///   length: number (required),
        ///   siblings: [Fish]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response PutValidMissingRequired(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphismClient.PutValidMissingRequired");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidMissingRequiredRequest(content, context);
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
            uri.AppendPath("/complex/polymorphism/valid", false);
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
            uri.AppendPath("/complex/polymorphism/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetDotSyntaxRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/dotsyntax", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetComposedWithDiscriminatorRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/composedWithDiscriminator", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetComposedWithoutDiscriminatorRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/composedWithoutDiscriminator", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetComplicatedRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/complicated", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePutComplicatedRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/complicated", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreatePutMissingDiscriminatorRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/missingdiscriminator", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreatePutValidMissingRequiredRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphism/missingrequired/invalid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
