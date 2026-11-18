# DocSpring.Client.Model.SupportMessage
A message on a support ticket.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The message's ID. | 
**Author** | **SupportMessageAuthor** | `reporter`: your side. `team`: a person at DocSpring. `system`: DocSpring itself. | 
**Body** | **string** | The message, as plain text. | 
**CreatedAt** | **DateTime** | When the message was sent. | 
**FirstReadAt** | **DateTime** | When one of the team's messages was first returned by the API. It shows that the message was fetched, not that a person read it. Null for your own messages. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

