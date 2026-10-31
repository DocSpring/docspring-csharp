# DocSpring C# SDK

The official C# client for the [DocSpring API](https://docspring.com/docs/api/). DocSpring fills PDF
forms with your data, generates PDFs and Word documents from HTML and Word templates, combines PDFs and collects
e-signatures.

[Documentation](https://docspring.com/docs/) · [API reference](https://docspring.com/docs/api/) ·
[NuGet](https://www.nuget.org/packages/DocSpring.Client/) · [Changelog](https://github.com/DocSpring/docspring-csharp/blob/main/CHANGELOG.md)

The code in this repository is generated from DocSpring's OpenAPI spec ([About this SDK](#about-this-sdk)). Issues and
pull requests are welcome.

Version 4.3.0. Requires .NET Standard 2.0 (.NET 6 or later, or .NET Framework 4.6.2 or later).

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
var body = new DocSpring.Client.Model.CreateSubmissionRequest() {
  Data = new Dictionary<string, object> {
    { "first_name", "John" },
    { "last_name", "Smith" },
    { "phone_number", "+11234567890" }
  },
  Metadata = new Dictionary<string, object> {
    { "user_id", 42 }
  },
  Test = true
};

var response = await api.CreateSubmissionAsync(templateId, body: body);
var result = response.Created();
Console.WriteLine(result);
```

By default the call waits for the PDF, for up to 95 seconds, and the submission in the response has a link to
download it (`files.pdf.download_url`). Set `wait` to false to get a pending submission straight away.
[Sync vs. async processing](https://docspring.com/docs/api-guide/synchronous-requests/) covers the time limit, status
checks and webhooks.

## Methods

[docs/apis/Client.md](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md) has each method's parameters and return type, and
[docs/models/](https://github.com/DocSpring/docspring-csharp/tree/main/docs/models) has the models. The [API reference](https://docspring.com/docs/api/) has
C# code for every method.

| Method | Description |
| ------ | ----------- |
| [`AddTemplateFields`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#addtemplatefields) | Add fields to a template |
| [`CopyTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#copytemplate) | Copy a template |
| [`CreateCombinedPdf`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createcombinedpdf) | Combine PDFs |
| [`CreateCustomFileFromUpload`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createcustomfilefromupload) | Create a custom file from an upload |
| [`CreateFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createfolder) | Create a folder |
| [`CreateSignatureRequestEvent`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createsignaturerequestevent) | Record a signature request event |
| [`CreateSignatureRequestToken`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createsignaturerequesttoken) | Create a signature request token |
| [`CreateSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createsubmission) | Generate a PDF |
| [`CreateSubmissionBatch`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createsubmissionbatch) | Generate PDFs in a batch |
| [`CreateTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createtemplate) | Create a template |
| [`CreateTemplatePreview`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createtemplatepreview) | Preview a template with data |
| [`CreateWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#createwebhook) | Create a webhook |
| [`DeleteCustomFile`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletecustomfile) | Delete a custom file |
| [`DeleteFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletefolder) | Delete a folder |
| [`DeleteTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletetemplate) | Delete a template |
| [`DeleteWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#deletewebhook) | Delete a webhook |
| [`ExpireCombinedPdf`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#expirecombinedpdf) | Expire a combined PDF |
| [`ExpireSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#expiresubmission) | Expire a submission |
| [`GenerateSubmissionFiles`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#generatesubmissionfiles) | Generate more files |
| [`GenerateSubmissionPreview`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#generatesubmissionpreview) | Generate a preview PDF |
| [`GetCombinedPdf`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getcombinedpdf) | Get a combined PDF |
| [`GetCustomFile`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getcustomfile) | Get a custom file |
| [`GetFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getfolder) | Get a folder |
| [`GetPresignUrl`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getpresignurl) | Get a presigned URL to upload a file |
| [`GetSignatureRequest`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getsignaturerequest) | Get a signature request |
| [`GetSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getsubmission) | Get a submission |
| [`GetSubmissionBatch`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getsubmissionbatch) | Get a batch |
| [`GetTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplate) | Get a template |
| [`GetTemplateDiff`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplatediff) | Compare a version of a template with the one before it |
| [`GetTemplateModelCode`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplatemodelcode) | Generate typed code for a template's submission data |
| [`GetTemplatePageImages`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplatepageimages) | Get images of a template's pages |
| [`GetTemplatePreview`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplatepreview) | Get a template preview |
| [`GetTemplateSchema`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#gettemplateschema) | Get the JSON Schema of a template's submission data |
| [`GetWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#getwebhook) | Get a webhook |
| [`ListCombinedPdfs`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listcombinedpdfs) | List combined PDFs |
| [`ListCustomFiles`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listcustomfiles) | List custom files |
| [`ListFolders`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listfolders) | List folders |
| [`ListSubmissions`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listsubmissions) | List submissions |
| [`ListTemplateFields`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listtemplatefields) | List a template's fields |
| [`ListTemplates`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listtemplates) | List templates |
| [`ListTemplateSubmissions`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listtemplatesubmissions) | List a template's submissions |
| [`ListWebhooks`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#listwebhooks) | List webhooks |
| [`MoveFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#movefolder) | Move a folder |
| [`MoveTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#movetemplate) | Move a template to a folder |
| [`PublishTemplateVersion`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#publishtemplateversion) | Publish a template version |
| [`RemoveTemplateFields`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#removetemplatefields) | Remove fields from a template |
| [`RenameFolder`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#renamefolder) | Rename a folder |
| [`ReorderTemplateFields`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#reordertemplatefields) | Reorder a template's fields |
| [`RestoreTemplateVersion`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#restoretemplateversion) | Restore a template version |
| [`TestAuthentication`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#testauthentication) | Test authentication |
| [`UpdateSignatureRequest`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatesignaturerequest) | Update a signature request |
| [`UpdateTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatetemplate) | Update a template |
| [`UpdateTemplateDocument`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatetemplatedocument) | Replace a template's document |
| [`UpdateTemplateFields`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatetemplatefields) | Update a template's fields |
| [`UpdateWebhook`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#updatewebhook) | Update a webhook |
| [`UploadTemplate`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#uploadtemplate) | Create a template from an uploaded PDF or Word document |
| [`UploadTemplateDocument`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#uploadtemplatedocument) | Replace a template's document with an uploaded file |
| [`ValidateSubmission`](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md#validatesubmission) | Check a submission without creating it |

## Errors

Methods return a response object rather than throwing for an error status. `IsCreated`, `IsUnprocessableContent` and the other `Is...` properties say which documented response came back, and `Created()` or `TryCreated(out var result)` give you its body.

The client checks each request against the API's request schemas before sending it. A request the API would reject throws a `DocSpring.Client.Client.ValidationException` (an `ArgumentException`), whose `Details` are `ErrorDetail`s with a `Code`, a `Message` and a `Pointer` into the body (or a `Parameter`). Turn the check off with `client.ValidateRequests = false`.
The details are the ones the API's 422 response would have, so you get them without a round trip.

## API changes

DocSpring adds fields and enum values to API v2 without releasing a new API version. Changes that would break
existing code, such as removing or renaming a field, go in a new API version
([API changes](https://docspring.com/docs/api-guide/openapi-schema/#api-changes)). So this SDK keeps working with
responses that are newer than it is:

- The model leaves out a response field added to the API after this release (models have an `AdditionalProperties` dictionary, but the generated JSON converters don't fill it).
- An enum value added to the API after this release comes back as the API sent it: handle values you don't recognize.

Upgrade the SDK to read new fields and enum values. The [changelog](https://github.com/DocSpring/docspring-csharp/blob/main/CHANGELOG.md) lists
what each release adds.

## About this SDK

This SDK is generated from DocSpring's [OpenAPI spec](https://docspring.com/api-docs/v2/openapi.json) with
[DocSpring's fork of OpenAPI Generator](https://github.com/DocSpring/openapi-generator/tree/docspring/all_patches) 7.26.0.
The fork changes the C# generator:

- Enum types are readonly structs rather than C# `enum`s, so an enum value added to the API after this release comes back as the API sent it (`ToString()`), with `IsKnown` false. The static properties are the values this release knows, and `Values` lists them.
- Nullable and optional enums write `null`, or leave the property out, without throwing.
- Model constructors assign required properties, and optional object and list properties serialize their value rather than the `Option<T>` wrapper.
- A union whose discriminator has several values for one model (`TemplateFieldDependencyConditionInput`) compiles.

On top of the generated code, we add:

- A client constructor that reads your credentials, region and host from the environment.
- `DocSpring.Sdk.NewClient(...)` and `DocSpring.Sdk.NewClientFromEnv()`, which build a client without a .NET host builder.
- `DocSpring.Webhooks.VerifyWebhookSignature(payload, signatureHeader, secret)` checks a webhook request's `X-DocSpring-Signature` header, with `toleranceSeconds` and `now` arguments.

Each release regenerates every file, so a change made only here would be lost in the next one. Issues and pull
requests are welcome all the same: [open an issue](https://github.com/DocSpring/docspring-csharp/issues) or a pull request, or email
[support@docspring.com](mailto:support@docspring.com), and we'll make the fix in the generator so that every release
keeps it. [AGENTS.md](https://github.com/DocSpring/docspring-csharp/blob/main/AGENTS.md) is a guide for AI coding agents that integrate this SDK.

## License

MIT. See [LICENSE](https://github.com/DocSpring/docspring-csharp/blob/main/LICENSE).
