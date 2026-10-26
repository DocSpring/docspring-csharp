# DocSpring.Client.Model.FieldDependency
A field's own conditional logic rule: when other fields' values meet its conditions, the field is shown, made required, or both.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **TemplateFieldDependencyAction** | What the rule does to the fields it applies to when its conditions are met. | 
**Conditions** | [**List&lt;TemplateFieldDependencyCondition&gt;**](TemplateFieldDependencyCondition.md) | The conditions on other fields' values. | 
**Match** | **TemplateFieldDependencyMatch** | Whether all of the conditions (the default) or any of them must be met. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

