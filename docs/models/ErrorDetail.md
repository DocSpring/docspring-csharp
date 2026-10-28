# DocSpring.Client.Model.ErrorDetail
One problem with the request, such as a missing or invalid property.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | What's wrong: `required`, `unknown_property`, `type`, `enum`, `format`, a JSON Schema keyword such as `minLength`, or a DocSpring code. New codes can be added. | 
**Message** | **string** | A human-readable explanation of the problem. | 
**Pointer** | **string** | A JSON pointer to the value in the request body (RFC 6901). An empty string means the whole body. In a submission's `data_errors`, it points into the request that created the submission. | [optional] 
**Parameter** | **string** | The query parameter or header the detail is about. | [optional] 
**SubmissionId** | **string** | For a batch item that failed validation, the ID of the submission recorded for it. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

