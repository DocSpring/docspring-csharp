# DocSpring.Client.Model.UpdateSignatureRequestRequest
The settings to change. Properties left out keep their values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the signature request, such as an ID from your app. | [optional] 
**AuthType** | **SignatureRequestAuthType** | How your app authenticated the person before it showed them the signature request. | [optional] 
**AuthSecondFactorType** | **SignatureRequestAuthSecondFactorType** | The second factor your app authenticated them with, if any. | [optional] 
**AuthProvider** | **string** | The service that authenticated them, such as `google`. Required when `auth_type` is `oauth`. | [optional] 
**AuthSessionStartedAt** | **DateTime** | When your app authenticated them. Set for you with `email_link`. | [optional] 
**AuthSessionIdHash** | **string** | A hash of your app's session ID, for the audit trail. | [optional] 
**AuthUserIdHash** | **string** | Their user ID in your app, or a SHA-256 hash of a salt and the user ID. | [optional] 
**AuthUsernameHash** | **string** | Their username in your app, or a SHA-256 hash of a salt and the username. | [optional] 
**AuthPhoneNumberHash** | **string** | The phone number they authenticated with, or a SHA-256 hash of a salt and the phone number. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

