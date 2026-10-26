# DocSpring.Client.Model.SubmissionFiles
A submission's generated files. Each one is left out until it exists.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pdf** | [**GeneratedFile**](GeneratedFile.md) | The submission's PDF. | [optional] 
**AuditTrail** | [**GeneratedFile**](GeneratedFile.md) | The audit trail of a submission with signature requests: who signed, when and how. It's also added to the end of the PDF when the template's `merge_audit_trail_pdf` is on. | [optional] 
**Preview** | [**GeneratedFile**](GeneratedFile.md) | The preview PDF from POST /submissions/{submission_id}/generate_preview, such as for a submission still waiting for its signature requests. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

