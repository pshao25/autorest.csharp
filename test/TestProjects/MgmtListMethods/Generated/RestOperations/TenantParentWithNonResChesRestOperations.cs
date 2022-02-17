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
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    internal partial class TenantParentWithNonResChesRestOperations
    {
        private readonly string _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> server parameter. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of TenantParentWithNonResChesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public TenantParentWithNonResChesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            Endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-06-01";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Azure.ResourceManager.Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string tenantTestName, string tenantParentWithNonResChName, TenantParentWithNonResChData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithNonResChes/", false);
            uri.AppendPath(tenantParentWithNonResChName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Create or update. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/>, <paramref name="tenantParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<TenantParentWithNonResChData>> CreateOrUpdateAsync(string tenantTestName, string tenantParentWithNonResChName, TenantParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }
            if (tenantParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(tenantTestName, tenantParentWithNonResChName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithNonResChData.DeserializeTenantParentWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/>, <paramref name="tenantParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public Response<TenantParentWithNonResChData> CreateOrUpdate(string tenantTestName, string tenantParentWithNonResChName, TenantParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }
            if (tenantParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(tenantTestName, tenantParentWithNonResChName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithNonResChData.DeserializeTenantParentWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string tenantTestName, string tenantParentWithNonResChName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithNonResChes/", false);
            uri.AppendPath(tenantParentWithNonResChName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        public async Task<Response<TenantParentWithNonResChData>> GetAsync(string tenantTestName, string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }
            if (tenantParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChName));
            }

            using var message = CreateGetRequest(tenantTestName, tenantParentWithNonResChName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithNonResChData.DeserializeTenantParentWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TenantParentWithNonResChData)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        public Response<TenantParentWithNonResChData> Get(string tenantTestName, string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }
            if (tenantParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChName));
            }

            using var message = CreateGetRequest(tenantTestName, tenantParentWithNonResChName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithNonResChData.DeserializeTenantParentWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TenantParentWithNonResChData)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string tenantTestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithNonResChes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> is null. </exception>
        public async Task<Response<TenantParentWithNonResChListResult>> ListAsync(string tenantTestName, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }

            using var message = CreateListRequest(tenantTestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithNonResChListResult.DeserializeTenantParentWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> is null. </exception>
        public Response<TenantParentWithNonResChListResult> List(string tenantTestName, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }

            using var message = CreateListRequest(tenantTestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithNonResChListResult.DeserializeTenantParentWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNonResourceChildRequest(string tenantTestName, string tenantParentWithNonResChName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithNonResChes/", false);
            uri.AppendPath(tenantParentWithNonResChName, true);
            uri.AppendPath("/nonResourceChild", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Lists all. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        public async Task<Response<NonResourceChildListResult>> ListNonResourceChildAsync(string tenantTestName, string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }
            if (tenantParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChName));
            }

            using var message = CreateListNonResourceChildRequest(tenantTestName, tenantParentWithNonResChName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NonResourceChildListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NonResourceChildListResult.DeserializeNonResourceChildListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        public Response<NonResourceChildListResult> ListNonResourceChild(string tenantTestName, string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }
            if (tenantParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChName));
            }

            using var message = CreateListNonResourceChildRequest(tenantTestName, tenantParentWithNonResChName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NonResourceChildListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NonResourceChildListResult.DeserializeNonResourceChildListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string tenantTestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="tenantTestName"/> is null. </exception>
        public async Task<Response<TenantParentWithNonResChListResult>> ListNextPageAsync(string nextLink, string tenantTestName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }

            using var message = CreateListNextPageRequest(nextLink, tenantTestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithNonResChListResult.DeserializeTenantParentWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="tenantTestName"/> is null. </exception>
        public Response<TenantParentWithNonResChListResult> ListNextPage(string nextLink, string tenantTestName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (tenantTestName == null)
            {
                throw new ArgumentNullException(nameof(tenantTestName));
            }

            using var message = CreateListNextPageRequest(nextLink, tenantTestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithNonResChListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithNonResChListResult.DeserializeTenantParentWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
