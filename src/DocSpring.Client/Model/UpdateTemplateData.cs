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
    /// UpdateTemplateData
    /// </summary>
    [DataContract]
    public partial class UpdateTemplateData :  IEquatable<UpdateTemplateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTemplateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateData" /> class.
        /// </summary>
        /// <param name="template">template (required).</param>
        public UpdateTemplateData(TemplatestemplateIdTemplate template = default(TemplatestemplateIdTemplate))
        {
            // to ensure "template" is required (not null)
            if (template == null)
            {
                throw new InvalidDataException("template is a required property for UpdateTemplateData and cannot be null");
            }
            else
            {
                this.Template = template;
            }
        }
        
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public TemplatestemplateIdTemplate Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTemplateData {\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as UpdateTemplateData);
        }

        /// <summary>
        /// Returns true if UpdateTemplateData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTemplateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTemplateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
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
