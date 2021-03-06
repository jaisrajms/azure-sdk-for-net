// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes the access location for a web service asset.
    /// </summary>
    public partial class AssetLocation
    {
        /// <summary>
        /// Initializes a new instance of the AssetLocation class.
        /// </summary>
        public AssetLocation() { }

        /// <summary>
        /// Initializes a new instance of the AssetLocation class.
        /// </summary>
        public AssetLocation(string uri, string credentials = default(string))
        {
            Uri = uri;
            Credentials = credentials;
        }

        /// <summary>
        /// The URI where the asset is accessible from, (e.g. aml://abc for
        /// system assets or https://xyz for user asets
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Access credentials for the asset, if applicable (e.g. asset
        /// specified by storage account connection string + blob URI)
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public string Credentials { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
