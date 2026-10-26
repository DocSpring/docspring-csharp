# DocSpring.Client.Model.CustomFile
A PDF you uploaded to merge with other PDFs (POST /combined_pdfs). Get an upload URL with GET /uploads/presign first.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The custom file's ID. | 
**CreatedAt** | **DateTime** | When the custom file was created. | 
**UpdatedAt** | **DateTime** | When the custom file was last updated. | 
**DownloadUrl** | **string** | A temporary link to download the file. | 
**Size** | **int** | The file's size in bytes. | 
**ContentType** | **string** | The file's media type, such as `application/pdf`. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

