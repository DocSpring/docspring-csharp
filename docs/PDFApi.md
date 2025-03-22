# DocSpring.Client.Api.PDFApi

All URIs are relative to *https://sync.api.docspring.com/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFieldsToTemplate**](PDFApi.md#addfieldstotemplate) | **PUT** /templates/{template_id}/add_fields | Add new fields to a Template |
| [**BatchGeneratePdfs**](PDFApi.md#batchgeneratepdfs) | **POST** /submissions/batches | Generates multiple PDFs |
| [**CombinePdfs**](PDFApi.md#combinepdfs) | **POST** /combined_submissions?v&#x3D;2 | Merge submission PDFs, template PDFs, or custom files |
| [**CombineSubmissions**](PDFApi.md#combinesubmissions) | **POST** /combined_submissions | Merge generated PDFs together |
| [**CopyTemplate**](PDFApi.md#copytemplate) | **POST** /templates/{template_id}/copy | Copy a Template |
| [**CreateCustomFileFromUpload**](PDFApi.md#createcustomfilefromupload) | **POST** /custom_files | Create a new custom file from a cached presign upload |
| [**CreateDataRequestEvent**](PDFApi.md#createdatarequestevent) | **POST** /data_requests/{data_request_id}/events | Creates a new event for emailing a signee a request for signature |
| [**CreateDataRequestToken**](PDFApi.md#createdatarequesttoken) | **POST** /data_requests/{data_request_id}/tokens | Creates a new data request token for form authentication |
| [**CreateFolder**](PDFApi.md#createfolder) | **POST** /folders/ | Create a folder |
| [**CreateHTMLTemplate**](PDFApi.md#createhtmltemplate) | **POST** /templates?endpoint_description&#x3D;html | Create a new HTML template |
| [**CreatePDFTemplate**](PDFApi.md#createpdftemplate) | **POST** /templates | Create a new PDF template with a form POST file upload |
| [**CreatePDFTemplateFromUpload**](PDFApi.md#createpdftemplatefromupload) | **POST** /templates?endpoint_description&#x3D;cached_upload | Create a new PDF template from a cached presign upload |
| [**DeleteFolder**](PDFApi.md#deletefolder) | **DELETE** /folders/{folder_id} | Delete a folder |
| [**DeleteTemplate**](PDFApi.md#deletetemplate) | **DELETE** /templates/{template_id} | Delete a template |
| [**ExpireCombinedSubmission**](PDFApi.md#expirecombinedsubmission) | **DELETE** /combined_submissions/{combined_submission_id} | Expire a combined submission |
| [**ExpireSubmission**](PDFApi.md#expiresubmission) | **DELETE** /submissions/{submission_id} | Expire a PDF submission |
| [**GeneratePdf**](PDFApi.md#generatepdf) | **POST** /templates/{template_id}/submissions | Generates a new PDF |
| [**GeneratePdfForHtmlTemplate**](PDFApi.md#generatepdfforhtmltemplate) | **POST** /templates/{template_id}/submissions?endpoint_description&#x3D;html_templates | Generates a new PDF for an HTML template |
| [**GeneratePreview**](PDFApi.md#generatepreview) | **POST** /submissions/{submission_id}/generate_preview | Generated a preview PDF for partially completed data requests |
| [**GetCombinedSubmission**](PDFApi.md#getcombinedsubmission) | **GET** /combined_submissions/{combined_submission_id} | Check the status of a combined submission (merged PDFs) |
| [**GetDataRequest**](PDFApi.md#getdatarequest) | **GET** /data_requests/{data_request_id} | Look up a submission data request |
| [**GetFullTemplate**](PDFApi.md#getfulltemplate) | **GET** /templates/{template_id}?full&#x3D;true | Fetch the full attributes for a PDF template |
| [**GetPresignUrl**](PDFApi.md#getpresignurl) | **GET** /uploads/presign | Get a presigned URL so that you can upload a file to our AWS S3 bucket |
| [**GetSubmission**](PDFApi.md#getsubmission) | **GET** /submissions/{submission_id} | Check the status of a PDF |
| [**GetSubmissionBatch**](PDFApi.md#getsubmissionbatch) | **GET** /submissions/batches/{submission_batch_id} | Check the status of a submission batch job |
| [**GetTemplate**](PDFApi.md#gettemplate) | **GET** /templates/{template_id} | Check the status of an uploaded template |
| [**GetTemplateSchema**](PDFApi.md#gettemplateschema) | **GET** /templates/{template_id}/schema | Fetch the JSON schema for a template |
| [**ListCombinedSubmissions**](PDFApi.md#listcombinedsubmissions) | **GET** /combined_submissions | Get a list of all combined submissions |
| [**ListFolders**](PDFApi.md#listfolders) | **GET** /folders/ | Get a list of all folders |
| [**ListSubmissions**](PDFApi.md#listsubmissions) | **GET** /submissions | List all submissions |
| [**ListTemplateSubmissions**](PDFApi.md#listtemplatesubmissions) | **GET** /templates/{template_id}/submissions | List all submissions for a given template |
| [**ListTemplates**](PDFApi.md#listtemplates) | **GET** /templates | Get a list of all templates |
| [**MoveFolderToFolder**](PDFApi.md#movefoldertofolder) | **POST** /folders/{folder_id}/move | Move a folder |
| [**MoveTemplateToFolder**](PDFApi.md#movetemplatetofolder) | **POST** /templates/{template_id}/move | Move Template to folder |
| [**PublishTemplateVersion**](PDFApi.md#publishtemplateversion) | **POST** /templates/{template_id}/publish_version | Publish a template version |
| [**RenameFolder**](PDFApi.md#renamefolder) | **POST** /folders/{folder_id}/rename | Rename a folder |
| [**RestoreTemplateVersion**](PDFApi.md#restoretemplateversion) | **POST** /templates/{template_id}/restore_version | Restore a template version |
| [**TestAuthentication**](PDFApi.md#testauthentication) | **GET** /authentication | Test Authentication |
| [**UpdateDataRequest**](PDFApi.md#updatedatarequest) | **PUT** /data_requests/{data_request_id} | Update a submission data request |
| [**UpdateTemplate**](PDFApi.md#updatetemplate) | **PUT** /templates/{template_id} | Update a Template |

<a id="addfieldstotemplate"></a>
# **AddFieldsToTemplate**
> TemplateAddFieldsResponse AddFieldsToTemplate (string templateId, AddFieldsData data)

Add new fields to a Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class AddFieldsToTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef02;  // string | 
            var data = new AddFieldsData(); // AddFieldsData | 

            try
            {
                // Add new fields to a Template
                TemplateAddFieldsResponse result = apiInstance.AddFieldsToTemplate(templateId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.AddFieldsToTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFieldsToTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add new fields to a Template
    ApiResponse<TemplateAddFieldsResponse> response = apiInstance.AddFieldsToTemplateWithHttpInfo(templateId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.AddFieldsToTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="batchgeneratepdfs"></a>
# **BatchGeneratePdfs**
> BatchGeneratePdfs201Response BatchGeneratePdfs (SubmissionBatchData data, bool? wait = null)

Generates multiple PDFs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class BatchGeneratePdfsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new SubmissionBatchData(); // SubmissionBatchData | 
            var wait = true;  // bool? | Wait for submission batch to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) (optional)  (default to true)

            try
            {
                // Generates multiple PDFs
                BatchGeneratePdfs201Response result = apiInstance.BatchGeneratePdfs(data, wait);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.BatchGeneratePdfs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchGeneratePdfsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generates multiple PDFs
    ApiResponse<BatchGeneratePdfs201Response> response = apiInstance.BatchGeneratePdfsWithHttpInfo(data, wait);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.BatchGeneratePdfsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**SubmissionBatchData**](SubmissionBatchData.md) |  |  |
| **wait** | **bool?** | Wait for submission batch to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="combinepdfs"></a>
# **CombinePdfs**
> CreateCombinedSubmissionResponse CombinePdfs (CombinePdfsData data)

Merge submission PDFs, template PDFs, or custom files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CombinePdfsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new CombinePdfsData(); // CombinePdfsData | 

            try
            {
                // Merge submission PDFs, template PDFs, or custom files
                CreateCombinedSubmissionResponse result = apiInstance.CombinePdfs(data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CombinePdfs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CombinePdfsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merge submission PDFs, template PDFs, or custom files
    ApiResponse<CreateCombinedSubmissionResponse> response = apiInstance.CombinePdfsWithHttpInfo(data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CombinePdfsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="combinesubmissions"></a>
# **CombineSubmissions**
> CreateCombinedSubmissionResponse CombineSubmissions (CombinedSubmissionData data, bool? wait = null)

Merge generated PDFs together

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CombineSubmissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new CombinedSubmissionData(); // CombinedSubmissionData | 
            var wait = true;  // bool? | Wait for combined submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) (optional)  (default to true)

            try
            {
                // Merge generated PDFs together
                CreateCombinedSubmissionResponse result = apiInstance.CombineSubmissions(data, wait);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CombineSubmissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CombineSubmissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merge generated PDFs together
    ApiResponse<CreateCombinedSubmissionResponse> response = apiInstance.CombineSubmissionsWithHttpInfo(data, wait);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CombineSubmissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**CombinedSubmissionData**](CombinedSubmissionData.md) |  |  |
| **wait** | **bool?** | Wait for combined submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="copytemplate"></a>
# **CopyTemplate**
> TemplatePreview CopyTemplate (string templateId, CopyTemplateOptions options = null)

Copy a Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CopyTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 
            var options = new CopyTemplateOptions(); // CopyTemplateOptions |  (optional) 

            try
            {
                // Copy a Template
                TemplatePreview result = apiInstance.CopyTemplate(templateId, options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CopyTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy a Template
    ApiResponse<TemplatePreview> response = apiInstance.CopyTemplateWithHttpInfo(templateId, options);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CopyTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcustomfilefromupload"></a>
# **CreateCustomFileFromUpload**
> CreateCustomFileResponse CreateCustomFileFromUpload (CreateCustomFileData data)

Create a new custom file from a cached presign upload

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreateCustomFileFromUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new CreateCustomFileData(); // CreateCustomFileData | 

            try
            {
                // Create a new custom file from a cached presign upload
                CreateCustomFileResponse result = apiInstance.CreateCustomFileFromUpload(data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreateCustomFileFromUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomFileFromUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new custom file from a cached presign upload
    ApiResponse<CreateCustomFileResponse> response = apiInstance.CreateCustomFileFromUploadWithHttpInfo(data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreateCustomFileFromUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdatarequestevent"></a>
# **CreateDataRequestEvent**
> CreateSubmissionDataRequestEventResponse CreateDataRequestEvent (string dataRequestId, CreateSubmissionDataRequestEventRequest varEvent)

Creates a new event for emailing a signee a request for signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreateDataRequestEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var dataRequestId = drq_1234567890abcdef01;  // string | 
            var varEvent = new CreateSubmissionDataRequestEventRequest(); // CreateSubmissionDataRequestEventRequest | 

            try
            {
                // Creates a new event for emailing a signee a request for signature
                CreateSubmissionDataRequestEventResponse result = apiInstance.CreateDataRequestEvent(dataRequestId, varEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreateDataRequestEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataRequestEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new event for emailing a signee a request for signature
    ApiResponse<CreateSubmissionDataRequestEventResponse> response = apiInstance.CreateDataRequestEventWithHttpInfo(dataRequestId, varEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreateDataRequestEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdatarequesttoken"></a>
# **CreateDataRequestToken**
> CreateSubmissionDataRequestTokenResponse CreateDataRequestToken (string dataRequestId, string type = null)

Creates a new data request token for form authentication

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreateDataRequestTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var dataRequestId = drq_1234567890abcdef01;  // string | 
            var type = api;  // string |  (optional) 

            try
            {
                // Creates a new data request token for form authentication
                CreateSubmissionDataRequestTokenResponse result = apiInstance.CreateDataRequestToken(dataRequestId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreateDataRequestToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataRequestTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new data request token for form authentication
    ApiResponse<CreateSubmissionDataRequestTokenResponse> response = apiInstance.CreateDataRequestTokenWithHttpInfo(dataRequestId, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreateDataRequestTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfolder"></a>
# **CreateFolder**
> Folder CreateFolder (CreateFolderData data)

Create a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new CreateFolderData(); // CreateFolderData | 

            try
            {
                // Create a folder
                Folder result = apiInstance.CreateFolder(data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a folder
    ApiResponse<Folder> response = apiInstance.CreateFolderWithHttpInfo(data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createhtmltemplate"></a>
# **CreateHTMLTemplate**
> TemplatePreview CreateHTMLTemplate (CreateHtmlTemplate data)

Create a new HTML template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreateHTMLTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new CreateHtmlTemplate(); // CreateHtmlTemplate | 

            try
            {
                // Create a new HTML template
                TemplatePreview result = apiInstance.CreateHTMLTemplate(data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreateHTMLTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateHTMLTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new HTML template
    ApiResponse<TemplatePreview> response = apiInstance.CreateHTMLTemplateWithHttpInfo(data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreateHTMLTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpdftemplate"></a>
# **CreatePDFTemplate**
> TemplatePreview CreatePDFTemplate (System.IO.Stream templateDocument, string templateName, bool? wait = null, string templateDescription = null, string templateParentFolderId = null)

Create a new PDF template with a form POST file upload

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreatePDFTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateDocument = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var templateName = "templateName_example";  // string | 
            var wait = true;  // bool? | Wait for template document to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) (optional)  (default to true)
            var templateDescription = "templateDescription_example";  // string |  (optional) 
            var templateParentFolderId = "templateParentFolderId_example";  // string |  (optional) 

            try
            {
                // Create a new PDF template with a form POST file upload
                TemplatePreview result = apiInstance.CreatePDFTemplate(templateDocument, templateName, wait, templateDescription, templateParentFolderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreatePDFTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePDFTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new PDF template with a form POST file upload
    ApiResponse<TemplatePreview> response = apiInstance.CreatePDFTemplateWithHttpInfo(templateDocument, templateName, wait, templateDescription, templateParentFolderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreatePDFTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateDocument** | **System.IO.Stream****System.IO.Stream** |  |  |
| **templateName** | **string** |  |  |
| **wait** | **bool?** | Wait for template document to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpdftemplatefromupload"></a>
# **CreatePDFTemplateFromUpload**
> TemplatePreview CreatePDFTemplateFromUpload (CreatePdfTemplate data)

Create a new PDF template from a cached presign upload

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class CreatePDFTemplateFromUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var data = new CreatePdfTemplate(); // CreatePdfTemplate | 

            try
            {
                // Create a new PDF template from a cached presign upload
                TemplatePreview result = apiInstance.CreatePDFTemplateFromUpload(data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.CreatePDFTemplateFromUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePDFTemplateFromUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new PDF template from a cached presign upload
    ApiResponse<TemplatePreview> response = apiInstance.CreatePDFTemplateFromUploadWithHttpInfo(data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.CreatePDFTemplateFromUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> Folder DeleteFolder (string folderId)

Delete a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var folderId = fld_1234567890abcdef01;  // string | 

            try
            {
                // Delete a folder
                Folder result = apiInstance.DeleteFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.DeleteFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a folder
    ApiResponse<Folder> response = apiInstance.DeleteFolderWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.DeleteFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetemplate"></a>
# **DeleteTemplate**
> TemplateDeleteResponse DeleteTemplate (string templateId, string version = null)

Delete a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class DeleteTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 
            var version = 0.1.0;  // string |  (optional) 

            try
            {
                // Delete a template
                TemplateDeleteResponse result = apiInstance.DeleteTemplate(templateId, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.DeleteTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a template
    ApiResponse<TemplateDeleteResponse> response = apiInstance.DeleteTemplateWithHttpInfo(templateId, version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.DeleteTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="expirecombinedsubmission"></a>
# **ExpireCombinedSubmission**
> CombinedSubmission ExpireCombinedSubmission (string combinedSubmissionId)

Expire a combined submission

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ExpireCombinedSubmissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var combinedSubmissionId = com_1234567890abcdef01;  // string | 

            try
            {
                // Expire a combined submission
                CombinedSubmission result = apiInstance.ExpireCombinedSubmission(combinedSubmissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ExpireCombinedSubmission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExpireCombinedSubmissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Expire a combined submission
    ApiResponse<CombinedSubmission> response = apiInstance.ExpireCombinedSubmissionWithHttpInfo(combinedSubmissionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ExpireCombinedSubmissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="expiresubmission"></a>
# **ExpireSubmission**
> SubmissionPreview ExpireSubmission (string submissionId)

Expire a PDF submission

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ExpireSubmissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var submissionId = sub_1234567890abcdef01;  // string | 

            try
            {
                // Expire a PDF submission
                SubmissionPreview result = apiInstance.ExpireSubmission(submissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ExpireSubmission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExpireSubmissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Expire a PDF submission
    ApiResponse<SubmissionPreview> response = apiInstance.ExpireSubmissionWithHttpInfo(submissionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ExpireSubmissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatepdf"></a>
# **GeneratePdf**
> CreateSubmissionResponse GeneratePdf (string templateId, CreatePdfSubmissionData submission, bool? wait = null)

Generates a new PDF

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GeneratePdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 
            var submission = new CreatePdfSubmissionData(); // CreatePdfSubmissionData | 
            var wait = true;  // bool? | Wait for submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) (optional)  (default to true)

            try
            {
                // Generates a new PDF
                CreateSubmissionResponse result = apiInstance.GeneratePdf(templateId, submission, wait);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GeneratePdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneratePdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generates a new PDF
    ApiResponse<CreateSubmissionResponse> response = apiInstance.GeneratePdfWithHttpInfo(templateId, submission, wait);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GeneratePdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **submission** | [**CreatePdfSubmissionData**](CreatePdfSubmissionData.md) |  |  |
| **wait** | **bool?** | Wait for submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatepdfforhtmltemplate"></a>
# **GeneratePdfForHtmlTemplate**
> CreateSubmissionResponse GeneratePdfForHtmlTemplate (string templateId, CreateHtmlSubmissionData submission, bool? wait = null)

Generates a new PDF for an HTML template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GeneratePdfForHtmlTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_HTML567890abcdef01;  // string | 
            var submission = new CreateHtmlSubmissionData(); // CreateHtmlSubmissionData | 
            var wait = true;  // bool? | Wait for submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) (optional)  (default to true)

            try
            {
                // Generates a new PDF for an HTML template
                CreateSubmissionResponse result = apiInstance.GeneratePdfForHtmlTemplate(templateId, submission, wait);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GeneratePdfForHtmlTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneratePdfForHtmlTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generates a new PDF for an HTML template
    ApiResponse<CreateSubmissionResponse> response = apiInstance.GeneratePdfForHtmlTemplateWithHttpInfo(templateId, submission, wait);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GeneratePdfForHtmlTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **submission** | [**CreateHtmlSubmissionData**](CreateHtmlSubmissionData.md) |  |  |
| **wait** | **bool?** | Wait for submission to be processed before returning. Set to false to return immediately. Default: true (on sync.* subdomain) | [optional] [default to true] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatepreview"></a>
# **GeneratePreview**
> SuccessErrorResponse GeneratePreview (string submissionId)

Generated a preview PDF for partially completed data requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GeneratePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var submissionId = sub_1234567890abcdef01;  // string | 

            try
            {
                // Generated a preview PDF for partially completed data requests
                SuccessErrorResponse result = apiInstance.GeneratePreview(submissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GeneratePreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneratePreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generated a preview PDF for partially completed data requests
    ApiResponse<SuccessErrorResponse> response = apiInstance.GeneratePreviewWithHttpInfo(submissionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GeneratePreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcombinedsubmission"></a>
# **GetCombinedSubmission**
> CombinedSubmission GetCombinedSubmission (string combinedSubmissionId)

Check the status of a combined submission (merged PDFs)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetCombinedSubmissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var combinedSubmissionId = com_1234567890abcdef01;  // string | 

            try
            {
                // Check the status of a combined submission (merged PDFs)
                CombinedSubmission result = apiInstance.GetCombinedSubmission(combinedSubmissionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetCombinedSubmission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCombinedSubmissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the status of a combined submission (merged PDFs)
    ApiResponse<CombinedSubmission> response = apiInstance.GetCombinedSubmissionWithHttpInfo(combinedSubmissionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetCombinedSubmissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatarequest"></a>
# **GetDataRequest**
> SubmissionDataRequestShow GetDataRequest (string dataRequestId)

Look up a submission data request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetDataRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var dataRequestId = drq_1234567890abcdef01;  // string | 

            try
            {
                // Look up a submission data request
                SubmissionDataRequestShow result = apiInstance.GetDataRequest(dataRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetDataRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Look up a submission data request
    ApiResponse<SubmissionDataRequestShow> response = apiInstance.GetDataRequestWithHttpInfo(dataRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetDataRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfulltemplate"></a>
# **GetFullTemplate**
> Template GetFullTemplate (string templateId)

Fetch the full attributes for a PDF template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetFullTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 

            try
            {
                // Fetch the full attributes for a PDF template
                Template result = apiInstance.GetFullTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetFullTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFullTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the full attributes for a PDF template
    ApiResponse<Template> response = apiInstance.GetFullTemplateWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetFullTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpresignurl"></a>
# **GetPresignUrl**
> UploadPresignResponse GetPresignUrl ()

Get a presigned URL so that you can upload a file to our AWS S3 bucket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetPresignUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);

            try
            {
                // Get a presigned URL so that you can upload a file to our AWS S3 bucket
                UploadPresignResponse result = apiInstance.GetPresignUrl();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetPresignUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPresignUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a presigned URL so that you can upload a file to our AWS S3 bucket
    ApiResponse<UploadPresignResponse> response = apiInstance.GetPresignUrlWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetPresignUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsubmission"></a>
# **GetSubmission**
> Submission GetSubmission (string submissionId, bool? includeData = null)

Check the status of a PDF

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetSubmissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var submissionId = sub_1234567890abcdef01;  // string | 
            var includeData = true;  // bool? |  (optional) 

            try
            {
                // Check the status of a PDF
                Submission result = apiInstance.GetSubmission(submissionId, includeData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetSubmission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubmissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the status of a PDF
    ApiResponse<Submission> response = apiInstance.GetSubmissionWithHttpInfo(submissionId, includeData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetSubmissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionId** | **string** |  |  |
| **includeData** | **bool?** |  | [optional]  |

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
| **200** | processed submission found |  -  |
| **404** | submission not found |  -  |
| **401** | authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsubmissionbatch"></a>
# **GetSubmissionBatch**
> SubmissionBatchWithSubmissions GetSubmissionBatch (string submissionBatchId, bool? includeSubmissions = null)

Check the status of a submission batch job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetSubmissionBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var submissionBatchId = sbb_1234567890abcdef01;  // string | 
            var includeSubmissions = true;  // bool? |  (optional) 

            try
            {
                // Check the status of a submission batch job
                SubmissionBatchWithSubmissions result = apiInstance.GetSubmissionBatch(submissionBatchId, includeSubmissions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetSubmissionBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubmissionBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the status of a submission batch job
    ApiResponse<SubmissionBatchWithSubmissions> response = apiInstance.GetSubmissionBatchWithHttpInfo(submissionBatchId, includeSubmissions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetSubmissionBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submissionBatchId** | **string** |  |  |
| **includeSubmissions** | **bool?** |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettemplate"></a>
# **GetTemplate**
> TemplatePreview GetTemplate (string templateId)

Check the status of an uploaded template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 

            try
            {
                // Check the status of an uploaded template
                TemplatePreview result = apiInstance.GetTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the status of an uploaded template
    ApiResponse<TemplatePreview> response = apiInstance.GetTemplateWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettemplateschema"></a>
# **GetTemplateSchema**
> JsonSchema GetTemplateSchema (string templateId)

Fetch the JSON schema for a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class GetTemplateSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 

            try
            {
                // Fetch the JSON schema for a template
                JsonSchema result = apiInstance.GetTemplateSchema(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.GetTemplateSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemplateSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the JSON schema for a template
    ApiResponse<JsonSchema> response = apiInstance.GetTemplateSchemaWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.GetTemplateSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcombinedsubmissions"></a>
# **ListCombinedSubmissions**
> List&lt;CombinedSubmission&gt; ListCombinedSubmissions (int? page = null, int? perPage = null)

Get a list of all combined submissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ListCombinedSubmissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var page = 2;  // int? | Default: 1 (optional) 
            var perPage = 1;  // int? | Default: 50 (optional) 

            try
            {
                // Get a list of all combined submissions
                List<CombinedSubmission> result = apiInstance.ListCombinedSubmissions(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ListCombinedSubmissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCombinedSubmissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of all combined submissions
    ApiResponse<List<CombinedSubmission>> response = apiInstance.ListCombinedSubmissionsWithHttpInfo(page, perPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ListCombinedSubmissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Default: 1 | [optional]  |
| **perPage** | **int?** | Default: 50 | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfolders"></a>
# **ListFolders**
> List&lt;Folder&gt; ListFolders (string parentFolderId = null)

Get a list of all folders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ListFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var parentFolderId = fld_1234567890abcdef02;  // string | Filter By Folder Id (optional) 

            try
            {
                // Get a list of all folders
                List<Folder> result = apiInstance.ListFolders(parentFolderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ListFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of all folders
    ApiResponse<List<Folder>> response = apiInstance.ListFoldersWithHttpInfo(parentFolderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ListFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listsubmissions"></a>
# **ListSubmissions**
> ListSubmissionsResponse ListSubmissions (string cursor = null, decimal? limit = null, string createdAfter = null, string createdBefore = null, string type = null, bool? includeData = null)

List all submissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ListSubmissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var cursor = sub_1234567890abcdef12;  // string |  (optional) 
            var limit = 3;  // decimal? |  (optional) 
            var createdAfter = 2019-01-01T09:00:00-05:00;  // string |  (optional) 
            var createdBefore = 2020-01-01T09:00:00.000+0200;  // string |  (optional) 
            var type = test;  // string |  (optional) 
            var includeData = true;  // bool? |  (optional) 

            try
            {
                // List all submissions
                ListSubmissionsResponse result = apiInstance.ListSubmissions(cursor, limit, createdAfter, createdBefore, type, includeData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ListSubmissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSubmissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all submissions
    ApiResponse<ListSubmissionsResponse> response = apiInstance.ListSubmissionsWithHttpInfo(cursor, limit, createdAfter, createdBefore, type, includeData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ListSubmissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string** |  | [optional]  |
| **limit** | **decimal?** |  | [optional]  |
| **createdAfter** | **string** |  | [optional]  |
| **createdBefore** | **string** |  | [optional]  |
| **type** | **string** |  | [optional]  |
| **includeData** | **bool?** |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtemplatesubmissions"></a>
# **ListTemplateSubmissions**
> ListSubmissionsResponse ListTemplateSubmissions (string templateId, string cursor = null, decimal? limit = null, string createdAfter = null, string createdBefore = null, string type = null, bool? includeData = null)

List all submissions for a given template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ListTemplateSubmissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef02;  // string | 
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var createdAfter = "createdAfter_example";  // string |  (optional) 
            var createdBefore = "createdBefore_example";  // string |  (optional) 
            var type = "type_example";  // string |  (optional) 
            var includeData = true;  // bool? |  (optional) 

            try
            {
                // List all submissions for a given template
                ListSubmissionsResponse result = apiInstance.ListTemplateSubmissions(templateId, cursor, limit, createdAfter, createdBefore, type, includeData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ListTemplateSubmissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTemplateSubmissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all submissions for a given template
    ApiResponse<ListSubmissionsResponse> response = apiInstance.ListTemplateSubmissionsWithHttpInfo(templateId, cursor, limit, createdAfter, createdBefore, type, includeData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ListTemplateSubmissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **cursor** | **string** |  | [optional]  |
| **limit** | **decimal?** |  | [optional]  |
| **createdAfter** | **string** |  | [optional]  |
| **createdBefore** | **string** |  | [optional]  |
| **type** | **string** |  | [optional]  |
| **includeData** | **bool?** |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtemplates"></a>
# **ListTemplates**
> List&lt;TemplatePreview&gt; ListTemplates (string query = null, string parentFolderId = null, int? page = null, int? perPage = null)

Get a list of all templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class ListTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var query = 2;  // string | Search By Name (optional) 
            var parentFolderId = fld_1234567890abcdef01;  // string | Filter By Folder Id (optional) 
            var page = 2;  // int? | Default: 1 (optional) 
            var perPage = 1;  // int? | Default: 50 (optional) 

            try
            {
                // Get a list of all templates
                List<TemplatePreview> result = apiInstance.ListTemplates(query, parentFolderId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.ListTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of all templates
    ApiResponse<List<TemplatePreview>> response = apiInstance.ListTemplatesWithHttpInfo(query, parentFolderId, page, perPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.ListTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Search By Name | [optional]  |
| **parentFolderId** | **string** | Filter By Folder Id | [optional]  |
| **page** | **int?** | Default: 1 | [optional]  |
| **perPage** | **int?** | Default: 50 | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="movefoldertofolder"></a>
# **MoveFolderToFolder**
> Folder MoveFolderToFolder (string folderId, MoveFolderData data)

Move a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class MoveFolderToFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var folderId = fld_1234567890abcdef01;  // string | 
            var data = new MoveFolderData(); // MoveFolderData | 

            try
            {
                // Move a folder
                Folder result = apiInstance.MoveFolderToFolder(folderId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.MoveFolderToFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveFolderToFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move a folder
    ApiResponse<Folder> response = apiInstance.MoveFolderToFolderWithHttpInfo(folderId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.MoveFolderToFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="movetemplatetofolder"></a>
# **MoveTemplateToFolder**
> TemplatePreview MoveTemplateToFolder (string templateId, MoveTemplateData data)

Move Template to folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class MoveTemplateToFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 
            var data = new MoveTemplateData(); // MoveTemplateData | 

            try
            {
                // Move Template to folder
                TemplatePreview result = apiInstance.MoveTemplateToFolder(templateId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.MoveTemplateToFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveTemplateToFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move Template to folder
    ApiResponse<TemplatePreview> response = apiInstance.MoveTemplateToFolderWithHttpInfo(templateId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.MoveTemplateToFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="publishtemplateversion"></a>
# **PublishTemplateVersion**
> TemplatePublishVersionResponse PublishTemplateVersion (string templateId, PublishVersionData data)

Publish a template version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class PublishTemplateVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 
            var data = new PublishVersionData(); // PublishVersionData | 

            try
            {
                // Publish a template version
                TemplatePublishVersionResponse result = apiInstance.PublishTemplateVersion(templateId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.PublishTemplateVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PublishTemplateVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publish a template version
    ApiResponse<TemplatePublishVersionResponse> response = apiInstance.PublishTemplateVersionWithHttpInfo(templateId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.PublishTemplateVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="renamefolder"></a>
# **RenameFolder**
> Folder RenameFolder (string folderId, RenameFolderData data)

Rename a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class RenameFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var folderId = fld_1234567890abcdef01;  // string | 
            var data = new RenameFolderData(); // RenameFolderData | 

            try
            {
                // Rename a folder
                Folder result = apiInstance.RenameFolder(folderId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.RenameFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename a folder
    ApiResponse<Folder> response = apiInstance.RenameFolderWithHttpInfo(folderId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.RenameFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="restoretemplateversion"></a>
# **RestoreTemplateVersion**
> SuccessErrorResponse RestoreTemplateVersion (string templateId, RestoreVersionData data)

Restore a template version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class RestoreTemplateVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef01;  // string | 
            var data = new RestoreVersionData(); // RestoreVersionData | 

            try
            {
                // Restore a template version
                SuccessErrorResponse result = apiInstance.RestoreTemplateVersion(templateId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.RestoreTemplateVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreTemplateVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a template version
    ApiResponse<SuccessErrorResponse> response = apiInstance.RestoreTemplateVersionWithHttpInfo(templateId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.RestoreTemplateVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testauthentication"></a>
# **TestAuthentication**
> SuccessErrorResponse TestAuthentication ()

Test Authentication

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class TestAuthenticationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);

            try
            {
                // Test Authentication
                SuccessErrorResponse result = apiInstance.TestAuthentication();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.TestAuthentication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestAuthenticationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test Authentication
    ApiResponse<SuccessErrorResponse> response = apiInstance.TestAuthenticationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.TestAuthenticationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedatarequest"></a>
# **UpdateDataRequest**
> CreateSubmissionDataRequestResponse UpdateDataRequest (string dataRequestId, UpdateSubmissionDataRequestData data)

Update a submission data request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class UpdateDataRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var dataRequestId = drq_1234567890abcdef01;  // string | 
            var data = new UpdateSubmissionDataRequestData(); // UpdateSubmissionDataRequestData | 

            try
            {
                // Update a submission data request
                CreateSubmissionDataRequestResponse result = apiInstance.UpdateDataRequest(dataRequestId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.UpdateDataRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a submission data request
    ApiResponse<CreateSubmissionDataRequestResponse> response = apiInstance.UpdateDataRequestWithHttpInfo(dataRequestId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.UpdateDataRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> SuccessMultipleErrorsResponse UpdateTemplate (string templateId, UpdateHtmlTemplate data)

Update a Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Model;

namespace Example
{
    public class UpdateTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sync.api.docspring.com/api/v1";
            // Configure HTTP basic authorization: api_token_basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PDFApi(config);
            var templateId = tpl_1234567890abcdef03;  // string | 
            var data = new UpdateHtmlTemplate(); // UpdateHtmlTemplate | 

            try
            {
                // Update a Template
                SuccessMultipleErrorsResponse result = apiInstance.UpdateTemplate(templateId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFApi.UpdateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Template
    ApiResponse<SuccessMultipleErrorsResponse> response = apiInstance.UpdateTemplateWithHttpInfo(templateId, data);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFApi.UpdateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

