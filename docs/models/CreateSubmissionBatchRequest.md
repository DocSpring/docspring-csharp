# DocSpring.Client.Model.CreateSubmissionBatchRequest
The submissions to create, and the settings they share.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Submissions** | [**List&lt;SubmissionInput&gt;**](SubmissionInput.md) | Up to 50 submissions. Each one takes the properties of POST /templates/{template_id}/submissions except `signature_requests`, plus `template_id` and `template_version` when it uses a different template from the batch. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the batch, such as an ID from your app. | [optional] 
**TemplateId** | **string** | The template for each submission that doesn't name its own `template_id`. | [optional] 
**TemplateVersion** | **string** | The template version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` or `draft`. Default `latest` (the draft when no version has been published). | [optional] 
**Test** | **bool** | The default `test` for each submission that doesn't set its own. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

