// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtExtensionResource
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        #region BuiltInPolicyDefinition
        /// <summary> Gets an object representing a BuiltInPolicyDefinitionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="BuiltInPolicyDefinitionCollection" /> object. </returns>
        public static BuiltInPolicyDefinitionCollection GetBuiltInPolicyDefinitions(this Tenant tenant)
        {
            return new BuiltInPolicyDefinitionCollection(tenant);
        }
        #endregion

        private static TenantExtensionClient GetExtensionClient(Tenant tenant)
        {
            return tenant.GetCachedClient((armClient) =>
            {
                return new TenantExtensionClient(armClient, tenant.Id);
            }
            );
        }
    }
}
