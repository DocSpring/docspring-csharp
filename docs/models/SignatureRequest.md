# DocSpring.Client.Model.SignatureRequest
A request for someone to fill in their fields of a submission and sign it. Someone who only fills in fields for the people who sign later (such as an employer's section) has a signature request too. The submission's PDF is generated once every signature request is completed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The signature request's ID. | 
**SubmissionId** | **string** | The ID of the submission the signature request belongs to. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the signature request, such as an ID from your app. | 
**Role** | **string** | Which of the template's signers the person is. Until templates have roles of their own, a template's signers are `Signer 1`, `Signer 2` and so on, up to `Signer 100`: `Signer 1` is the one whose details the template's `@@signature_requests/0` fields print. | 
**SortOrder** | **int** | The signer's position, from 0: `Signer 1` is 0. The template's `@@signature_requests/&lt;sort_order&gt;` fields print this signature request's details. | 
**State** | **SignatureRequestState** | `pending` until the person completes the signature request (`completed`) or declines it (`declined`). | 
**AuthType** | **SignatureRequestAuthType** | How your app authenticated the person before it showed them the signature request. | 
**AuthSecondFactorType** | **SignatureRequestAuthSecondFactorType** | The second factor your app authenticated them with, if any. | 
**CreatedAt** | **DateTime** | When the signature request was created. | 
**UpdatedAt** | **DateTime** | When the signature request was last updated. | 
**Name** | **string** | The name of the person the request is for. | 
**Email** | **string** | Their email address. | 
**Fields** | **List&lt;string&gt;** | The fields this person fills in. Null for a signature request created with API v1 without a field list: it asks for every field the submission's data doesn't have. | 
**Data** | **Dictionary&lt;string, Object&gt;** | The values this person entered for their own fields (`fields`). Null when their submission's data is left out: in lists without `include_data=true`, in the events of a webhook that leaves out submission data, and once the submission has expired. | 
**ViewedAt** | **DateTime** | When the person first opened the signature request. | 
**CompletedAt** | **DateTime** | When they completed it. | 
**DeclinedAt** | **DateTime** | When they declined it. | 
**AuthProvider** | **string** | The service that authenticated them, such as `google`. Required when `auth_type` is `oauth`. | 
**AuthSessionStartedAt** | **DateTime** | When your app authenticated them. Set for you with `email_link`. | 
**AuthSessionIdHash** | **string** | A hash of your app's session ID, for the audit trail. | 
**AuthUserIdHash** | **string** | Their user ID in your app, or a SHA-256 hash of a salt and the user ID. | 
**AuthUsernameHash** | **string** | Their username in your app, or a SHA-256 hash of a salt and the username. | 
**AuthPhoneNumberHash** | **string** | The phone number they authenticated with, or a SHA-256 hash of a salt and the phone number. | 
**IpAddress** | **string** | The IP address they completed the signature request from. Null in the events of a webhook that leaves out submission data. | 
**UserAgent** | **string** | The User-Agent header of the browser they completed the signature request with. Null in the events of a webhook that leaves out submission data. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

