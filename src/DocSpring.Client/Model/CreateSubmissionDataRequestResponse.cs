/*
 * DocSpring API
 *
 * DocSpring provides an API that helps you fill out and sign PDF templates.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DocSpring.Client.Client.OpenAPIDateConverter;

namespace DocSpring.Client.Model
{
    /// <summary>
    /// CreateSubmissionDataRequestResponse
    /// </summary>
    [DataContract(Name = "create_submission_data_request_response")]
    public partial class CreateSubmissionDataRequestResponse : IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 2
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionDataRequestResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubmissionDataRequestResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionDataRequestResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="dataRequest">dataRequest (required).</param>
        /// <param name="errors">errors.</param>
        public CreateSubmissionDataRequestResponse(StatusEnum status = default(StatusEnum), SubmissionDataRequestShow dataRequest = default(SubmissionDataRequestShow), List<string> errors = default(List<string>))
        {
            this.Status = status;
            // to ensure "dataRequest" is required (not null)
            if (dataRequest == null)
            {
                throw new ArgumentNullException("dataRequest is a required property for CreateSubmissionDataRequestResponse and cannot be null");
            }
            this.DataRequest = dataRequest;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets DataRequest
        /// </summary>
        [DataMember(Name = "data_request", IsRequired = true, EmitDefaultValue = true)]
        public SubmissionDataRequestShow DataRequest { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubmissionDataRequestResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataRequest: ").Append(DataRequest).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
