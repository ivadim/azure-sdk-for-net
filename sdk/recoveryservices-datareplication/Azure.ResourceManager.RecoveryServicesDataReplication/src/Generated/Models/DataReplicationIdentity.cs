// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Identity model. </summary>
    public partial class DataReplicationIdentity
    {
        /// <summary> Initializes a new instance of DataReplicationIdentity. </summary>
        /// <param name="tenantId"> Gets or sets the tenant Id of the SPN with which Dra communicates to service. </param>
        /// <param name="applicationId">
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </param>
        /// <param name="objectId"> Gets or sets the object Id of the SPN with which Dra communicates to service. </param>
        /// <param name="audience"> Gets or sets the audience of the SPN with which Dra communicates to service. </param>
        /// <param name="aadAuthority"> Gets or sets the authority of the SPN with which Dra communicates to service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/>, <paramref name="objectId"/>, <paramref name="audience"/> or <paramref name="aadAuthority"/> is null. </exception>
        public DataReplicationIdentity(Guid tenantId, string applicationId, string objectId, string audience, string aadAuthority)
        {
            Argument.AssertNotNull(applicationId, nameof(applicationId));
            Argument.AssertNotNull(objectId, nameof(objectId));
            Argument.AssertNotNull(audience, nameof(audience));
            Argument.AssertNotNull(aadAuthority, nameof(aadAuthority));

            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
        }

        /// <summary> Gets or sets the tenant Id of the SPN with which Dra communicates to service. </summary>
        public Guid TenantId { get; set; }
        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which Dra communicates to
        /// service.
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary> Gets or sets the object Id of the SPN with which Dra communicates to service. </summary>
        public string ObjectId { get; set; }
        /// <summary> Gets or sets the audience of the SPN with which Dra communicates to service. </summary>
        public string Audience { get; set; }
        /// <summary> Gets or sets the authority of the SPN with which Dra communicates to service. </summary>
        public string AadAuthority { get; set; }
    }
}
