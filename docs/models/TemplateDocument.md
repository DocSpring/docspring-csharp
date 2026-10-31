# DocSpring.Client.Model.TemplateDocument
A PDF template's PDF, or a Word template's Word document.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **TemplateDocumentState** | `pending` while DocSpring processes the PDF, then `processed` (`ready` says when its pages are done too). `password_required`, `malformed_pdf` and `unknown_error` mean the PDF couldn't be processed, and `error_message` says why: upload it again or upload another one. `downloading` while DocSpring downloads a `document_url`, then as for an upload. `download_failed` means it couldn't be downloaded, and `error_message` says why. `converting` while DocSpring converts an OpenDocument file (.odt) uploaded to a Word template to a Word document, and `conversion_failed` when it couldn't, with `error_message` saying why. A template keeps its document while a new one is downloaded or converted, and when it couldn't be. A Word document is `processed` once it's uploaded, downloaded or converted. | 
**PageCount** | **int** | 0 until the PDF has been processed. 0 for a Word document, whose pages depend on the data. | 
**FieldReimportState** | **FieldReimportState** | Whether the fields are being re-imported from this PDF (`reimport_fields` when the PDF was replaced): `requested` while DocSpring processes the PDF, then `imported`, or `no_fields` when the PDF had no fillable fields and the template kept its fields. `none` when no re-import was asked for, or when it couldn't run (the PDF couldn't be processed, or the template was locked or published while it was). | 
**PageProcessingStatuses** | [**List&lt;TemplatePageProcessingStatus&gt;**](TemplatePageProcessingStatus.md) | How processing is going on each page, in page order: its image, and its fields when DocSpring sets them up (`detect_fields` when the template was created). `state` becomes `processed` once every page is done. Empty until DocSpring has read the PDF, for PDFs uploaded before DocSpring recorded page statuses, and for a Word document. | 
**Filename** | **string** | The file's name. Null until a `document_url` has been downloaded or an OpenDocument file converted. | 
**ErrorMessage** | **string** | Why the PDF couldn't be processed, or the document downloaded or converted, and how to fix it. Null unless `state` is an error. | 
**Md5** | **string** | The MD5 hash of the PDF. Null for a Word document. | 
**PageDimensions** | **List&lt;List&lt;decimal&gt;&gt;** | Each page's width and height in PDF points. Null until the PDF has been processed. | 
**HasFillableFields** | **bool** | Whether the PDF has fillable form fields. Null until DocSpring has read the PDF, and for a Word document. | 
**FieldLogicStatus** | **TemplateFieldLogicStatus** | AI field setup's last step, which reads the whole form once every page is done and can still rename fields and add conditional logic and required fields: `pending` or `processing` until it finishes, then `processed`, `failed` or `skipped`. Null until every page is done, and when there's no logic step to run (`field_logic` is `none`, or the PDF has no fields). Null for a Word document. | 
**DownloadUrl** | **string** | A temporary link to download the PDF. Null for a Word document (use `permanent_url`). | 
**PermanentUrl** | **string** | A link to download the file that doesn't expire. Null until a PDF has been processed. A Word document's is built from the template's current document when it's downloaded. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

