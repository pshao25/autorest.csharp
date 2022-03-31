// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace ResourceClients_LowLevel
{
    /// <summary> The ResourceService service client. </summary>
    public partial class ResourceServiceClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ResourceServiceClient for mocking. </summary>
        protected ResourceServiceClient()
        {
        }

        /// <summary> Initializes a new instance of ResourceServiceClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public ResourceServiceClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new ResourceServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ResourceServiceClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public ResourceServiceClient(AzureKeyCredential credential, Uri endpoint, ResourceServiceClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ResourceServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Method that belongs to the top level service. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetParametersAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ResourceServiceClient.GetParameters");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetParametersRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Method that belongs to the top level service. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetParameters(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ResourceServiceClient.GetParameters");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetParametersRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all groups. It is defined in `Group` subclient, but must be promoted to the `Service` client. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetGroupsAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ResourceServiceClient.GetGroups");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetGroupsRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all groups. It is defined in `Group` subclient, but must be promoted to the `Service` client. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetGroups(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ResourceServiceClient.GetGroups");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetGroupsRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all items. It is defined in `Item` subclient, but must be promoted to the `Service` client, because it has neither `groupId` nor `itemId` parameters. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual AsyncPageable<BinaryData> GetAllItemsAsync(RequestContext context = null)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "ResourceServiceClient.GetAllItems");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAllItemsRequest(context)
                        : CreateGetAllItemsNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Get all items. It is defined in `Item` subclient, but must be promoted to the `Service` client, because it has neither `groupId` nor `itemId` parameters. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Pageable<BinaryData> GetAllItems(RequestContext context = null)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "ResourceServiceClient.GetAllItems");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAllItemsRequest(context)
                        : CreateGetAllItemsNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Initializes a new instance of ResourceGroup. </summary>
        /// <param name="groupId"> Group identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ResourceGroup GetResourceGroup(string groupId)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            return new ResourceGroup(ClientDiagnostics, _pipeline, _keyCredential, groupId, _endpoint);
        }

        internal HttpMessage CreateGetParametersRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetGroupsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/groups", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAllItemsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/items", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAllItemsNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
