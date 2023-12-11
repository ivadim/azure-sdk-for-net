// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The gcpOrganization data for the parent account. </summary>
    public partial class GcpParentOrganizationalInfo : GcpOrganizationalInfo
    {
        /// <summary> Initializes a new instance of <see cref="GcpParentOrganizationalInfo"/>. </summary>
        public GcpParentOrganizationalInfo()
        {
            ExcludedProjectNumbers = new ChangeTrackingList<string>();
            OrganizationMembershipType = OrganizationMembershipType.Organization;
        }

        /// <summary> Initializes a new instance of <see cref="GcpParentOrganizationalInfo"/>. </summary>
        /// <param name="organizationMembershipType"> The multi cloud account's membership type in the organization. </param>
        /// <param name="excludedProjectNumbers"> If the multi cloud account is of membership type organization, list of accounts excluded from offering. </param>
        /// <param name="serviceAccountEmailAddress"> The service account email address which represents the organization level permissions container. </param>
        /// <param name="workloadIdentityProviderId"> The GCP workload identity provider id which represents the permissions required to auto provision security connectors. </param>
        /// <param name="organizationName"> GCP organization name. </param>
        internal GcpParentOrganizationalInfo(OrganizationMembershipType organizationMembershipType, IList<string> excludedProjectNumbers, string serviceAccountEmailAddress, string workloadIdentityProviderId, string organizationName) : base(organizationMembershipType)
        {
            ExcludedProjectNumbers = excludedProjectNumbers;
            ServiceAccountEmailAddress = serviceAccountEmailAddress;
            WorkloadIdentityProviderId = workloadIdentityProviderId;
            OrganizationName = organizationName;
            OrganizationMembershipType = organizationMembershipType;
        }

        /// <summary> If the multi cloud account is of membership type organization, list of accounts excluded from offering. </summary>
        public IList<string> ExcludedProjectNumbers { get; }
        /// <summary> The service account email address which represents the organization level permissions container. </summary>
        public string ServiceAccountEmailAddress { get; set; }
        /// <summary> The GCP workload identity provider id which represents the permissions required to auto provision security connectors. </summary>
        public string WorkloadIdentityProviderId { get; set; }
        /// <summary> GCP organization name. </summary>
        public string OrganizationName { get; }
    }
}
