// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace MixApiVersion
{
    // Data plane generated client.
    /// <summary> The MixApiVersion service client. </summary>
    public partial class MixApiVersionClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of MixApiVersionClient for mocking. </summary>
        protected MixApiVersionClient()
        {
        }

        /// <summary> Initializes a new instance of MixApiVersionClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public MixApiVersionClient(Uri endpoint) : this(endpoint, new MixApiVersionClientOptions())
        {
        }

        /// <summary> Initializes a new instance of MixApiVersionClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public MixApiVersionClient(Uri endpoint, MixApiVersionClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new MixApiVersionClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        private Pets _cachedPets;
        private ListPetToysResponse _cachedListPetToysResponse;

        /// <summary> Initializes a new instance of Pets. </summary>
        public virtual Pets GetPetsClient()
        {
            return Volatile.Read(ref _cachedPets) ?? Interlocked.CompareExchange(ref _cachedPets, new Pets(ClientDiagnostics, _pipeline, _endpoint, _apiVersion), null) ?? _cachedPets;
        }

        /// <summary> Initializes a new instance of ListPetToysResponse. </summary>
        public virtual ListPetToysResponse GetListPetToysResponseClient()
        {
            return Volatile.Read(ref _cachedListPetToysResponse) ?? Interlocked.CompareExchange(ref _cachedListPetToysResponse, new ListPetToysResponse(ClientDiagnostics, _pipeline, _endpoint, _apiVersion), null) ?? _cachedListPetToysResponse;
        }
    }
}
