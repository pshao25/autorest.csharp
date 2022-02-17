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
using PublicClientCtor.Models;

namespace PublicClientCtor
{
    internal partial class PublicClientCtorRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _param1;
        private readonly string _param2;
        private readonly string _apiVersion;

        /// <summary> server parameter. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of PublicClientCtorRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="param1"> Tesing Param1. </param>
        /// <param name="param2"> Testing Param2. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public PublicClientCtorRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string param1 = "value1", string param2 = null, string apiVersion = "1.0.0")
        {
            Endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _param1 = param1;
            _param2 = param2;
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateOperationRequest(TestModel value)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendRaw("/publicclientctor/1.0.0", false);
            uri.AppendPath("/op", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (_param1 != null)
            {
                request.Headers.Add("Param1", _param1);
            }
            if (_param2 != null)
            {
                request.Headers.Add("Param2", _param2);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(value);
            request.Content = content;
            return message;
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public async Task<Response> OperationAsync(TestModel value, CancellationToken cancellationToken = default)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateOperationRequest(value);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Response Operation(TestModel value, CancellationToken cancellationToken = default)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateOperationRequest(value);
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
