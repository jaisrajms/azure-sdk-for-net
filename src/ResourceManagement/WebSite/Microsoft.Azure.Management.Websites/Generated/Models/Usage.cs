// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class that represents usage of the quota resource.
    /// </summary>
    public partial class Usage : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage() { }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string displayName = default(string), string usageName = default(string), string resourceName = default(string), string unit = default(string), long? currentValue = default(long?), long? limit = default(long?), DateTime? nextResetTime = default(DateTime?), ComputeModeOptions? computeMode = default(ComputeModeOptions?), string siteMode = default(string))
            : base(location, id, name, type, tags)
        {
            DisplayName = displayName;
            UsageName = usageName;
            ResourceName = resourceName;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetTime = nextResetTime;
            ComputeMode = computeMode;
            SiteMode = siteMode;
        }

        /// <summary>
        /// Friendly name shown in the UI
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Name of the quota
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string UsageName { get; set; }

        /// <summary>
        /// Name of the quota resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// Units of measurement for the quota resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The current value of the resource counter
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentValue")]
        public long? CurrentValue { get; set; }

        /// <summary>
        /// The resource limit
        /// </summary>
        [JsonProperty(PropertyName = "properties.limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Next reset time for the resource counter
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextResetTime")]
        public DateTime? NextResetTime { get; set; }

        /// <summary>
        /// ComputeMode used for this usage. Possible values for this property
        /// include: 'Shared', 'Dedicated', 'Dynamic'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computeMode")]
        public ComputeModeOptions? ComputeMode { get; set; }

        /// <summary>
        /// SiteMode used for this usage
        /// </summary>
        [JsonProperty(PropertyName = "properties.siteMode")]
        public string SiteMode { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
