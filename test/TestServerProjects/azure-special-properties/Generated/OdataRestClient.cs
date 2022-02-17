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

namespace azure_special_properties
{
    internal partial class OdataRestClient
    {
        private readonly HttpPipeline _pipeline;

        /// <summary> server parameter. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of OdataRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public OdataRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            Endpoint = endpoint ?? new Uri("http://localhost:3000");
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetWithFilterRequest(string filter, int? top, string orderby)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/azurespecials/odata/filter", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Specify filter parameter with value &apos;$filter=id gt 5 and name eq &apos;foo&apos;&amp;$orderby=id&amp;$top=10&apos;. </summary>
        /// <param name="filter"> The filter parameter with value &apos;$filter=id gt 5 and name eq &apos;foo&apos;&apos;. </param>
        /// <param name="top"> The top parameter with value 10. </param>
        /// <param name="orderby"> The orderby parameter with value id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> GetWithFilterAsync(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetWithFilterRequest(filter, top, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Specify filter parameter with value &apos;$filter=id gt 5 and name eq &apos;foo&apos;&amp;$orderby=id&amp;$top=10&apos;. </summary>
        /// <param name="filter"> The filter parameter with value &apos;$filter=id gt 5 and name eq &apos;foo&apos;&apos;. </param>
        /// <param name="top"> The top parameter with value 10. </param>
        /// <param name="orderby"> The orderby parameter with value id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetWithFilter(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetWithFilterRequest(filter, top, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
