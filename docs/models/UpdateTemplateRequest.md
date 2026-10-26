# DocSpring.Client.Model.UpdateTemplateRequest
The settings to change. Properties left out keep their values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The template's name. | [optional] 
**Description** | **string** | Shown under the template's name at the top of its hosted forms, and used as their meta description. Not shown on embedded forms or signature requests. | [optional] 
**ParentFolderId** | **string** | The ID of the folder the template is in. Null for a template at the root. Setting it moves the template and all of its published versions. | [optional] 
**Locked** | **bool** | A locked template can't be changed or deleted until it's unlocked (`locked` can always be changed). | [optional] 
**AddSignatureRequestSubmissionIdFooters** | **bool** | Print the submission ID in the footer of each page of PDFs signed through signature requests. | [optional] 
**AiFieldNamingLanguage** | **AiFieldNamingLanguage** | The language AI field setup names fields in: `auto` uses the form's language when it's written in the Latin alphabet without accents, and English otherwise; `english` always uses English; `form_language` uses the form's language and script. New templates take it from your account's template settings. Null for HTML templates. | [optional] 
**AllowAdditionalProperties** | **bool** | Accept submission data with properties that aren't fields of the template. | [optional] 
**AllowSkippingOptionalFields** | **bool** | Visual forms and signature request forms show the Continue button as soon as the required fields are filled in, without visiting each optional field. The `allowSkippingOptionalFields` embed option overrides it. | [optional] 
**DefaultFormMode** | **TemplateFormMode** | The hosted form that /templates/{template_id}/form shows when its URL has no `mode` parameter: `web` (the web form), `visual` (the visual form, where fields are filled in on the PDF) or `dual` (both, in tabs). HTML templates have no visual form, so `web` is the only value they accept. | [optional] 
**EditableSubmissions** | **bool** | Generate PDFs whose text and check fields stay fillable ("Generate Editable PDFs"). A submission's `editable` overrides it. | [optional] 
**EmbedDomains** | **List&lt;string&gt;** | The sites where the template's signature requests, forms and embedded template editor can be loaded: a host such as `app.example.com`, with an optional leading wildcard (`*.example.com`), port (`localhost:3000`) or scheme (`https://app.example.com`; without one, `http` and `https` both work). When it's empty, live signature requests don't load on any site, and the embedded template editor loads on every site. | [optional] 
**EmbedEditAllowSettings** | **bool** | Allow the embedded template editor to change sensitive template settings (webhooks, redirect URL, encryption, public access, expiration and so on). | [optional] 
**EmbedEditAllowVersioning** | **bool** | Allow the embedded template editor to publish, restore, compare and delete published versions. | [optional] 
**EmbedEditAllowDocumentReplacement** | **bool** | Allow the embedded template editor to replace the template's PDF. | [optional] 
**EncryptPdfs** | **bool** | Encrypt generated PDFs with `encrypt_pdfs_password`. | [optional] 
**EncryptPdfsPassword** | **string** | The password that opens encrypted PDFs. It's never returned; `has_encrypt_pdfs_password` says if it's set. | [optional] 
**ExpireSubmissions** | **bool** | Delete each submission's data and PDF after `expire_after` `expiration_interval`. | [optional] 
**ExpireAfter** | **int** | How many `expiration_interval`s a submission's data and PDF are kept for, when `expire_submissions` is on. At most 5256000 (10 years in minutes). | [optional] 
**ExpirationInterval** | **ExpirationInterval** | The unit of `expire_after`. | [optional] 
**MergeAuditTrailPdf** | **bool** | Add the audit trail to the end of PDFs signed through signature requests. | [optional] 
**ParseDatesUsingTemplateDateFormat** | **bool** | Date fields also accept NN/NN/YYYY dates (with slashes, dashes or dots), read in the order of the template's default date format: month first for %m/%d/%Y, day first for %d/%m/%Y. When false, date fields only accept YYYY-MM-DD. Applies to PDF templates: an HTML template's date fields only accept YYYY-MM-DD. Date fields that include a time take RFC 3339 date-times either way. | [optional] 
**PublicSubmissions** | **bool** | Allow anyone with a submission's ID to download its PDF. | [optional] 
**PublicWebForm** | **bool** | Allow anyone to fill in the template's web form. | [optional] 
**RedirectUrl** | **string** | Where the web form sends people after they submit it. | [optional] 
**SlackWebhookUrl** | **string** | A Slack incoming webhook URL that is notified about the template's submissions. It's never returned; `has_slack_webhook_url` says if it's set. | [optional] 
**Defaults** | [**TemplateDefaultsInput**](TemplateDefaultsInput.md) | The default style of the template's fields. Setting it replaces the whole object. | [optional] 
**FieldDependencies** | [**List&lt;TemplateFieldDependencyInput&gt;**](TemplateFieldDependencyInput.md) | The template's conditional logic rules. Setting them replaces all of the rules. | [optional] 
**Html** | **string** | The HTML of an HTML template, as a Liquid template. Null for PDF templates. | [optional] 
**Scss** | **string** | The SCSS of an HTML template. | [optional] 
**HeaderHtml** | **string** | The HTML printed at the top of each page of an HTML template. | [optional] 
**FooterHtml** | **string** | The HTML printed at the bottom of each page of an HTML template. | [optional] 
**HtmlEngineOptions** | [**HtmlEngineOptionsInput**](HtmlEngineOptionsInput.md) | Null resets the options to their defaults. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

