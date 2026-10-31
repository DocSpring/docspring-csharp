# DocSpring.Client.Model.CombinedPdfSource
A PDF to merge.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **CombinedPdfSourceType** | What the PDF is: a submission's PDF, another combined PDF, a template's PDF, a custom file (POST /custom_files) or a PDF to download from a URL. | 
**Id** | **string** | The ID of the submission, combined PDF, template or custom file. | [optional] 
**Url** | **string** | For a `url` source, the URL to download the PDF from. Removed once the combined PDF has expired. | [optional] 
**TemplateVersion** | **string** | For a `template` source, the version to use: a published version (`1.2.0`, or `1` for the latest 1.x.x), `latest` or `draft`. Default `latest` (the draft when no version has been published). | [optional] 
**Processed** | **bool** | For a `template` source: true (the default) merges the template's processed PDF, which is the PDF submissions are filled in on (decrypted, with its form fields removed). false merges the PDF as it was uploaded. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

