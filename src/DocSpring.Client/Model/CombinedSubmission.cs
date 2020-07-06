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
    /// CombinedSubmission
    /// </summary>
    [DataContract]
    public partial class CombinedSubmission :  IEquatable<CombinedSubmission>, IValidatableObject
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
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 3

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedSubmission" /> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="expired">expired.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="sourcePdfs">sourcePdfs.</param>
        /// <param name="pdfHash">pdfHash.</param>
        /// <param name="downloadUrl">downloadUrl.</param>
        /// <param name="submissionIds">submissionIds.</param>
        /// <param name="id">id.</param>
        /// <param name="state">state.</param>
        /// <param name="actions">actions.</param>
        public CombinedSubmission(Object metadata = default(Object), bool? expired = default(bool?), string expiresAt = default(string), List<Object> sourcePdfs = default(List<Object>), string pdfHash = default(string), string downloadUrl = default(string), List<string> submissionIds = default(List<string>), string id = default(string), StateEnum? state = default(StateEnum?), List<CombinedSubmissionAction> actions = default(List<CombinedSubmissionAction>))
        {
            this.Metadata = metadata;
            this.Expired = expired;
            this.ExpiresAt = expiresAt;
            this.SourcePdfs = sourcePdfs;
            this.PdfHash = pdfHash;
            this.DownloadUrl = downloadUrl;
            this.SubmissionIds = submissionIds;
            this.Id = id;
            this.State = state;
            this.Actions = actions;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

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
        /// Gets or Sets SourcePdfs
        /// </summary>
        [DataMember(Name="source_pdfs", EmitDefaultValue=false)]
        public List<Object> SourcePdfs { get; set; }

        /// <summary>
        /// Gets or Sets PdfHash
        /// </summary>
        [DataMember(Name="pdf_hash", EmitDefaultValue=false)]
        public string PdfHash { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="download_url", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionIds
        /// </summary>
        [DataMember(Name="submission_ids", EmitDefaultValue=false)]
        public List<string> SubmissionIds { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<CombinedSubmissionAction> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinedSubmission {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  SourcePdfs: ").Append(SourcePdfs).Append("\n");
            sb.Append("  PdfHash: ").Append(PdfHash).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  SubmissionIds: ").Append(SubmissionIds).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as CombinedSubmission);
        }

        /// <summary>
        /// Returns true if CombinedSubmission instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinedSubmission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinedSubmission input)
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
                    this.SourcePdfs == input.SourcePdfs ||
                    this.SourcePdfs != null &&
                    this.SourcePdfs.SequenceEqual(input.SourcePdfs)
                ) && 
                (
                    this.PdfHash == input.PdfHash ||
                    (this.PdfHash != null &&
                    this.PdfHash.Equals(input.PdfHash))
                ) && 
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    (this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl))
                ) && 
                (
                    this.SubmissionIds == input.SubmissionIds ||
                    this.SubmissionIds != null &&
                    this.SubmissionIds.SequenceEqual(input.SubmissionIds)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Expired != null)
                    hashCode = hashCode * 59 + this.Expired.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.SourcePdfs != null)
                    hashCode = hashCode * 59 + this.SourcePdfs.GetHashCode();
                if (this.PdfHash != null)
                    hashCode = hashCode * 59 + this.PdfHash.GetHashCode();
                if (this.DownloadUrl != null)
                    hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.SubmissionIds != null)
                    hashCode = hashCode * 59 + this.SubmissionIds.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
