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
    /// FullTemplate
    /// </summary>
    [DataContract(Name = "full_template")]
    public partial class FullTemplate : IValidatableObject
    {
        /// <summary>
        /// Defines ExpirationInterval
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpirationIntervalEnum
        {
            /// <summary>
            /// Enum Minutes for value: minutes
            /// </summary>
            [EnumMember(Value = "minutes")]
            Minutes = 1,

            /// <summary>
            /// Enum Hours for value: hours
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours = 2,

            /// <summary>
            /// Enum Days for value: days
            /// </summary>
            [EnumMember(Value = "days")]
            Days = 3
        }


        /// <summary>
        /// Gets or Sets ExpirationInterval
        /// </summary>
        [DataMember(Name = "expiration_interval", IsRequired = true, EmitDefaultValue = true)]
        public ExpirationIntervalEnum ExpirationInterval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FullTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FullTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FullTemplate" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="publicWebForm">publicWebForm (required).</param>
        /// <param name="publicSubmissions">publicSubmissions (required).</param>
        /// <param name="expireSubmissions">expireSubmissions (required).</param>
        /// <param name="expireAfter">expireAfter (required).</param>
        /// <param name="expirationInterval">expirationInterval (required).</param>
        /// <param name="allowAdditionalProperties">allowAdditionalProperties (required).</param>
        /// <param name="editableSubmissions">editableSubmissions (required).</param>
        /// <param name="locked">locked (required).</param>
        /// <param name="webhookUrl">webhookUrl (required).</param>
        /// <param name="slackWebhookUrl">slackWebhookUrl (required).</param>
        /// <param name="redirectUrl">redirectUrl (required).</param>
        /// <param name="firstTemplate">firstTemplate (required).</param>
        /// <param name="html">html (required).</param>
        /// <param name="headerHtml">headerHtml (required).</param>
        /// <param name="footerHtml">footerHtml (required).</param>
        /// <param name="scss">scss (required).</param>
        /// <param name="encryptPdfs">encryptPdfs (required).</param>
        /// <param name="encryptPdfsPassword">encryptPdfsPassword (required).</param>
        /// <param name="defaults">defaults (required).</param>
        /// <param name="fields">fields (required).</param>
        /// <param name="sharedFieldData">sharedFieldData (required).</param>
        /// <param name="fieldOrder">fieldOrder (required).</param>
        /// <param name="documentMd5">documentMd5 (required).</param>
        /// <param name="documentFilename">documentFilename (required).</param>
        /// <param name="documentParseError">documentParseError (required).</param>
        /// <param name="documentState">documentState (required).</param>
        /// <param name="embedDomains">embedDomains (required).</param>
        /// <param name="pageCount">pageCount (required).</param>
        /// <param name="documentProcessed">documentProcessed (required).</param>
        /// <param name="demo">demo (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="templateType">templateType (required).</param>
        /// <param name="pageDimensions">pageDimensions (required).</param>
        /// <param name="documentUrl">documentUrl (required).</param>
        /// <param name="permanentDocumentUrl">permanentDocumentUrl (required).</param>
        /// <param name="path">path (required).</param>
        /// <param name="parentFolderId">parentFolderId (required).</param>
        public FullTemplate(string name = default(string), string description = default(string), bool publicWebForm = default(bool), bool publicSubmissions = default(bool), bool expireSubmissions = default(bool), decimal expireAfter = default(decimal), ExpirationIntervalEnum expirationInterval = default(ExpirationIntervalEnum), bool allowAdditionalProperties = default(bool), bool editableSubmissions = default(bool), bool locked = default(bool), string webhookUrl = default(string), string slackWebhookUrl = default(string), string redirectUrl = default(string), bool firstTemplate = default(bool), string html = default(string), string headerHtml = default(string), string footerHtml = default(string), string scss = default(string), bool encryptPdfs = default(bool), string encryptPdfsPassword = default(string), TemplateDefaults defaults = default(TemplateDefaults), Object fields = default(Object), Object sharedFieldData = default(Object), List<List<decimal>> fieldOrder = default(List<List<decimal>>), string documentMd5 = default(string), string documentFilename = default(string), bool documentParseError = default(bool), string documentState = default(string), List<string> embedDomains = default(List<string>), decimal pageCount = default(decimal), bool documentProcessed = default(bool), bool demo = default(bool), string id = default(string), string templateType = default(string), List<List<decimal>> pageDimensions = default(List<List<decimal>>), string documentUrl = default(string), string permanentDocumentUrl = default(string), string path = default(string), string parentFolderId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FullTemplate and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for FullTemplate and cannot be null");
            }
            this.Description = description;
            this.PublicWebForm = publicWebForm;
            this.PublicSubmissions = publicSubmissions;
            this.ExpireSubmissions = expireSubmissions;
            this.ExpireAfter = expireAfter;
            this.ExpirationInterval = expirationInterval;
            this.AllowAdditionalProperties = allowAdditionalProperties;
            this.EditableSubmissions = editableSubmissions;
            this.Locked = locked;
            // to ensure "webhookUrl" is required (not null)
            if (webhookUrl == null)
            {
                throw new ArgumentNullException("webhookUrl is a required property for FullTemplate and cannot be null");
            }
            this.WebhookUrl = webhookUrl;
            // to ensure "slackWebhookUrl" is required (not null)
            if (slackWebhookUrl == null)
            {
                throw new ArgumentNullException("slackWebhookUrl is a required property for FullTemplate and cannot be null");
            }
            this.SlackWebhookUrl = slackWebhookUrl;
            // to ensure "redirectUrl" is required (not null)
            if (redirectUrl == null)
            {
                throw new ArgumentNullException("redirectUrl is a required property for FullTemplate and cannot be null");
            }
            this.RedirectUrl = redirectUrl;
            this.FirstTemplate = firstTemplate;
            // to ensure "html" is required (not null)
            if (html == null)
            {
                throw new ArgumentNullException("html is a required property for FullTemplate and cannot be null");
            }
            this.Html = html;
            // to ensure "headerHtml" is required (not null)
            if (headerHtml == null)
            {
                throw new ArgumentNullException("headerHtml is a required property for FullTemplate and cannot be null");
            }
            this.HeaderHtml = headerHtml;
            // to ensure "footerHtml" is required (not null)
            if (footerHtml == null)
            {
                throw new ArgumentNullException("footerHtml is a required property for FullTemplate and cannot be null");
            }
            this.FooterHtml = footerHtml;
            // to ensure "scss" is required (not null)
            if (scss == null)
            {
                throw new ArgumentNullException("scss is a required property for FullTemplate and cannot be null");
            }
            this.Scss = scss;
            this.EncryptPdfs = encryptPdfs;
            // to ensure "encryptPdfsPassword" is required (not null)
            if (encryptPdfsPassword == null)
            {
                throw new ArgumentNullException("encryptPdfsPassword is a required property for FullTemplate and cannot be null");
            }
            this.EncryptPdfsPassword = encryptPdfsPassword;
            // to ensure "defaults" is required (not null)
            if (defaults == null)
            {
                throw new ArgumentNullException("defaults is a required property for FullTemplate and cannot be null");
            }
            this.Defaults = defaults;
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for FullTemplate and cannot be null");
            }
            this.Fields = fields;
            // to ensure "sharedFieldData" is required (not null)
            if (sharedFieldData == null)
            {
                throw new ArgumentNullException("sharedFieldData is a required property for FullTemplate and cannot be null");
            }
            this.SharedFieldData = sharedFieldData;
            // to ensure "fieldOrder" is required (not null)
            if (fieldOrder == null)
            {
                throw new ArgumentNullException("fieldOrder is a required property for FullTemplate and cannot be null");
            }
            this.FieldOrder = fieldOrder;
            // to ensure "documentMd5" is required (not null)
            if (documentMd5 == null)
            {
                throw new ArgumentNullException("documentMd5 is a required property for FullTemplate and cannot be null");
            }
            this.DocumentMd5 = documentMd5;
            // to ensure "documentFilename" is required (not null)
            if (documentFilename == null)
            {
                throw new ArgumentNullException("documentFilename is a required property for FullTemplate and cannot be null");
            }
            this.DocumentFilename = documentFilename;
            this.DocumentParseError = documentParseError;
            // to ensure "documentState" is required (not null)
            if (documentState == null)
            {
                throw new ArgumentNullException("documentState is a required property for FullTemplate and cannot be null");
            }
            this.DocumentState = documentState;
            // to ensure "embedDomains" is required (not null)
            if (embedDomains == null)
            {
                throw new ArgumentNullException("embedDomains is a required property for FullTemplate and cannot be null");
            }
            this.EmbedDomains = embedDomains;
            this.PageCount = pageCount;
            this.DocumentProcessed = documentProcessed;
            this.Demo = demo;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FullTemplate and cannot be null");
            }
            this.Id = id;
            // to ensure "templateType" is required (not null)
            if (templateType == null)
            {
                throw new ArgumentNullException("templateType is a required property for FullTemplate and cannot be null");
            }
            this.TemplateType = templateType;
            // to ensure "pageDimensions" is required (not null)
            if (pageDimensions == null)
            {
                throw new ArgumentNullException("pageDimensions is a required property for FullTemplate and cannot be null");
            }
            this.PageDimensions = pageDimensions;
            // to ensure "documentUrl" is required (not null)
            if (documentUrl == null)
            {
                throw new ArgumentNullException("documentUrl is a required property for FullTemplate and cannot be null");
            }
            this.DocumentUrl = documentUrl;
            // to ensure "permanentDocumentUrl" is required (not null)
            if (permanentDocumentUrl == null)
            {
                throw new ArgumentNullException("permanentDocumentUrl is a required property for FullTemplate and cannot be null");
            }
            this.PermanentDocumentUrl = permanentDocumentUrl;
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for FullTemplate and cannot be null");
            }
            this.Path = path;
            // to ensure "parentFolderId" is required (not null)
            if (parentFolderId == null)
            {
                throw new ArgumentNullException("parentFolderId is a required property for FullTemplate and cannot be null");
            }
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PublicWebForm
        /// </summary>
        [DataMember(Name = "public_web_form", IsRequired = true, EmitDefaultValue = true)]
        public bool PublicWebForm { get; set; }

        /// <summary>
        /// Gets or Sets PublicSubmissions
        /// </summary>
        [DataMember(Name = "public_submissions", IsRequired = true, EmitDefaultValue = true)]
        public bool PublicSubmissions { get; set; }

        /// <summary>
        /// Gets or Sets ExpireSubmissions
        /// </summary>
        [DataMember(Name = "expire_submissions", IsRequired = true, EmitDefaultValue = true)]
        public bool ExpireSubmissions { get; set; }

        /// <summary>
        /// Gets or Sets ExpireAfter
        /// </summary>
        [DataMember(Name = "expire_after", IsRequired = true, EmitDefaultValue = true)]
        public decimal ExpireAfter { get; set; }

        /// <summary>
        /// Gets or Sets AllowAdditionalProperties
        /// </summary>
        [DataMember(Name = "allow_additional_properties", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowAdditionalProperties { get; set; }

        /// <summary>
        /// Gets or Sets EditableSubmissions
        /// </summary>
        [DataMember(Name = "editable_submissions", IsRequired = true, EmitDefaultValue = true)]
        public bool EditableSubmissions { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name = "locked", IsRequired = true, EmitDefaultValue = true)]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name = "webhook_url", IsRequired = true, EmitDefaultValue = true)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets SlackWebhookUrl
        /// </summary>
        [DataMember(Name = "slack_webhook_url", IsRequired = true, EmitDefaultValue = true)]
        public string SlackWebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name = "redirect_url", IsRequired = true, EmitDefaultValue = true)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or Sets FirstTemplate
        /// </summary>
        [DataMember(Name = "first_template", IsRequired = true, EmitDefaultValue = true)]
        public bool FirstTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", IsRequired = true, EmitDefaultValue = true)]
        public string Html { get; set; }

        /// <summary>
        /// Gets or Sets HeaderHtml
        /// </summary>
        [DataMember(Name = "header_html", IsRequired = true, EmitDefaultValue = true)]
        public string HeaderHtml { get; set; }

        /// <summary>
        /// Gets or Sets FooterHtml
        /// </summary>
        [DataMember(Name = "footer_html", IsRequired = true, EmitDefaultValue = true)]
        public string FooterHtml { get; set; }

        /// <summary>
        /// Gets or Sets Scss
        /// </summary>
        [DataMember(Name = "scss", IsRequired = true, EmitDefaultValue = true)]
        public string Scss { get; set; }

        /// <summary>
        /// Gets or Sets EncryptPdfs
        /// </summary>
        [DataMember(Name = "encrypt_pdfs", IsRequired = true, EmitDefaultValue = true)]
        public bool EncryptPdfs { get; set; }

        /// <summary>
        /// Gets or Sets EncryptPdfsPassword
        /// </summary>
        [DataMember(Name = "encrypt_pdfs_password", IsRequired = true, EmitDefaultValue = true)]
        public string EncryptPdfsPassword { get; set; }

        /// <summary>
        /// Gets or Sets Defaults
        /// </summary>
        [DataMember(Name = "defaults", IsRequired = true, EmitDefaultValue = true)]
        public TemplateDefaults Defaults { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public Object Fields { get; set; }

        /// <summary>
        /// Gets or Sets SharedFieldData
        /// </summary>
        [DataMember(Name = "shared_field_data", IsRequired = true, EmitDefaultValue = true)]
        public Object SharedFieldData { get; set; }

        /// <summary>
        /// Gets or Sets FieldOrder
        /// </summary>
        [DataMember(Name = "field_order", IsRequired = true, EmitDefaultValue = true)]
        public List<List<decimal>> FieldOrder { get; set; }

        /// <summary>
        /// Gets or Sets DocumentMd5
        /// </summary>
        [DataMember(Name = "document_md5", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentMd5 { get; set; }

        /// <summary>
        /// Gets or Sets DocumentFilename
        /// </summary>
        [DataMember(Name = "document_filename", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentFilename { get; set; }

        /// <summary>
        /// Gets or Sets DocumentParseError
        /// </summary>
        [DataMember(Name = "document_parse_error", IsRequired = true, EmitDefaultValue = true)]
        public bool DocumentParseError { get; set; }

        /// <summary>
        /// Gets or Sets DocumentState
        /// </summary>
        [DataMember(Name = "document_state", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentState { get; set; }

        /// <summary>
        /// Gets or Sets EmbedDomains
        /// </summary>
        [DataMember(Name = "embed_domains", IsRequired = true, EmitDefaultValue = true)]
        public List<string> EmbedDomains { get; set; }

        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name = "page_count", IsRequired = true, EmitDefaultValue = true)]
        public decimal PageCount { get; set; }

        /// <summary>
        /// Gets or Sets DocumentProcessed
        /// </summary>
        [DataMember(Name = "document_processed", IsRequired = true, EmitDefaultValue = true)]
        public bool DocumentProcessed { get; set; }

        /// <summary>
        /// Gets or Sets Demo
        /// </summary>
        [DataMember(Name = "demo", IsRequired = true, EmitDefaultValue = true)]
        public bool Demo { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateType
        /// </summary>
        [DataMember(Name = "template_type", IsRequired = true, EmitDefaultValue = true)]
        public string TemplateType { get; set; }

        /// <summary>
        /// Gets or Sets PageDimensions
        /// </summary>
        [DataMember(Name = "page_dimensions", IsRequired = true, EmitDefaultValue = true)]
        public List<List<decimal>> PageDimensions { get; set; }

        /// <summary>
        /// Gets or Sets DocumentUrl
        /// </summary>
        [DataMember(Name = "document_url", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// Gets or Sets PermanentDocumentUrl
        /// </summary>
        [DataMember(Name = "permanent_document_url", IsRequired = true, EmitDefaultValue = true)]
        public string PermanentDocumentUrl { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets ParentFolderId
        /// </summary>
        [DataMember(Name = "parent_folder_id", IsRequired = true, EmitDefaultValue = true)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FullTemplate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PublicWebForm: ").Append(PublicWebForm).Append("\n");
            sb.Append("  PublicSubmissions: ").Append(PublicSubmissions).Append("\n");
            sb.Append("  ExpireSubmissions: ").Append(ExpireSubmissions).Append("\n");
            sb.Append("  ExpireAfter: ").Append(ExpireAfter).Append("\n");
            sb.Append("  ExpirationInterval: ").Append(ExpirationInterval).Append("\n");
            sb.Append("  AllowAdditionalProperties: ").Append(AllowAdditionalProperties).Append("\n");
            sb.Append("  EditableSubmissions: ").Append(EditableSubmissions).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  SlackWebhookUrl: ").Append(SlackWebhookUrl).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  FirstTemplate: ").Append(FirstTemplate).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  HeaderHtml: ").Append(HeaderHtml).Append("\n");
            sb.Append("  FooterHtml: ").Append(FooterHtml).Append("\n");
            sb.Append("  Scss: ").Append(Scss).Append("\n");
            sb.Append("  EncryptPdfs: ").Append(EncryptPdfs).Append("\n");
            sb.Append("  EncryptPdfsPassword: ").Append(EncryptPdfsPassword).Append("\n");
            sb.Append("  Defaults: ").Append(Defaults).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  SharedFieldData: ").Append(SharedFieldData).Append("\n");
            sb.Append("  FieldOrder: ").Append(FieldOrder).Append("\n");
            sb.Append("  DocumentMd5: ").Append(DocumentMd5).Append("\n");
            sb.Append("  DocumentFilename: ").Append(DocumentFilename).Append("\n");
            sb.Append("  DocumentParseError: ").Append(DocumentParseError).Append("\n");
            sb.Append("  DocumentState: ").Append(DocumentState).Append("\n");
            sb.Append("  EmbedDomains: ").Append(EmbedDomains).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  DocumentProcessed: ").Append(DocumentProcessed).Append("\n");
            sb.Append("  Demo: ").Append(Demo).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateType: ").Append(TemplateType).Append("\n");
            sb.Append("  PageDimensions: ").Append(PageDimensions).Append("\n");
            sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
            sb.Append("  PermanentDocumentUrl: ").Append(PermanentDocumentUrl).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
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
