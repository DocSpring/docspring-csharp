# DocSpring.Client.Model.EmailActionCustomization
A template's changes to an account email action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the account email action sends for this template. It also needs to be on itself (`enabled`). | 
**Customized** | [**List&lt;EmailActionSetting&gt;**](EmailActionSetting.md) | The settings this template changes. The others follow the account email action. | 
**ConsecutiveFailures** | **int** | How many of this template's emails in a row have failed because of a setting it changes. | 
**CreatedAt** | **DateTime** | When the template first changed the email action. | 
**UpdatedAt** | **DateTime** | When the template's changes last changed. | 
**FailingSince** | **DateTime** | When the current run of those failures started. | 
**LastFailureAt** | **DateTime** | When one of those emails last failed. | 
**LastFailureMessage** | **string** | Why it failed. | 
**DisabledAt** | **DateTime** | When DocSpring turned the email action off for this template, such as when an address the template added bounced. | 
**DisabledReason** | **string** | Why DocSpring turned it off for this template. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

