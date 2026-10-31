# DocSpring.Client.Model.SignatureRequestToken
A token that opens a signature request without signing in to DocSpring, in a form embedded in your app or from a link you send. Create a token each time you open the form or send a link, rather than storing one to reuse later: its link expires. A signing page that opened before then keeps working for 7 more days, so the person can finish the form later.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The token's ID. | 
**SignatureRequestId** | **string** | The ID of the signature request the token opens. | 
**Type** | **SignatureRequestTokenType** | `api`: the link opens the signature request for 24 hours. `email`: 7 days. | 
**Secret** | **string** | The token's secret. It's only returned when the token is created. | 
**SignatureRequestUrl** | **string** | A link that opens the signature request with this token. | 
**ExpiresAt** | **DateTime** | When the link stops opening the signature request. | 
**CreatedAt** | **DateTime** | When the token was created. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

