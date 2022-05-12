// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class to add extension methods to Azure.Management.Storage. </summary>
    public static partial class StorageExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeletedAccountResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedAccountResources and their operations over a DeletedAccountResource. </returns>
        public static DeletedAccountCollection GetDeletedAccounts(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedAccounts();
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeletedAccountResource>> GetDeletedAccountAsync(this SubscriptionResource subscriptionResource, string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetDeletedAccounts().GetAsync(location, deletedAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DeletedAccountResource> GetDeletedAccount(this SubscriptionResource subscriptionResource, string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetDeletedAccounts().Get(location, deletedAccountName, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageSkuInformation> GetSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageSkuInformation> GetSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkus(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageAccountResource> GetStorageAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetStorageAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageAccountResource> GetStorageAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetStorageAccounts(cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageUsage> GetUsagesByLocationAsync(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetUsagesByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageUsage> GetUsagesByLocation(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetUsagesByLocation(location, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of StorageAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageAccountResources and their operations over a StorageAccountResource. </returns>
        public static StorageAccountCollection GetStorageAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetStorageAccounts();
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageAccountResource>> GetStorageAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetStorageAccounts().GetAsync(accountName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageAccountResource> GetStorageAccount(this ResourceGroupResource resourceGroupResource, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetStorageAccounts().Get(accountName, expand, cancellationToken);
        }

        #region BlobServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobServiceResource.CreateResourceIdentifier" /> to create a <see cref="BlobServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobServiceResource" /> object. </returns>
        public static BlobServiceResource GetBlobServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobServiceResource.ValidateResourceId(id);
                return new BlobServiceResource(client, id);
            }
            );
        }
        #endregion

        #region BlobContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobContainerResource.CreateResourceIdentifier" /> to create a <see cref="BlobContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainerResource" /> object. </returns>
        public static BlobContainerResource GetBlobContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobContainerResource.ValidateResourceId(id);
                return new BlobContainerResource(client, id);
            }
            );
        }
        #endregion

        #region ImmutabilityPolicyResource
        /// <summary>
        /// Gets an object representing an <see cref="ImmutabilityPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ImmutabilityPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ImmutabilityPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicyResource" /> object. </returns>
        public static ImmutabilityPolicyResource GetImmutabilityPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ImmutabilityPolicyResource.ValidateResourceId(id);
                return new ImmutabilityPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region FileServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="FileServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileServiceResource.CreateResourceIdentifier" /> to create a <see cref="FileServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileServiceResource" /> object. </returns>
        public static FileServiceResource GetFileServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FileServiceResource.ValidateResourceId(id);
                return new FileServiceResource(client, id);
            }
            );
        }
        #endregion

        #region FileShareResource
        /// <summary>
        /// Gets an object representing a <see cref="FileShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileShareResource.CreateResourceIdentifier" /> to create a <see cref="FileShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShareResource" /> object. </returns>
        public static FileShareResource GetFileShareResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FileShareResource.ValidateResourceId(id);
                return new FileShareResource(client, id);
            }
            );
        }
        #endregion

        #region StorageAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountResource" /> object. </returns>
        public static StorageAccountResource GetStorageAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccountResource.ValidateResourceId(id);
                return new StorageAccountResource(client, id);
            }
            );
        }
        #endregion

        #region DeletedAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DeletedAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAccountResource.CreateResourceIdentifier" /> to create a <see cref="DeletedAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccountResource" /> object. </returns>
        public static DeletedAccountResource GetDeletedAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeletedAccountResource.ValidateResourceId(id);
                return new DeletedAccountResource(client, id);
            }
            );
        }
        #endregion

        #region ManagementPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagementPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementPolicyResource.CreateResourceIdentifier" /> to create a <see cref="ManagementPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementPolicyResource" /> object. </returns>
        public static ManagementPolicyResource GetManagementPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagementPolicyResource.ValidateResourceId(id);
                return new ManagementPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region BlobInventoryPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="BlobInventoryPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobInventoryPolicyResource.CreateResourceIdentifier" /> to create a <see cref="BlobInventoryPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicyResource" /> object. </returns>
        public static BlobInventoryPolicyResource GetBlobInventoryPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobInventoryPolicyResource.ValidateResourceId(id);
                return new BlobInventoryPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region StoragePrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="StoragePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StoragePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="StoragePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StoragePrivateEndpointConnectionResource" /> object. </returns>
        public static StoragePrivateEndpointConnectionResource GetStoragePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StoragePrivateEndpointConnectionResource.ValidateResourceId(id);
                return new StoragePrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region ObjectReplicationPolicyResource
        /// <summary>
        /// Gets an object representing an <see cref="ObjectReplicationPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ObjectReplicationPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ObjectReplicationPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicyResource" /> object. </returns>
        public static ObjectReplicationPolicyResource GetObjectReplicationPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ObjectReplicationPolicyResource.ValidateResourceId(id);
                return new ObjectReplicationPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region EncryptionScopeResource
        /// <summary>
        /// Gets an object representing an <see cref="EncryptionScopeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EncryptionScopeResource.CreateResourceIdentifier" /> to create an <see cref="EncryptionScopeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScopeResource" /> object. </returns>
        public static EncryptionScopeResource GetEncryptionScopeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EncryptionScopeResource.ValidateResourceId(id);
                return new EncryptionScopeResource(client, id);
            }
            );
        }
        #endregion
    }
}
