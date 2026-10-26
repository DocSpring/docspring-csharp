# DocSpring.Client.Model.Folder
A folder of templates. Folders can contain other folders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The folder's ID. | 
**Name** | **string** | The folder's name. It can't contain `/`, and is unique within its parent folder. | 
**Path** | **string** | The path of the folder this folder is in, such as `/Contracts`. `/` for a folder at the root. | 
**CreatedAt** | **DateTime** | When the folder was created. | 
**UpdatedAt** | **DateTime** | When the folder was last updated. | 
**ParentFolderId** | **string** | The ID of the folder this folder is in. Null for a folder at the root. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

