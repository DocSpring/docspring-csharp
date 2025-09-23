# DocSpring.Client.Api.Client

All URIs are relative to *https://sync.api.docspring.com/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFieldsToTemplate**](Client.md#addfieldstotemplate) | **PUT** /templates/{template_id}/add_fields | Add new fields to a Template |
| [**BatchGeneratePdfs**](Client.md#batchgeneratepdfs) | **POST** /submissions/batches | Generate multiple PDFs |
| [**CombinePdfs**](Client.md#combinepdfs) | **POST** /combined_submissions | Merge submission PDFs, template PDFs, or custom files |
| [**CopyTemplate**](Client.md#copytemplate) | **POST** /templates/{template_id}/copy | Copy a template |
| [**CreateCustomFileFromUpload**](Client.md#createcustomfilefromupload) | **POST** /custom_files | Create a new custom file from a cached S3 upload |
| [**CreateDataRequestEvent**](Client.md#createdatarequestevent) | **POST** /data_requests/{data_request_id}/events | Create a new event for emailing a signee a request for signature |
| [**CreateDataRequestToken**](Client.md#createdatarequesttoken) | **POST** /data_requests/{data_request_id}/tokens | Create a new data request token for form authentication |
| [**CreateFolder**](Client.md#createfolder) | **POST** /folders/ | Create a folder |
| [**CreateHtmlTemplate**](Client.md#createhtmltemplate) | **POST** /templates?endpoint_variant&#x3D;create_html_template | Create a new HTML template |
| [**CreatePdfTemplate**](Client.md#createpdftemplate) | **POST** /templates | Create a new PDF template with a form POST file upload |
| [**CreatePdfTemplateFromUpload**](Client.md#createpdftemplatefromupload) | **POST** /templates?endpoint_variant&#x3D;create_template_from_cached_upload | Create a new PDF template from a cached S3 file upload |
| [**DeleteFolder**](Client.md#deletefolder) | **DELETE** /folders/{folder_id} | Delete a folder |
| [**DeleteTemplate**](Client.md#deletetemplate) | **DELETE** /templates/{template_id} | Delete a template |
| [**ExpireCombinedSubmission**](Client.md#expirecombinedsubmission) | **DELETE** /combined_submissions/{combined_submission_id} | Expire a combined submission |
| [**ExpireSubmission**](Client.md#expiresubmission) | **DELETE** /submissions/{submission_id} | Expire a PDF submission |
| [**GeneratePdf**](Client.md#generatepdf) | **POST** /templates/{template_id}/submissions | Generate a PDF |
| [**GeneratePreview**](Client.md#generatepreview) | **POST** /submissions/{submission_id}/generate_preview | Generate a preview PDF for partially completed data requests |
| [**GetCombinedSubmission**](Client.md#getcombinedsubmission) | **GET** /combined_submissions/{combined_submission_id} | Check the status of a combined submission (merged PDFs) |
| [**GetDataRequest**](Client.md#getdatarequest) | **GET** /data_requests/{data_request_id} | Look up a submission data request |
| [**GetFullTemplate**](Client.md#getfulltemplate) | **GET** /templates/{template_id}?full&#x3D;true | Fetch the full attributes for a PDF template |
| [**GetPresignUrl**](Client.md#getpresignurl) | **GET** /uploads/presign | Get a presigned S3 URL for direct file upload |
| [**GetSubmission**](Client.md#getsubmission) | **GET** /submissions/{submission_id} | Check the status of a PDF |
| [**GetSubmissionBatch**](Client.md#getsubmissionbatch) | **GET** /submissions/batches/{submission_batch_id} | Check the status of a submission batch job |
| [**GetTemplate**](Client.md#gettemplate) | **GET** /templates/{template_id} | Check the status of an uploaded template |
| [**GetTemplateSchema**](Client.md#gettemplateschema) | **GET** /templates/{template_id}/schema | Fetch the JSON schema for a template |
| [**ListCombinedSubmissions**](Client.md#listcombinedsubmissions) | **GET** /combined_submissions | Get a list of all combined submissions |
| [**ListFolders**](Client.md#listfolders) | **GET** /folders/ | Get a list of all folders |
| [**ListSubmissions**](Client.md#listsubmissions) | **GET** /submissions | List all submissions |
| [**ListTemplateSubmissions**](Client.md#listtemplatesubmissions) | **GET** /templates/{template_id}/submissions | List all submissions for a given template |
| [**ListTemplates**](Client.md#listtemplates) | **GET** /templates | Get a list of all templates |
| [**MoveFolderToFolder**](Client.md#movefoldertofolder) | **POST** /folders/{folder_id}/move | Move a folder |
| [**MoveTemplateToFolder**](Client.md#movetemplatetofolder) | **POST** /templates/{template_id}/move | Move Template to folder |
| [**PublishTemplateVersion**](Client.md#publishtemplateversion) | **POST** /templates/{template_id}/publish_version | Publish a template version |
| [**RenameFolder**](Client.md#renamefolder) | **POST** /folders/{folder_id}/rename | Rename a folder |
| [**RestoreTemplateVersion**](Client.md#restoretemplateversion) | **POST** /templates/{template_id}/restore_version | Restore a template version |
| [**TestAuthentication**](Client.md#testauthentication) | **GET** /authentication | Test authentication |
| [**UpdateDataRequest**](Client.md#updatedatarequest) | **PUT** /data_requests/{data_request_id} | Update a submission data request |
| [**UpdateTemplate**](Client.md#updatetemplate) | **PUT** /templates/{template_id} | Update a Template |
| [**UpdateTemplateDocument**](Client.md#updatetemplatedocument) | **PUT** /templates/{template_id}?endpoint_variant&#x3D;update_template_pdf_with_form_post | Update a template&#39;s document with a form POST file upload |
| [**UpdateTemplateDocumentFromUpload**](Client.md#updatetemplatedocumentfromupload) | **PUT** /templates/{template_id}?endpoint_variant&#x3D;update_template_pdf_with_cached_upload | Update a template&#39;s document with a cached S3 file upload |

<a id="addfieldstotemplate"></a>
# **AddFieldsToTemplate**
> TemplateAddFieldsResponse AddFieldsToTemplate (string templateId, AddFieldsData data)

Add new fields to a Template

Adds fields to a PDF template. Configure field types, positions, defaults, and formatting options. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **data** | [**AddFieldsData**](AddFieldsData.md) |  |  |

### Return type

[**TemplateAddFieldsResponse**](TemplateAddFieldsResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | add fields success |  -  |
| **422** | add fields error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="batchgeneratepdfs"></a>
# **BatchGeneratePdfs**
> BatchGeneratePdfs201Response BatchGeneratePdfs (SubmissionBatchData data, bool wait = null)

Generate multiple PDFs

Generates up to 50 PDFs in a single request. Each submission can use a different template and data. Supports both synchronous (wait for all PDFs) and asynchronous processing. More efficient than individual requests when creating multiple PDFs.  See also: - [Batch and Combine PDFs](https://docspring.com/docs/api-guide/generate-pdfs/batch-generate-pdfs/) - Generate and merge PDFs in one request 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**SubmissionBatchData**](SubmissionBatchData.md) |  |  |
| **wait** | **bool** | Wait for submission batch to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |

### Return type

[**BatchGeneratePdfs201Response**](BatchGeneratePdfs201Response.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | submissions created |  -  |
| **200** | some PDFs with invalid data |  -  |
| **401** | authentication failed |  -  |
| **422** | array of arrays |  -  |
| **400** | invalid JSON |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="combinepdfs"></a>
# **CombinePdfs**
> CreateCombinedSubmissionResponse CombinePdfs (CombinePdfsData data)

Merge submission PDFs, template PDFs, or custom files

Combines multiple PDFs from various sources into a single PDF file. Supports merging submission PDFs, template PDFs, custom files, other merged PDFs, and PDFs from URLs. Merges the PDFs in the order provided. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**CombinePdfsData**](CombinePdfsData.md) |  |  |

### Return type

[**CreateCombinedSubmissionResponse**](CreateCombinedSubmissionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | combined submission created |  -  |
| **422** | invalid request |  -  |
| **400** | invalid JSON |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="copytemplate"></a>
# **CopyTemplate**
> TemplatePreview CopyTemplate (string templateId, CopyTemplateOptions options = null)

Copy a template

Creates a copy of an existing template with all its fields and configuration. Optionally specify a new name and target folder. The copied template starts as a new draft that can be modified independently of the original. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **options** | [**CopyTemplateOptions**](CopyTemplateOptions.md) |  | [optional]  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | copy template success |  -  |
| **404** | folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcustomfilefromupload"></a>
# **CreateCustomFileFromUpload**
> CreateCustomFileResponse CreateCustomFileFromUpload (CreateCustomFileData data)

Create a new custom file from a cached S3 upload

The Custom Files API endpoint allows you to upload PDFs to DocSpring and then merge them with other PDFs. First upload your file using the presigned URL endpoint, then use the returned cache_id to create the custom file. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**CreateCustomFileData**](CreateCustomFileData.md) |  |  |

### Return type

[**CreateCustomFileResponse**](CreateCustomFileResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | returns the custom file |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createdatarequestevent"></a>
# **CreateDataRequestEvent**
> CreateSubmissionDataRequestEventResponse CreateDataRequestEvent (string dataRequestId, CreateSubmissionDataRequestEventRequest varEvent)

Create a new event for emailing a signee a request for signature

Records user notification events for data requests. Use this to create an audit trail showing when and how users were notified about data request forms. Supports email, SMS, and other notification types. Records the notification time for compliance tracking.  See also: - [Embedded Data Requests Guide](https://docspring.com/docs/guides/embedded-forms/embedded-data-requests/) - User notification workflow 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataRequestId** | **string** |  |  |
| **varEvent** | [**CreateSubmissionDataRequestEventRequest**](CreateSubmissionDataRequestEventRequest.md) |  |  |

### Return type

[**CreateSubmissionDataRequestEventResponse**](CreateSubmissionDataRequestEventResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | event created |  -  |
| **401** | authentication failed |  -  |
| **422** | message recipient must not be blank |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createdatarequesttoken"></a>
# **CreateDataRequestToken**
> CreateSubmissionDataRequestTokenResponse CreateDataRequestToken (string dataRequestId, string type = null)

Create a new data request token for form authentication

Creates an authentication token for accessing a data request form. Tokens can be created for API access (1 hour expiration) or email links (30 day expiration). Returns a token and a pre-authenticated URL for the data request form.  See also: - [Embedded Data Requests Guide](https://docspring.com/docs/guides/embedded-forms/embedded-data-requests/) 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataRequestId** | **string** |  |  |
| **type** | **string** |  | [optional]  |

### Return type

[**CreateSubmissionDataRequestTokenResponse**](CreateSubmissionDataRequestTokenResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | token created |  -  |
| **401** | authentication failed |  -  |
| **422** | invalid request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createfolder"></a>
# **CreateFolder**
> Folder CreateFolder (CreateFolderData data)

Create a folder

Creates a new folder for organizing templates. Folders can be nested within other folders by providing a `parent_folder_id`. Folder names must be unique within the same parent. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**CreateFolderData**](CreateFolderData.md) |  |  |

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
| **422** | name already exist |  -  |
| **404** | parent folder doesn&#39;t exist |  -  |
| **200** | folder created inside another folder |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createhtmltemplate"></a>
# **CreateHtmlTemplate**
> TemplatePreview CreateHtmlTemplate (CreateHtmlTemplate data)

Create a new HTML template

Creates a new HTML template using HTML, CSS/SCSS, and Liquid templating. Allows complete control over PDF layout and styling. Supports headers, footers, and dynamic content using Liquid syntax for field values, conditions, loops, and filters. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**CreateHtmlTemplate**](CreateHtmlTemplate.md) |  |  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | returns a created template |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpdftemplate"></a>
# **CreatePdfTemplate**
> TemplatePreview CreatePdfTemplate (System.IO.Stream templateDocument, string templateName, bool wait = null, string templateDescription = null, string templateParentFolderId = null)

Create a new PDF template with a form POST file upload

Creates a new PDF template by uploading a PDF file. The uploaded PDF becomes the foundation for your template, and you can then add fillable fields using the template editor. Use the wait parameter to control whether the request waits for document processing to complete. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateDocument** | **System.IO.Stream****System.IO.Stream** |  |  |
| **templateName** | **string** |  |  |
| **wait** | **bool** | Wait for template document to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |
| **templateDescription** | **string** |  | [optional]  |
| **templateParentFolderId** | **string** |  | [optional]  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | returns a pending template |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpdftemplatefromupload"></a>
# **CreatePdfTemplateFromUpload**
> TemplatePreview CreatePdfTemplateFromUpload (CreatePdfTemplate data)

Create a new PDF template from a cached S3 file upload

Creates a new PDF template from a file previously uploaded to S3 using a presigned URL. This two-step process allows for more reliable large file uploads by first uploading the file to S3, then creating the template using the cached upload ID. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**CreatePdfTemplate**](CreatePdfTemplate.md) |  |  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | returns a pending template |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> Folder DeleteFolder (string folderId)

Delete a folder

Deletes an empty folder. The folder must not contain any templates or subfolders. Move or delete all contents before attempting to delete the folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** |  |  |

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
| **404** | folder doesn&#39;t exist |  -  |
| **422** | folder has contents |  -  |
| **200** | folder is empty |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetemplate"></a>
# **DeleteTemplate**
> TemplateDeleteResponse DeleteTemplate (string templateId, string version = null)

Delete a template

Deletes a template or a specific template version. When no version is specified, deletes the entire template including all versions. When a version is specified, deletes only that version while preserving others. Returns remaining version information. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **version** | **string** |  | [optional]  |

### Return type

[**TemplateDeleteResponse**](TemplateDeleteResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template version deleted successfully |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="expirecombinedsubmission"></a>
# **ExpireCombinedSubmission**
> CombinedSubmission ExpireCombinedSubmission (string combinedSubmissionId)

Expire a combined submission

Expiring a combined submission deletes the PDF from our system. This is useful for invalidating sensitive documents. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **combinedSubmissionId** | **string** |  |  |

### Return type

[**CombinedSubmission**](CombinedSubmission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | submission was expired |  -  |
| **404** | combined submission not found |  -  |
| **403** | test API token used |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="expiresubmission"></a>
# **ExpireSubmission**
> SubmissionPreview ExpireSubmission (string submissionId)

Expire a PDF submission

Expiring a PDF submission deletes the PDF and removes the data from our database. This is useful for invalidating sensitive documents after they've been downloaded. You can also [configure a data retention policy for your submissions](https://docspring.com/docs/template-editor/settings/#expire-submissions) so that they automatically expire. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** |  |  |

### Return type

[**SubmissionPreview**](SubmissionPreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | submission was expired |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |
| **403** | test API token used |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generatepdf"></a>
# **GeneratePdf**
> CreateSubmissionResponse GeneratePdf (string templateId, CreatePdfSubmissionData submission, bool wait = null)

Generate a PDF

Creates a PDF submission by filling in a template with data. Supports both synchronous (default) and asynchronous processing. Set `wait: false` to return immediately.  See also: - [Customize the PDF Title and Filename](https://docspring.com/docs/api-guide/generate-pdfs/customize-pdf-title-and-filename/) - Set custom metadata - [Handling Truncated Text](https://docspring.com/docs/api-guide/generate-pdfs/handle-truncated-text/) - Handle text that doesn't fit in fields 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **submission** | [**CreatePdfSubmissionData**](CreatePdfSubmissionData.md) |  |  |
| **wait** | **bool** | Wait for submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |

### Return type

[**CreateSubmissionResponse**](CreateSubmissionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | submission created |  -  |
| **422** | invalid request |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generatepreview"></a>
# **GeneratePreview**
> SuccessErrorResponse GeneratePreview (string submissionId)

Generate a preview PDF for partially completed data requests

Generates a preview PDF for a submission with partially completed data requests. Useful for showing users what the final document will look like before all signatures or data have been collected. The preview includes any data collected so far. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** |  |  |

### Return type

[**SuccessErrorResponse**](SuccessErrorResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | preview was successfully requested |  -  |
| **404** | submission not found |  -  |
| **422** | error requesting preview |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcombinedsubmission"></a>
# **GetCombinedSubmission**
> CombinedSubmission GetCombinedSubmission (string combinedSubmissionId)

Check the status of a combined submission (merged PDFs)

Retrieves the details and status of a combined submission. Returns processing state, download URL (if processed), metadata, and information about any integrated actions (e.g., S3 uploads). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **combinedSubmissionId** | **string** |  |  |

### Return type

[**CombinedSubmission**](CombinedSubmission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | processed combined submission found |  -  |
| **404** | combined submission not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdatarequest"></a>
# **GetDataRequest**
> SubmissionDataRequestShow GetDataRequest (string dataRequestId)

Look up a submission data request

Retrieves the details and status of a data request. Returns information about the request state (pending, viewed, completed), authentication details, and metadata. Includes audit information like IP address, browseruser agent, and timestamps.  See also: - [Embedded Data Requests Guide](https://docspring.com/docs/guides/embedded-forms/embedded-data-requests/) - Complete guide to data request workflow 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataRequestId** | **string** |  |  |

### Return type

[**SubmissionDataRequestShow**](SubmissionDataRequestShow.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | completed submission data request found |  -  |
| **404** | submission data request not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfulltemplate"></a>
# **GetFullTemplate**
> Template GetFullTemplate (string templateId)

Fetch the full attributes for a PDF template

Retrieves complete template information including fields, defaults, settings, and HTML/SCSS content. Use this to get all template data needed for automated updates or analysis. Returns more detailed information than the basic `getTemplate` endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |

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
| **200** | template found |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpresignurl"></a>
# **GetPresignUrl**
> UploadPresignResponse GetPresignUrl ()

Get a presigned S3 URL for direct file upload

Returns a presigned S3 URL for uploading files directly to our S3 bucket. Use this endpoint to upload large files before creating templates or custom files. S3 will respond with a JSON object that you can include in your DocSpring API request.  Uploaded files can be used to: - [Create templates](https://docspring.com/docs/api/#tag/templates/post/templates?endpoint_variant=create_template_from_cached_upload) - [Update templates](https://docspring.com/docs/api/#tag/templates/put/templates/{template_id}?endpoint_variant=update_template_pdf_with_cached_upload) - [Create custom files](https://docspring.com/docs/api/#tag/custom-files/post/custom_files) and then [merge them with other PDFs](https://docspring.com/docs/api/#tag/combine-pdfs/post/combined_submissions) 


### Parameters
This endpoint does not need any parameter.
### Return type

[**UploadPresignResponse**](UploadPresignResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | presign URL generated |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubmission"></a>
# **GetSubmission**
> Submission GetSubmission (string submissionId, bool includeData = null)

Check the status of a PDF

Retrieves the details and status of a PDF submission. Returns processing state, download URL (if processed), metadata, submission data (optional), and information about any integrated actions. Use this to poll for completion when using asynchronous processing. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** |  |  |
| **includeData** | **bool** |  | [optional]  |

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
| **200** | processed submission found with data |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubmissionbatch"></a>
# **GetSubmissionBatch**
> SubmissionBatchWithSubmissions GetSubmissionBatch (string submissionBatchId, bool includeSubmissions = null)

Check the status of a submission batch job

Retrieves the status and results of a batch PDF generation job. Returns processing state, completion statistics, and optionally includes all individual submission details. Use this to poll for completion when using asynchronous batch processing. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionBatchId** | **string** |  |  |
| **includeSubmissions** | **bool** |  | [optional]  |

### Return type

[**SubmissionBatchWithSubmissions**](SubmissionBatchWithSubmissions.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | processed submission batch found |  -  |
| **404** | submission batch not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplate"></a>
# **GetTemplate**
> TemplatePreview GetTemplate (string templateId)

Check the status of an uploaded template

Retrieves information about a template including processing status and document URL. Use this to check if template is ready to view in the template editor or generate PDFs. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template found |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplateschema"></a>
# **GetTemplateSchema**
> JsonSchema GetTemplateSchema (string templateId)

Fetch the JSON schema for a template

Retrieves the JSON Schema definition for a template's fields. Use this to validate data before submitting it for PDF generation, or to build dynamic forms that match the template's field structure and validation requirements.  See also: - [Generate PDFs Guide](https://docspring.com/docs/api-guide/generate-pdfs/generate-pdfs-via-api/) - Use schema to validate submission data 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |

### Return type

[**JsonSchema**](JsonSchema.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template found |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcombinedsubmissions"></a>
# **ListCombinedSubmissions**
> List&lt;CombinedSubmission&gt; ListCombinedSubmissions (int page = null, int perPage = null)

Get a list of all combined submissions

Returns a paginated list of combined submissions (merged PDFs) for your account. Includes processing status, expiration details, and download URLs for processed PDFs. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Default: 1 | [optional]  |
| **perPage** | **int** | Default: 50 | [optional]  |

### Return type

[**List&lt;CombinedSubmission&gt;**](CombinedSubmission.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | enumerate all combined submissions |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listfolders"></a>
# **ListFolders**
> List&lt;Folder&gt; ListFolders (string parentFolderId = null)

Get a list of all folders

Returns a list of folders in your account. Can be filtered by parent folder ID to retrieve subfolders. Folders help organize templates and maintain a hierarchical structure. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentFolderId** | **string** | Filter By Folder Id | [optional]  |

### Return type

[**List&lt;Folder&gt;**](Folder.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | enumerate all folders |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listsubmissions"></a>
# **ListSubmissions**
> ListSubmissionsResponse ListSubmissions (string cursor = null, int limit = null, string createdAfter = null, string createdBefore = null, string type = null, bool includeData = null)

List all submissions

Returns a paginated list of all PDF submissions across all templates in your account. Can be filtered by date range and submission type (test/live). Supports cursor-based pagination and optionally includes submission data for each result. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string** |  | [optional]  |
| **limit** | **int** |  | [optional]  |
| **createdAfter** | **string** |  | [optional]  |
| **createdBefore** | **string** |  | [optional]  |
| **type** | **string** |  | [optional]  |
| **includeData** | **bool** |  | [optional]  |

### Return type

[**ListSubmissionsResponse**](ListSubmissionsResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | listing submissions |  -  |
| **422** | invalid type |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtemplatesubmissions"></a>
# **ListTemplateSubmissions**
> ListSubmissionsResponse ListTemplateSubmissions (string templateId, string cursor = null, int limit = null, string createdAfter = null, string createdBefore = null, string type = null, bool includeData = null)

List all submissions for a given template

Returns a paginated list of all submissions for a specific template. Can be filtered by date range, submission type (test/live), and optionally include submission data. Supports cursor-based pagination for efficient retrieval of large result sets. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **cursor** | **string** |  | [optional]  |
| **limit** | **int** |  | [optional]  |
| **createdAfter** | **string** |  | [optional]  |
| **createdBefore** | **string** |  | [optional]  |
| **type** | **string** |  | [optional]  |
| **includeData** | **bool** |  | [optional]  |

### Return type

[**ListSubmissionsResponse**](ListSubmissionsResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | listing submissions |  -  |
| **404** | invalid template id |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtemplates"></a>
# **ListTemplates**
> List&lt;TemplatePreview&gt; ListTemplates (string query = null, string parentFolderId = null, int page = null, int perPage = null)

Get a list of all templates

Retrieves a list of your templates with search, filtering, and pagination options. Returns basic template information including ID, name, type (PDF or HTML), and folder location. Supports text search by name and filtering by parent folder. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Search By Name | [optional]  |
| **parentFolderId** | **string** | Filter By Folder Id | [optional]  |
| **page** | **int** | Default: 1 | [optional]  |
| **perPage** | **int** | Default: 50 | [optional]  |

### Return type

[**List&lt;TemplatePreview&gt;**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | enumerate all templates |  -  |
| **404** | filter templates by invalid folder id |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="movefoldertofolder"></a>
# **MoveFolderToFolder**
> Folder MoveFolderToFolder (string folderId, MoveFolderData data)

Move a folder

Moves a folder to a new parent folder or to the root level. All templates and subfolders within the folder are moved together. Cannot move a folder into one of its own subfolders. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** |  |  |
| **data** | [**MoveFolderData**](MoveFolderData.md) |  |  |

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
| **404** | parent folder doesn&#39;t exist |  -  |
| **200** | move to root folder |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="movetemplatetofolder"></a>
# **MoveTemplateToFolder**
> TemplatePreview MoveTemplateToFolder (string templateId, MoveTemplateData data)

Move Template to folder

Moves a template to a different folder or to the root level. Use this to organize templates within your folders. Provide a folder ID to move to a specific folder, or `null` to move to the root level. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **data** | [**MoveTemplateData**](MoveTemplateData.md) |  |  |

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | move template success |  -  |
| **404** | folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="publishtemplateversion"></a>
# **PublishTemplateVersion**
> TemplatePublishVersionResponse PublishTemplateVersion (string templateId, PublishVersionData data)

Publish a template version

Publishes the current draft version of a template and creates a new immutable version with semantic versioning (major.minor.patch). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **data** | [**PublishVersionData**](PublishVersionData.md) |  |  |

### Return type

[**TemplatePublishVersionResponse**](TemplatePublishVersionResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | version published successfully |  -  |
| **422** | invalid version type |  -  |
| **404** | template not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="renamefolder"></a>
# **RenameFolder**
> Folder RenameFolder (string folderId, RenameFolderData data)

Rename a folder

Renames an existing folder. The new name must be unique within the same parent folder. This operation only changes the folder name, not its location or contents. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** |  |  |
| **data** | [**RenameFolderData**](RenameFolderData.md) |  |  |

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
| **422** | name already exist |  -  |
| **404** | folder doesn&#39;t belong to me |  -  |
| **200** | successful rename |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="restoretemplateversion"></a>
# **RestoreTemplateVersion**
> SuccessErrorResponse RestoreTemplateVersion (string templateId, RestoreVersionData data)

Restore a template version

Restores your template to a previously published version, copying that version's content and configuration to the current draft. Use this to revert changes or recover from an unwanted modification. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **data** | [**RestoreVersionData**](RestoreVersionData.md) |  |  |

### Return type

[**SuccessErrorResponse**](SuccessErrorResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | version restored successfully |  -  |
| **422** | draft version not allowed |  -  |
| **404** | template version not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="testauthentication"></a>
# **TestAuthentication**
> SuccessErrorResponse TestAuthentication ()

Test authentication

Checks whether your API token is valid by making an authenticated request. Returns a success response if authentication passes. This endpoint is useful for verifying credentials during setup or troubleshooting issues. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**SuccessErrorResponse**](SuccessErrorResponse.md)

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

<a id="updatedatarequest"></a>
# **UpdateDataRequest**
> CreateSubmissionDataRequestResponse UpdateDataRequest (string dataRequestId, UpdateSubmissionDataRequestData data)

Update a submission data request

Updates authentication details for a data request. Use this when a user logs in to record their authentication method, provider, session information, and hashed identifiers. Updates metadata and tracks authentication state changes for auditing and compliance. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataRequestId** | **string** |  |  |
| **data** | [**UpdateSubmissionDataRequestData**](UpdateSubmissionDataRequestData.md) |  |  |

### Return type

[**CreateSubmissionDataRequestResponse**](CreateSubmissionDataRequestResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | submission data request updated |  -  |
| **422** | invalid request |  -  |
| **404** | submission data request not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> SuccessMultipleErrorsResponse UpdateTemplate (string templateId, UpdateHtmlTemplate data)

Update a Template

Updates template content and properties. For HTML templates, you can modify the HTML, SCSS, headers, footers, name, and description. Changes are applied to your draft template and do not affect published template versions. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **data** | [**UpdateHtmlTemplate**](UpdateHtmlTemplate.md) |  |  |

### Return type

[**SuccessMultipleErrorsResponse**](SuccessMultipleErrorsResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | update template success |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplatedocument"></a>
# **UpdateTemplateDocument**
> SuccessMultipleErrorsResponse UpdateTemplateDocument (string templateId, System.IO.Stream templateDocument, string templateName = null)

Update a template's document with a form POST file upload

Upload a new PDF file to update a PDF template's document. This replaces the template's PDF while preserving all of the existing fields. If you upload a PDF with fewer pages than the current document, any fields on the removed pages will be deleted. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **templateDocument** | **System.IO.Stream****System.IO.Stream** |  |  |
| **templateName** | **string** |  | [optional]  |

### Return type

[**SuccessMultipleErrorsResponse**](SuccessMultipleErrorsResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | returns a template with updated document |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplatedocumentfromupload"></a>
# **UpdateTemplateDocumentFromUpload**
> SuccessMultipleErrorsResponse UpdateTemplateDocumentFromUpload (string templateId, UpdatePdfTemplate data)

Update a template's document with a cached S3 file upload

Updates a PDF template's document using a cached file upload. This is a three-step process: First, request a presigned URL to upload your PDF file to our S3 bucket. Then, use that URL to upload your PDF file. Finally, submit the ID of the uploaded file to replace the template's document. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **data** | [**UpdatePdfTemplate**](UpdatePdfTemplate.md) |  |  |

### Return type

[**SuccessMultipleErrorsResponse**](SuccessMultipleErrorsResponse.md)

### Authorization

[api_token_basic](../README.md#api_token_basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | returns a template with updated document |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

