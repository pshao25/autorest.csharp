// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace OneModelInTwoResources.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableOneModelInTwoResourcesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableOneModelInTwoResourcesResourceGroupResource"/> class for mocking. </summary>
        protected MockableOneModelInTwoResourcesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableOneModelInTwoResourcesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableOneModelInTwoResourcesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SiteResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SiteResources and their operations over a SiteResource. </returns>
        public virtual SiteCollection GetSites()
        {
            return GetCachedClient(client => new SiteCollection(client, Id));
        }

        /// <summary>
        /// Description for Gets the details of a web, mobile, or API app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteResource>> GetSiteAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetSites().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets the details of a web, mobile, or API app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteResource> GetSite(string name, CancellationToken cancellationToken = default)
        {
            return GetSites().Get(name, cancellationToken);
        }
    }
}
