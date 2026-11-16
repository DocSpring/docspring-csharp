# DocSpring.Client.Model.SignatureRequestInput
A request for someone to fill in their fields of a submission and sign it. Someone who only fills in fields for the people who sign later (such as an employer's section) has a signature request too. The submission's PDF is generated once every signature request is completed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the person the request is for. | [optional] 
**Email** | **string** | Their email address. Null when they have none. | [optional] 
**Fields** | **List&lt;string&gt;** | The fields this person fills in or signs, besides the ones the template gives their role. A submission's only signature request can leave it out: the person gets every field without a role that `data` doesn't fill in. With two or more signature requests, every required field that `data` doesn't fill in needs a signer, from its role in the template or from a signature request's `fields` (an optional one that nobody is given stays empty). Each field can only be in one signature request, can't be another role's or the sender's, and needs `prefilled_values_editable` when `data` fills it in. A field that the Liquid of an HTML template, a Word template or a page design uses outside its form fields (`{{ name }}`) can only be filled in by the signer who signs first (the only signer, or the only one in the first `signing_step`): their signing page asks them for it before the document is made. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Your own data about the signature request, such as an ID from your app. | [optional] 
**Role** | **string** | Which of the template's signers the person is: one of its roles, by key (`tenant`), or by place (`Signer 1` is the first role). A template without roles has `Signer 1`, `Signer 2` and so on, up to `Signer 100`. Either every signature request has a `role` or none does, and each role can only have one. Without any `role`, the first signature request is the template's first signer, the second its second, and so on. When the template gives its roles names of their own (`Tenant`, not `Signer 1`), two or more signature requests each need a `role`. | [optional] 
**AuthType** | **SignatureRequestAuthType** | How your app authenticated the person before it showed them the signature request. | [optional] 
**AuthSecondFactorType** | **SignatureRequestAuthSecondFactorType** | The second factor your app authenticated them with, if any. | [optional] 
**AuthProvider** | **string** | The service that authenticated them, such as `google`. Required when `auth_type` is `oauth`. | [optional] 
**AuthSessionStartedAt** | **DateTime** | When your app authenticated them. Set for you with `email_link`. | [optional] 
**AuthSessionIdHash** | **string** | A hash of your app's session ID, for the audit trail. | [optional] 
**AuthUserIdHash** | **string** | Their user ID in your app, or a SHA-256 hash of a salt and the user ID. | [optional] 
**AuthUsernameHash** | **string** | Their username in your app, or a SHA-256 hash of a salt and the username. | [optional] 
**AuthPhoneNumberHash** | **string** | The phone number they authenticated with, or a SHA-256 hash of a salt and the phone number. | [optional] 
**IgnoreUnknownFields** | **bool** | Leave out names in `fields` that the template doesn't have, for one field list that you send with several templates. Without it, an unknown name makes the submission `invalid_data`. | [optional] 
**PrefilledValuesEditable** | **bool** | Let the person change the values that `data` already has for their fields. Without it, a field in `fields` that `data` fills in is a 422, and a field of their role that `data` fills in is the sender's. | [optional] 
**SendEmail** | **bool** | Whether DocSpring emails this person their signing link. Default: the submission's `send_email`. Set it to false for someone who signs in your app (embedded signing) or whose link you send yourself. When DocSpring emails them, `email` is required and `auth_type` is `email_link` (the default). Otherwise `auth_type` is required. | [optional] 
**SigningStep** | **int** | When this person signs, with `signing_order: sequential`: everyone in step 1 first, then step 2, and so on. People in the same step sign in any order. Only the order of the numbers matters. Either every signature request has a `signing_step` or none does; without them, each person is a step of their own, in the order of `signature_requests`. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

