# DocSpring.Client.Model.TemplatePreview
PNG images of a template's pages filled in with data you send (not a PDF), to check how an HTML, PDF or Word template prints with your data before you publish a version or send live data. A preview makes no submission and uses no credits. Its pages are watermarked like a test submission's PDF, and it's deleted an hour after it's created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The preview's ID. | 
**TemplateId** | **string** | The template's ID. | 
**State** | **TemplatePreviewState** | `pending` while it renders (usually a few seconds), then `processed`, or `error` with an `error_message`. | 
**Pages** | [**List&lt;PageImage&gt;**](PageImage.md) | A PNG image of each page once it's processed, in order: `pages[0]` is page 1. A preview has no PDF. Their `download_url`s expire, so get the preview again when you need them. | 
**ExpiresAt** | **DateTime** | When the preview and its images are deleted. | 
**VarVersion** | **string** | The published version that was rendered, such as `1.2.0`. Null for the draft. | 
**ErrorMessage** | **string** | Why the preview couldn't be rendered, such as an error in an HTML or Word template's Liquid, or a value in the data that a field can't print. | 
**PageCount** | **int** | How many pages the template printed, once it's processed. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

