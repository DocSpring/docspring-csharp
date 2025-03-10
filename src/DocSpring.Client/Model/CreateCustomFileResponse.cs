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
    /// CreateCustomFileResponse
    /// </summary>
    [DataContract(Name = "create_custom_file_response")]
    public partial class CreateCustomFileResponse : IValidatableObject
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
        /// Initializes a new instance of the <see cref="CreateCustomFileResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCustomFileResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomFileResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="customFile">customFile (required).</param>
        /// <param name="errors">errors.</param>
        public CreateCustomFileResponse(StatusEnum status = default(StatusEnum), CustomFile customFile = default(CustomFile), List<string> errors = default(List<string>))
        {
            this.Status = status;
            // to ensure "customFile" is required (not null)
            if (customFile == null)
            {
                throw new ArgumentNullException("customFile is a required property for CreateCustomFileResponse and cannot be null");
            }
            this.CustomFile = customFile;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets CustomFile
        /// </summary>
        [DataMember(Name = "custom_file", IsRequired = true, EmitDefaultValue = true)]
        public CustomFile CustomFile { get; set; }

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
            sb.Append("class CreateCustomFileResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CustomFile: ").Append(CustomFile).Append("\n");
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
