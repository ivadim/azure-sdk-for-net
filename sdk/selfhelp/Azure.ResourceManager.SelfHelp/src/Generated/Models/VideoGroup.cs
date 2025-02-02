// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Video group detail. </summary>
    public partial class VideoGroup
    {
        /// <summary> Initializes a new instance of VideoGroup. </summary>
        public VideoGroup()
        {
            Videos = new ChangeTrackingList<VideoGroupVideo>();
        }

        /// <summary> Initializes a new instance of VideoGroup. </summary>
        /// <param name="videos"> List of videos will be shown to customers. </param>
        /// <param name="replacementKey"> Place holder used in HTML Content replace control with the insight content. </param>
        internal VideoGroup(IList<VideoGroupVideo> videos, string replacementKey)
        {
            Videos = videos;
            ReplacementKey = replacementKey;
        }

        /// <summary> List of videos will be shown to customers. </summary>
        public IList<VideoGroupVideo> Videos { get; }
        /// <summary> Place holder used in HTML Content replace control with the insight content. </summary>
        public string ReplacementKey { get; set; }
    }
}
