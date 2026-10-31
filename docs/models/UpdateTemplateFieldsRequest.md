# DocSpring.Client.Model.UpdateTemplateFieldsRequest
The fields to change in the template's draft.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fields** | [**List&lt;FieldInput&gt;**](FieldInput.md) | The changes, each with the `id` of the field it changes. Settings left out keep their values. Changing a shared setting changes it for every field with the same name. Renaming a field moves it to the shared settings of its new name, and conditional logic and formulas that use the old name follow it when no other field has that name. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

