# DocSpring.Client.Model.SignatureRequestInput
A request for someone to fill in their fields of a submission and sign it. Someone who only fills in fields for the people who sign later (such as an employer's section) has a signature request too. The submission's PDF is generated once every signature request is completed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fields** | **List&lt;string&gt;** | The fields this person fills in. Each field can only be in one signature request, and a field that `data` fills in needs `prefilled_values_editable`. | 
**AuthType** | **SignatureRequestAuthType** | How your app authenticated the person before it showed them the signature request. | 
**Name** | **string** | The name of the person the request is for. | [optional] 
**Email** | **string** | Their email address. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the signature request, such as an ID from your app. | [optional] 
**Role** | **string** | Which of the template's signers the person is: `Signer 1`, `Signer 2` and so on, up to `Signer 100`, until templates have roles of their own. Either every signature request has a `role` or none does, and each role can only have one. | [optional] 
**AuthSecondFactorType** | **SignatureRequestAuthSecondFactorType** | The second factor your app authenticated them with, if any. | [optional] 
**AuthProvider** | **string** | The service that authenticated them, such as `google`. Required when `auth_type` is `oauth`. | [optional] 
**AuthSessionStartedAt** | **DateTime** | When your app authenticated them. Set for you with `email_link`. | [optional] 
**AuthSessionIdHash** | **string** | A hash of your app's session ID, for the audit trail. | [optional] 
**AuthUserIdHash** | **string** | Their user ID in your app, or a SHA-256 hash of a salt and the user ID. | [optional] 
**AuthUsernameHash** | **string** | Their username in your app, or a SHA-256 hash of a salt and the username. | [optional] 
**AuthPhoneNumberHash** | **string** | The phone number they authenticated with, or a SHA-256 hash of a salt and the phone number. | [optional] 
**IgnoreUnknownFields** | **bool** | Leave out names in `fields` that the template doesn't have, for one field list that you send with several templates. Without it, an unknown name makes the submission `invalid_data`. | [optional] 
**PrefilledValuesEditable** | **bool** | Let the person change the values that `data` already has for fields in `fields`. Without it, those fields are a 422. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

