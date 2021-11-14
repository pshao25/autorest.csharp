// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace CollapseRequestConditions
{
    /// <summary> The MatchConditionCollapse service client. </summary>
    public partial class MatchConditionCollapseClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of MatchConditionCollapseClient for mocking. </summary>
        protected MatchConditionCollapseClient()
        {
        }

        /// <summary> Initializes a new instance of MatchConditionCollapseClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public MatchConditionCollapseClient(AzureKeyCredential credential, Uri endpoint = null, CollapseRequestConditionsClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");
            options ??= new CollapseRequestConditionsClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <param name="otherHeader"> other header. </param>
        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CollapseGetWithHeadAsync(string otherHeader = null, MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.CollapseGetWithHead");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapseGetWithHeadRequest(otherHeader, matchConditions);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="otherHeader"> other header. </param>
        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual Response CollapseGetWithHead(string otherHeader = null, MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.CollapseGetWithHead");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapseGetWithHeadRequest(otherHeader, matchConditions);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CollapsePutAsync(RequestContent content, MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.CollapsePut");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapsePutRequest(content, matchConditions);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual Response CollapsePut(RequestContent content, MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.CollapsePut");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapsePutRequest(content, matchConditions);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CollapseGetAsync(MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.CollapseGet");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapseGetRequest(matchConditions);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual Response CollapseGet(MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.CollapseGet");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapseGetRequest(matchConditions);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="ifModifiedSince"> Specify this header value to operate only on a blob if it has been modified since the specified date/time. </param>
        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> MulticollapseGetAsync(DateTimeOffset? ifModifiedSince = null, MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.MulticollapseGet");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMulticollapseGetRequest(ifModifiedSince, matchConditions);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="ifModifiedSince"> Specify this header value to operate only on a blob if it has been modified since the specified date/time. </param>
        /// <param name="matchConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="context"> The request context. </param>
#pragma warning disable AZC0002
        public virtual Response MulticollapseGet(DateTimeOffset? ifModifiedSince = null, MatchConditions matchConditions = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("MatchConditionCollapseClient.MulticollapseGet");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMulticollapseGetRequest(ifModifiedSince, matchConditions);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCollapseGetWithHeadRequest(string otherHeader, MatchConditions matchConditions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/MatchConditionCollapse/withHead", false);
            request.Uri = uri;
            if (otherHeader != null)
            {
                request.Headers.Add("otherHeader", otherHeader);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCollapsePutRequest(RequestContent content, MatchConditions matchConditions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/MatchConditionCollapse/", false);
            request.Uri = uri;
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCollapseGetRequest(MatchConditions matchConditions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/MatchConditionCollapse/", false);
            request.Uri = uri;
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateMulticollapseGetRequest(DateTimeOffset? ifModifiedSince, MatchConditions matchConditions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/MatchConditionCollapse/multi", false);
            request.Uri = uri;
            if (ifModifiedSince != null)
            {
                request.Headers.Add("If-Modified-Since", ifModifiedSince.Value, "R");
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
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
