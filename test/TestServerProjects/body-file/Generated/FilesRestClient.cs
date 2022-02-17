// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_file
{
    internal partial class FilesRestClient
    {
        private readonly HttpPipeline _pipeline;

        /// <summary> server parameter. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of FilesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public FilesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            Endpoint = endpoint ?? new Uri("http://localhost:3000");
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetFileRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/files/stream/nonempty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "image/png, application/json");
            return message;
        }

        /// <summary> Get file. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Stream>> GetFileAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetFileRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get file. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Stream> GetFile(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetFileRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetFileLargeRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/files/stream/verylarge", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "image/png, application/json");
            return message;
        }

        /// <summary> Get a large file. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Stream>> GetFileLargeAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetFileLargeRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a large file. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Stream> GetFileLarge(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetFileLargeRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetEmptyFileRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/files/stream/empty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "image/png, application/json");
            return message;
        }

        /// <summary> Get empty file. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Stream>> GetEmptyFileAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetEmptyFileRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get empty file. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Stream> GetEmptyFile(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetEmptyFileRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
