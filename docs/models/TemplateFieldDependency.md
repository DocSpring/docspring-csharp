# DocSpring.Client.Model.TemplateFieldDependency
A conditional logic rule: when other fields' values meet its conditions, it shows its target fields, makes them required, or both.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **TemplateFieldDependencyAction** | What the rule does to the fields it applies to when its conditions are met. | 
**Conditions** | [**List&lt;TemplateFieldDependencyCondition&gt;**](TemplateFieldDependencyCondition.md) | The conditions on other fields' values. | 
**Targets** | **List&lt;string&gt;** | The names of the fields the rule shows or makes required. | 
**Match** | **TemplateFieldDependencyMatch** | Whether all of the conditions (the default) or any of them must be met. | [optional] 
**Group** | **string** | Marks a rule made for a field group in the template editor. Its targets outside the group are removed when the template is saved, and the rule is removed once the group has no fields. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

