# DocSpring.Client.Model.TemplateDocumentSummary
A PDF template's PDF or a Word template's Word document, as template lists show it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **TemplateDocumentState** | `pending` while DocSpring processes the PDF, then `processed` (`ready` says when its pages are done too). `password_required`, `malformed_pdf` and `unknown_error` mean the PDF couldn't be processed, and `error_message` says why: upload it again or upload another one. `downloading` while DocSpring downloads a `document_url`, then as for an upload. `download_failed` means it couldn't be downloaded, and `error_message` says why. `converting` while DocSpring converts an OpenDocument file (.odt) uploaded to a Word template to a Word document, and `conversion_failed` when it couldn't, with `error_message` saying why. A template keeps its document while a new one is downloaded or converted, and when it couldn't be. A Word document is `processed` once it's uploaded, downloaded or converted. | 
**PageCount** | **int** | 0 until the PDF has been processed. 0 for a Word document, whose pages depend on the data. | 
**Filename** | **string** | The file's name. Null until a `document_url` has been downloaded or an OpenDocument file converted. | 
**ErrorMessage** | **string** | Why the PDF couldn't be processed, or the document downloaded or converted, and how to fix it. Null unless `state` is an error. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

