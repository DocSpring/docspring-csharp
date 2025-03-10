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
    /// CombinedSubmission
    /// </summary>
    [DataContract(Name = "combined_submission")]
    public partial class CombinedSubmission : IValidatableObject
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
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedSubmission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CombinedSubmission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedSubmission" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="expired">expired (required).</param>
        /// <param name="expiresIn">expiresIn (required).</param>
        /// <param name="expiresAt">expiresAt (required).</param>
        /// <param name="processedAt">processedAt (required).</param>
        /// <param name="errorMessage">errorMessage (required).</param>
        /// <param name="submissionIds">submissionIds (required).</param>
        /// <param name="sourcePdfs">sourcePdfs (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="password">password (required).</param>
        /// <param name="pdfHash">pdfHash (required).</param>
        /// <param name="downloadUrl">downloadUrl (required).</param>
        /// <param name="actions">actions (required).</param>
        public CombinedSubmission(string id = default(string), StateEnum state = default(StateEnum), bool expired = default(bool), int? expiresIn = default(int?), string expiresAt = default(string), string processedAt = default(string), string errorMessage = default(string), List<string> submissionIds = default(List<string>), List<Object> sourcePdfs = default(List<Object>), Object metadata = default(Object), string password = default(string), string pdfHash = default(string), string downloadUrl = default(string), List<CombinedSubmissionAction> actions = default(List<CombinedSubmissionAction>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CombinedSubmission and cannot be null");
            }
            this.Id = id;
            this.State = state;
            this.Expired = expired;
            // to ensure "expiresIn" is required (not null)
            if (expiresIn == null)
            {
                throw new ArgumentNullException("expiresIn is a required property for CombinedSubmission and cannot be null");
            }
            this.ExpiresIn = expiresIn;
            // to ensure "expiresAt" is required (not null)
            if (expiresAt == null)
            {
                throw new ArgumentNullException("expiresAt is a required property for CombinedSubmission and cannot be null");
            }
            this.ExpiresAt = expiresAt;
            // to ensure "processedAt" is required (not null)
            if (processedAt == null)
            {
                throw new ArgumentNullException("processedAt is a required property for CombinedSubmission and cannot be null");
            }
            this.ProcessedAt = processedAt;
            // to ensure "errorMessage" is required (not null)
            if (errorMessage == null)
            {
                throw new ArgumentNullException("errorMessage is a required property for CombinedSubmission and cannot be null");
            }
            this.ErrorMessage = errorMessage;
            // to ensure "submissionIds" is required (not null)
            if (submissionIds == null)
            {
                throw new ArgumentNullException("submissionIds is a required property for CombinedSubmission and cannot be null");
            }
            this.SubmissionIds = submissionIds;
            // to ensure "sourcePdfs" is required (not null)
            if (sourcePdfs == null)
            {
                throw new ArgumentNullException("sourcePdfs is a required property for CombinedSubmission and cannot be null");
            }
            this.SourcePdfs = sourcePdfs;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for CombinedSubmission and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for CombinedSubmission and cannot be null");
            }
            this.Password = password;
            // to ensure "pdfHash" is required (not null)
            if (pdfHash == null)
            {
                throw new ArgumentNullException("pdfHash is a required property for CombinedSubmission and cannot be null");
            }
            this.PdfHash = pdfHash;
            // to ensure "downloadUrl" is required (not null)
            if (downloadUrl == null)
            {
                throw new ArgumentNullException("downloadUrl is a required property for CombinedSubmission and cannot be null");
            }
            this.DownloadUrl = downloadUrl;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for CombinedSubmission and cannot be null");
            }
            this.Actions = actions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name = "expired", IsRequired = true, EmitDefaultValue = true)]
        public bool Expired { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", IsRequired = true, EmitDefaultValue = true)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", IsRequired = true, EmitDefaultValue = true)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedAt
        /// </summary>
        [DataMember(Name = "processed_at", IsRequired = true, EmitDefaultValue = true)]
        public string ProcessedAt { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "error_message", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionIds
        /// </summary>
        [DataMember(Name = "submission_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SubmissionIds { get; set; }

        /// <summary>
        /// Gets or Sets SourcePdfs
        /// </summary>
        [DataMember(Name = "source_pdfs", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> SourcePdfs { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets PdfHash
        /// </summary>
        [DataMember(Name = "pdf_hash", IsRequired = true, EmitDefaultValue = true)]
        public string PdfHash { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name = "download_url", IsRequired = true, EmitDefaultValue = true)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<CombinedSubmissionAction> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CombinedSubmission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  ProcessedAt: ").Append(ProcessedAt).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  SubmissionIds: ").Append(SubmissionIds).Append("\n");
            sb.Append("  SourcePdfs: ").Append(SourcePdfs).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PdfHash: ").Append(PdfHash).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
