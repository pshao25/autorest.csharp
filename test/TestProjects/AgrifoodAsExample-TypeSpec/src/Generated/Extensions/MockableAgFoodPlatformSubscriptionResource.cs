// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AgFoodPlatform.Models;

namespace Azure.ResourceManager.AgFoodPlatform.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAgFoodPlatformSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _dataManagerForAgricultureClientDiagnostics;
        private DataManagerForAgriculturesRestOperations _dataManagerForAgricultureRestClient;
        private ClientDiagnostics _checkNameAvailabilityOperationsClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityOperationsRestClient;
        private ClientDiagnostics _operationResultsOperationsClientDiagnostics;
        private OperationResultsRestOperations _operationResultsOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAgFoodPlatformSubscriptionResource"/> class for mocking. </summary>
        protected MockableAgFoodPlatformSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAgFoodPlatformSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAgFoodPlatformSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataManagerForAgricultureClientDiagnostics => _dataManagerForAgricultureClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", DataManagerForAgricultureResource.ResourceType.Namespace, Diagnostics);
        private DataManagerForAgriculturesRestOperations DataManagerForAgricultureRestClient => _dataManagerForAgricultureRestClient ??= new DataManagerForAgriculturesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataManagerForAgricultureResource.ResourceType));
        private ClientDiagnostics CheckNameAvailabilityOperationsClientDiagnostics => _checkNameAvailabilityOperationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityOperationsRestClient => _checkNameAvailabilityOperationsRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics OperationResultsOperationsClientDiagnostics => _operationResultsOperationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationResultsRestOperations OperationResultsOperationsRestClient => _operationResultsOperationsRestClient ??= new OperationResultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the DataManagerForAgriculture instances for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Azure.ResourceManager.AgFoodPlatform/farmBeats</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataManagerForAgriculture_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataManagerForAgricultureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataManagerForAgricultureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataManagerForAgricultureResource> GetDataManagerForAgriculturesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataManagerForAgricultureRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataManagerForAgricultureRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataManagerForAgricultureResource(Client, DataManagerForAgricultureData.DeserializeDataManagerForAgricultureData(e)), DataManagerForAgricultureClientDiagnostics, Pipeline, "MockableAgFoodPlatformSubscriptionResource.GetDataManagerForAgricultures", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the DataManagerForAgriculture instances for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Azure.ResourceManager.AgFoodPlatform/farmBeats</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataManagerForAgriculture_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataManagerForAgricultureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataManagerForAgricultureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataManagerForAgricultureResource> GetDataManagerForAgricultures(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataManagerForAgricultureRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataManagerForAgricultureRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataManagerForAgricultureResource(Client, DataManagerForAgricultureData.DeserializeDataManagerForAgricultureData(e)), DataManagerForAgricultureClientDiagnostics, Pipeline, "MockableAgFoodPlatformSubscriptionResource.GetDataManagerForAgricultures", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityOperations_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CheckNameAvailabilityResponse>> CheckNameAvailabilityCheckNameAvailabilityOperationAsync(CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityOperationsClientDiagnostics.CreateScope("MockableAgFoodPlatformSubscriptionResource.CheckNameAvailabilityCheckNameAvailabilityOperation");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityOperationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityOperations_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResponse> CheckNameAvailabilityCheckNameAvailabilityOperation(CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CheckNameAvailabilityOperationsClientDiagnostics.CreateScope("MockableAgFoodPlatformSubscriptionResource.CheckNameAvailabilityCheckNameAvailabilityOperation");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityOperationsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get operationResults for a Data Manager For Agriculture resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/locations/{locations}/operationResults/{operationResultsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationResultsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locations"> Location. </param>
        /// <param name="operationResultsId"> operationResultsId for a specific location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locations"/> or <paramref name="operationResultsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locations"/> or <paramref name="operationResultsId"/> is null. </exception>
        public virtual async Task<Response<ArmAsyncOperation>> GetOperationResultsOperationAsync(string locations, string operationResultsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locations, nameof(locations));
            Argument.AssertNotNullOrEmpty(operationResultsId, nameof(operationResultsId));

            using var scope = OperationResultsOperationsClientDiagnostics.CreateScope("MockableAgFoodPlatformSubscriptionResource.GetOperationResultsOperation");
            scope.Start();
            try
            {
                var response = await OperationResultsOperationsRestClient.GetAsync(Id.SubscriptionId, locations, operationResultsId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get operationResults for a Data Manager For Agriculture resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/locations/{locations}/operationResults/{operationResultsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationResultsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locations"> Location. </param>
        /// <param name="operationResultsId"> operationResultsId for a specific location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locations"/> or <paramref name="operationResultsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locations"/> or <paramref name="operationResultsId"/> is null. </exception>
        public virtual Response<ArmAsyncOperation> GetOperationResultsOperation(string locations, string operationResultsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locations, nameof(locations));
            Argument.AssertNotNullOrEmpty(operationResultsId, nameof(operationResultsId));

            using var scope = OperationResultsOperationsClientDiagnostics.CreateScope("MockableAgFoodPlatformSubscriptionResource.GetOperationResultsOperation");
            scope.Start();
            try
            {
                var response = OperationResultsOperationsRestClient.Get(Id.SubscriptionId, locations, operationResultsId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
