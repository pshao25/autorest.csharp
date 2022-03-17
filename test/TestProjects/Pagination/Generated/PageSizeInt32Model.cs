// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Pagination
{
    /// <summary> A Class representing a PageSizeInt32Model along with the instance operations that can be performed on it. </summary>
    public partial class PageSizeInt32Model : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PageSizeInt32Model"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt32Model/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _pageSizeInt32ModelClientDiagnostics;
        private readonly PageSizeInt32ModelsRestOperations _pageSizeInt32ModelRestClient;
        private readonly PageSizeInt32ModelData _data;

        /// <summary> Initializes a new instance of the <see cref="PageSizeInt32Model"/> class for mocking. </summary>
        protected PageSizeInt32Model()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PageSizeInt32Model"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PageSizeInt32Model(ArmClient client, PageSizeInt32ModelData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PageSizeInt32Model"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PageSizeInt32Model(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _pageSizeInt32ModelClientDiagnostics = new ClientDiagnostics("Pagination", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string pageSizeInt32ModelApiVersion);
            _pageSizeInt32ModelRestClient = new PageSizeInt32ModelsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, pageSizeInt32ModelApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/pageSizeInt32Model";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PageSizeInt32ModelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt32Model/{name}
        /// Operation Id: PageSizeInt32Models_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PageSizeInt32Model>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _pageSizeInt32ModelClientDiagnostics.CreateScope("PageSizeInt32Model.Get");
            scope.Start();
            try
            {
                var response = await _pageSizeInt32ModelRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PageSizeInt32Model(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt32Model/{name}
        /// Operation Id: PageSizeInt32Models_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PageSizeInt32Model> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _pageSizeInt32ModelClientDiagnostics.CreateScope("PageSizeInt32Model.Get");
            scope.Start();
            try
            {
                var response = _pageSizeInt32ModelRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PageSizeInt32Model(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
