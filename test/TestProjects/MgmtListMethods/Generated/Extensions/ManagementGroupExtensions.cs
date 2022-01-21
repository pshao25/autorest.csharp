// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Management;

namespace MgmtListMethods
{
    /// <summary> A class to add extension methods to ManagementGroup. </summary>
    public static partial class ManagementGroupExtensions
    {
        #region MgmtGrpParentWithNonResChWithLoc
        /// <summary> Gets an object representing a MgmtGrpParentWithNonResChWithLocCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="MgmtGrpParentWithNonResChWithLocCollection" /> object. </returns>
        public static MgmtGrpParentWithNonResChWithLocCollection GetMgmtGrpParentWithNonResChWithLocs(this ManagementGroup managementGroup)
        {
            return new MgmtGrpParentWithNonResChWithLocCollection(managementGroup);
        }
        #endregion

        #region MgmtGrpParentWithNonResCh
        /// <summary> Gets an object representing a MgmtGrpParentWithNonResChCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="MgmtGrpParentWithNonResChCollection" /> object. </returns>
        public static MgmtGrpParentWithNonResChCollection GetMgmtGrpParentWithNonResChes(this ManagementGroup managementGroup)
        {
            return new MgmtGrpParentWithNonResChCollection(managementGroup);
        }
        #endregion

        #region MgmtGrpParentWithLoc
        /// <summary> Gets an object representing a MgmtGrpParentWithLocCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="MgmtGrpParentWithLocCollection" /> object. </returns>
        public static MgmtGrpParentWithLocCollection GetMgmtGrpParentWithLocs(this ManagementGroup managementGroup)
        {
            return new MgmtGrpParentWithLocCollection(managementGroup);
        }
        #endregion

        #region MgmtGroupParent
        /// <summary> Gets an object representing a MgmtGroupParentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="MgmtGroupParentCollection" /> object. </returns>
        public static MgmtGroupParentCollection GetMgmtGroupParents(this ManagementGroup managementGroup)
        {
            return new MgmtGroupParentCollection(managementGroup);
        }
        #endregion

        private static ManagementGroupExtensionClient GetExtensionClient(ManagementGroup managementGroup)
        {
            return managementGroup.GetCachedClient((armClient) =>
            {
                return new ManagementGroupExtensionClient(armClient, managementGroup.Id);
            }
            );
        }
    }
}
