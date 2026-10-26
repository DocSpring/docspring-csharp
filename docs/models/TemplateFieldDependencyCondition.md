# DocSpring.Client.Model.TemplateFieldDependencyCondition
A condition on a field's value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The name of the field whose value is compared. | 
**Operator** | **TemplateFieldDependencyOperator** | How the field's value is compared with `value`. `in`: one of a list. `range`: from `value` to `range_max`. | 
**Value** | **Object** | The value to compare the field's value with. | [optional] 
**RangeMax** | **Object** | The upper end of a `range`, a number (or a number as a string, as the template editor saves it). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

