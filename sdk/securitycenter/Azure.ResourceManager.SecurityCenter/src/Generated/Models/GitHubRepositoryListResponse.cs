// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of RP resources which supports pagination. </summary>
    internal partial class GitHubRepositoryListResponse
    {
        /// <summary> Initializes a new instance of <see cref="GitHubRepositoryListResponse"/>. </summary>
        internal GitHubRepositoryListResponse()
        {
            Value = new ChangeTrackingList<GitHubRepositoryData>();
        }

        /// <summary> Initializes a new instance of <see cref="GitHubRepositoryListResponse"/>. </summary>
        /// <param name="value"> Gets or sets list of resources. </param>
        /// <param name="nextLink"> Gets or sets next link to scroll over the results. </param>
        internal GitHubRepositoryListResponse(IReadOnlyList<GitHubRepositoryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets list of resources. </summary>
        public IReadOnlyList<GitHubRepositoryData> Value { get; }
        /// <summary> Gets or sets next link to scroll over the results. </summary>
        public string NextLink { get; }
    }
}
