/*
 * API v1
 *
 * DocSpring is a service that helps you fill out and sign PDF templates.
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
    /// CreateSubmissionBatchSubmissionsResponse
    /// </summary>
    [DataContract(Name = "create_submission_batch_submissions_response")]
    public partial class CreateSubmissionBatchSubmissionsResponse : IValidatableObject
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
            Error = 2,

            /// <summary>
            /// Enum ValidButNotSaved for value: valid_but_not_saved
            /// </summary>
            [EnumMember(Value = "valid_but_not_saved")]
            ValidButNotSaved = 3
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionBatchSubmissionsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubmissionBatchSubmissionsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionBatchSubmissionsResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="errors">errors.</param>
        /// <param name="submission">submission.</param>
        public CreateSubmissionBatchSubmissionsResponse(StatusEnum status = default(StatusEnum), List<string> errors = default(List<string>), Submission submission = default(Submission))
        {
            this.Status = status;
            this.Errors = errors;
            this.Submission = submission;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Submission
        /// </summary>
        [DataMember(Name = "submission", EmitDefaultValue = false)]
        public Submission Submission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubmissionBatchSubmissionsResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Submission: ").Append(Submission).Append("\n");
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
