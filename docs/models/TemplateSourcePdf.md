# DocSpring.Client.Model.TemplateSourcePdf
A template's PDF to merge.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the submission, combined PDF, template or custom file. | 
**Type** | **string** | Must be `template`. | [default to "template"]
**TemplateVersion** | **string** | For a `template` source, the version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` (the newest published version, or the draft when none has been published) or `draft`. Default `latest`. | [optional] 
**Processed** | **bool** | For a `template` source: true (the default) merges the template's processed PDF, which is the PDF submissions are filled in on (decrypted, with its form fields removed). false merges the PDF as it was uploaded. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

