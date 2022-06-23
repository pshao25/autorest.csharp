// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtMultipleParentResource
{
    internal class AnotherParentChildOperationSource : IOperationSource<AnotherParentChildResource>
    {
        private readonly ArmClient _client;

        internal AnotherParentChildOperationSource(ArmClient client)
        {
            _client = client;
        }

        AnotherParentChildResource IOperationSource<AnotherParentChildResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ChildBodyData.DeserializeChildBodyData(document.RootElement);
            return new AnotherParentChildResource(_client, data);
        }

        async ValueTask<AnotherParentChildResource> IOperationSource<AnotherParentChildResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ChildBodyData.DeserializeChildBodyData(document.RootElement);
            return new AnotherParentChildResource(_client, data);
        }
    }
}
