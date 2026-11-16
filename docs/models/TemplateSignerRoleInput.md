# DocSpring.Client.Model.TemplateSignerRoleInput
One of a template's signer roles: someone who fills in or signs its fields.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The role's name, such as Tenant, which the template editor shows. Each role has its own, and `Signer N` can only be role N's. | 
**Id** | **string** | The role's ID, which never changes: fields refer to their role by it, so changing the role's key or name, or moving it in the list, keeps its fields. Leave it out for a new role. A role keeps the ID you give it, so roles copied from another template with their IDs keep the fields copied with them. | [optional] 
**Key** | **string** | The role's name in the API and in the template's code, in snake_case: `role: tenant` on a field tag, a field's `signer_role`, a signature request's `role`, and `@@signature_requests/tenant/...` fields. Each role has its own, and `sender` is taken (it marks the fields that submission data fills in). Left out, it's made from `name`: Co-tenant 2 is `co_tenant_2`. | [optional] 
**NameExpression** | **string** | The signer's name, for a signature request that doesn't give one: a fixed name, or text and `{{ variables }}` that name a path into the submission's data, such as `{{ tenant.name }}` or `{{ tenant.first_name }} {{ tenant.last_name }}`. No filters or tags. Each variable is one of the template's fields, unless the template allows additional properties: setting one that isn't is a `422`. A value the data doesn't have prints nothing, and a name that comes out blank is left out. Null for none. | [optional] 
**EmailExpression** | **string** | The signer's email address, for a signature request that doesn't give one: a fixed address, such as `leasing@example.com`, or one from the submission's data, written like `name_expression`: `{{ tenant.email }}`. The data has to have the value, so it's one of the template's fields (one the sender fills in) or the template allows additional properties: setting a variable that isn't a field is a `422` otherwise. Null for none. | [optional] 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

