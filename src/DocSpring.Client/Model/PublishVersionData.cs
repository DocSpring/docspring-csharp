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
    /// PublishVersionData
    /// </summary>
    [DataContract(Name = "publish_version_data")]
    public partial class PublishVersionData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishVersionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublishVersionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishVersionData" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="versionType">versionType (required).</param>
        public PublishVersionData(string description = default(string), string versionType = default(string))
        {
            // to ensure "versionType" is required (not null)
            if (versionType == null)
            {
                throw new ArgumentNullException("versionType is a required property for PublishVersionData and cannot be null");
            }
            this.VersionType = versionType;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets VersionType
        /// </summary>
        [DataMember(Name = "version_type", IsRequired = true, EmitDefaultValue = true)]
        public string VersionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishVersionData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VersionType: ").Append(VersionType).Append("\n");
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
