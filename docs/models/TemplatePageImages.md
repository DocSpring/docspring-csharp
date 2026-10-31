# DocSpring.Client.Model.TemplatePageImages
A JPEG image of each page of a PDF template's PDF, at 140 DPI (a US Letter page is 1190 x 1540 pixels), to see the pages that fields are placed on. The template's `document.page_dimensions` gives each page's size in PDF points. Fields are placed in units where every page is 2480 wide: to place a field at a point on an image, multiply the point's pixel coordinates by 2480 and divide them by the image's `width`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **string** | The template's ID. | 
**PageCount** | **int** | How many pages the PDF has. | 
**Pages** | [**List&lt;PageImage&gt;**](PageImage.md) | An image of each page, in order: `pages[0]` is page 1. Their `download_url`s expire, so get them again when you need them. | 
**VarVersion** | **string** | The published version the images are of, such as `1.2.0`. Null for the draft. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

