# DocSpring.Client.Model.SupportHelp
A question put to DocSpring's AI help, and its answer from DocSpring's documentation. It opens no ticket and reaches no person.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The help request's ID. | 
**State** | **SupportHelpState** | `pending` until there's an answer, then `completed`. `failed`: the question couldn't be answered just now. | 
**Sources** | [**List&lt;SupportHelpSource&gt;**](SupportHelpSource.md) | The documentation pages the answer came from. | 
**Next** | **string** | What to do when the answer doesn't solve the problem, in a sentence for an AI agent to act on. | 
**Answered** | **bool** | Whether the documentation had an answer. Null while `state` is `pending`. | 
**Answer** | **string** | The answer, as plain text. When `answered` is false, what the documentation doesn't cover. Null while `state` is `pending`. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

