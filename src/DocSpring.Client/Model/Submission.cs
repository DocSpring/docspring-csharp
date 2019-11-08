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
    /// Submission
    /// </summary>
    [DataContract]
    public partial class Submission :  IEquatable<Submission>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 2,

            /// <summary>
            /// Enum Invaliddata for value: invalid_data
            /// </summary>
            [EnumMember(Value = "invalid_data")]
            Invaliddata = 3,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4,

            /// <summary>
            /// Enum Imagedownloadfailed for value: image_download_failed
            /// </summary>
            [EnumMember(Value = "image_download_failed")]
            Imagedownloadfailed = 5,

            /// <summary>
            /// Enum Imageprocessingfailed for value: image_processing_failed
            /// </summary>
            [EnumMember(Value = "image_processing_failed")]
            Imageprocessingfailed = 6,

            /// <summary>
            /// Enum Waitingfordatarequests for value: waiting_for_data_requests
            /// </summary>
            [EnumMember(Value = "waiting_for_data_requests")]
            Waitingfordatarequests = 7,

            /// <summary>
            /// Enum Syntaxerror for value: syntax_error
            /// </summary>
            [EnumMember(Value = "syntax_error")]
            Syntaxerror = 8,

            /// <summary>
            /// Enum Accountsuspended for value: account_suspended
            /// </summary>
            [EnumMember(Value = "account_suspended")]
            Accountsuspended = 9,

            /// <summary>
            /// Enum Licenserevoked for value: license_revoked
            /// </summary>
            [EnumMember(Value = "license_revoked")]
            Licenserevoked = 10

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Submission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Submission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Submission" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="test">test (required).</param>
        /// <param name="editable">editable.</param>
        /// <param name="expired">expired (required).</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="processedAt">processedAt.</param>
        /// <param name="state">state (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="downloadUrl">downloadUrl.</param>
        /// <param name="permanentDownloadUrl">permanentDownloadUrl.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="dataRequests">dataRequests.</param>
        /// <param name="actions">actions.</param>
        public Submission(string id = default(string), string templateId = default(string), bool? test = default(bool?), bool? editable = default(bool?), bool? expired = default(bool?), string expiresAt = default(string), string processedAt = default(string), StateEnum state = default(StateEnum), Object metadata = default(Object), string downloadUrl = default(string), string permanentDownloadUrl = default(string), string batchId = default(string), List<SubmissionDataRequest> dataRequests = default(List<SubmissionDataRequest>), List<SubmissionAction> actions = default(List<SubmissionAction>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Submission and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "test" is required (not null)
            if (test == null)
            {
                throw new InvalidDataException("test is a required property for Submission and cannot be null");
            }
            else
            {
                this.Test = test;
            }
            // to ensure "expired" is required (not null)
            if (expired == null)
            {
                throw new InvalidDataException("expired is a required property for Submission and cannot be null");
            }
            else
            {
                this.Expired = expired;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for Submission and cannot be null");
            }
            else
            {
                this.State = state;
            }
            this.TemplateId = templateId;
            this.Editable = editable;
            this.ExpiresAt = expiresAt;
            this.ProcessedAt = processedAt;
            this.Metadata = metadata;
            this.DownloadUrl = downloadUrl;
            this.PermanentDownloadUrl = permanentDownloadUrl;
            this.BatchId = batchId;
            this.DataRequests = dataRequests;
            this.Actions = actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        /// Gets or Sets Editable
        /// </summary>
        [DataMember(Name="editable", EmitDefaultValue=false)]
        public bool? Editable { get; set; }

        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedAt
        /// </summary>
        [DataMember(Name="processed_at", EmitDefaultValue=false)]
        public string ProcessedAt { get; set; }


        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="download_url", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets PermanentDownloadUrl
        /// </summary>
        [DataMember(Name="permanent_download_url", EmitDefaultValue=false)]
        public string PermanentDownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name="batch_id", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or Sets DataRequests
        /// </summary>
        [DataMember(Name="data_requests", EmitDefaultValue=false)]
        public List<SubmissionDataRequest> DataRequests { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<SubmissionAction> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Submission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  ProcessedAt: ").Append(ProcessedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  PermanentDownloadUrl: ").Append(PermanentDownloadUrl).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  DataRequests: ").Append(DataRequests).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as Submission);
        }

        /// <summary>
        /// Returns true if Submission instances are equal
        /// </summary>
        /// <param name="input">Instance of Submission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Submission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                ) && 
                (
                    this.Editable == input.Editable ||
                    (this.Editable != null &&
                    this.Editable.Equals(input.Editable))
                ) && 
                (
                    this.Expired == input.Expired ||
                    (this.Expired != null &&
                    this.Expired.Equals(input.Expired))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.ProcessedAt == input.ProcessedAt ||
                    (this.ProcessedAt != null &&
                    this.ProcessedAt.Equals(input.ProcessedAt))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    (this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl))
                ) && 
                (
                    this.PermanentDownloadUrl == input.PermanentDownloadUrl ||
                    (this.PermanentDownloadUrl != null &&
                    this.PermanentDownloadUrl.Equals(input.PermanentDownloadUrl))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.DataRequests == input.DataRequests ||
                    this.DataRequests != null &&
                    this.DataRequests.SequenceEqual(input.DataRequests)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                if (this.Editable != null)
                    hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Expired != null)
                    hashCode = hashCode * 59 + this.Expired.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.ProcessedAt != null)
                    hashCode = hashCode * 59 + this.ProcessedAt.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.DownloadUrl != null)
                    hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.PermanentDownloadUrl != null)
                    hashCode = hashCode * 59 + this.PermanentDownloadUrl.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.DataRequests != null)
                    hashCode = hashCode * 59 + this.DataRequests.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
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
