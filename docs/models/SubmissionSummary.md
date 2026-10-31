# DocSpring.Client.Model.SubmissionSummary
A submission in a list: its template, state, test or live, metadata and timestamps, with its data and files when you ask for them. Get a submission by its ID for its signature requests, uploads and page images.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The submission's ID. | 
**TemplateType** | **TemplateType** | The template's type: `pdf`, `html` or `docx`. | 
**Source** | **SubmissionSource** | `api`: created with the API. `web`: a web form. `reprocess`: a copy of another submission, made to generate its PDF again. | 
**State** | **SubmissionState** | `pending` until the files have been generated, then `processed`. `waiting_for_signature_requests` until every signature request is completed. `insufficient_credits`: waiting for credits; `error_message` says whether the files are generated once you add them. `account_suspended`: waiting for the account to be reactivated, for up to 30 days. Waiting ends in `error` if it's discarded or takes over 30 days. Every other state is final, with no files: `invalid_data` (the data doesn't match the template's fields: see `data_errors`), `declined` (a signature request was declined), and the states where generating the files failed, which have an `error_message`: `syntax_error` (a mistake in an HTML template's Liquid or SCSS, or in a Word template's tags), `image_download_failed` or `image_processing_failed` (an image in the data or the template couldn't be downloaded or read) and `error` (anything else). Older submissions can also be `license_revoked` or `accidental`. | 
**Test** | **bool** | Test PDFs have a watermark and are free. Live PDFs use credits. Submissions made with a test API token are always test submissions. | 
**Editable** | **bool** | `true` keeps the PDF's text and check fields fillable, and `false` flattens every field. Left out, the template decides: its `editable_submissions` setting, or each field's own Editable option. A response shows the template's setting when the request left this out. Can't be `true` with `signature_requests`. | 
**DataErrors** | [**List&lt;ErrorDetail&gt;**](ErrorDetail.md) | Why the data doesn't match the template's fields, when `state` is `invalid_data`: the same details as the 422 response that recorded it, with pointers into the request that created the submission (`/data/name`). Cleared once the submission has expired. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the submission, such as an ID from your app. It isn't printed on the PDF. Two keys also change the PDF: `pdf_filename` names its file (`files.pdf.filename`, and its download), and `pdf_title` is its title in the PDF's document properties (and an HTML template's `&lt;title&gt;`, unless its HTML has one). Without `pdf_title`, the title is the template's name. In `pdf_filename`, a `.pdf` ending is removed, each run of characters other than letters, digits, `-`, `_` and `.` becomes one `_`, and the first 128 characters are kept, then `.pdf` is added. Without it, the file is named after the submission's ID (`sub_1234567890abcdef01.pdf`). | 
**Files** | [**SubmissionFiles**](SubmissionFiles.md) | Empty unless you pass `include_files=true`: then the generated files, as when you get the submission, without the `png` pages' links (`files.png.pages` is null). Get the submission for its page images. | 
**Expired** | **bool** | An expired submission's data, metadata, password and PDF have been deleted. | 
**CreatedAt** | **DateTime** | When the submission was created. | 
**UpdatedAt** | **DateTime** | When the submission was last updated. | 
**TemplateId** | **string** | Null once the template has been permanently deleted. | 
**TemplateVersion** | **string** | The published version of the template the submission used. Null for the draft. | 
**BatchId** | **string** | The ID of the batch the submission was created in. | 
**Data** | **Dictionary&lt;string, Object&gt;** | The submission's data, with the values entered in completed signature requests. Null unless you pass `include_data=true`. Empty once the submission has expired. | 
**ErrorMessage** | **string** | Why the PDF couldn't be generated, when `state` is `error`. | 
**ExpiresAt** | **DateTime** | When the submission expires. Null if it's kept until you delete it. | 
**ProcessedAt** | **DateTime** | When the PDF was generated. Null until then. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

