# DocSpring.Client.Model.AskSupportHelpRequest
A question about DocSpring. Never include secrets, credentials or your users' data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Question** | **string** | What you want to know, in a sentence or two. For a follow-up question, include what was asked and answered before that matters to it: each request is answered by itself. | 
**Tool** | **string** | The API operation, MCP tool or CLI command involved, if any. | [optional] 
**Error** | **string** | The exact error text, if any. | [optional] 
**Conversation** | [**List&lt;SupportHelpTurn&gt;**](SupportHelpTurn.md) | For a chat: the questions and answers so far, oldest first, when `question` follows on from them. At most 40 turns: start a new conversation after that. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

