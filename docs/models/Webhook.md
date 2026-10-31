# DocSpring.Client.Model.Webhook
An endpoint that DocSpring sends a POST request to when a subscribed event happens.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The webhook's ID. | 
**Url** | **string** | The endpoint that receives webhook POST requests. | 
**Enabled** | **bool** | Whether DocSpring sends events to the webhook. Webhooks are disabled after repeated failures. | 
**EventTypes** | [**List&lt;WebhookEventType&gt;**](WebhookEventType.md) | The events the webhook subscribes to. A webhook made in the dashboard can also subscribe to API token, account integration and user events, which are listed with their own names. | 
**VarVersion** | **int** | The format of the requests DocSpring sends. Webhooks created with API v2 use 4: each event's `data` is the resource as API v2 returns it. Webhooks made in the dashboard or with API v1 use 3, which has API v1's resources and names (`combined_submission`, `submission_data_request`). Versions 1 and 2 are legacy formats for submission events. | 
**ApiTokenIds** | **List&lt;string&gt;** | Only send events from these API tokens. Combined with the other scope lists using OR. Applies to submission, signature request, combined PDF, submission batch and custom file events. | 
**TemplateIds** | **List&lt;string&gt;** | Only send events for these templates. Combined with the other scope lists using OR. Applies to submission, signature request and template events. | 
**FolderIds** | **List&lt;string&gt;** | Only send events for templates in these folders, including their subfolders. Combined with the other scope lists using OR. Applies to submission, signature request, template and folder events. | 
**IncludeSubmissionData** | **bool** | Include the submission's field data in the payload. When false, the submission's data and truncated_text, and each signature request's data, ip_address and user_agent, are null. | 
**StripFields** | **List&lt;string&gt;** | Dot-separated paths to remove from the event's data object. Form fields live under `data` (`data.ssn` removes the ssn field). A bare name removes a top-level key (`metadata` removes the whole metadata object). | 
**Headers** | **Dictionary&lt;string, string&gt;** | Headers to send with each request. | 
**ConsecutiveFailures** | **int** | How many deliveries in a row have failed. | 
**CreatedAt** | **DateTime** | When the webhook was created. | 
**UpdatedAt** | **DateTime** | When the webhook was last updated. | 
**Name** | **string** | A name for the webhook, shown in the dashboard. | 
**Mode** | **WebhookMode** | Only send events for test or live submissions. Null sends both. | 
**LastFailureAt** | **DateTime** | When a delivery last failed. | 
**DisabledAt** | **DateTime** | When the webhook was disabled. Null while it is enabled. | 
**DisabledReason** | **string** | Why the webhook was disabled, such as after repeated failures. | 
**Secret** | **string** | The key that signs each request (the X-DocSpring-Signature header), so you can check that a request came from DocSpring. Null for some webhooks created before signing existed. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

