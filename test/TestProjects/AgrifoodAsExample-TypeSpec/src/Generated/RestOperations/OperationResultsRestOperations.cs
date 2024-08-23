// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AgFoodPlatform.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    internal partial class OperationResultsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of OperationResultsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public OperationResultsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string locations, string operationResultsId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/locations/", false);
            uri.AppendPath(locations, true);
            uri.AppendPath("/operationResults/", false);
            uri.AppendPath(operationResultsId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string locations, string operationResultsId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/locations/", false);
            uri.AppendPath(locations, true);
            uri.AppendPath("/operationResults/", false);
            uri.AppendPath(operationResultsId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get operationResults for a Data Manager For Agriculture resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="locations"> Location. </param>
        /// <param name="operationResultsId"> operationResultsId for a specific location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locations"/> or <paramref name="operationResultsId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="locations"/> or <paramref name="operationResultsId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ArmAsyncOperation>> GetAsync(string subscriptionId, string locations, string operationResultsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locations, nameof(locations));
            Argument.AssertNotNullOrEmpty(operationResultsId, nameof(operationResultsId));

            using var message = CreateGetRequest(subscriptionId, locations, operationResultsId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmAsyncOperation value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArmAsyncOperation.DeserializeArmAsyncOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get operationResults for a Data Manager For Agriculture resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="locations"> Location. </param>
        /// <param name="operationResultsId"> operationResultsId for a specific location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locations"/> or <paramref name="operationResultsId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="locations"/> or <paramref name="operationResultsId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ArmAsyncOperation> Get(string subscriptionId, string locations, string operationResultsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locations, nameof(locations));
            Argument.AssertNotNullOrEmpty(operationResultsId, nameof(operationResultsId));

            using var message = CreateGetRequest(subscriptionId, locations, operationResultsId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmAsyncOperation value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArmAsyncOperation.DeserializeArmAsyncOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
