# DocSpring.Client.Model.FieldGroupInput
A group of a template's fields: the fields whose names start with the group's name and a `/`. In submission data, a group is an object, or an array for a list.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The group's name: `address` for the field `address/city`. A list's item numbers are written as `~`, so the fields `items/0/price` and `items/1/price` are in the groups `items` and `items/~`, the list's items. | 
**Title** | **string** | The group's title in the template's data schema and on forms. When it's empty, a title is made from the group's name. | [optional] 
**Description** | **string** | Help text for the group, added to the template's data schema and shown on forms. | [optional] 
**Metadata** | **string** | Text for your own use, added to the template's data schema as `x-metadata`. DocSpring doesn't use it. | [optional] 
**MinItems** | **int** | Lists only (`type` `array`): the fewest items submission data must have. Null for no minimum. | [optional] 
**MaxItems** | **int** | HTML templates' lists only: the most items submission data can have. Null for no limit. A PDF template's list takes as many items as its fields are numbered for, or more with `allow_additional_items`. | [optional] 
**AllowAdditionalItems** | **bool** | PDF templates' lists only: submission data can have more items than the list's fields are numbered for. Default false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

