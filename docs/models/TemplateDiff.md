# DocSpring.Client.Model.TemplateDiff
What changed in a version of a template since the version before it: the draft since the latest published version, or a published version since the one before it. Fields are compared with all their settings, so `y` is measured from the top of each field's page.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **string** | The template's ID. | 
**Summary** | [**TemplateDiffSummary**](TemplateDiffSummary.md) | How many changes of each kind there are. | 
**Fields** | [**TemplateFieldChanges**](TemplateFieldChanges.md) | The fields that changed. | 
**ChangedSettings** | **List&lt;string&gt;** | The names of the template's settings that changed, as they're named on the Template (`name`, `html`, `defaults`, `expire_after`, ...). Values aren't included, and secrets like `encrypt_pdfs_password` are named when they change. | 
**DocumentChanged** | **bool** | The template's PDF was replaced (or added, when there's no `from_version`). | 
**FromVersion** | **string** | The earlier version, such as `1.1.0`. Null when no version was published before `to_version`: it's compared with a new template, so all of its fields are added. | 
**ToVersion** | **string** | The later version, such as `1.2.0`. Null for the draft. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

