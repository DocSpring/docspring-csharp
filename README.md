# DocSpring C# SDK

The official C# client for the [DocSpring API](https://docspring.com/docs/api/). DocSpring fills PDF
templates with your data, generates PDFs from HTML templates, combines PDFs and collects e-signatures.

[Documentation](https://docspring.com/docs/) · [API reference](https://docspring.com/docs/api/) ·
[NuGet](https://www.nuget.org/packages/DocSpring.Client/) · [Changelog](https://github.com/DocSpring/docspring-csharp/blob/main/CHANGELOG.md)

Version 3.4.0. Requires .NET Standard 2.0 (.NET 6 or later, or .NET Framework 4.6.2 or later).

## Install and configure

Install from NuGet:

Package Manager

```powershell
PM> Install-Package DocSpring.Client
```

.NET CLI

```bash
dotnet add package DocSpring.Client
```

Paket CLI

```bash
paket add DocSpring.Client
```

Configure authentication via environment variables:

```bash
export DOCSPRING_TOKEN_ID="API_TOKEN_ID"
export DOCSPRING_TOKEN_SECRET="API_TOKEN_SECRET"
```

You can also configure the region or host. The host takes priority over the region:

```bash
export DOCSPRING_REGION="US" # US or EU (defaults to US)
export DOCSPRING_HOST="docspring.yourcompany.com" # For on-premise deployments
```

Initialize the client:

```csharp
var api = DocSpring.Client.Client.EnvClientFactory.NewClient();
```

Or provide credentials directly:

```csharp
var api = DocSpring.Client.Client.EnvClientFactory.NewClient("API_TOKEN_ID", "API_TOKEN_SECRET");
```

## Generate a PDF

Fill a template with data (use your template's ID in place of `tpl_1234567890abcdef01`):

```csharp
var templateId = "tpl_1234567890abcdef01";
var submission = new DocSpring.Client.Model.CreatePdfSubmissionData(
  new Dictionary<string, object> {
  { "first_name", "John" },
  { "last_name", "Smith" },
  { "phone_number", "+11234567890" }
}
) {
  metadata = new Dictionary<string, object> {
  { "foo", 123 },
  { "bar", "baz" }
}
};

var task = api.GeneratePdfAsync(templateId, submission: submission);
var resp = await task;
Console.WriteLine(resp);
```

By default the call waits for the PDF, for up to 95 seconds, and the submission in the response has its
`download_url`. Set `wait` to false to get a pending submission straight away.
[Sync vs. async processing](https://docspring.com/docs/api-guide/synchronous-requests/) covers the time limit, status
checks and webhooks.

## Methods

[docs/apis/Client.md](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md) has each method's parameters and return type, and
[docs/models/](https://github.com/DocSpring/docspring-csharp/tree/main/docs/models) has the models. The [API reference](https://docspring.com/docs/api/) has
C# code for every method.

| Method | Description |
| ------ | ----------- |
| [`AddFieldsToTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#addfieldstotemplate) | Add new fields to a Template |
| [`BatchGeneratePdfs`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#batchgeneratepdfs) | Generate multiple PDFs |
| [`CombinePdfs`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#combinepdfs) | Merge submission PDFs, template PDFs, or custom files |
| [`CopyTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#copytemplate) | Copy a template |
| [`CreateCustomFileFromUpload`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createcustomfilefromupload) | Create a new custom file from a cached S3 upload |
| [`CreateDataRequestEvent`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createdatarequestevent) | Create a new event for emailing a signee a request for signature |
| [`CreateDataRequestToken`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createdatarequesttoken) | Create a new data request token for form authentication |
| [`CreateFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createfolder) | Create a folder |
| [`CreateHtmlTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createhtmltemplate) | Create a new HTML template |
| [`CreatePdfTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createpdftemplate) | Create a new PDF template with a form POST file upload |
| [`CreatePdfTemplateFromUpload`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createpdftemplatefromupload) | Create a new PDF template from a cached S3 file upload |
| [`CreateWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createwebhook) | Create a webhook |
| [`DeleteFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletefolder) | Delete a folder |
| [`DeleteTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletetemplate) | Delete a template |
| [`DeleteWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletewebhook) | Delete a webhook |
| [`ExpireCombinedSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#expirecombinedsubmission) | Expire a combined submission |
| [`ExpireSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#expiresubmission) | Expire a PDF submission |
| [`GeneratePdf`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#generatepdf) | Generate a PDF |
| [`GeneratePreview`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#generatepreview) | Generate a preview PDF for partially completed data requests |
| [`GetCombinedSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getcombinedsubmission) | Check the status of a combined submission (merged PDFs) |
| [`GetDataRequest`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getdatarequest) | Look up a submission data request |
| [`GetFullTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getfulltemplate) | Fetch the full attributes for a PDF template |
| [`GetPresignUrl`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getpresignurl) | Get a presigned S3 URL for direct file upload |
| [`GetSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getsubmission) | Check the status of a PDF |
| [`GetSubmissionBatch`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getsubmissionbatch) | Check the status of a submission batch job |
| [`GetTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplate) | Check the status of an uploaded template |
| [`GetTemplateModelCode`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplatemodelcode) | Generate typed model code for a template |
| [`GetTemplateSchema`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplateschema) | Fetch the JSON schema for a template |
| [`GetWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getwebhook) | Get a webhook |
| [`ListCombinedSubmissions`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listcombinedsubmissions) | Get a list of all combined submissions |
| [`ListFolders`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listfolders) | Get a list of all folders |
| [`ListSubmissions`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listsubmissions) | List all submissions |
| [`ListTemplates`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listtemplates) | Get a list of all templates |
| [`ListTemplateSubmissions`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listtemplatesubmissions) | List all submissions for a given template |
| [`ListWebhooks`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listwebhooks) | Get a list of all webhooks |
| [`MoveFolderToFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#movefoldertofolder) | Move a folder |
| [`MoveTemplateToFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#movetemplatetofolder) | Move Template to folder |
| [`PublishTemplateVersion`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#publishtemplateversion) | Publish a template version |
| [`RenameFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#renamefolder) | Rename a folder |
| [`RestoreTemplateVersion`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#restoretemplateversion) | Restore a template version |
| [`TestAuthentication`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#testauthentication) | Test authentication |
| [`UpdateDataRequest`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatedatarequest) | Update a submission data request |
| [`UpdateTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatetemplate) | Update a Template |
| [`UpdateTemplateDocument`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatetemplatedocument) | Update a template's document with a form POST file upload |
| [`UpdateTemplateDocumentFromUpload`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatetemplatedocumentfromupload) | Update a template's document with a cached S3 file upload |
| [`UpdateWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatewebhook) | Update a webhook |

## Errors

Methods return a response object rather than throwing for an error status. `IsCreated`, `IsUnprocessableContent` and the other `Is...` properties say which documented response came back, and `Created()` or `TryCreated(out var result)` give you its body.

## API changes

DocSpring adds fields and enum values to API v1 without releasing a new API version. Changes that would break
existing code, such as removing or renaming a field, go in a new API version
([API changes](https://docspring.com/docs/api-guide/openapi-schema/#api-changes)). So this SDK keeps working with
responses that are newer than it is:

- The model leaves out a response field added to the API after this release (models have an `AdditionalProperties` dictionary, but the generated JSON converters don't fill it).
- An enum value added to the API after this release comes back as `UnknownDefaultOpenApi`, so give each `switch` over an enum a case or default for it.

Upgrade the SDK to read new fields and enum values. The [changelog](https://github.com/DocSpring/docspring-csharp/blob/main/CHANGELOG.md) lists
what each release adds.

## About this SDK

This SDK is generated from DocSpring's [OpenAPI spec](https://docspring.com/api-docs/v1/openapi.json) with
[DocSpring's fork of OpenAPI Generator](https://github.com/DocSpring/openapi-generator/tree/docspring/all_patches) 7.16.0.
The fork changes the C# generator:

- Enum values added to the API after this release come back as `UnknownDefaultOpenApi` instead of throwing, for required and nullable enums.
- Nullable enums read and write `null` without throwing.
- File uploads send a `multipart/form-data` body with the file's name and boundary.
- Paths with a query string (`?endpoint_variant=...`) aren't percent-encoded into the path.
- Model constructors assign required properties, and optional object and list properties serialize their value rather than the `Option<T>` wrapper.

On top of the generated code, we add:

- A client constructor that reads your credentials, region and host from the environment.
- `DocSpring.Sdk.NewClient(...)` and `DocSpring.Sdk.NewClientFromEnv()`, which build a client without a .NET host builder.

Because the code is generated, we can't merge pull requests that change it. Please
[open an issue](https://github.com/DocSpring/docspring-csharp/issues) or email [support@docspring.com](mailto:support@docspring.com) instead, and
we'll fix it in the generator. [AGENTS.md](https://github.com/DocSpring/docspring-csharp/blob/main/AGENTS.md) is a short guide for AI coding agents.

## License

MIT. See [LICENSE](https://github.com/DocSpring/docspring-csharp/blob/main/LICENSE).
