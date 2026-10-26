# DocSpring.Client.Model.PageImage
An image of one page of a PDF, a PNG of a submission's page or a JPEG of a template's.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Page** | **int** | The page number, from 1. | 
**Width** | **int** | The image's width in pixels. | 
**Height** | **int** | The image's height in pixels. | 
**Filename** | **string** | The image's file name, such as `sub_123_page_1.png`. | 
**ContentType** | **string** | The image's media type, `image/png` for a submission's pages or `image/jpeg` for a template's. | 
**Size** | **int** | The image's size in bytes. | 
**DownloadUrl** | **string** | A temporary link to download the image. A submission's is null when your account turns off download links for submissions. | 
**PermanentUrl** | **string** | A link to download a submission's image that doesn't expire: it redirects to a new temporary link. It needs your API token or a signed-in session, except for a submission of a template that makes its submissions public. Null for a template's page images. | 
**Sha256** | **string** | The SHA-256 hash of the image. Null for a template's page images. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

