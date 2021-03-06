/* 
 * API v1
 *
 * DocSpring is a service that helps you fill out and sign PDF templates.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DocSpring.Client.Client.OpenAPIDateConverter;

namespace DocSpring.Client.Model
{
    /// <summary>
    /// SubmissionBatchData
    /// </summary>
    [DataContract]
    public partial class SubmissionBatchData :  IEquatable<SubmissionBatchData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmissionBatchData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmissionBatchData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmissionBatchData" /> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="submissions">submissions (required).</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="test">test.</param>
        public SubmissionBatchData(Object metadata = default(Object), List<SubmissionDataBatchRequest> submissions = default(List<SubmissionDataBatchRequest>), string templateId = default(string), bool? test = default(bool?))
        {
            // to ensure "submissions" is required (not null)
            if (submissions == null)
            {
                throw new InvalidDataException("submissions is a required property for SubmissionBatchData and cannot be null");
            }
            else
            {
                this.Submissions = submissions;
            }
            this.Metadata = metadata;
            this.TemplateId = templateId;
            this.Test = test;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Submissions
        /// </summary>
        [DataMember(Name="submissions", EmitDefaultValue=false)]
        public List<SubmissionDataBatchRequest> Submissions { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="template_id", EmitDefaultValue=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public bool? Test { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmissionBatchData {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Submissions: ").Append(Submissions).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubmissionBatchData);
        }

        /// <summary>
        /// Returns true if SubmissionBatchData instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmissionBatchData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmissionBatchData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Submissions == input.Submissions ||
                    this.Submissions != null &&
                    this.Submissions.SequenceEqual(input.Submissions)
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Submissions != null)
                    hashCode = hashCode * 59 + this.Submissions.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
