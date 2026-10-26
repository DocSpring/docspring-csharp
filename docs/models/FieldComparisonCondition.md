# DocSpring.Client.Model.FieldComparisonCondition
A condition comparing a number field's value with a number.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The name of the field whose value is compared. | 
**Operator** | **FieldComparisonOperator** | How the field's value is compared with `value`. `in`: one of a list. `range`: from `value` to `range_max`. | 
**Value** | **Object** | The number the field's value is compared with, or a number as a string (as the template editor saves it). The field must be a number field. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

