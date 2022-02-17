// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using validation.Models;

namespace validation
{
    internal partial class AutoRestValidationTestRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly string _apiVersion;

        /// <summary> server parameter. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AutoRestValidationTestRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public AutoRestValidationTestRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "1.0.0")
        {
            _subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            Endpoint = endpoint ?? new Uri("http://localhost:3000");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateValidationOfMethodParametersRequest(string resourceGroupName, int id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/fakepath/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("apiVersion", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Validates input parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<Product>> ValidationOfMethodParametersAsync(string resourceGroupName, int id, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateValidationOfMethodParametersRequest(resourceGroupName, id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Product value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Product.DeserializeProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Validates input parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<Product> ValidationOfMethodParameters(string resourceGroupName, int id, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateValidationOfMethodParametersRequest(resourceGroupName, id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Product value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Product.DeserializeProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidationOfBodyRequest(string resourceGroupName, int id, Product body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/fakepath/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("apiVersion", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Validates body parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<Product>> ValidationOfBodyAsync(string resourceGroupName, int id, Product body = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateValidationOfBodyRequest(resourceGroupName, id, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Product value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Product.DeserializeProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Validates body parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<Product> ValidationOfBody(string resourceGroupName, int id, Product body = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateValidationOfBodyRequest(resourceGroupName, id, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Product value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Product.DeserializeProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetWithConstantInPathRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/validation/constantsInPath/", false);
            uri.AppendPath("constant", true);
            uri.AppendPath("/value", false);
            request.Uri = uri;
            return message;
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> GetWithConstantInPathAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetWithConstantInPathRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetWithConstantInPath(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetWithConstantInPathRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostWithConstantInBodyRequest(Product body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/validation/constantsInPath/", false);
            uri.AppendPath("constant", true);
            uri.AppendPath("/value", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Product>> PostWithConstantInBodyAsync(Product body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostWithConstantInBodyRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Product value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Product.DeserializeProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Product> PostWithConstantInBody(Product body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostWithConstantInBodyRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Product value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Product.DeserializeProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
