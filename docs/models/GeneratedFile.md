# DocSpring.Client.Model.GeneratedFile
A file that DocSpring generated, such as a submission's PDF. A file made after its submission was processed is listed while it's being made: check its `state` before using its links.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **GeneratedFileState** | `processed` once the file has been made. `pending` while it's being made, and `error` if it couldn't be made (see `error_message`). | 
**Filename** | **string** | The file's name, such as `sub_123.pdf`. | 
**ContentType** | **string** | The file's media type, such as `application/pdf`. | 
**ErrorMessage** | **string** | Why the file couldn't be made, when `state` is `error`. | 
**DownloadUrl** | **string** | A temporary link to download the file. Null until the file has been made, and when your account turns off download links for submissions. | 
**PermanentUrl** | **string** | A link to download the file that doesn't expire: it redirects to a new temporary link. It needs your API token or a signed-in session, except for a submission of a template that makes its submissions public. Null until the file has been made. | 
**Size** | **int** | The file's size in bytes. Null until the file has been made. | 
**Sha256** | **string** | The SHA-256 hash of the file. Null until the file has been made. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

