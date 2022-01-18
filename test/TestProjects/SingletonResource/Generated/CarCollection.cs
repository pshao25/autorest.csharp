// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SingletonResource.Models;

namespace SingletonResource
{
    /// <summary> A class representing collection of Car and their operations over its parent. </summary>
    public partial class CarCollection : ArmCollection, IEnumerable<Car>, IAsyncEnumerable<Car>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CarsRestOperations _carsRestClient;
        private readonly SingletonResourceRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="CarCollection"/> class for mocking. </summary>
        protected CarCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CarCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CarCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Car.ResourceType, out string apiVersion);
            _carsRestClient = new CarsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _restClient = new SingletonResourceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Cars_Put
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="carName"> The String to use. </param>
        /// <param name="parameters"> The Car to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual CarCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string carName, CarData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _carsRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, carName, parameters, cancellationToken);
                var operation = new CarCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Cars_Put
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="carName"> The String to use. </param>
        /// <param name="parameters"> The Car to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CarCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string carName, CarData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _carsRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, carName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CarCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Cars_Get
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        public virtual Response<Car> Get(string carName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.Get");
            scope.Start();
            try
            {
                var response = _carsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, carName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Car(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Cars_Get
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        public async virtual Task<Response<Car>> GetAsync(string carName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.Get");
            scope.Start();
            try
            {
                var response = await _carsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, carName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Car(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        public virtual Response<Car> GetIfExists(string carName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _carsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, carName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Car>(null, response.GetRawResponse());
                return Response.FromValue(new Car(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        public async virtual Task<Response<Car>> GetIfExistsAsync(string carName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _carsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, carName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Car>(null, response.GetRawResponse());
                return Response.FromValue(new Car(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string carName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(carName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="carName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="carName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string carName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(carName))
            {
                throw new ArgumentException($"Parameter {nameof(carName)} cannot be null or empty", nameof(carName));
            }

            using var scope = _clientDiagnostics.CreateScope("CarCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(carName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Cars
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Car" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Car> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Car> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CarCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.Cars(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Car(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Cars
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Car" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Car> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Car>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CarCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.CarsAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Car(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="Car" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CarCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Car.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Car" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CarCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Car.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Car> IEnumerable<Car>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Car> IAsyncEnumerable<Car>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Car, CarData> Construct() { }
    }
}
