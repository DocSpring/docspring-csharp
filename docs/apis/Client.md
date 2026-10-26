# DocSpring.Client.Api.Client

All URIs are relative to *https://sync.api.docspring.com/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopyTemplate**](Client.md#copytemplate) | **POST** /templates/{template_id}/copy | Copy a template |
| [**CreateCombinedPdf**](Client.md#createcombinedpdf) | **POST** /combined_pdfs | Combine PDFs |
| [**CreateCustomFileFromUpload**](Client.md#createcustomfilefromupload) | **POST** /custom_files | Create a custom file from an upload |
| [**CreateFolder**](Client.md#createfolder) | **POST** /folders | Create a folder |
| [**CreateSignatureRequestEvent**](Client.md#createsignaturerequestevent) | **POST** /signature_requests/{signature_request_id}/events | Record a signature request event |
| [**CreateSignatureRequestToken**](Client.md#createsignaturerequesttoken) | **POST** /signature_requests/{signature_request_id}/tokens | Create a signature request token |
| [**CreateSubmission**](Client.md#createsubmission) | **POST** /templates/{template_id}/submissions | Generate a PDF |
| [**CreateSubmissionBatch**](Client.md#createsubmissionbatch) | **POST** /submissions/batches | Generate PDFs in a batch |
| [**CreateTemplate**](Client.md#createtemplate) | **POST** /templates | Create a template |
| [**CreateWebhook**](Client.md#createwebhook) | **POST** /webhooks | Create a webhook |
| [**DeleteCustomFile**](Client.md#deletecustomfile) | **DELETE** /custom_files/{custom_file_id} | Delete a custom file |
| [**DeleteFolder**](Client.md#deletefolder) | **DELETE** /folders/{folder_id} | Delete a folder |
| [**DeleteTemplate**](Client.md#deletetemplate) | **DELETE** /templates/{template_id} | Delete a template |
| [**DeleteWebhook**](Client.md#deletewebhook) | **DELETE** /webhooks/{webhook_id} | Delete a webhook |
| [**ExpireCombinedPdf**](Client.md#expirecombinedpdf) | **DELETE** /combined_pdfs/{combined_pdf_id} | Expire a combined PDF |
| [**ExpireSubmission**](Client.md#expiresubmission) | **DELETE** /submissions/{submission_id} | Expire a submission |
| [**GenerateSubmissionPreview**](Client.md#generatesubmissionpreview) | **POST** /submissions/{submission_id}/generate_preview | Generate a preview PDF |
| [**GetCombinedPdf**](Client.md#getcombinedpdf) | **GET** /combined_pdfs/{combined_pdf_id} | Get a combined PDF |
| [**GetCustomFile**](Client.md#getcustomfile) | **GET** /custom_files/{custom_file_id} | Get a custom file |
| [**GetFolder**](Client.md#getfolder) | **GET** /folders/{folder_id} | Get a folder |
| [**GetPresignUrl**](Client.md#getpresignurl) | **GET** /uploads/presign | Get a presigned URL to upload a file |
| [**GetSignatureRequest**](Client.md#getsignaturerequest) | **GET** /signature_requests/{signature_request_id} | Get a signature request |
| [**GetSubmission**](Client.md#getsubmission) | **GET** /submissions/{submission_id} | Get a submission |
| [**GetSubmissionBatch**](Client.md#getsubmissionbatch) | **GET** /submissions/batches/{submission_batch_id} | Get a batch |
| [**GetTemplate**](Client.md#gettemplate) | **GET** /templates/{template_id} | Get a template |
| [**GetTemplateModelCode**](Client.md#gettemplatemodelcode) | **GET** /templates/{template_id}/model_code | Generate typed code for a template's submission data |
| [**GetTemplateSchema**](Client.md#gettemplateschema) | **GET** /templates/{template_id}/schema | Get the JSON Schema of a template's submission data |
| [**GetWebhook**](Client.md#getwebhook) | **GET** /webhooks/{webhook_id} | Get a webhook |
| [**ListCombinedPdfs**](Client.md#listcombinedpdfs) | **GET** /combined_pdfs | List combined PDFs |
| [**ListCustomFiles**](Client.md#listcustomfiles) | **GET** /custom_files | List custom files |
| [**ListFolders**](Client.md#listfolders) | **GET** /folders | List folders |
| [**ListSubmissions**](Client.md#listsubmissions) | **GET** /submissions | List submissions |
| [**ListTemplateSubmissions**](Client.md#listtemplatesubmissions) | **GET** /templates/{template_id}/submissions | List a template's submissions |
| [**ListTemplates**](Client.md#listtemplates) | **GET** /templates | List templates |
| [**ListWebhooks**](Client.md#listwebhooks) | **GET** /webhooks | List webhooks |
| [**MoveFolder**](Client.md#movefolder) | **POST** /folders/{folder_id}/move | Move a folder |
| [**MoveTemplate**](Client.md#movetemplate) | **POST** /templates/{template_id}/move | Move a template to a folder |
| [**PublishTemplateVersion**](Client.md#publishtemplateversion) | **POST** /templates/{template_id}/publish_version | Publish a template version |
| [**RenameFolder**](Client.md#renamefolder) | **POST** /folders/{folder_id}/rename | Rename a folder |
| [**RestoreTemplateVersion**](Client.md#restoretemplateversion) | **POST** /templates/{template_id}/restore_version | Restore a template version |
| [**TestAuthentication**](Client.md#testauthentication) | **GET** /authentication | Test authentication |
| [**UpdateSignatureRequest**](Client.md#updatesignaturerequest) | **PUT** /signature_requests/{signature_request_id} | Update a signature request |
| [**UpdateTemplate**](Client.md#updatetemplate) | **PUT** /templates/{template_id} | Update a template |
| [**UpdateTemplateDocument**](Client.md#updatetemplatedocument) | **PUT** /templates/{template_id}/document | Replace a template's PDF |
| [**UpdateWebhook**](Client.md#updatewebhook) | **PUT** /webhooks/{webhook_id} | Update a webhook |
| [**UploadTemplate**](Client.md#uploadtemplate) | **POST** /templates/upload | Create a PDF template from an uploaded PDF |
| [**UploadTemplateDocument**](Client.md#uploadtemplatedocument) | **PUT** /templates/{template_id}/document/upload | Replace a template's PDF with an uploaded PDF |

<a id="copytemplate"></a>
# **CopyTemplate**
> Template CopyTemplate (string templateId, CopyTemplateRequest body = null)

Copy a template

Copies a template (its draft, or a published version) into a new template.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**CopyTemplateRequest**](CopyTemplateRequest.md) | Settings for the copy. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcombinedpdf"></a>
# **CreateCombinedPdf**
> CombinedPdf CreateCombinedPdf (CreateCombinedPdfRequest body, bool wait = null)

Combine PDFs

Merges PDFs into one: submissions, other combined PDFs, templates, custom files (POST /custom_files) and PDFs from URLs, in the order of `source_pdfs`. The PDF is generated in the background: on sync.api hosts the request waits for it (unless you pass `wait=false`), otherwise poll GET /combined_pdfs/{combined_pdf_id} until `state` isn't `pending`.  A template source merges the template's processed PDF by default: the PDF submissions are filled in on, decrypted and with its form fields removed. Pass `processed: false` to merge the PDF as it was uploaded. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateCombinedPdfRequest**](CreateCombinedPdfRequest.md) | The PDFs to merge, and the combined PDF's settings. |  |
| **wait** | **bool** | Wait until the PDF has been generated before responding. Default true on sync.api hosts. | [optional]  |

### Return type

[**CombinedPdf**](CombinedPdf.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcustomfilefromupload"></a>
# **CreateCustomFileFromUpload**
> CustomFile CreateCustomFileFromUpload (CreateCustomFileFromUploadRequest body)

Create a custom file from an upload

Creates a custom file from a PDF you uploaded, so you can merge it with other PDFs. Upload the file with the presigned upload (GET /uploads/presign) first, then pass its `fields.key` as `cache_id`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateCustomFileFromUploadRequest**](CreateCustomFileFromUploadRequest.md) | The uploaded file to create the custom file from. |  |

### Return type

[**CustomFile**](CustomFile.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | custom file created |  -  |
| **422** | invalid custom file |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createfolder"></a>
# **CreateFolder**
> Folder CreateFolder (CreateFolderRequest body)

Create a folder

Creates a folder for organizing templates. Pass `parent_folder_id` to create it inside another folder. Folder names are unique within their parent folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateFolderRequest**](CreateFolderRequest.md) | The folder to create. |  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | folder created inside another folder |  -  |
| **422** | invalid folder |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createsignaturerequestevent"></a>
# **CreateSignatureRequestEvent**
> SignatureRequestEvent CreateSignatureRequestEvent (string signatureRequestId, CreateSignatureRequestEventRequest body)

Record a signature request event

Records something that happened outside DocSpring in the signature request's audit trail: you sent the request to the person (`send_request`). The audit trail shows it as reported by your account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |
| **body** | [**CreateSignatureRequestEventRequest**](CreateSignatureRequestEventRequest.md) | The event to record. |  |

### Return type

[**SignatureRequestEvent**](SignatureRequestEvent.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | event recorded |  -  |
| **422** | invalid event |  -  |
| **404** | signature request not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createsignaturerequesttoken"></a>
# **CreateSignatureRequestToken**
> SignatureRequestToken CreateSignatureRequestToken (string signatureRequestId, CreateSignatureRequestTokenRequest body = null)

Create a signature request token

Creates a token that opens the signature request without signing in, in a form embedded in your app or from a link you send. The response is the only time the token's secret is returned. The link works for 24 hours, or 7 days for an `email` token, and a signing page that opened in time keeps working for 7 more days. A test API token can't create a token for a live signature request. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |
| **body** | [**CreateSignatureRequestTokenRequest**](CreateSignatureRequestTokenRequest.md) | The kind of link to make. Send no body for an `api` token. | [optional]  |

### Return type

[**SignatureRequestToken**](SignatureRequestToken.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createsubmission"></a>
# **CreateSubmission**
> Submission CreateSubmission (string templateId, CreateSubmissionRequest body, string version = null, bool wait = null)

Generate a PDF

Creates a submission: fills in a template with your data and generates a PDF. The PDF is generated in the background: on sync.api hosts the request waits for it (unless you pass `wait=false`), otherwise poll GET /submissions/{submission_id} until `state` isn't `pending`.  Data that doesn't match the template's fields returns a 422 with an `invalid_data` error. The submission is still saved, with its errors, so you can find it in DocSpring: the error's `submission_id` is its ID. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**CreateSubmissionRequest**](CreateSubmissionRequest.md) | The submission's data and settings. |  |
| **version** | **string** | The template version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` or `draft`. Default `latest` (the draft when no version has been published). | [optional]  |
| **wait** | **bool** | Wait until the PDF has been generated before responding. Default true on sync.api hosts. | [optional]  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createsubmissionbatch"></a>
# **CreateSubmissionBatch**
> SubmissionBatch CreateSubmissionBatch (CreateSubmissionBatchRequest body, bool wait = null)

Generate PDFs in a batch

Creates up to 50 submissions in one request, from one template or several. The PDFs are only generated when every submission is valid. On sync.api hosts the request waits until every PDF has been generated (unless you pass `wait=false`), otherwise poll GET /submissions/batches/{submission_batch_id} until `processed_at` is set.  When any submission is invalid, nothing is generated and the request returns a 422. Submissions whose data doesn't match their template's fields are still saved with their errors (an `invalid_data` error, with each one's `submission_id` in its details), so you can find them in DocSpring. The other submissions aren't saved. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateSubmissionBatchRequest**](CreateSubmissionBatchRequest.md) | The submissions to create, and the settings they share. |  |
| **wait** | **bool** | Wait until every PDF in the batch has been generated before responding. Default true on sync.api hosts. | [optional]  |

### Return type

[**SubmissionBatch**](SubmissionBatch.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createtemplate"></a>
# **CreateTemplate**
> Template CreateTemplate (CreateTemplateRequest body, bool wait = null)

Create a template

Creates an HTML template, or a PDF template from a PDF you uploaded with the presigned upload (GET /uploads/presign): pass its `fields.key` as `cache_id`. To send the PDF with the request instead, use POST /templates/upload.  A PDF template is ready to generate PDFs once DocSpring has processed its PDF (`ready` is true). On sync.api hosts the request waits for that unless you pass `wait=false`. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateTemplateRequest**](CreateTemplateRequest.md) | The template to create. |  |
| **wait** | **bool** | Wait until the PDF has been processed before responding. Default true on sync.api hosts. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createwebhook"></a>
# **CreateWebhook**
> Webhook CreateWebhook (CreateWebhookRequest body)

Create a webhook

Creates a webhook that sends a POST request to your endpoint whenever a subscribed event happens. Scope it to API tokens, templates or folders to receive only their events. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateWebhookRequest**](CreateWebhookRequest.md) | The webhook to create. |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | webhook created |  -  |
| **422** | invalid webhook |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecustomfile"></a>
# **DeleteCustomFile**
> CustomFile DeleteCustomFile (string customFileId)

Delete a custom file

Deletes a custom file and returns it. Use a live API token: test tokens can't delete custom files. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customFileId** | **string** | The custom file's ID. |  |

### Return type

[**CustomFile**](CustomFile.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> Folder DeleteFolder (string folderId)

Delete a folder

Deletes an empty folder and returns it. A folder that still has templates or folders in it can't be deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetemplate"></a>
# **DeleteTemplate**
> Template DeleteTemplate (string templateId, string version = null)

Delete a template

Deletes a template's draft and all of its published versions, or one published version (`version`). Returns the template as it was before it was deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | Delete only this published version (`1.2.0`) or the draft (`draft`, when no version has been published). Without it, the draft and every published version are deleted. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletewebhook"></a>
# **DeleteWebhook**
> Webhook DeleteWebhook (string webhookId)

Delete a webhook

Deletes a webhook so it stops receiving events, and returns it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | The webhook's ID. |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook deleted |  -  |
| **404** | webhook not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="expirecombinedpdf"></a>
# **ExpireCombinedPdf**
> CombinedPdf ExpireCombinedPdf (string combinedPdfId)

Expire a combined PDF

Deletes a combined PDF's PDF and returns the expired combined PDF.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **combinedPdfId** | **string** | The combined PDF's ID. |  |

### Return type

[**CombinedPdf**](CombinedPdf.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="expiresubmission"></a>
# **ExpireSubmission**
> Submission ExpireSubmission (string submissionId)

Expire a submission

Deletes a submission's data and PDF now, and returns the expired submission.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** | The submission's ID. |  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generatesubmissionpreview"></a>
# **GenerateSubmissionPreview**
> Submission GenerateSubmissionPreview (string submissionId)

Generate a preview PDF

Generates a preview of a submission's PDF in the background, such as for a submission still waiting for its signature requests. It's in `files.preview` once `preview_generated_at` changes. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** | The submission's ID. |  |

### Return type

[**Submission**](Submission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | combined PDF |  -  |
| **404** | combined PDF not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | custom file found |  -  |
| **404** | custom file not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folder found |  -  |
| **404** | folder not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | presigned URL created |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signature request |  -  |
| **404** | signature request not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | processed submission |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | batch |  -  |
| **404** | batch not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplate"></a>
# **GetTemplate**
> Template GetTemplate (string templateId, string version = null)

Get a template

Returns a template: its draft, or one of its published versions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | A published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` or `draft`. Default `draft`. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplatemodelcode"></a>
# **GetTemplateModelCode**
> TemplateModelCode GetTemplateModelCode (string templateId, ModelCodeLanguage lang, string version = null)

Generate typed code for a template's submission data

Generates types for a template's submission data in TypeScript, JavaScript, Ruby, Python, PHP, Java, C#, Elixir or Go, so your app catches mistakes before it calls the API. `root_type_name` is the type of the whole `data` object. Java returns every class in `code`, each under a `// ClassName.java` comment. A template with no named fields returns 422. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **lang** | **ModelCodeLanguage** | The language to generate the code in. |  |
| **version** | **string** | The template version: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` or `draft`. Default `latest` (the draft when no version has been published), the version a submission uses by default. | [optional]  |

### Return type

[**TemplateModelCode**](TemplateModelCode.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplateschema"></a>
# **GetTemplateSchema**
> Dictionary&lt;string, Object&gt; GetTemplateSchema (string templateId, string version = null)

Get the JSON Schema of a template's submission data

Returns the JSON Schema that a submission's `data` must match. Use it to check data before you create submissions, or to build a form for the template's fields. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **version** | **string** | The template version: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` or `draft`. Default `latest` (the draft when no version has been published), the version a submission uses by default. | [optional]  |

### Return type

**Dictionary<string, Object>**

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template schema |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook found |  -  |
| **404** | webhook not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | combined PDFs |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | custom files |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | folders in a folder |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listsubmissions"></a>
# **ListSubmissions**
> SubmissionList ListSubmissions (string templateId = null, bool test = null, DateTime createdAfter = null, DateTime createdBefore = null, bool includeData = null, int limit = null, string cursor = null)

List submissions

Returns the submissions in your account, newest first, one page at a time. Lists leave out each submission's `data` unless you pass `include_data=true`. 


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

### Return type

[**SubmissionList**](SubmissionList.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | submissions |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtemplatesubmissions"></a>
# **ListTemplateSubmissions**
> SubmissionList ListTemplateSubmissions (string templateId, bool test = null, DateTime createdAfter = null, DateTime createdBefore = null, bool includeData = null, int limit = null, string cursor = null)

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

### Return type

[**SubmissionList**](SubmissionList.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtemplates"></a>
# **ListTemplates**
> TemplateSummaryList ListTemplates (string query = null, string parentFolderId = null, int limit = null, string cursor = null)

List templates

Returns the templates in your account (their drafts), newest first, one page at a time. Get a template by its ID for its HTML, defaults and published versions. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Only list templates whose name contains this text (ignoring case). | [optional]  |
| **parentFolderId** | **string** | Only list the templates in this folder (not in its subfolders). | [optional]  |
| **limit** | **int** | How many items to return (1-100, default 50). | [optional] [default to 50] |
| **cursor** | **string** | The previous page's `next_cursor`, to get the next page. It's the ID of that page's last item, so get the next page before you delete or change the items on this one. | [optional]  |

### Return type

[**TemplateSummaryList**](TemplateSummaryList.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | templates |  -  |
| **422** | invalid query parameters |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhooks for a template and event |  -  |
| **422** | unknown event type |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="movefolder"></a>
# **MoveFolder**
> Folder MoveFolder (string folderId, MoveFolderRequest body)

Move a folder

Moves a folder into another folder, or to the root with `parent_folder_id: null`. Its templates and folders move with it. A folder can't move into itself or one of its own folders. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |
| **body** | [**MoveFolderRequest**](MoveFolderRequest.md) | Where to move the folder. |  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="movetemplate"></a>
# **MoveTemplate**
> Template MoveTemplate (string templateId, MoveTemplateRequest body)

Move a template to a folder

Moves a template and all of its published versions to a folder, or to the root (`null`).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**MoveTemplateRequest**](MoveTemplateRequest.md) | Where to move the template. |  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="publishtemplateversion"></a>
# **PublishTemplateVersion**
> TemplateVersion PublishTemplateVersion (string templateId, PublishTemplateVersionRequest body)

Publish a template version

Publishes the template's draft as a new version that doesn't change. `version_type` says which part of the latest version number goes up. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**PublishTemplateVersionRequest**](PublishTemplateVersionRequest.md) | The version to publish. |  |

### Return type

[**TemplateVersion**](TemplateVersion.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | version published |  -  |
| **422** | invalid version type |  -  |
| **404** | template not found |  -  |
| **409** | published at the same time |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="renamefolder"></a>
# **RenameFolder**
> Folder RenameFolder (string folderId, RenameFolderRequest body)

Rename a folder

Renames a folder. The name must be unique within its parent folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** | The folder's ID. |  |
| **body** | [**RenameFolderRequest**](RenameFolderRequest.md) | The folder's new name. |  |

### Return type

[**Folder**](Folder.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="restoretemplateversion"></a>
# **RestoreTemplateVersion**
> Template RestoreTemplateVersion (string templateId, RestoreTemplateVersionRequest body)

Restore a template version

Replaces the template's draft with a copy of one of its published versions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**RestoreTemplateVersionRequest**](RestoreTemplateVersionRequest.md) | The version to restore. |  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

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

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | authentication succeeded |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesignaturerequest"></a>
# **UpdateSignatureRequest**
> SignatureRequest UpdateSignatureRequest (string signatureRequestId, UpdateSignatureRequestRequest body)

Update a signature request

Changes a pending signature request's metadata, or how your app authenticated the person (for the audit trail). Once the person has opened it, only its metadata can be changed, and a completed or declined signature request can't be changed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The signature request's ID. |  |
| **body** | [**UpdateSignatureRequestRequest**](UpdateSignatureRequestRequest.md) | The settings to change. Properties left out keep their values. |  |

### Return type

[**SignatureRequest**](SignatureRequest.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> Template UpdateTemplate (string templateId, UpdateTemplateRequest body)

Update a template

Changes a template's draft. Properties left out keep their values. `defaults` and `html_engine_options` replace the whole object. Setting `parent_folder_id` moves the template and all of its published versions. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**UpdateTemplateRequest**](UpdateTemplateRequest.md) | The settings to change. Properties left out keep their values. |  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template updated |  -  |
| **409** | template is locked |  -  |
| **404** | template not found |  -  |
| **422** | invalid update |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplatedocument"></a>
# **UpdateTemplateDocument**
> Template UpdateTemplateDocument (string templateId, UpdateTemplateDocumentRequest body, bool wait = null)

Replace a template's PDF

Replaces a PDF template's PDF with one you uploaded with the presigned upload (GET /uploads/presign). The fields stay where they are, unless `reimport_fields` replaces them with the new PDF's fillable fields. To send the PDF with the request instead, use PUT /templates/{template_id}/document/upload. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **body** | [**UpdateTemplateDocumentRequest**](UpdateTemplateDocumentRequest.md) | The new PDF. |  |
| **wait** | **bool** | Wait until the PDF has been processed before responding. Default true on sync.api hosts. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PDF replaced |  -  |
| **409** | template is locked, so its fields can't be re-imported |  -  |
| **422** | not a PDF template |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
> Webhook UpdateWebhook (string webhookId, UpdateWebhookRequest body)

Update a webhook

Updates a webhook. Only the properties you send change.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | The webhook's ID. |  |
| **body** | [**UpdateWebhookRequest**](UpdateWebhookRequest.md) | The settings to change. Properties left out keep their values. |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook updated |  -  |
| **404** | webhook not found |  -  |
| **422** | invalid webhook |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadtemplate"></a>
# **UploadTemplate**
> Template UploadTemplate (System.IO.Stream document, bool wait = null, string name = null, string description = null, string parentFolderId = null, AiFieldNamingLanguage aiFieldNamingLanguage = null, bool detectFields = null, FieldSetupSource fieldSource = null, FieldSetupNaming fieldNaming = null, FieldSetupLogic fieldLogic = null)

Create a PDF template from an uploaded PDF

Creates a PDF template from a PDF sent with the request (`multipart/form-data`). For large files, upload the PDF with the presigned upload (GET /uploads/presign) and create the template with POST /templates. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **document** | **System.IO.Stream****System.IO.Stream** | The PDF. |  |
| **wait** | **bool** | Wait until the PDF has been processed before responding. Default true on sync.api hosts. | [optional]  |
| **name** | **string** | The template's name. | [optional]  |
| **description** | **string** | The template's description. | [optional]  |
| **parentFolderId** | **string** | The folder to put the template in. Left out, it's created at the root. | [optional]  |
| **aiFieldNamingLanguage** | **AiFieldNamingLanguage** | The language AI field setup names fields in: `auto` uses the form's language when it's written in the Latin alphabet without accents, and English otherwise; `english` always uses English; `form_language` uses the form's language and script. Default: your account's template settings. | [optional]  |
| **detectFields** | **bool** | Set up the PDF's fields as DocSpring's "Automatically detect fields" upload option does: import or detect the fields, name them with AI, and set up conditional logic. `field_source`, `field_naming` and `field_logic` choose how. Default false. `document.page_processing_statuses` and `document.field_logic_status` show how it's going, and `document.state` becomes `processed` once every page's fields are set up. | [optional]  |
| **fieldSource** | **FieldSetupSource** | With `detect_fields`, where the fields come from. `auto` (the default) imports the form fields of a fillable PDF and detects the fields of a PDF without them; `pdf_detection` detects the fields from the page layout, even on a fillable PDF; `pdf_form_fields` only imports the PDF's form fields. | [optional]  |
| **fieldNaming** | **FieldSetupNaming** | With `detect_fields`, how the fields are named. `ai` (the default) names them and sets their types and settings with AI; `preserve` keeps the names of the PDF's form fields, and AI only names the fields it detected. `preserve` needs `field_source` `auto` or `pdf_form_fields`. | [optional]  |
| **fieldLogic** | **FieldSetupLogic** | With `detect_fields`, whether AI reads the whole form once the fields are named and sets up conditional logic and required fields (`ai`) or not (`none`). Default: your account's template settings. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadtemplatedocument"></a>
# **UploadTemplateDocument**
> Template UploadTemplateDocument (string templateId, System.IO.Stream document, bool wait = null, bool reimportFields = null)

Replace a template's PDF with an uploaded PDF

Replaces a PDF template's PDF with one sent with the request (`multipart/form-data`). The fields stay where they are, unless `reimport_fields` replaces them with the new PDF's fillable fields. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The template's ID. |  |
| **document** | **System.IO.Stream****System.IO.Stream** | The new PDF. |  |
| **wait** | **bool** | Wait until the PDF has been processed before responding. Default true on sync.api hosts. | [optional]  |
| **reimportFields** | **bool** | Replace all of the template's fields with the fillable fields in the new PDF, once DocSpring has processed it (`document.field_reimport_state`). As on a first upload, the default typeface, font size, bold and color are taken from the PDF's fields; the template's other settings are kept. If the PDF has no fillable fields, the template keeps its fields. A locked template can't re-import its fields. | [optional]  |

### Return type

[**Template**](Template.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PDF replaced |  -  |
| **422** | not a PDF template |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

