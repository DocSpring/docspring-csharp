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
    /// CombinedSubmissionData
    /// </summary>
    [DataContract(Name = "combined_submission_data")]
    public partial class CombinedSubmissionData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedSubmissionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CombinedSubmissionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedSubmissionData" /> class.
        /// </summary>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="password">password.</param>
        /// <param name="submissionIds">submissionIds (required).</param>
        /// <param name="test">test.</param>
        public CombinedSubmissionData(int expiresIn = default(int), Object metadata = default(Object), string password = default(string), List<string> submissionIds = default(List<string>), bool test = default(bool))
        {
            // to ensure "submissionIds" is required (not null)
            if (submissionIds == null)
            {
                throw new ArgumentNullException("submissionIds is a required property for CombinedSubmissionData and cannot be null");
            }
            this.SubmissionIds = submissionIds;
            this.ExpiresIn = expiresIn;
            this.Metadata = metadata;
            this.Password = password;
            this.Test = test;
        }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionIds
        /// </summary>
        [DataMember(Name = "submission_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SubmissionIds { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name = "test", EmitDefaultValue = true)]
        public bool Test { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CombinedSubmissionData {\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SubmissionIds: ").Append(SubmissionIds).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
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
