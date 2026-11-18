# DocSpring.Client.Model.ReplyToSupportTicketRequest
A message to add to the ticket. Never include secrets, credentials or your users' data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | **string** | The message: an answer to the team's question, more detail, or whether their fix worked. Plain text. | 
**Outcome** | **SupportTicketReplyOutcome** | `resolved`: the problem is fixed, so close the ticket. `still_broken`: it isn't, so reopen the ticket. Without it, the reply answers a ticket that was waiting for one and otherwise leaves the status as it is. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

