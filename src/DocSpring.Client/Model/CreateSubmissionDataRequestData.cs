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
    /// CreateSubmissionDataRequestData
    /// </summary>
    [DataContract]
    public partial class CreateSubmissionDataRequestData :  IEquatable<CreateSubmissionDataRequestData>, IValidatableObject
    {
        /// <summary>
        /// Defines AuthType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            [EnumMember(Value = "password")]
            Password = 2,

            /// <summary>
            /// Enum Oauth for value: oauth
            /// </summary>
            [EnumMember(Value = "oauth")]
            Oauth = 3,

            /// <summary>
            /// Enum Emaillink for value: email_link
            /// </summary>
            [EnumMember(Value = "email_link")]
            Emaillink = 4,

            /// <summary>
            /// Enum Phonenumber for value: phone_number
            /// </summary>
            [EnumMember(Value = "phone_number")]
            Phonenumber = 5,

            /// <summary>
            /// Enum Ldap for value: ldap
            /// </summary>
            [EnumMember(Value = "ldap")]
            Ldap = 6,

            /// <summary>
            /// Enum Saml for value: saml
            /// </summary>
            [EnumMember(Value = "saml")]
            Saml = 7

        }

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name="auth_type", EmitDefaultValue=false)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// Defines AuthSecondFactorType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthSecondFactorTypeEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Phonenumber for value: phone_number
            /// </summary>
            [EnumMember(Value = "phone_number")]
            Phonenumber = 2,

            /// <summary>
            /// Enum Totp for value: totp
            /// </summary>
            [EnumMember(Value = "totp")]
            Totp = 3,

            /// <summary>
            /// Enum Mobilepush for value: mobile_push
            /// </summary>
            [EnumMember(Value = "mobile_push")]
            Mobilepush = 4,

            /// <summary>
            /// Enum Securitykey for value: security_key
            /// </summary>
            [EnumMember(Value = "security_key")]
            Securitykey = 5,

            /// <summary>
            /// Enum Fingerprint for value: fingerprint
            /// </summary>
            [EnumMember(Value = "fingerprint")]
            Fingerprint = 6

        }

        /// <summary>
        /// Gets or Sets AuthSecondFactorType
        /// </summary>
        [DataMember(Name="auth_second_factor_type", EmitDefaultValue=false)]
        public AuthSecondFactorTypeEnum? AuthSecondFactorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubmissionDataRequestData" /> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="authType">authType.</param>
        /// <param name="authSecondFactorType">authSecondFactorType.</param>
        /// <param name="authPhoneNumberHash">authPhoneNumberHash.</param>
        /// <param name="authSessionStartedAt">authSessionStartedAt.</param>
        /// <param name="authUserIdHash">authUserIdHash.</param>
        /// <param name="authSessionIdHash">authSessionIdHash.</param>
        /// <param name="authUsernameHash">authUsernameHash.</param>
        /// <param name="name">name.</param>
        /// <param name="fields">fields.</param>
        /// <param name="email">email.</param>
        /// <param name="authProvider">authProvider.</param>
        /// <param name="order">order.</param>
        public CreateSubmissionDataRequestData(Object metadata = default(Object), AuthTypeEnum? authType = default(AuthTypeEnum?), AuthSecondFactorTypeEnum? authSecondFactorType = default(AuthSecondFactorTypeEnum?), string authPhoneNumberHash = default(string), string authSessionStartedAt = default(string), string authUserIdHash = default(string), string authSessionIdHash = default(string), string authUsernameHash = default(string), string name = default(string), List<string> fields = default(List<string>), string email = default(string), string authProvider = default(string), int? order = default(int?))
        {
            this.Metadata = metadata;
            this.AuthType = authType;
            this.AuthSecondFactorType = authSecondFactorType;
            this.AuthPhoneNumberHash = authPhoneNumberHash;
            this.AuthSessionStartedAt = authSessionStartedAt;
            this.AuthUserIdHash = authUserIdHash;
            this.AuthSessionIdHash = authSessionIdHash;
            this.AuthUsernameHash = authUsernameHash;
            this.Name = name;
            this.Fields = fields;
            this.Email = email;
            this.AuthProvider = authProvider;
            this.Order = order;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }



        /// <summary>
        /// Gets or Sets AuthPhoneNumberHash
        /// </summary>
        [DataMember(Name="auth_phone_number_hash", EmitDefaultValue=false)]
        public string AuthPhoneNumberHash { get; set; }

        /// <summary>
        /// Gets or Sets AuthSessionStartedAt
        /// </summary>
        [DataMember(Name="auth_session_started_at", EmitDefaultValue=false)]
        public string AuthSessionStartedAt { get; set; }

        /// <summary>
        /// Gets or Sets AuthUserIdHash
        /// </summary>
        [DataMember(Name="auth_user_id_hash", EmitDefaultValue=false)]
        public string AuthUserIdHash { get; set; }

        /// <summary>
        /// Gets or Sets AuthSessionIdHash
        /// </summary>
        [DataMember(Name="auth_session_id_hash", EmitDefaultValue=false)]
        public string AuthSessionIdHash { get; set; }

        /// <summary>
        /// Gets or Sets AuthUsernameHash
        /// </summary>
        [DataMember(Name="auth_username_hash", EmitDefaultValue=false)]
        public string AuthUsernameHash { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets AuthProvider
        /// </summary>
        [DataMember(Name="auth_provider", EmitDefaultValue=false)]
        public string AuthProvider { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubmissionDataRequestData {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  AuthSecondFactorType: ").Append(AuthSecondFactorType).Append("\n");
            sb.Append("  AuthPhoneNumberHash: ").Append(AuthPhoneNumberHash).Append("\n");
            sb.Append("  AuthSessionStartedAt: ").Append(AuthSessionStartedAt).Append("\n");
            sb.Append("  AuthUserIdHash: ").Append(AuthUserIdHash).Append("\n");
            sb.Append("  AuthSessionIdHash: ").Append(AuthSessionIdHash).Append("\n");
            sb.Append("  AuthUsernameHash: ").Append(AuthUsernameHash).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  AuthProvider: ").Append(AuthProvider).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as CreateSubmissionDataRequestData);
        }

        /// <summary>
        /// Returns true if CreateSubmissionDataRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubmissionDataRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubmissionDataRequestData input)
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
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.AuthSecondFactorType == input.AuthSecondFactorType ||
                    (this.AuthSecondFactorType != null &&
                    this.AuthSecondFactorType.Equals(input.AuthSecondFactorType))
                ) && 
                (
                    this.AuthPhoneNumberHash == input.AuthPhoneNumberHash ||
                    (this.AuthPhoneNumberHash != null &&
                    this.AuthPhoneNumberHash.Equals(input.AuthPhoneNumberHash))
                ) && 
                (
                    this.AuthSessionStartedAt == input.AuthSessionStartedAt ||
                    (this.AuthSessionStartedAt != null &&
                    this.AuthSessionStartedAt.Equals(input.AuthSessionStartedAt))
                ) && 
                (
                    this.AuthUserIdHash == input.AuthUserIdHash ||
                    (this.AuthUserIdHash != null &&
                    this.AuthUserIdHash.Equals(input.AuthUserIdHash))
                ) && 
                (
                    this.AuthSessionIdHash == input.AuthSessionIdHash ||
                    (this.AuthSessionIdHash != null &&
                    this.AuthSessionIdHash.Equals(input.AuthSessionIdHash))
                ) && 
                (
                    this.AuthUsernameHash == input.AuthUsernameHash ||
                    (this.AuthUsernameHash != null &&
                    this.AuthUsernameHash.Equals(input.AuthUsernameHash))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.AuthProvider == input.AuthProvider ||
                    (this.AuthProvider != null &&
                    this.AuthProvider.Equals(input.AuthProvider))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthSecondFactorType != null)
                    hashCode = hashCode * 59 + this.AuthSecondFactorType.GetHashCode();
                if (this.AuthPhoneNumberHash != null)
                    hashCode = hashCode * 59 + this.AuthPhoneNumberHash.GetHashCode();
                if (this.AuthSessionStartedAt != null)
                    hashCode = hashCode * 59 + this.AuthSessionStartedAt.GetHashCode();
                if (this.AuthUserIdHash != null)
                    hashCode = hashCode * 59 + this.AuthUserIdHash.GetHashCode();
                if (this.AuthSessionIdHash != null)
                    hashCode = hashCode * 59 + this.AuthSessionIdHash.GetHashCode();
                if (this.AuthUsernameHash != null)
                    hashCode = hashCode * 59 + this.AuthUsernameHash.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.AuthProvider != null)
                    hashCode = hashCode * 59 + this.AuthProvider.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
