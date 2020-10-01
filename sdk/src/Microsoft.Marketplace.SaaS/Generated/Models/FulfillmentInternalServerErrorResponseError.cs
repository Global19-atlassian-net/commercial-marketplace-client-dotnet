// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace.SaaS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FulfillmentInternalServerErrorResponseError
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FulfillmentInternalServerErrorResponseError class.
        /// </summary>
        public FulfillmentInternalServerErrorResponseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FulfillmentInternalServerErrorResponseError class.
        /// </summary>
        public FulfillmentInternalServerErrorResponseError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
