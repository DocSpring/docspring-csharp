# DocSpring.Client.Api.Client

All URIs are relative to *https://sync.api.docspring.com/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTemplateFields**](Client.md#addtemplatefields) | **POST** /templates/{template_id}/fields | Add fields to a template |
| [**CopyTemplate**](Client.md#copytemplate) | **POST** /templates/{template_id}/copy | Copy a template |
| [**CreateAccountEmailAction**](Client.md#createaccountemailaction) | **POST** /email_actions | Create an account email action |
| [**CreateCombinedPdf**](Client.md#createcombinedpdf) | **POST** /combined_pdfs | Combine PDFs |
| [**CreateCustomFileFromUpload**](Client.md#createcustomfilefromupload) | **POST** /custom_files | Create a custom file from an upload |
| [**CreateEmailAction**](Client.md#createemailaction) | **POST** /templates/{template_id}/email_actions | Create an email action |
| [**CreateEmailDomain**](Client.md#createemaildomain) | **POST** /email_domains | Add an email domain |
| [**CreateFolder**](Client.md#createfolder) | **POST** /folders | Create a folder |
| [**CreateSignatureRequestEvent**](Client.md#createsignaturerequestevent) | **POST** /signature_requests/{signature_request_id}/events | Record a signature request event |
| [**CreateSignatureRequestToken**](Client.md#createsignaturerequesttoken) | **POST** /signature_requests/{signature_request_id}/tokens | Create a signature request token |
| [**CreateSubmission**](Client.md#createsubmission) | **POST** /templates/{template_id}/submissions | Generate a PDF |
| [**CreateSubmissionBatch**](Client.md#createsubmissionbatch) | **POST** /submissions/batches | Generate PDFs in a batch |
| [**CreateTemplate**](Client.md#createtemplate) | **POST** /templates | Create a template |
| [**CreateTemplatePreview**](Client.md#createtemplatepreview) | **POST** /templates/{template_id}/previews | Preview a template with data |
| [**CreateWebhook**](Client.md#createwebhook) | **POST** /webhooks | Create a webhook |
| [**DeleteAccountEmailAction**](Client.md#deleteaccountemailaction) | **DELETE** /email_actions/{email_action_id} | Delete an account email action |
| [**DeleteCustomFile**](Client.md#deletecustomfile) | **DELETE** /custom_files/{custom_file_id} | Delete a custom file |
| [**DeleteEmailAction**](Client.md#deleteemailaction) | **DELETE** /templates/{template_id}/email_actions/{email_action_id} | Delete an email action |
| [**DeleteEmailActionCustomization**](Client.md#deleteemailactioncustomization) | **DELETE** /templates/{template_id}/email_actions/{email_action_id}/customization | Reset an account email action's customization |
| [**DeleteEmailDomain**](Client.md#deleteemaildomain) | **DELETE** /email_domains/{email_domain_id} | Remove an email domain |
| [**DeleteFolder**](Client.md#deletefolder) | **DELETE** /folders/{folder_id} | Delete a folder |
| [**DeleteTemplate**](Client.md#deletetemplate) | **DELETE** /templates/{template_id} | Delete a template |
| [**DeleteWebhook**](Client.md#deletewebhook) | **DELETE** /webhooks/{webhook_id} | Delete a webhook |
| [**ExpireCombinedPdf**](Client.md#expirecombinedpdf) | **DELETE** /combined_pdfs/{combined_pdf_id} | Expire a combined PDF |
| [**ExpireSubmission**](Client.md#expiresubmission) | **DELETE** /submissions/{submission_id} | Expire a submission |
| [**GenerateSubmissionFiles**](Client.md#generatesubmissionfiles) | **POST** /submissions/{submission_id}/generate_files | Generate more files |
| [**GenerateSubmissionPreview**](Client.md#generatesubmissionpreview) | **POST** /submissions/{submission_id}/generate_preview | Generate a preview PDF |
| [**GetAccountEmailAction**](Client.md#getaccountemailaction) | **GET** /email_actions/{email_action_id} | Get an account email action |
| [**GetCombinedPdf**](Client.md#getcombinedpdf) | **GET** /combined_pdfs/{combined_pdf_id} | Get a combined PDF |
| [**GetCustomFile**](Client.md#getcustomfile) | **GET** /custom_files/{custom_file_id} | Get a custom file |
| [**GetEmailAction**](Client.md#getemailaction) | **GET** /templates/{template_id}/email_actions/{email_action_id} | Get an email action |
| [**GetEmailDomain**](Client.md#getemaildomain) | **GET** /email_domains/{email_domain_id} | Get an email domain |
| [**GetFolder**](Client.md#getfolder) | **GET** /folders/{folder_id} | Get a folder |
| [**GetPresignUrl**](Client.md#getpresignurl) | **GET** /uploads/presign | Get a presigned URL to upload a file |
| [**GetSignatureRequest**](Client.md#getsignaturerequest) | **GET** /signature_requests/{signature_request_id} | Get a signature request |
| [**GetSubmission**](Client.md#getsubmission) | **GET** /submissions/{submission_id} | Get a submission |
| [**GetSubmissionBatch**](Client.md#getsubmissionbatch) | **GET** /submissions/batches/{submission_batch_id} | Get a batch |
| [**GetTemplate**](Client.md#gettemplate) | **GET** /templates/{template_id} | Get a template |
| [**GetTemplateDiff**](Client.md#gettemplatediff) | **GET** /templates/{template_id}/diff | Compare a version of a template with the one before it |
| [**GetTemplateModelCode**](Client.md#gettemplatemodelcode) | **GET** /templates/{template_id}/model_code | Generate typed code for a template's submission data |
| [**GetTemplatePageImages**](Client.md#gettemplatepageimages) | **GET** /templates/{template_id}/page_images | Get images of a template's pages |
| [**GetTemplatePreview**](Client.md#gettemplatepreview) | **GET** /templates/{template_id}/previews/{preview_id} | Get a template preview |
| [**GetTemplateSchema**](Client.md#gettemplateschema) | **GET** /templates/{template_id}/schema | Get the JSON Schema of a template's submission data |
| [**GetWebhook**](Client.md#getwebhook) | **GET** /webhooks/{webhook_id} | Get a webhook |
| [**ListAccountEmailActions**](Client.md#listaccountemailactions) | **GET** /email_actions | List account email actions |
| [**ListCombinedPdfs**](Client.md#listcombinedpdfs) | **GET** /combined_pdfs | List combined PDFs |
| [**ListCustomFiles**](Client.md#listcustomfiles) | **GET** /custom_files | List custom files |
| [**ListEmailActions**](Client.md#listemailactions) | **GET** /templates/{template_id}/email_actions | List email actions |
| [**ListEmailDomains**](Client.md#listemaildomains) | **GET** /email_domains | List email domains |
| [**ListFolders**](Client.md#listfolders) | **GET** /folders | List folders |
| [**ListSubmissions**](Client.md#listsubmissions) | **GET** /submissions | List submissions |
| [**ListTemplateFields**](Client.md#listtemplatefields) | **GET** /templates/{template_id}/fields | List a template's fields |
| [**ListTemplateSubmissions**](Client.md#listtemplatesubmissions) | **GET** /templates/{template_id}/submissions | List a template's submissions |
| [**ListTemplates**](Client.md#listtemplates) | **GET** /templates | List templates |
| [**ListWebhooks**](Client.md#listwebhooks) | **GET** /webhooks | List webhooks |
| [**MoveFolder**](Client.md#movefolder) | **POST** /folders/{folder_id}/move | Move a folder |
| [**MoveTemplate**](Client.md#movetemplate) | **POST** /templates/{template_id}/move | Move a template to a folder |
| [**PublishTemplateVersion**](Client.md#publishtemplateversion) | **POST** /templates/{template_id}/publish_version | Publish a template version |
| [**RemoveTemplateFields**](Client.md#removetemplatefields) | **POST** /templates/{template_id}/fields/remove | Remove fields from a template |
| [**RenameFolder**](Client.md#renamefolder) | **POST** /folders/{folder_id}/rename | Rename a folder |
| [**ReorderTemplateFields**](Client.md#reordertemplatefields) | **POST** /templates/{template_id}/fields/reorder | Reorder a template's fields |
| [**RestoreTemplateVersion**](Client.md#restoretemplateversion) | **POST** /templates/{template_id}/restore_version | Restore a template version |
| [**SendAccountEmailActionTestEmail**](Client.md#sendaccountemailactiontestemail) | **POST** /email_actions/{email_action_id}/test_email | Send a test email for an account email action |
| [**SendEmailActionTestEmail**](Client.md#sendemailactiontestemail) | **POST** /templates/{template_id}/email_actions/{email_action_id}/test_email | Send a test email |
| [**TestAuthentication**](Client.md#testauthentication) | **GET** /authentication | Test authentication |
| [**UpdateAccountEmailAction**](Client.md#updateaccountemailaction) | **PUT** /email_actions/{email_action_id} | Update an account email action |
| [**UpdateEmailAction**](Client.md#updateemailaction) | **PUT** /templates/{template_id}/email_actions/{email_action_id} | Update an email action |
| [**UpdateEmailActionCustomization**](Client.md#updateemailactioncustomization) | **PUT** /templates/{template_id}/email_actions/{email_action_id}/customization | Customize an account email action for a template |
| [**UpdateSignatureRequest**](Client.md#updatesignaturerequest) | **PUT** /signature_requests/{signature_request_id} | Update a signature request |
| [**UpdateTemplate**](Client.md#updatetemplate) | **PUT** /templates/{template_id} | Update a template |
| [**UpdateTemplateDocument**](Client.md#updatetemplatedocument) | **PUT** /templates/{template_id}/document | Replace a template's document |
| [**UpdateTemplateFields**](Client.md#updatetemplatefields) | **PUT** /templates/{template_id}/fields | Update a template's fields |
| [**UpdateWebhook**](Client.md#updatewebhook) | **PUT** /webhooks/{webhook_id} | Update a webhook |
| [**UploadTemplate**](Client.md#uploadtemplate) | **POST** /templates/upload | Create a template from an uploaded PDF or Word document |
| [**UploadTemplateDocument**](Client.md#uploadtemplatedocument) | **PUT** /templates/{template_id}/document/upload | Replace a template's document with an uploaded file |
| [**ValidateSubmission**](Client.md#validatesubmission) | **POST** /templates/{template_id}/submissions/validate | Check a submission without creating it |
| [**VerifyEmailDomain**](Client.md#verifyemaildomain) | **POST** /email_domains/{email_domain_id}/verify | Verify an email domain |

<a id="addtemplatefields"></a>
# **AddTemplateFields**
> TemplateFields AddTemplateFields (string templateId, AddTemplateFieldsRequest body, string idempotencyKey = null)

Add fields to a template

Adds fields to a template's draft and returns all of its fields. Publish a version for submissions of published versions to have them. A field with the name of one of the template's fields shares its settings (`type`, `required`, `default`, ...), so a field that sets one to another value is refused: PUT /templates/{template_id}/fields changes them for every field with the name. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**AddTemplateFieldsRequest**](AddTemplateFieldsRequest.md) | The fields to add to the template's draft. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**TemplateFields**](TemplateFields.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | fields added |  -  |
| **409** | the template's PDF hasn't been processed |  -  |
| **422** | invalid fields |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="copytemplate"></a>
# **CopyTemplate**
> Template CopyTemplate (string templateId, CopyTemplateRequest body = null, string idempotencyKey = null)

Copy a template

Copies a template (its draft, or a published version) into a new template.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**CopyTemplateRequest**](CopyTemplateRequest.md) | Settings for the copy. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | template copied |  -  |
| **422** | invalid copy |  -  |
| **403** | the plan's template limit is reached |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createaccountemailaction"></a>
# **CreateAccountEmailAction**
> EmailAction CreateAccountEmailAction (CreateAccountEmailActionRequest body, string idempotencyKey = null)

Create an account email action

Adds an email action to your account. It sends for every template, or only for the templates in `template_ids` and the templates in the folders in `folder_ids` (and the folders inside them). Each template can turn it off or change its settings for that template only (`PUT /templates/{template_id}/email_actions/{email_action_id}/customization`). Without a paid plan (Starter or higher), email actions only email your team: test submissions' emails go to your account's users, and live submissions' emails aren't sent. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateAccountEmailActionRequest**](CreateAccountEmailActionRequest.md) | The account email action to create. Properties left out get their defaults, and it sends for every template unless it lists `template_ids` or `folder_ids`. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | account email action created |  -  |
| **422** | unknown template |  -  |
| **403** | email actions turned off for the account |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createcombinedpdf"></a>
# **CreateCombinedPdf**
> CombinedPdf CreateCombinedPdf (CreateCombinedPdfRequest body, bool wait = null, string idempotencyKey = null)

Combine PDFs

Merges PDFs into one: submissions, other combined PDFs, templates, custom files (POST /custom_files) and PDFs from URLs, in the order of `source_pdfs`. The PDF is generated in the background: on sync.api hosts the request waits for it (unless you pass `wait=false`), otherwise poll GET /combined_pdfs/{combined_pdf_id} until `state` isn't `pending`.  A template source merges the template's processed PDF by default: the PDF submissions are filled in on, decrypted and with its form fields removed. Pass `processed: false` to merge the PDF as it was uploaded. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateCombinedPdfRequest**](CreateCombinedPdfRequest.md) | The PDFs to merge, and the combined PDF's settings. |  |
| **wait** | **bool** | Wait until the PDF has been generated before responding. Default true on sync.api hosts. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**CombinedPdf**](CombinedPdf.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | combined PDF created |  -  |
| **422** | invalid source PDFs |  -  |
| **403** | not allowed |  -  |
| **402** | not enough credits |  -  |
| **409** | a request with the same Idempotency-Key is still being processed |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's combined_pdf_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createcustomfilefromupload"></a>
# **CreateCustomFileFromUpload**
> CustomFile CreateCustomFileFromUpload (CreateCustomFileFromUploadRequest body, string idempotencyKey = null)

Create a custom file from an upload

Creates a custom file from a PDF you uploaded, so you can merge it with other PDFs. Upload the file with the presigned upload (GET /uploads/presign) first, then pass its `fields.key` as `cache_id`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateCustomFileFromUploadRequest**](CreateCustomFileFromUploadRequest.md) | The uploaded file to create the custom file from. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**CustomFile**](CustomFile.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | custom file created |  -  |
| **422** | invalid custom file |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createemailaction"></a>
# **CreateEmailAction**
> EmailAction CreateEmailAction (string templateId, CreateEmailActionRequest body, string idempotencyKey = null)

Create an email action

Adds an email action to a template's draft. From then on, each processed submission emails its PDF to the recipients in `to`, `cc` and `bcc`: addresses, and tags for the address in one of the submission's fields (`{{ data.tenant_email }}`) or in its metadata (`{{ metadata.agent_email }}`). With `send_when`, only the submissions whose values meet its conditions send one. Without a paid plan (Starter or higher), email actions only email your team: test submissions' emails go to your account's users, and live submissions' emails aren't sent. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**CreateEmailActionRequest**](CreateEmailActionRequest.md) | The email action to create. Properties left out get their defaults. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | email action created |  -  |
| **422** | invalid email action |  -  |
| **403** | email actions turned off for the account |  -  |
| **409** | locked template |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createemaildomain"></a>
# **CreateEmailDomain**
> EmailDomain CreateEmailDomain (CreateEmailDomainRequest body, string idempotencyKey = null)

Add an email domain

Adds a domain for email actions to send from, and returns the DNS records to add to it. DocSpring checks for them every few minutes, and the domain is verified once its DKIM and DMARC records are found. Needs a paid monthly plan. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateEmailDomainRequest**](CreateEmailDomainRequest.md) | The domain to add. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailDomain**](EmailDomain.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | email domain added |  -  |
| **422** | invalid domain |  -  |
| **403** | plan without email actions |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createfolder"></a>
# **CreateFolder**
> Folder CreateFolder (CreateFolderRequest body, string idempotencyKey = null)

Create a folder

Creates a folder for organizing templates. Pass `parent_folder_id` to create it inside another folder. Folder names are unique within their parent folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateFolderRequest**](CreateFolderRequest.md) | The folder to create. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | folder created inside another folder |  -  |
| **422** | invalid folder |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createsignaturerequestevent"></a>
# **CreateSignatureRequestEvent**
> SignatureRequestEvent CreateSignatureRequestEvent (string signatureRequestId, CreateSignatureRequestEventRequest body, string idempotencyKey = null)

Record a signature request event

Records something that happened outside DocSpring in the signature request's audit trail: you sent the request to the person (`send_request`). The audit trail shows it as reported by your account. A finished (completed, declined or expired) signature request's audit trail takes no more events, and a test API token can't record one for a live signature request. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |
| **body** | [**CreateSignatureRequestEventRequest**](CreateSignatureRequestEventRequest.md) | The event to record. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**SignatureRequestEvent**](SignatureRequestEvent.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | event recorded |  -  |
| **403** | test API token on a live signature request |  -  |
| **409** | signature request finished |  -  |
| **422** | invalid event |  -  |
| **404** | signature request not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createsignaturerequesttoken"></a>
# **CreateSignatureRequestToken**
> SignatureRequestToken CreateSignatureRequestToken (string signatureRequestId, CreateSignatureRequestTokenRequest body = null, string idempotencyKey = null)

Create a signature request token

Creates a token that opens the signature request without signing in, in a form embedded in your app or from a link you send. The response is the only time the token's secret is returned. The link works for 24 hours, or 7 days for an `email` token, and a signing page that opened in time keeps working for 7 more days. A test API token can't create a token for a live signature request. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |
| **body** | [**CreateSignatureRequestTokenRequest**](CreateSignatureRequestTokenRequest.md) | The kind of link to make. Send no body for an `api` token. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**SignatureRequestToken**](SignatureRequestToken.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | token created |  -  |
| **403** | test API token on a live signature request |  -  |
| **409** | signature request finished |  -  |
| **422** | invalid token request |  -  |
| **404** | signature request not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createsubmission"></a>
# **CreateSubmission**
> Submission CreateSubmission (string templateId, CreateSubmissionRequest body, string version = null, bool wait = null, string idempotencyKey = null)

Generate a PDF

Creates a submission: fills in a template with your data and generates a PDF. The PDF is generated in the background: on sync.api hosts the request waits for it (unless you pass `wait=false`), otherwise poll GET /submissions/{submission_id} until `state` isn't `pending`.  Data that doesn't match the template's fields returns a 422 with an `invalid_data` error. The submission is still saved, with its errors, so you can find it in DocSpring: the error's `submission_id` is its ID.  With `signature_requests`, the PDF is generated once everyone has signed. DocSpring emails each signer a link to sign, unless `send_email` is false, and can send reminders and the completed document. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**CreateSubmissionRequest**](CreateSubmissionRequest.md) | The submission's data and settings. |  |
| **version** | **string** | The template version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `latest`. | [optional]  |
| **wait** | **bool** | Wait until the files have been generated before responding. Default true on sync.api hosts. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | submission created |  -  |
| **422** | invalid data |  -  |
| **402** | not enough credits |  -  |
| **403** | the account is suspended |  -  |
| **404** | template not found |  -  |
| **409** | a request with the same Idempotency-Key is still being processed |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's submission_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createsubmissionbatch"></a>
# **CreateSubmissionBatch**
> SubmissionBatch CreateSubmissionBatch (CreateSubmissionBatchRequest body, bool wait = null, string idempotencyKey = null)

Generate PDFs in a batch

Creates up to 50 submissions in one request, from one template or several. The PDFs are only generated when every submission is valid. On sync.api hosts the request waits until every PDF has been generated (unless you pass `wait=false`), otherwise poll GET /submissions/batches/{submission_batch_id} until `processed_at` is set.  When any submission is invalid, nothing is generated and the request returns a 422. Submissions whose data doesn't match their template's fields are still saved with their errors (an `invalid_data` error, with each one's `submission_id` in its details), so you can find them in DocSpring. The other submissions aren't saved. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateSubmissionBatchRequest**](CreateSubmissionBatchRequest.md) | The submissions to create, and the settings they share. |  |
| **wait** | **bool** | Wait until every file in the batch has been generated before responding. Default true on sync.api hosts. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**SubmissionBatch**](SubmissionBatch.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | batch created |  -  |
| **422** | invalid data |  -  |
| **402** | not enough credits |  -  |
| **403** | account suspended |  -  |
| **409** | a request with the same Idempotency-Key is still being processed |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's submission_batch_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createtemplate"></a>
# **CreateTemplate**
> Template CreateTemplate (CreateTemplateRequest body, bool wait = null, string idempotencyKey = null)

Create a template

Creates an HTML template, or a PDF or Word template from a file you uploaded with the presigned upload (GET /uploads/presign): pass its `fields.key` as `cache_id`. You can send a link to the file (`document_url`) or the file in base64 (`document_base64`) instead, or send the file with the request with POST /templates/upload. A Word template is made from a Word document (.docx) or an OpenDocument text file (.odt), which DocSpring converts to a Word document. It needs its `output_format`: what each submission makes, a Word document (`docx`), an OpenDocument file (`odt`) or a PDF. A page design (`page_designer`) takes its `layout` in the Page Designer layout format, or starts with an empty page without one.  A PDF template is ready to generate PDFs once DocSpring has processed its PDF, a template created from a `document_url` once its document has been downloaded, and one created from an .odt once it has been converted (`ready` is true). On sync.api hosts the request waits for that unless you pass `wait=false`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateTemplateRequest**](CreateTemplateRequest.md) | The template to create. |  |
| **wait** | **bool** | Wait until the PDF has been processed, a `document_url`'s PDF or Word document downloaded, and an OpenDocument file converted, before responding. Default true on sync.api hosts. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | HTML template created |  -  |
| **422** | invalid template |  -  |
| **403** | the plan's template limit is reached |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's template_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createtemplatepreview"></a>
# **CreateTemplatePreview**
> TemplatePreview CreateTemplatePreview (string templateId, CreateTemplatePreviewRequest body, string version = null, string idempotencyKey = null)

Preview a template with data

Makes PNG images of a template's pages filled in with the data you send (not a PDF), so you can check how an HTML, PDF or Word template or a page design prints with your data before you publish a version or send live data. A Word template's pages are its PDF's, whatever its `output_format`. It renders the template's draft, or the published `version` you ask for. A preview makes no submission and uses no credits, and its pages are watermarked like a test submission's PDF. It's `pending` while it renders: get it with GET /templates/{template_id}/previews/{preview_id} until it's `processed`, with an image of each page, or `error`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**CreateTemplatePreviewRequest**](CreateTemplatePreviewRequest.md) | The data to render the template with. |  |
| **version** | **string** | A published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `draft`. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | preview created |  -  |
| **409** | this server can't convert Word documents to PDF |  -  |
| **422** | no data |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="createwebhook"></a>
# **CreateWebhook**
> Webhook CreateWebhook (CreateWebhookRequest body, string idempotencyKey = null)

Create a webhook

Creates a webhook that sends a POST request to your endpoint whenever a subscribed event happens. Scope it to API tokens, templates or folders to receive only their events. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateWebhookRequest**](CreateWebhookRequest.md) | The webhook to create. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | webhook created |  -  |
| **422** | invalid webhook |  -  |
| **403** | the plan's integration limit is reached |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deleteaccountemailaction"></a>
# **DeleteAccountEmailAction**
> EmailAction DeleteAccountEmailAction (string emailActionId, string idempotencyKey = null)

Delete an account email action

Deletes one of your account's email actions, with every template's customization of it. Emails it has already queued for submissions aren't sent. Submissions keep the record of the emails it sent. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailActionId** | **string** | The account email action's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account email action deleted |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deletecustomfile"></a>
# **DeleteCustomFile**
> CustomFile DeleteCustomFile (string customFileId, string idempotencyKey = null)

Delete a custom file

Deletes a custom file and returns it. Use a live API token: test tokens can't delete custom files. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customFileId** | **string** | The custom file's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**CustomFile**](CustomFile.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | custom file deleted |  -  |
| **403** | test API token |  -  |
| **404** | custom file not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deleteemailaction"></a>
# **DeleteEmailAction**
> EmailAction DeleteEmailAction (string templateId, string emailActionId, string idempotencyKey = null)

Delete an email action

Deletes an email action. Emails it has already queued for submissions aren't sent. Submissions keep the record of the emails it sent. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **emailActionId** | **string** | The email action's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email action deleted |  -  |
| **409** | locked template |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deleteemailactioncustomization"></a>
# **DeleteEmailActionCustomization**
> EmailAction DeleteEmailActionCustomization (string templateId, string emailActionId, string idempotencyKey = null)

Reset an account email action's customization

Removes the template's changes to one of your account's email actions: it sends for this template as it is, and again if the template had turned it off. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **emailActionId** | **string** | The ID of one of your account's email actions that sends for the template. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | customization reset |  -  |
| **409** | locked template |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deleteemaildomain"></a>
# **DeleteEmailDomain**
> EmailDomain DeleteEmailDomain (string emailDomainId, string idempotencyKey = null)

Remove an email domain

Removes an email domain. Email actions that send from an address at it fail until you add and verify it again, or change their `from_address`. You can then remove its DNS records. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailDomainId** | **string** | The email domain's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailDomain**](EmailDomain.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email domain removed |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> Folder DeleteFolder (string folderId, string idempotencyKey = null)

Delete a folder

Deletes an empty folder and returns it. A folder that still has templates or folders in it can't be deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folder deleted |  -  |
| **409** | folder is not empty |  -  |
| **404** | folder not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deletetemplate"></a>
# **DeleteTemplate**
> Template DeleteTemplate (string templateId, string version = null, string idempotencyKey = null)

Delete a template

Deletes a template's draft and all of its published versions, or one published version (`version`). Returns the template as it was before it was deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | Delete only this published version (`1.2.0`) or the draft (`draft`, when no version has been published). Without it, the draft and every published version are deleted. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template deleted |  -  |
| **409** | template is locked |  -  |
| **404** | template not found |  -  |
| **422** | invalid version |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="deletewebhook"></a>
# **DeleteWebhook**
> Webhook DeleteWebhook (string webhookId, string idempotencyKey = null)

Delete a webhook

Deletes a webhook so it stops receiving events, and returns it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | The webhook's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook deleted |  -  |
| **404** | webhook not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="expirecombinedpdf"></a>
# **ExpireCombinedPdf**
> CombinedPdf ExpireCombinedPdf (string combinedPdfId, string idempotencyKey = null)

Expire a combined PDF

Deletes a combined PDF's PDF and returns the expired combined PDF.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **combinedPdfId** | **string** | The combined PDF's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**CombinedPdf**](CombinedPdf.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | combined PDF expired |  -  |
| **403** | test API token |  -  |
| **404** | combined PDF not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="expiresubmission"></a>
# **ExpireSubmission**
> Submission ExpireSubmission (string submissionId, string idempotencyKey = null)

Expire a submission

Deletes a submission's data and PDF now, and returns the expired submission.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** | The submission's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | submission expired |  -  |
| **403** | test API token |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="generatesubmissionfiles"></a>
# **GenerateSubmissionFiles**
> Submission GenerateSubmissionFiles (string submissionId, GenerateSubmissionFilesRequest body, bool wait = null, string idempotencyKey = null)

Generate more files

Adds formats to a processed submission's files, in the background, without using credits again: `pdf`, the PDF of a Word template's submission that made only its Word document (converted from that document), `docx`, the Word document of a Word template's submission that made only its PDF (made again from its data and the template version it used), `odt`, a Word template's submission's OpenDocument file (converted from its Word document, or from one made again when it didn't keep one), and `png`, a PNG image of each page of the PDF (up to 100 pages), which makes the PDF first when the submission doesn't have one. To make them with the submission, add them to `output_formats` when you create it.  Each new file is listed in `files` while it's made: on sync.api hosts the request waits for them (unless you pass `wait=false`), otherwise poll GET /submissions/{submission_id} until none of their `state` is `pending`. A file that couldn't be made has the state `error` and an `error_message`, and the submission stays processed. Asking for a format the submission already has (or is making) changes nothing. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** | The submission's ID. |  |
| **body** | [**GenerateSubmissionFilesRequest**](GenerateSubmissionFilesRequest.md) | The formats to make. |  |
| **wait** | **bool** | Wait until the files have been generated before responding. Default true on sync.api hosts. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | images of the pages requested |  -  |
| **409** | files not possible |  -  |
| **422** | invalid request |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's submission_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="generatesubmissionpreview"></a>
# **GenerateSubmissionPreview**
> Submission GenerateSubmissionPreview (string submissionId, string idempotencyKey = null)

Generate a preview PDF

Generates a preview of a submission's PDF in the background, such as for a submission still waiting for its signature requests. It's in `files.preview` once `preview_generated_at` changes. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** | The submission's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | preview requested |  -  |
| **409** | preview not possible |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getaccountemailaction"></a>
# **GetAccountEmailAction**
> EmailAction GetAccountEmailAction (string emailActionId)

Get an account email action

Returns one of your account's email actions, with its settings and whether its emails are failing.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailActionId** | **string** | The account email action's ID. |  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account email action |  -  |
| **404** | account email action not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getcombinedpdf"></a>
# **GetCombinedPdf**
> CombinedPdf GetCombinedPdf (string combinedPdfId)

Get a combined PDF

Returns a combined PDF, with a temporary link to download it once it has been generated.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **combinedPdfId** | **string** | The combined PDF's ID. |  |

### Return type

[**CombinedPdf**](CombinedPdf.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | combined PDF |  -  |
| **404** | combined PDF not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getcustomfile"></a>
# **GetCustomFile**
> CustomFile GetCustomFile (string customFileId)

Get a custom file

Returns a custom file, with a temporary URL to download it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customFileId** | **string** | The custom file's ID. |  |

### Return type

[**CustomFile**](CustomFile.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | custom file found |  -  |
| **404** | custom file not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getemailaction"></a>
# **GetEmailAction**
> EmailAction GetEmailAction (string templateId, string emailActionId)

Get an email action

Returns one of a template's email actions, with its settings and whether its emails are failing.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **emailActionId** | **string** | The email action's ID. |  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email action |  -  |
| **404** | email action not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getemaildomain"></a>
# **GetEmailDomain**
> EmailDomain GetEmailDomain (string emailDomainId)

Get an email domain

Returns an email domain, whether it's verified, and the DNS records to add to it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailDomainId** | **string** | The email domain's ID. |  |

### Return type

[**EmailDomain**](EmailDomain.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email domain |  -  |
| **404** | email domain not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getfolder"></a>
# **GetFolder**
> Folder GetFolder (string folderId)

Get a folder

Returns a folder.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folder found |  -  |
| **404** | folder not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getpresignurl"></a>
# **GetPresignUrl**
> UploadPresign GetPresignUrl ()

Get a presigned URL to upload a file

Returns a presigned S3 form for uploading a file directly to DocSpring, for files too large to send in a request body. POST the `fields` and the file (as `file`) to `url` as multipart/form-data, then pass `fields.key` as the `cache_id` when you create a custom file. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**UploadPresign**](UploadPresign.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | presigned URL created |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getsignaturerequest"></a>
# **GetSignatureRequest**
> SignatureRequest GetSignatureRequest (string signatureRequestId)

Get a signature request

Returns a signature request, with the values the person has entered so far.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |

### Return type

[**SignatureRequest**](SignatureRequest.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signature request |  -  |
| **404** | signature request not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getsubmission"></a>
# **GetSubmission**
> Submission GetSubmission (string submissionId)

Get a submission

Returns a submission, with its data and links to download its PDF.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** | The submission's ID. |  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | processed submission |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getsubmissionbatch"></a>
# **GetSubmissionBatch**
> SubmissionBatch GetSubmissionBatch (string submissionBatchId, bool includeData = null)

Get a batch

Returns a batch with its submissions. The batch has finished once `processed_at` is set: its `state` is `processed` when every PDF was generated, or `error` when any submission failed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionBatchId** | **string** | The batch's ID. |  |
| **includeData** | **bool** | Include each submission's `data` (null without it). | [optional]  |

### Return type

[**SubmissionBatch**](SubmissionBatch.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | batch |  -  |
| **404** | batch not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="gettemplate"></a>
# **GetTemplate**
> Template GetTemplate (string templateId, string version = null)

Get a template

Returns a template: its draft, or one of its published versions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | A published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `draft`. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PDF template |  -  |
| **404** | template not found |  -  |
| **422** | invalid version |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="gettemplatediff"></a>
# **GetTemplateDiff**
> TemplateDiff GetTemplateDiff (string templateId, string version = null)

Compare a version of a template with the one before it

Returns what changed in the template's draft since its latest published version (or in a published version since the one before it): fields added, removed, changed and moved, the settings that changed, and whether the document was replaced. Check it before you publish a version. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | A published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `draft`. | [optional]  |

### Return type

[**TemplateDiff**](TemplateDiff.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the draft's changes since the latest published version |  -  |
| **409** | the template's PDF hasn't been processed |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="gettemplatemodelcode"></a>
# **GetTemplateModelCode**
> TemplateModelCode GetTemplateModelCode (string templateId, ModelCodeLanguage lang, string version = null, bool justTypes = null)

Generate typed code for a template's submission data

Generates types for a template's submission data in TypeScript, JavaScript, Ruby, Python, PHP, Java, C#, Elixir, Go or Rust, so your app catches mistakes before it calls the API. `root_type_name` is the type of the whole `data` object, and `just_types=true` leaves out the code that converts JSON to and from the types. Java returns every class in `code`, each under a `// ClassName.java` comment. A template with no named fields returns 422. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **lang** | **ModelCodeLanguage** | The language to generate the code in. |  |
| **version** | **string** | The template version: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `latest`, the version a submission uses by default. | [optional]  |
| **justTypes** | **bool** | Return only the types (interfaces, classes or structs), without the code that converts JSON to and from them. Default false. JavaScript has no types, PHP has no types-only code, and Rust's code is only types (serde converts the JSON), so theirs is the same either way. | [optional]  |

### Return type

[**TemplateModelCode**](TemplateModelCode.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | model code |  -  |
| **422** | unknown language |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="gettemplatepageimages"></a>
# **GetTemplatePageImages**
> TemplatePageImages GetTemplatePageImages (string templateId, string version = null)

Get images of a template's pages

Returns a JPEG image of each page of a PDF template's PDF, with temporary links to download them: the draft's PDF, or a published version's. Use them to see the pages that fields are placed on. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | A published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `draft`. | [optional]  |

### Return type

[**TemplatePageImages**](TemplatePageImages.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | page images |  -  |
| **409** | no page images |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="gettemplatepreview"></a>
# **GetTemplatePreview**
> TemplatePreview GetTemplatePreview (string templateId, string previewId)

Get a template preview

Returns a preview made with POST /templates/{template_id}/previews. Once it's `processed`, `pages` has a PNG image of each page with a temporary link to download it: a preview has no PDF. Previews are deleted an hour after they're created. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **previewId** | **string** | The preview's ID. |  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | preview |  -  |
| **404** | preview not found |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="gettemplateschema"></a>
# **GetTemplateSchema**
> Dictionary&lt;string, Object&gt; GetTemplateSchema (string templateId, string version = null)

Get the JSON Schema of a template's submission data

Returns the JSON Schema that a submission's `data` must match. Use it to check data before you create submissions, or to build a form for the template's fields. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | The template version: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `latest`, the version a submission uses by default. | [optional]  |

### Return type

**Dictionary<string, Object>**

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template schema |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (string webhookId)

Get a webhook

Returns a webhook.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | The webhook's ID. |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook found |  -  |
| **404** | webhook not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listaccountemailactions"></a>
# **ListAccountEmailActions**
> EmailActionList ListAccountEmailActions (int limit = null, string cursor = null)

List account email actions

Returns your account's email actions, newest first, one page at a time. Each one emails the files of every template's processed submissions, or of the templates and folders it lists. A template's own email actions are listed with the template (`GET /templates/{template_id}/email_actions`). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**EmailActionList**](EmailActionList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account email actions |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listcombinedpdfs"></a>
# **ListCombinedPdfs**
> CombinedPdfList ListCombinedPdfs (int limit = null, string cursor = null)

List combined PDFs

Returns the combined PDFs in your account, newest first, one page at a time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**CombinedPdfList**](CombinedPdfList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | combined PDFs |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listcustomfiles"></a>
# **ListCustomFiles**
> CustomFileList ListCustomFiles (int limit = null, string cursor = null)

List custom files

Returns the custom files in your account, newest first, one page at a time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**CustomFileList**](CustomFileList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | custom files |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listemailactions"></a>
# **ListEmailActions**
> EmailActionList ListEmailActions (string templateId, int limit = null, string cursor = null)

List email actions

Returns the email actions of a template's draft, and your account's email actions that send for it, newest first, one page at a time. Each one emails every processed submission's files to the people it lists. An account email action (`template_id` null) shows the settings it sends for this template, with the template's changes in `customization`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**EmailActionList**](EmailActionList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email actions |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listemaildomains"></a>
# **ListEmailDomains**
> EmailDomainList ListEmailDomains (int limit = null, string cursor = null)

List email domains

Returns the domains in your account that email actions can send from once they're verified, newest first, one page at a time. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**EmailDomainList**](EmailDomainList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email domains |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listfolders"></a>
# **ListFolders**
> FolderList ListFolders (string parentFolderId = null, int limit = null, string cursor = null)

List folders

Returns the folders in your account, newest first, one page at a time. Pass `parent_folder_id` to list the folders in one folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentFolderId** | **string** | Only list the folders in this folder. Without it, the list has every folder, at any depth. | [optional]  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**FolderList**](FolderList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folders in a folder |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listsubmissions"></a>
# **ListSubmissions**
> SubmissionList ListSubmissions (string templateId = null, bool test = null, DateTime createdAfter = null, DateTime createdBefore = null, bool includeData = null, int limit = null, string cursor = null, SubmissionState state = null, bool includeFiles = null)

List submissions

Returns the submissions in your account, newest first, one page at a time. Each one is a summary: its `data` is null unless you pass `include_data=true`, and its `files` are empty unless you pass `include_files=true`. Get a submission by its ID for its signature requests, uploads and page images. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | Only list this template's submissions. | [optional]  |
| **test** | **bool** | Only list test submissions (true) or live submissions (false). | [optional]  |
| **createdAfter** | **DateTime** | Only list submissions created after this time (RFC 3339, such as `2025-01-31T09:00:00Z`). | [optional]  |
| **createdBefore** | **DateTime** | Only list submissions created before this time. | [optional]  |
| **includeData** | **bool** | Include each submission's `data` (null without it). | [optional]  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |
| **state** | **SubmissionState** | Only list submissions in this state (one state per request). The ones that failed are `invalid_data`, `error`, `syntax_error`, `image_download_failed` and `image_processing_failed`, and one still `pending` an hour after it was created is stuck. | [optional]  |
| **includeFiles** | **bool** | Include each submission's generated files and their download links (`files`, empty without it), without the page images' links. | [optional]  |

### Return type

[**SubmissionList**](SubmissionList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | submissions |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listtemplatefields"></a>
# **ListTemplateFields**
> TemplateFields ListTemplateFields (string templateId, string version = null)

List a template's fields

Returns a template's fields with all of their settings, page by page: the draft's fields, or a published version's. A PDF template's fields are placed on its pages: GET /templates/{template_id}/page_images has images of the pages. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | A published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `draft`. | [optional]  |

### Return type

[**TemplateFields**](TemplateFields.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | fields |  -  |
| **409** | the template's PDF hasn't been processed |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listtemplatesubmissions"></a>
# **ListTemplateSubmissions**
> SubmissionList ListTemplateSubmissions (string templateId, bool test = null, DateTime createdAfter = null, DateTime createdBefore = null, bool includeData = null, int limit = null, string cursor = null, SubmissionState state = null, bool includeFiles = null)

List a template's submissions

Returns a template's submissions (from every version of the template), newest first.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **test** | **bool** | Only list test submissions (true) or live submissions (false). | [optional]  |
| **createdAfter** | **DateTime** | Only list submissions created after this time (RFC 3339, such as `2025-01-31T09:00:00Z`). | [optional]  |
| **createdBefore** | **DateTime** | Only list submissions created before this time. | [optional]  |
| **includeData** | **bool** | Include each submission's `data` (null without it). | [optional]  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |
| **state** | **SubmissionState** | Only list submissions in this state (one state per request). The ones that failed are `invalid_data`, `error`, `syntax_error`, `image_download_failed` and `image_processing_failed`, and one still `pending` an hour after it was created is stuck. | [optional]  |
| **includeFiles** | **bool** | Include each submission's generated files and their download links (`files`, empty without it), without the page images' links. | [optional]  |

### Return type

[**SubmissionList**](SubmissionList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template's submissions |  -  |
| **404** | template not found |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listtemplates"></a>
# **ListTemplates**
> TemplateSummaryList ListTemplates (string query = null, string parentFolderId = null, int limit = null, string cursor = null)

List templates

Returns the templates in your account (their drafts), newest first, one page at a time. Each one is a summary: get a template by its ID for its settings, its PDF in full, its HTML, defaults and published versions. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Only list templates whose name contains this text (ignoring case). `%` and `_` match themselves. | [optional]  |
| **parentFolderId** | **string** | Only list the templates in this folder (not in its subfolders). | [optional]  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**TemplateSummaryList**](TemplateSummaryList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | templates |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="listwebhooks"></a>
# **ListWebhooks**
> WebhookList ListWebhooks (WebhookEventType eventType = null, WebhookMode mode = null, string templateId = null, string folderId = null, string apiTokenId = null, int limit = null, string cursor = null)

List webhooks

Returns the webhooks in your account, newest first, one page at a time. Filter them by event type, mode, or the API token, template or folder they're scoped to. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventType** | **WebhookEventType** | Only list webhooks that subscribe to this event. | [optional]  |
| **mode** | **WebhookMode** | Only list webhooks set to this mode. | [optional]  |
| **templateId** | **string** | Only list webhooks scoped to this template. | [optional]  |
| **folderId** | **string** | Only list webhooks scoped to this folder. | [optional]  |
| **apiTokenId** | **string** | Only list webhooks scoped to this API token. | [optional]  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**WebhookList**](WebhookList.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhooks for a template and event |  -  |
| **422** | unknown event type |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="movefolder"></a>
# **MoveFolder**
> Folder MoveFolder (string folderId, MoveFolderRequest body, string idempotencyKey = null)

Move a folder

Moves a folder into another folder, or to the root with `parent_folder_id: null`. Its templates and folders move with it. A folder can't move into itself or one of its own folders. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |
| **body** | [**MoveFolderRequest**](MoveFolderRequest.md) | Where to move the folder. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folder moved into another folder |  -  |
| **422** | invalid move |  -  |
| **404** | folder not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="movetemplate"></a>
# **MoveTemplate**
> Template MoveTemplate (string templateId, MoveTemplateRequest body, string idempotencyKey = null)

Move a template to a folder

Moves a template and all of its published versions to a folder, or to the root (`null`).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**MoveTemplateRequest**](MoveTemplateRequest.md) | Where to move the template. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template moved |  -  |
| **422** | invalid move |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="publishtemplateversion"></a>
# **PublishTemplateVersion**
> TemplateVersion PublishTemplateVersion (string templateId, PublishTemplateVersionRequest body, string idempotencyKey = null)

Publish a template version

Publishes the template's draft as a new version. Its content (the PDF or HTML, fields, name and description) never changes, while settings such as `webhook_url` and `public_submissions` keep following the draft. `version_type` says which part of the latest version number goes up. While the template's PDF is downloading or being processed, or DocSpring is setting up its fields, it returns a 409 that says so. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**PublishTemplateVersionRequest**](PublishTemplateVersionRequest.md) | The version to publish. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**TemplateVersion**](TemplateVersion.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | version published |  -  |
| **422** | invalid version type |  -  |
| **404** | template not found |  -  |
| **409** | no changes to publish |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="removetemplatefields"></a>
# **RemoveTemplateFields**
> TemplateFields RemoveTemplateFields (string templateId, RemoveTemplateFieldsRequest body, string idempotencyKey = null)

Remove fields from a template

Removes fields from a template's draft and returns the fields that are left. Conditional logic that used only the removed fields is removed too. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**RemoveTemplateFieldsRequest**](RemoveTemplateFieldsRequest.md) | The fields to remove from the template's draft. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**TemplateFields**](TemplateFields.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | fields removed |  -  |
| **422** | a field the template does not have |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="renamefolder"></a>
# **RenameFolder**
> Folder RenameFolder (string folderId, RenameFolderRequest body, string idempotencyKey = null)

Rename a folder

Renames a folder. The name must be unique within its parent folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |
| **body** | [**RenameFolderRequest**](RenameFolderRequest.md) | The folder's new name. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folder renamed |  -  |
| **422** | name already exists |  -  |
| **404** | folder not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="reordertemplatefields"></a>
# **ReorderTemplateFields**
> TemplateFields ReorderTemplateFields (string templateId, ReorderTemplateFieldsRequest body, string idempotencyKey = null)

Reorder a template's fields

Changes the order of the fields in a template's draft and returns them in their new order. Send every field's ID: each field stays on its page, and a page's fields are printed in this order, so a later field prints over an earlier one where they overlap. Their values are in this order in the template's data schema and forms. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**ReorderTemplateFieldsRequest**](ReorderTemplateFieldsRequest.md) | The new order of the fields in the template's draft. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**TemplateFields**](TemplateFields.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | fields reordered |  -  |
| **422** | a field missing from the order |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="restoretemplateversion"></a>
# **RestoreTemplateVersion**
> Template RestoreTemplateVersion (string templateId, RestoreTemplateVersionRequest body, string idempotencyKey = null)

Restore a template version

Replaces the template's draft with a copy of one of its published versions. The draft keeps its settings that apply to every version, such as `webhook_url`.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**RestoreTemplateVersionRequest**](RestoreTemplateVersionRequest.md) | The version to restore. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | version restored |  -  |
| **409** | template is locked |  -  |
| **422** | unknown version |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="sendaccountemailactiontestemail"></a>
# **SendAccountEmailActionTestEmail**
> EmailActionTestEmail SendAccountEmailActionTestEmail (string emailActionId, SendAccountEmailActionTestEmailRequest body = null, string idempotencyKey = null)

Send a test email for an account email action

Sends the account email action's email to the API token's user only, as it would go for one template it sends for, with each field shown as its name in brackets, so you can check how it looks. When the email action attaches its files and that template is a PDF template, the test attaches the template's blank PDF. It isn't recorded on any submission. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailActionId** | **string** | The account email action's ID. |  |
| **body** | [**SendAccountEmailActionTestEmailRequest**](SendAccountEmailActionTestEmailRequest.md) | Which template the test email is for. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailActionTestEmail**](EmailActionTestEmail.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | test email sent |  -  |
| **422** | template it does not send for |  -  |
| **409** | no template to send for |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="sendemailactiontestemail"></a>
# **SendEmailActionTestEmail**
> EmailActionTestEmail SendEmailActionTestEmail (string templateId, string emailActionId, string idempotencyKey = null)

Send a test email

Sends the email action's email to the API token's user only, with each field and metadata value shown as its name in brackets, so you can check how it looks. When the email action attaches its files and the template is a PDF template, the test attaches the template's blank PDF. It isn't recorded on any submission. Without a paid plan, the user needs a confirmed email address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **emailActionId** | **string** | The email action's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailActionTestEmail**](EmailActionTestEmail.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | test email sent |  -  |
| **409** | email action that cannot send |  -  |
| **403** | email actions turned off for the account |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="testauthentication"></a>
# **TestAuthentication**
> AuthenticationCheck TestAuthentication ()

Test authentication

Checks whether your API token is valid by making an authenticated request. This endpoint is useful for verifying credentials during setup or troubleshooting issues. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**AuthenticationCheck**](AuthenticationCheck.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | authentication succeeded |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updateaccountemailaction"></a>
# **UpdateAccountEmailAction**
> EmailAction UpdateAccountEmailAction (string emailActionId, UpdateAccountEmailActionRequest body, string idempotencyKey = null)

Update an account email action

Changes one of your account's email actions. Properties left out keep their values. Its templates' customizations keep their own changes, and follow the rest. Set `enabled` to false to stop its emails for every template. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailActionId** | **string** | The account email action's ID. |  |
| **body** | [**UpdateAccountEmailActionRequest**](UpdateAccountEmailActionRequest.md) | The settings to change. Properties left out keep their values. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account email action updated |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updateemailaction"></a>
# **UpdateEmailAction**
> EmailAction UpdateEmailAction (string templateId, string emailActionId, UpdateEmailActionRequest body, string idempotencyKey = null)

Update an email action

Changes an email action's settings. Properties left out keep their values. Set `enabled` to false to stop its emails, or to true to turn it back on after DocSpring turned it off. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **emailActionId** | **string** | The email action's ID. |  |
| **body** | [**UpdateEmailActionRequest**](UpdateEmailActionRequest.md) | The settings to change. Properties left out keep their values. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email action updated |  -  |
| **422** | invalid email action |  -  |
| **409** | account email action |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updateemailactioncustomization"></a>
# **UpdateEmailActionCustomization**
> EmailAction UpdateEmailActionCustomization (string templateId, string emailActionId, UpdateEmailActionCustomizationRequest body, string idempotencyKey = null)

Customize an account email action for a template

Changes one of your account's email actions for this template only, replacing any changes the template had. Each setting you send is changed for this template, and the ones you leave out follow the account email action, including later changes to it. Set `enabled` to false to stop it sending for this template. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **emailActionId** | **string** | The ID of one of your account's email actions that sends for the template. |  |
| **body** | [**UpdateEmailActionCustomizationRequest**](UpdateEmailActionCustomizationRequest.md) | The template's changes to the account email action, replacing any it had. Each setting you send is changed for this template, and the ones you leave out follow the account email action. `enabled: false` stops it sending for this template; left out, it sends. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailAction**](EmailAction.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | customization saved |  -  |
| **422** | invalid customization |  -  |
| **409** | template's own email action |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updatesignaturerequest"></a>
# **UpdateSignatureRequest**
> SignatureRequest UpdateSignatureRequest (string signatureRequestId, UpdateSignatureRequestRequest body, string idempotencyKey = null)

Update a signature request

Changes a pending signature request's metadata, or how your app authenticated the person (for the audit trail). Once the person has opened it, only its metadata can be changed, and a completed or declined signature request can't be changed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |
| **body** | [**UpdateSignatureRequestRequest**](UpdateSignatureRequestRequest.md) | The settings to change. Properties left out keep their values. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**SignatureRequest**](SignatureRequest.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signature request updated |  -  |
| **409** | signature request completed |  -  |
| **422** | invalid request |  -  |
| **404** | signature request not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> Template UpdateTemplate (string templateId, UpdateTemplateRequest body, string idempotencyKey = null)

Update a template

Changes a template's draft. Properties left out keep their values. `defaults`, `html_engine_options` and a page design's `layout` replace the whole object, and `field_groups` changes only the groups it lists. A new layout adds a field for each new value it reads. Settings such as `webhook_url`, `public_submissions` and `expire_after` apply to every published version too, and setting `parent_folder_id` moves the template and all of its published versions. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**UpdateTemplateRequest**](UpdateTemplateRequest.md) | The settings to change. Properties left out keep their values. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template updated |  -  |
| **409** | template is locked |  -  |
| **422** | invalid field group changes |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updatetemplatedocument"></a>
# **UpdateTemplateDocument**
> Template UpdateTemplateDocument (string templateId, UpdateTemplateDocumentRequest body, bool wait = null, string idempotencyKey = null)

Replace a template's document

Replaces a PDF template's PDF, or a Word template's Word document (from a .docx or an .odt), with one you uploaded with the presigned upload (GET /uploads/presign) (`cache_id`), a link to download it from (`document_url`), or the file in base64 (`document_base64`). A PDF template's fields stay where they are, unless `reimport_fields` replaces them with the new PDF's fillable fields, and a Word template gets a field for each new tag. To send the file as `multipart/form-data` instead, use PUT /templates/{template_id}/document/upload. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**UpdateTemplateDocumentRequest**](UpdateTemplateDocumentRequest.md) | The new PDF, or a Word template's new Word document, as one of `cache_id`, `document_url` and `document_base64`. |  |
| **wait** | **bool** | Wait until the PDF has been processed, a `document_url`'s PDF or Word document downloaded, and an OpenDocument file converted, before responding. Default true on sync.api hosts. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PDF replaced |  -  |
| **409** | template is locked, so its fields can't be re-imported |  -  |
| **422** | no document, or more than one |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's template_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updatetemplatefields"></a>
# **UpdateTemplateFields**
> TemplateFields UpdateTemplateFields (string templateId, UpdateTemplateFieldsRequest body, string idempotencyKey = null)

Update a template's fields

Changes fields of a template's draft and returns all of its fields. Settings left out keep their values. A shared setting (`type`, `required`, `default`, ...) changes for every field with the same name. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**UpdateTemplateFieldsRequest**](UpdateTemplateFieldsRequest.md) | The fields to change in the template's draft. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**TemplateFields**](TemplateFields.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | fields updated |  -  |
| **422** | invalid changes |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
> Webhook UpdateWebhook (string webhookId, UpdateWebhookRequest body, string idempotencyKey = null)

Update a webhook

Updates a webhook. Only the properties you send change.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | The webhook's ID. |  |
| **body** | [**UpdateWebhookRequest**](UpdateWebhookRequest.md) | The settings to change. Properties left out keep their values. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook updated |  -  |
| **403** | turning the webhook on would go over the plan's integration limit |  -  |
| **404** | webhook not found |  -  |
| **422** | invalid webhook |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="uploadtemplate"></a>
# **UploadTemplate**
> Template UploadTemplate (System.IO.Stream document, bool wait = null, string name = null, string description = null, string parentFolderId = null, AiFieldNamingLanguage aiFieldNamingLanguage = null, bool detectFields = null, FieldSetupSource fieldSource = null, FieldSetupNaming fieldNaming = null, FieldSetupLogic fieldLogic = null, OutputFormat outputFormat = null, string idempotencyKey = null)

Create a template from an uploaded PDF or Word document

Creates a PDF template from a PDF, or a Word template from a Word document (.docx) or an OpenDocument text file (.odt), sent with the request (`multipart/form-data`). A Word template needs its `output_format`. For large files, upload the file with the presigned upload (GET /uploads/presign) and create the template with POST /templates. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **document** | **System.IO.Stream****System.IO.Stream** | A PDF (for a PDF template) or a Word document (.docx or .odt, for a Word template). DocSpring converts an OpenDocument text file (.odt) to a Word document after responding: the template's `document.state` is `converting` until then (sync.api hosts wait for it). |  |
| **wait** | **bool** | Wait until the PDF has been processed, a `document_url`'s PDF or Word document downloaded, and an OpenDocument file converted, before responding. Default true on sync.api hosts. | [optional]  |
| **name** | **string** | The template's name. | [optional]  |
| **description** | **string** | The template's description. | [optional]  |
| **parentFolderId** | **string** | The folder to put the template in. Left out, it's created at the root. | [optional]  |
| **aiFieldNamingLanguage** | **AiFieldNamingLanguage** | The language AI field setup names fields in: `auto` uses the form's language when it's written in the Latin alphabet without accents, and English otherwise; `english` always uses English; `form_language` uses the form's language and script. Default: your account's template settings. | [optional]  |
| **detectFields** | **bool** | Set up the PDF's fields as DocSpring's "Automatically detect fields" upload option does: import or detect the fields, name them with AI, and set up conditional logic. `field_source`, `field_naming` and `field_logic` choose how. Default false. `document.page_processing_statuses` and `document.field_logic_status` show how it's going, and `document.state` becomes `processed` once every page's fields are set up. | [optional]  |
| **fieldSource** | **FieldSetupSource** | With `detect_fields`, where the fields come from. `auto` (the default) imports the form fields of a fillable PDF and detects the fields of a PDF without them; `pdf_detection` detects the fields from the page layout, even on a fillable PDF; `pdf_form_fields` only imports the PDF's form fields. | [optional]  |
| **fieldNaming** | **FieldSetupNaming** | With `detect_fields`, how the fields are named. `ai` (the default) names them and sets their types and settings with AI; `preserve` keeps the names of the PDF's form fields, and AI only names the fields it detected. `preserve` needs `field_source` `auto` or `pdf_form_fields`. | [optional]  |
| **fieldLogic** | **FieldSetupLogic** | With `detect_fields`, whether AI reads the whole form once the fields are named and sets up conditional logic and required fields (`ai`) or not (`none`). Default: your account's template settings. | [optional]  |
| **outputFormat** | **OutputFormat** | What each submission of a Word template makes unless its request sets `output_formats`: `docx` (a Word document), `odt` (an OpenDocument file, converted from the Word document) or `pdf`. Required when `document` is a Word document. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | PDF template created |  -  |
| **422** | invalid upload |  -  |
| **403** | the plan's template limit is reached |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's template_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="uploadtemplatedocument"></a>
# **UploadTemplateDocument**
> Template UploadTemplateDocument (string templateId, System.IO.Stream document, bool wait = null, bool reimportFields = null, string idempotencyKey = null)

Replace a template's document with an uploaded file

Replaces a PDF template's PDF, or a Word template's Word document, with one sent with the request (`multipart/form-data`). A PDF template's fields stay where they are, unless `reimport_fields` replaces them with the new PDF's fillable fields, and a Word template gets a field for each new tag. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **document** | **System.IO.Stream****System.IO.Stream** | The new PDF, or the new Word document (.docx or .odt) of a Word template. |  |
| **wait** | **bool** | Wait until the PDF has been processed, a `document_url`'s PDF or Word document downloaded, and an OpenDocument file converted, before responding. Default true on sync.api hosts. | [optional]  |
| **reimportFields** | **bool** | Replace all of the template's fields with the fillable fields in the new PDF, once DocSpring has processed it (`document.field_reimport_state`). As on a first upload, the default typeface, font size, bold and color are taken from the PDF's fields; the template's other settings are kept. If the PDF has no fillable fields, the template keeps its fields. A locked template can't re-import its fields. Only for PDF templates: a Word template adds a field for each new tag. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PDF replaced |  -  |
| **422** | an HTML template |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |
| **504** | On a sync.api host, the wait ran out: the record was saved and is still being processed. Get it by the ID in the error's template_id instead of sending the request again. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="validatesubmission"></a>
# **ValidateSubmission**
> SubmissionValidation ValidateSubmission (string templateId, ValidateSubmissionRequest body, string version = null, string idempotencyKey = null)

Check a submission without creating it

Checks a submission as creating it would (its data against the template's fields, its settings and signature requests) without saving it, generating anything or using credits. It doesn't check your account's credits. The response says whether the submission is valid, and if not, has the error that creating it would return. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**ValidateSubmissionRequest**](ValidateSubmissionRequest.md) | The submission's data and settings. |  |
| **version** | **string** | The template version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `latest`. | [optional]  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**SubmissionValidation**](SubmissionValidation.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | valid submission |  -  |
| **404** | template not found |  -  |
| **422** | invalid request |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

<a id="verifyemaildomain"></a>
# **VerifyEmailDomain**
> EmailDomain VerifyEmailDomain (string emailDomainId, string idempotencyKey = null)

Verify an email domain

Checks the email domain's DNS records now, instead of waiting for the next check. If DocSpring has stopped looking for its DKIM records (3 days after they were created), it starts again with new ones: replace the CNAME records with them. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailDomainId** | **string** | The email domain's ID. |  |
| **idempotencyKey** | **string** | A key of your own, such as a UUID, that makes it safe to send this request again: for 24 hours, DocSpring answers a request with the same key from the same API token with the first request's response (and an `Idempotent-Replayed: true` header) instead of processing it again. Send a new key with each new request, and the same key each time you send the same request again, such as after a timeout, a network error or a 5xx. The same key with a different request is a 422 `idempotency_key_reused`. A 409 `idempotency_key_in_use` with a `Retry-After` header means the first request is still being processed: send the request again then. | [optional]  |

### Return type

[**EmailDomain**](EmailDomain.md)

### Authorization

[api_token_basic](../README.md#install-and-configure)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | email domain verified |  -  |
| **401** | authentication failed |  -  |
| **429** | Too many requests: wait the number of seconds in the Retry-After header, then send the request again. |  * Retry-After - Seconds until you can send the request again. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#methods) [[Back to Model list]](../../README.md#methods) [[Back to README]](../../README.md)

