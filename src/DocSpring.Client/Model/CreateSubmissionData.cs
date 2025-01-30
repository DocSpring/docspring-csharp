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
    /// CreateSubmissionData
    /// </summary>
    [DataContract(Name = "create_submission_data")]
    public partial class CreateSubmissionData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubmissionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionData" /> class.
        /// </summary>
        /// <param name="css">css.</param>
        /// <param name="data">data (required).</param>
        /// <param name="dataRequests">dataRequests.</param>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="fieldOverrides">fieldOverrides.</param>
        /// <param name="html">html.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="password">password.</param>
        /// <param name="test">test.</param>
        /// <param name="varVersion">varVersion.</param>
        public CreateSubmissionData(string css = default(string), Object data = default(Object), List<CreateSubmissionDataRequestData> dataRequests = default(List<CreateSubmissionDataRequestData>), int expiresIn = default(int), Object fieldOverrides = default(Object), string html = default(string), Object metadata = default(Object), string password = default(string), bool test = default(bool), string varVersion = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for CreateSubmissionData and cannot be null");
            }
            this.Data = data;
            this.Css = css;
            this.DataRequests = dataRequests;
            this.ExpiresIn = expiresIn;
            this.FieldOverrides = fieldOverrides;
            this.Html = html;
            this.Metadata = metadata;
            this.Password = password;
            this.Test = test;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Css
        /// </summary>
        [DataMember(Name = "css", EmitDefaultValue = false)]
        public string Css { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// Gets or Sets DataRequests
        /// </summary>
        [DataMember(Name = "data_requests", EmitDefaultValue = false)]
        public List<CreateSubmissionDataRequestData> DataRequests { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets FieldOverrides
        /// </summary>
        [DataMember(Name = "field_overrides", EmitDefaultValue = false)]
        public Object FieldOverrides { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = false)]
        public string Html { get; set; }

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
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name = "test", EmitDefaultValue = true)]
        public bool Test { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubmissionData {\n");
            sb.Append("  Css: ").Append(Css).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DataRequests: ").Append(DataRequests).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  FieldOverrides: ").Append(FieldOverrides).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
