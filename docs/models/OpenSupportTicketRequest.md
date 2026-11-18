# DocSpring.Client.Model.OpenSupportTicketRequest
A problem that blocks the user, a wrong result or a question for the DocSpring team. Never include secrets, credentials or your users' data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | One line, written like an issue title. | 
**Kind** | **SupportReportKind** | What kind of problem this is. | 
**Description** | **string** | What was tried, what was expected and what happened. | 
**Category** | **SupportReportCategory** | The part of DocSpring this is about. | [optional] 
**Impact** | **SupportReportImpact** | `blocked`: the task could not be done. `worked_around`: it was done another way. `friction`: it was only slower. | [optional] 
**Task** | **string** | What the user asked for, in a short phrase. | [optional] 
**RequestIds** | **List&lt;string&gt;** | The request IDs of the requests that went wrong: `error.request_id` in an error response, or any response's `X-Request-Id` header. | [optional] 
**Tool** | **string** | The API operation, MCP tool or CLI command involved. | [optional] 
**Error** | **string** | The exact error text. | [optional] 
**Suggestion** | **string** | What would have helped. | [optional] 
**Source** | **SupportReportSource** | `user`: the user asked for this to be sent. `agent` (the default): an AI agent noticed the problem itself. | [optional] 
**Session** | **string** | A label the sender chooses for its work, such as a session ID, a branch or a task name. When an account runs several agents at once, each can list only the tickets opened with its own label. | [optional] 
**Agent** | [**SupportReportAgent**](SupportReportAgent.md) | The AI agent sending this, as it describes itself. Stored as unverified. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

