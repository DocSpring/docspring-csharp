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
    /// CreateSubmissionBatchResponse
    /// </summary>
    [DataContract(Name = "create_submission_batch_response")]
    public partial class CreateSubmissionBatchResponse : IValidatableObject
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
        /// Initializes a new instance of the <see cref="CreateSubmissionBatchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubmissionBatchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionBatchResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="error">error.</param>
        /// <param name="errors">errors.</param>
        /// <param name="submissionBatch">submissionBatch (required).</param>
        /// <param name="submissions">submissions (required).</param>
        public CreateSubmissionBatchResponse(StatusEnum status = default(StatusEnum), string error = default(string), List<string> errors = default(List<string>), SubmissionBatch submissionBatch = default(SubmissionBatch), List<CreateSubmissionBatchSubmissionsResponse> submissions = default(List<CreateSubmissionBatchSubmissionsResponse>))
        {
            this.Status = status;
            // to ensure "submissionBatch" is required (not null)
            if (submissionBatch == null)
            {
                throw new ArgumentNullException("submissionBatch is a required property for CreateSubmissionBatchResponse and cannot be null");
            }
            this.SubmissionBatch = submissionBatch;
            // to ensure "submissions" is required (not null)
            if (submissions == null)
            {
                throw new ArgumentNullException("submissions is a required property for CreateSubmissionBatchResponse and cannot be null");
            }
            this.Submissions = submissions;
            this.Error = error;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionBatch
        /// </summary>
        [DataMember(Name = "submission_batch", IsRequired = true, EmitDefaultValue = true)]
        public SubmissionBatch SubmissionBatch { get; set; }

        /// <summary>
        /// Gets or Sets Submissions
        /// </summary>
        [DataMember(Name = "submissions", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateSubmissionBatchSubmissionsResponse> Submissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubmissionBatchResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  SubmissionBatch: ").Append(SubmissionBatch).Append("\n");
            sb.Append("  Submissions: ").Append(Submissions).Append("\n");
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
