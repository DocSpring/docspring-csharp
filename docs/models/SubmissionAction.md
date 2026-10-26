# DocSpring.Client.Model.SubmissionAction
An upload of a PDF to your storage, such as an S3 bucket.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The upload's ID. | 
**State** | **SubmissionActionState** | `pending` until the upload has run, then `processed`. `failed`: your storage rejected it. `error`: it failed in DocSpring. | 
**ActionType** | **SubmissionActionType** | The kind of storage, such as `aws_s3_upload` for an S3 bucket. | 
**ResultData** | **Dictionary&lt;string, Object&gt;** | Where the PDF was uploaded, such as the S3 bucket and key. | 
**IntegrationId** | **string** | The ID of the account integration it used. | 
**ErrorMessage** | **string** | Why the upload failed, when `state` is `failed` or `error`. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

