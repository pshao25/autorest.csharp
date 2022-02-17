// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using additionalProperties.Models;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace additionalProperties
{
    internal partial class PetsRestClient
    {
        private readonly HttpPipeline _pipeline;

        /// <summary> server parameter. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of PetsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public PetsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            Endpoint = endpoint ?? new Uri("http://localhost:3000");
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateAPTrueRequest(PetAPTrue createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/additionalProperties/true", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPTrue to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public async Task<Response<PetAPTrue>> CreateAPTrueAsync(PetAPTrue createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPTrueRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPTrue value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetAPTrue.DeserializePetAPTrue(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPTrue to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public Response<PetAPTrue> CreateAPTrue(PetAPTrue createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPTrueRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPTrue value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetAPTrue.DeserializePetAPTrue(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateCatAPTrueRequest(CatAPTrue createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/additionalProperties/true-subclass", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a CatAPTrue which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The CatAPTrue to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public async Task<Response<CatAPTrue>> CreateCatAPTrueAsync(CatAPTrue createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateCatAPTrueRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CatAPTrue value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CatAPTrue.DeserializeCatAPTrue(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a CatAPTrue which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The CatAPTrue to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public Response<CatAPTrue> CreateCatAPTrue(CatAPTrue createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateCatAPTrueRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CatAPTrue value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CatAPTrue.DeserializeCatAPTrue(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateAPObjectRequest(PetAPObject createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/additionalProperties/type/object", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPObject to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public async Task<Response<PetAPObject>> CreateAPObjectAsync(PetAPObject createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPObjectRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPObject value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetAPObject.DeserializePetAPObject(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPObject to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public Response<PetAPObject> CreateAPObject(PetAPObject createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPObjectRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPObject value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetAPObject.DeserializePetAPObject(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateAPStringRequest(PetAPString createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/additionalProperties/type/string", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public async Task<Response<PetAPString>> CreateAPStringAsync(PetAPString createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPStringRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPString value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetAPString.DeserializePetAPString(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public Response<PetAPString> CreateAPString(PetAPString createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPStringRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPString value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetAPString.DeserializePetAPString(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateAPInPropertiesRequest(PetAPInProperties createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/additionalProperties/in/properties", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPInProperties to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public async Task<Response<PetAPInProperties>> CreateAPInPropertiesAsync(PetAPInProperties createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPInPropertiesRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPInProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetAPInProperties.DeserializePetAPInProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPInProperties to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public Response<PetAPInProperties> CreateAPInProperties(PetAPInProperties createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPInPropertiesRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPInProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetAPInProperties.DeserializePetAPInProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateAPInPropertiesWithAPStringRequest(PetAPInPropertiesWithAPString createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/additionalProperties/in/properties/with/additionalProperties/string", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPInPropertiesWithAPString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public async Task<Response<PetAPInPropertiesWithAPString>> CreateAPInPropertiesWithAPStringAsync(PetAPInPropertiesWithAPString createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPInPropertiesWithAPStringRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPInPropertiesWithAPString value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetAPInPropertiesWithAPString.DeserializePetAPInPropertiesWithAPString(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The PetAPInPropertiesWithAPString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createParameters"/> is null. </exception>
        public Response<PetAPInPropertiesWithAPString> CreateAPInPropertiesWithAPString(PetAPInPropertiesWithAPString createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateCreateAPInPropertiesWithAPStringRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PetAPInPropertiesWithAPString value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetAPInPropertiesWithAPString.DeserializePetAPInPropertiesWithAPString(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
