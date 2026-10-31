# DocSpring.Client.Model.ErrorInfo
What went wrong.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **ErrorCode** | A machine-readable error code. Clients should handle codes they don't know: new codes can be added. `invalid_data`: a submission's data doesn't match its template's fields. The submission is still recorded. `insufficient_credits` (402): your credit balance can't cover a live PDF. The record was saved and waits for credits in the `insufficient_credits` state: its ID is in `submission_id`, `submission_batch_id` or `combined_pdf_id`. `upgrade_required` (403): your plan doesn't include this, such as more templates, another active integration (webhooks count) or the embedded template editor. `account_suspended` (403): the account is suspended, so it can't create submissions. `polling_timeout`: on a sync.api host, the files weren't ready in time. The record was created and is still being processed: its ID is in `submission_id`, `submission_batch_id`, `combined_pdf_id` or `template_id`. Without one of these IDs, the request itself got no answer in time, and the record may or may not have been created. `idempotency_key_in_use` (409): a request with the same Idempotency-Key is still being processed. Send the request again in a few seconds; when the first request has already created its record, its ID is in `submission_id`, `submission_batch_id` or `combined_pdf_id`. `idempotency_key_reused` (422): the Idempotency-Key was already used for a different request. | 
**Message** | **string** | A human-readable explanation, safe to show to developers. | 
**Details** | [**List&lt;ErrorDetail&gt;**](ErrorDetail.md) | What was wrong with each part of the request. Empty when the error isn't about one part of it. | 
**RequestId** | **string** | The ID of the request. Include it when you contact support. | 
**SubmissionId** | **string** | When a submission's data fails validation, the submission is still recorded (state `invalid_data`) so you can see it in the dashboard. This is its ID. With `insufficient_credits`, the submission that waits for credits. With `polling_timeout` or `idempotency_key_in_use`, the submission that's still being processed. | [optional] 
**SubmissionBatchId** | **string** | The ID of the recorded batch, when items in a batch fail validation. With `insufficient_credits`, the batch whose submissions wait for credits. With `polling_timeout` or `idempotency_key_in_use`, the batch that's still being processed. | [optional] 
**CombinedPdfId** | **string** | With `insufficient_credits`, the combined PDF that waits for credits. With `polling_timeout` or `idempotency_key_in_use`, the combined PDF that's still being processed. | [optional] 
**TemplateId** | **string** | With `polling_timeout`, the template whose PDF is still being processed. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

