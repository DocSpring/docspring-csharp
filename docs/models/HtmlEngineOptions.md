# DocSpring.Client.Model.HtmlEngineOptions
How an HTML template's PDFs are printed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **PageFormat** | The paper size. `Custom` uses `width` and `height`. | 
**Scale** | **decimal** | How much to scale the page, such as `0.8`. `1` prints it at its normal size. | 
**Landscape** | **bool** | Print pages in landscape orientation. | 
**PrintBackground** | **bool** | Print background colors and images. | 
**MarginTop** | **string** | The top margin, with a unit, such as `1in` or `20mm`. | 
**MarginBottom** | **string** | The bottom margin, with a unit. | 
**MarginLeft** | **string** | The left margin, with a unit. | 
**MarginRight** | **string** | The right margin, with a unit. | 
**Width** | **string** | The page width for the `Custom` format, with a unit (`8.5in`, `210mm`). | [optional] 
**Height** | **string** | The page height for the `Custom` format, with a unit. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

