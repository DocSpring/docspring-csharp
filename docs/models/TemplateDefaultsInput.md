# DocSpring.Client.Model.TemplateDefaultsInput
The default style of the template's fields. Each field can override it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Typeface** | **Typeface** | The font of text fields. | [optional] 
**FontSize** | **int** | The font size in points, a whole number. | [optional] 
**CharacterSpacing** | **decimal** | Extra space between characters, in points (0 to 50). | [optional] 
**Color** | **string** | The text color, as 6 hex digits without `#`, such as `444444`. | [optional] 
**BackgroundColor** | **string** | The field's background color, as 6 hex digits. | [optional] 
**Bold** | **bool** | Print text in bold. | [optional] 
**Uppercase** | **bool** | Print text in capital letters. | [optional] 
**Alignment** | **TextAlignment** | How text is aligned in its field. `justify` lines up both edges of every line of multiline text except the last of each paragraph. | [optional] 
**Opacity** | **decimal** | The opacity of the field's content, from 0 (invisible) to 1. | [optional] 
**DateFormat** | **string** | How date fields are printed, as a strftime format such as `%m/%d/%Y`. | [optional] 
**DateTimeFormat** | **string** | How date-time fields are printed, as a strftime format such as `%m/%d/%Y %H:%M:%S`. | [optional] 
**CheckColor** | **string** | The color of check marks, as 6 hex digits. | [optional] 
**CheckCharacter** | **CheckCharacter** | The character that a ticked check box prints. | [optional] 
**CheckBackgroundColor** | **string** | The check box's background color, as 6 hex digits. | [optional] 
**RequiredFieldBackgroundColor** | **string** | The background color that highlights required fields on visual forms and signature request forms, as 6 hex digits. PDFs don't print it. | [optional] 
**TrueText** | **string** | The text a boolean field prints for `true`. | [optional] 
**FalseText** | **string** | The text a boolean field prints for `false`. | [optional] 
**ShapeFillColor** | **string** | The fill color of shapes, as 6 hex digits. | [optional] 
**ShapeBorderColor** | **string** | The border color of shapes, as 6 hex digits. | [optional] 
**ShapeBorderWidth** | **int** | The border width of shapes, in whole points (at least 1). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

