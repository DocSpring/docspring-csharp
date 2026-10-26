# DocSpring.Client.Model.FieldRangeCondition
A condition on whether a number field's value is in a range.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The name of the field whose value is compared. | 
**Operator** | **string** | Must be `range`. | [default to "range"]
**Value** | **Object** | The lower end of the range, a number (or a number as a string, as the template editor saves it). Null or left out for no lower end. A range needs `value`, `range_max` or both. | [optional] 
**RangeMax** | **Object** | The upper end of the range, a number (or a number as a string, as the template editor saves it). Null or left out for no upper end. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

