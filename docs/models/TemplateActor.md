# DocSpring.Client.Model.TemplateActor
A user in your account, an API token, or someone using the embedded template editor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TemplateActorType** | `user`: a user in your account, also when they make the change with an app they connected (an OAuth access token). `api`: an API token. `external_user`: someone using the embedded template editor, as identified by your app. | 
**UserId** | **string** | The user's ID, for `user`. | 
**ExternalId** | **string** | The ID your app gave the embedded editor's user, for `external_user`. | 
**Name** | **string** | The user's name, or the name your app gave the embedded editor's user. | 
**Email** | **string** | The email address your app gave the embedded editor's user, for `external_user`. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

