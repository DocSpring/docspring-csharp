# DocSpring.Client.Model.SignatureRequestEvent
Something that happened to a signature request outside DocSpring, for its audit trail: you sent the request to the person (`send_request`). The audit trail shows it as reported by your account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The event's ID. | 
**SubmissionId** | **string** | The ID of the signature request's submission. | 
**SignatureRequestId** | **string** | The ID of the signature request. | 
**EventType** | **SignatureRequestEventType** | What happened. | 
**OccurredAt** | **DateTime** | When it happened. Default now. | 
**CreatedAt** | **DateTime** | When the event was recorded. | 
**MessageType** | **SignatureRequestMessageType** | How you sent the request. Required for `send_request`. | 
**MessageRecipient** | **string** | Where you sent the request, such as an email address or a phone number. Required for `send_request`. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

