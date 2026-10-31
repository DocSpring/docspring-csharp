# DocSpring.Client.Model.UploadPresign
A presigned S3 form for uploading a file. POST `fields` and the file (as `file`, last) to `url` as multipart/form-data. Then use `fields.key` as the `cache_id` when you create a custom file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The S3 URL to upload the file to. | 
**Method** | **UploadMethod** | The HTTP method for the upload. | 
**Fields** | **Dictionary&lt;string, string&gt;** | Form fields to send with the file. Send them all, as they are. `key` is the uploaded file's ID: pass it as `cache_id`. | 
**Headers** | **Dictionary&lt;string, string&gt;** | Headers to send with the upload. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

