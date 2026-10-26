# DocSpring.Client.Model.PageImages
A PNG image of each page of the submission's PDF (the `png` output format), at 140 DPI: a US Letter page is 1190 x 1540 pixels.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **GeneratedFileState** | `processed` once the images have been made, with the PDF or by POST /submissions/{submission_id}/generate_files. `pending` until then, and `error` if they couldn't be made (see `error_message`). | 
**ErrorMessage** | **string** | Why the images couldn't be made, when `state` is `error`. | 
**PageCount** | **int** | How many pages have an image. Null until the images have been made. | 
**Pages** | [**List&lt;PageImage&gt;**](PageImage.md) | An image of each page, in order: `pages[0]` is page 1. Lists of submissions leave it out (null): get the submission to see them. Empty until the images have been made. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

