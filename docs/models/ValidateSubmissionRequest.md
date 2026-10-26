# DocSpring.Client.Model.ValidateSubmissionRequest
The submission's data and settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Test** | **bool** | Test PDFs have a watermark and are free. Live PDFs use credits. Submissions made with a test API token are always test submissions. | [optional] 
**Editable** | **bool** | `true` keeps the PDF's text and check fields fillable, and `false` flattens every field. Left out, the template decides: its `editable_submissions` setting, or each field's own Editable option. A response shows the template's setting when the request left this out. Can't be `true` with `signature_requests`. | [optional] 
**Data** | **Dictionary&lt;string, Object&gt;** | The values of the template's fields, by field name. Required for a PDF template, unless `signature_requests` collects the values. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the submission, such as an ID from your app. It isn't printed on the PDF. | [optional] 
**Password** | **string** | A password that the PDF needs to be opened with. It's never returned; `has_password` says if it's set. | [optional] 
**OutputFormats** | [**List&lt;OutputFormat&gt;**](OutputFormat.md) | What the submission makes: `pdf`, and `png` (an image of each page of the PDF, up to 100 pages) when you ask for it. Default `["pdf"]`. POST /submissions/{submission_id}/generate_files adds `png` to a processed submission. | [optional] 
**ExpiresIn** | **int** | Seconds after the PDF is generated until the submission expires, up to 10 years (315360000). Default the template's expiration setting. A submission that isn't processed, such as one with invalid data, is kept for at least 48 hours. | [optional] 
**FieldOverrides** | [**Dictionary&lt;string, FieldOverride&gt;**](FieldOverride.md) | Changes to field settings for this submission only, by field name, such as `{"name": {"required": false, "font_size": 9}}`. A setting that identifies the field (`id`, `name`, `type`), that only the template sets (such as `description`), or that doesn't apply to the field's type and display type (such as `check_character` on a field displayed as text) is a 422. With `signature_requests`, `editable: true` is a 422, and a `default` for a signature or initials field makes the submission `invalid_data`. | [optional] 
**Html** | **string** | For an HTML template, HTML to use instead of the template's. | [optional] 
**Css** | **string** | For an HTML template, CSS to use instead of the template's. | [optional] 
**SignatureRequests** | [**List&lt;SignatureRequestInput&gt;**](SignatureRequestInput.md) | The people who sign the PDF, and fill in their fields first. The PDF is generated once every signature request is completed. PDF templates only. Without `role`s, the first signature request is `Signer 1`, the second `Signer 2`, and so on. To leave a signer out, give every signature request its `role` and leave that one's out. Only the signers sign: a value for a signature or initials field in `data` makes the submission `invalid_data`. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

