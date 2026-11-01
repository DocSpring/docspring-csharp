# DocSpring.Client.Model.CreateSubmissionBatchRequest
The submissions to create, and the settings they share.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Submissions** | [**List&lt;SubmissionInput&gt;**](SubmissionInput.md) | Up to 50 submissions. Each one takes the properties of POST /templates/{template_id}/submissions except `signature_requests` and the options for DocSpring's emails to signers (`send_email`, `signing_order`, `email_subject`, `email_message`, `cc`, `reply_to`, `notification_emails`, `notify_when_signed` and `reminders`), plus `template_id` and `template_version` when it uses a different template from the batch. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the batch, such as an ID from your app. | [optional] 
**TemplateId** | **string** | The template for each submission that doesn't name its own `template_id`. | [optional] 
**TemplateVersion** | **string** | The template version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `latest`. | [optional] 
**Test** | **bool** | The default `test` for each submission that doesn't set its own. | [optional] 
**OutputFormats** | [**List&lt;OutputFormat&gt;**](OutputFormat.md) | The default `output_formats` for each submission that doesn't set its own. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

