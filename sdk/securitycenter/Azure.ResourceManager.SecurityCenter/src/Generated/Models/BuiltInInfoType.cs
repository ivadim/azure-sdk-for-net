// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Pre-configured sensitive information type. </summary>
    public partial class BuiltInInfoType
    {
        /// <summary> Initializes a new instance of <see cref="BuiltInInfoType"/>. </summary>
        internal BuiltInInfoType()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BuiltInInfoType"/>. </summary>
        /// <param name="name"> Display name of the info type. </param>
        /// <param name="id"> Id of the info type. </param>
        /// <param name="builtInInfoTypeValue"> Category of the built-in info type. </param>
        internal BuiltInInfoType(string name, Guid? id, string builtInInfoTypeValue)
        {
            Name = name;
            Id = id;
            BuiltInInfoTypeValue = builtInInfoTypeValue;
        }

        /// <summary> Display name of the info type. </summary>
        public string Name { get; }
        /// <summary> Id of the info type. </summary>
        public Guid? Id { get; }
        /// <summary> Category of the built-in info type. </summary>
        public string BuiltInInfoTypeValue { get; }
    }
}
