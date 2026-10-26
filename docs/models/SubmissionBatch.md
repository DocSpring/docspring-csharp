# DocSpring.Client.Model.SubmissionBatch
Submissions created together in one request. Their PDFs are only generated when every submission in the batch is valid.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The batch's ID. | 
**State** | **SubmissionBatchState** | `pending` while the PDFs are being generated, then `processed`. `error` as soon as a submission fails, while the others can still be pending: the batch has finished once `processed_at` is set. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the batch, such as an ID from your app. | 
**TotalCount** | **int** | The number of submissions in the request. | 
**PendingCount** | **int** | The submissions whose PDFs haven't been generated yet. | 
**ErrorCount** | **int** | The submissions that were invalid or whose PDFs couldn't be generated. | 
**CompletionPercentage** | **int** | The percentage of the batch's submissions that have finished, from 0 to 100. | 
**Submissions** | [**List&lt;Submission&gt;**](Submission.md) | The batch's submissions, in the order of the request. Their `data` is null unless you pass `include_data=true`. A batch that failed validation only has the submissions that were recorded as `invalid_data`. | 
**CreatedAt** | **DateTime** | When the batch was created. | 
**UpdatedAt** | **DateTime** | When the batch was last updated. | 
**ProcessedAt** | **DateTime** | When every submission had finished. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

