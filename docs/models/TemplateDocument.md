# DocSpring.Client.Model.TemplateDocument
A PDF template's PDF.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **TemplateDocumentState** | `pending` while DocSpring processes the PDF, then `processed`. `password_required`, `malformed_pdf` and `unknown_error` mean the PDF couldn't be processed, and `error_message` says why: upload it again or upload another one. | 
**FieldReimportState** | **FieldReimportState** | Whether the fields are being re-imported from this PDF (`reimport_fields` when the PDF was replaced): `requested` while DocSpring processes the PDF, then `imported`, or `no_fields` when the PDF had no fillable fields and the template kept its fields. `none` when no re-import was asked for, or when it couldn't run (the PDF couldn't be processed, or the template was locked or published while it was). | 
**PageCount** | **int** | 0 until the PDF has been processed. | 
**PageProcessingStatuses** | [**List&lt;TemplatePageProcessingStatus&gt;**](TemplatePageProcessingStatus.md) | How processing is going on each page, in page order: its image, and its fields when DocSpring sets them up (`detect_fields` when the template was created). `state` becomes `processed` once every page is done. Empty until DocSpring has read the PDF, and for PDFs uploaded before DocSpring recorded page statuses. | 
**Filename** | **string** | The PDF's file name. | 
**Md5** | **string** | The MD5 hash of the PDF. | 
**ErrorMessage** | **string** | Why the PDF couldn't be processed, and how to fix it. Null unless `state` is an error. | 
**PageDimensions** | **List&lt;List&lt;decimal&gt;&gt;** | Each page's width and height in PDF points. Null until the PDF has been processed. | 
**HasFillableFields** | **bool** | Whether the PDF has fillable form fields. Null until DocSpring has read the PDF. | 
**FieldLogicStatus** | **TemplateFieldLogicStatus** | AI field setup's last step, which reads the whole form once every page is done and can still rename fields and add conditional logic and required fields: `pending` or `processing` until it finishes, then `processed`, `failed` or `skipped`. Null until every page is done, and when there's no logic step to run (`field_logic` is `none`, or the PDF has no fields). | 
**DownloadUrl** | **string** | A temporary link to download the PDF. | 
**PermanentUrl** | **string** | A link to download the PDF that doesn't expire. Null until the PDF has been processed. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

