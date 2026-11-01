# DocSpring.Client.Model.EmailDomainDnsRecord
A DNS record to add to an email domain.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Purpose** | **EmailDomainDnsRecordPurpose** | What the record is for. `dkim` signs the emails (required), `mail_from` lets SPF pass for your domain (recommended), and `dmarc` tells inboxes what to do with emails that fail these checks (required). | 
**Type** | **DnsRecordType** | The record's type. | 
**Name** | **string** | The record's name. Some DNS hosts add the domain to the end of a name by themselves. | 
**Value** | **string** | The record's value. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

