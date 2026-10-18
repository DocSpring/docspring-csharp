# DocSpring.Client.Model.CombinePdfsData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**source_pdfs** | **List&lt;Object&gt;** |  | 
**delete_custom_files** | **bool** | Delete the custom files in source_pdfs once the combined PDF has been processed (they&#39;re kept if it fails). Other combined submissions can&#39;t use them after that. A test API token can&#39;t delete custom files. | [optional] 
**expires_in** | **int** |  | [optional] 
**metadata** | **Object** |  | [optional] 
**password** | **string** |  | [optional] 
**test** | **bool** | Deprecated, and has no effect. Combining always uses credits, even with a test API token or watermarked source PDFs. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

