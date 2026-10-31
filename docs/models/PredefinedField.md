# DocSpring.Client.Model.PredefinedField
A field name that people using the embedded template editor can choose from, with the data type and settings a field gets when it's given that name.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The field's name, the key of its value in submission data. A `/` nests the key in objects and arrays (`customer/email`, `signers/0/name`). | 
**Type** | **FieldType** | The data type a field gets when it's given this name, as a field's `type`. | 
**DisplayName** | **string** | The name the template editor shows instead of `name`, where a `/` puts it in a folder, such as `Defendant/Name`. Null shows `name`. Two names can't share a display name. | [optional] 
**Title** | **string** | The Title setting a field gets when it's given this name. Null leaves the field's title as it is. | [optional] 
**OptionList** | **string** | String fields only: the values allowed, separated by commas, such as `Yes,No`. Null allows any value. | [optional] 
**RequiredInTemplate** | **bool** | Whether the template must have a field with this name. The embedded editor shows the names that are missing, and with `disableDoneButtonIfPredefinedFieldsMissing` keeps its Done button disabled until the template has them. Default false. | [optional] 
**FieldRequired** | **bool** | The Required setting a field gets when it's given this name. Default true. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

