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
    /// CombinePdfsData
    /// </summary>
    [DataContract]
    public partial class CombinePdfsData :  IEquatable<CombinePdfsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinePdfsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CombinePdfsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinePdfsData" /> class.
        /// </summary>
        /// <param name="test">test.</param>
        /// <param name="sourcePdfs">sourcePdfs (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="deleteCustomFiles">deleteCustomFiles.</param>
        public CombinePdfsData(bool? test = default(bool?), List<Object> sourcePdfs = default(List<Object>), Object metadata = default(Object), int? expiresIn = default(int?), bool? deleteCustomFiles = default(bool?))
        {
            // to ensure "sourcePdfs" is required (not null)
            if (sourcePdfs == null)
            {
                throw new InvalidDataException("sourcePdfs is a required property for CombinePdfsData and cannot be null");
            }
            else
            {
                this.SourcePdfs = sourcePdfs;
            }
            this.Test = test;
            this.Metadata = metadata;
            this.ExpiresIn = expiresIn;
            this.DeleteCustomFiles = deleteCustomFiles;
        }
        
        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public bool? Test { get; set; }

        /// <summary>
        /// Gets or Sets SourcePdfs
        /// </summary>
        [DataMember(Name="source_pdfs", EmitDefaultValue=false)]
        public List<Object> SourcePdfs { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets DeleteCustomFiles
        /// </summary>
        [DataMember(Name="delete_custom_files", EmitDefaultValue=false)]
        public bool? DeleteCustomFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinePdfsData {\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  SourcePdfs: ").Append(SourcePdfs).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  DeleteCustomFiles: ").Append(DeleteCustomFiles).Append("\n");
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
            return this.Equals(input as CombinePdfsData);
        }

        /// <summary>
        /// Returns true if CombinePdfsData instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinePdfsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinePdfsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
                ) && 
                (
                    this.SourcePdfs == input.SourcePdfs ||
                    this.SourcePdfs != null &&
                    this.SourcePdfs.SequenceEqual(input.SourcePdfs)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.DeleteCustomFiles == input.DeleteCustomFiles ||
                    (this.DeleteCustomFiles != null &&
                    this.DeleteCustomFiles.Equals(input.DeleteCustomFiles))
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
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                if (this.SourcePdfs != null)
                    hashCode = hashCode * 59 + this.SourcePdfs.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.DeleteCustomFiles != null)
                    hashCode = hashCode * 59 + this.DeleteCustomFiles.GetHashCode();
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
