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
    /// Template1Defaults
    /// </summary>
    [DataContract]
    public partial class Template1Defaults :  IEquatable<Template1Defaults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Template1Defaults" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="typeface">typeface.</param>
        public Template1Defaults(string color = default(string), decimal? fontSize = default(decimal?), string typeface = default(string))
        {
            this.Color = color;
            this.FontSize = fontSize;
            this.Typeface = typeface;
        }
        
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public decimal? FontSize { get; set; }

        /// <summary>
        /// Gets or Sets Typeface
        /// </summary>
        [DataMember(Name="typeface", EmitDefaultValue=false)]
        public string Typeface { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Template1Defaults {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Typeface: ").Append(Typeface).Append("\n");
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
            return this.Equals(input as Template1Defaults);
        }

        /// <summary>
        /// Returns true if Template1Defaults instances are equal
        /// </summary>
        /// <param name="input">Instance of Template1Defaults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Template1Defaults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.Typeface == input.Typeface ||
                    (this.Typeface != null &&
                    this.Typeface.Equals(input.Typeface))
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.Typeface != null)
                    hashCode = hashCode * 59 + this.Typeface.GetHashCode();
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