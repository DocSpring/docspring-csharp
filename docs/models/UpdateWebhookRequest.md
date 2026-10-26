# DocSpring.Client.Model.UpdateWebhookRequest
The settings to change. Properties left out keep their values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A name for the webhook, shown in the dashboard. | [optional] 
**Url** | **string** | The endpoint that receives webhook POST requests. | [optional] 
**Enabled** | **bool** | Whether DocSpring sends events to the webhook. Webhooks are disabled after repeated failures. | [optional] 
**EventTypes** | [**List&lt;WebhookEventType&gt;**](WebhookEventType.md) | The events the webhook subscribes to. A webhook made in the dashboard can also subscribe to API token, account integration and user events, which are listed with their own names. | [optional] 
**Mode** | **WebhookMode** | Only send events for test or live submissions. Null sends both. | [optional] 
**ApiTokenIds** | **List&lt;string&gt;** | Only send events from these API tokens. Combined with the other scope lists using OR. Applies to submission, signature request, combined PDF, submission batch and custom file events. | [optional] 
**TemplateIds** | **List&lt;string&gt;** | Only send events for these templates. Combined with the other scope lists using OR. Applies to submission, signature request and template events. | [optional] 
**FolderIds** | **List&lt;string&gt;** | Only send events for templates in these folders, including their subfolders. Combined with the other scope lists using OR. Applies to submission, signature request, template and folder events. | [optional] 
**IncludeSubmissionData** | **bool** | Include the submission's field data in the payload. When false, the submission's data and truncated_text, and each signature request's data, ip_address and user_agent, are null. | [optional] 
**StripFields** | **List&lt;string&gt;** | Dot-separated paths to remove from the event's data object. Form fields live under `data` (`data.ssn` removes the ssn field). A bare name removes a top-level key (`metadata` removes the whole metadata object). | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Headers to send with each request. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

