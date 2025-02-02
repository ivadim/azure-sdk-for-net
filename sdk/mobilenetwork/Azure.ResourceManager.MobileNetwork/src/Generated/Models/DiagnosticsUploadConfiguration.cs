// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Configuration for uploading packet core diagnostics. </summary>
    internal partial class DiagnosticsUploadConfiguration
    {
        /// <summary> Initializes a new instance of DiagnosticsUploadConfiguration. </summary>
        /// <param name="storageAccountContainerUri"> The Storage Account Container URL to upload diagnostics to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountContainerUri"/> is null. </exception>
        public DiagnosticsUploadConfiguration(Uri storageAccountContainerUri)
        {
            Argument.AssertNotNull(storageAccountContainerUri, nameof(storageAccountContainerUri));

            StorageAccountContainerUri = storageAccountContainerUri;
        }

        /// <summary> The Storage Account Container URL to upload diagnostics to. </summary>
        public Uri StorageAccountContainerUri { get; set; }
    }
}
