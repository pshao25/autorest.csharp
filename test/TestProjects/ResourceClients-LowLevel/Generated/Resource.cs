// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace ResourceClients_LowLevel
{
    /// <summary> The Resource service client. </summary>
    public partial class Resource
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> Group identifier. </summary>
        public virtual string GroupId { get; }
        /// <summary> Item identifier. </summary>
        public virtual string ItemId { get; }
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> The HTTP Uri. </summary>
        public virtual Uri Uri => _endpoint;

        /// <summary> Initializes a new instance of Resource for mocking. </summary>
        protected Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="clientDiagnostics"> The ClientDiagnostics instance to use. </param>
        /// <param name="pipeline"> The pipeline instance to use. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="groupId"> Group identifier. </param>
        /// <param name="itemId"> Item identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="groupId"/>, or <paramref name="itemId"/> is null. </exception>
        internal Resource(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, string groupId, string itemId, Uri endpoint = null)
        {
            Argument.AssertNotNull(clientDiagnostics, nameof(clientDiagnostics));
            Argument.AssertNotNull(pipeline, nameof(pipeline));
            Argument.AssertNotNull(groupId, nameof(groupId));
            Argument.AssertNotNull(itemId, nameof(itemId));
            endpoint ??= new Uri("http://localhost:3000");

            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            GroupId = groupId;
            ItemId = itemId;
            _endpoint = endpoint;
        }

        /// <summary> Get an item. Method should stay in `Item` subclient. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetItemAsync(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("Resource.GetItem");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemRequest(context);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an item. Method should stay in `Item` subclient. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
#pragma warning disable AZC0002
        public virtual Response GetItem(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("Resource.GetItem");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemRequest(context);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetItemRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/items/", false);
            uri.AppendPath(GroupId, true);
            uri.AppendPath("/", false);
            uri.AppendPath(ItemId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
