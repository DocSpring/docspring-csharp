# DocSpring.Client.Model.EmailDomain
A domain your email actions can send from once it's verified. Add its DNS records where you manage the domain's DNS: DocSpring checks for them every few minutes, and the domain is verified once its DKIM and DMARC records are found.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The email domain's ID. | 
**Domain** | **string** | The domain name, such as `example.com` or `mail.example.com`. Email actions can send from any address at it. | 
**State** | **EmailDomainState** | `pending` until its DNS records are found, then `verified`. `failed`: its records weren't found within 3 days, or were removed. Verify it again after fixing them. | 
**DkimState** | **EmailDomainRecordState** | Whether the DKIM records were found. | 
**MailFromState** | **EmailDomainRecordState** | Whether the MAIL FROM records were found. They're optional: they let SPF pass for your domain too. | 
**DnsRecords** | [**List&lt;EmailDomainDnsRecord&gt;**](EmailDomainDnsRecord.md) | The DNS records to add to the domain. Empty while DocSpring is still setting the domain up: verify it again in a few minutes to get them. | 
**CreatedAt** | **DateTime** | When the domain was added. | 
**DmarcPolicy** | **string** | The policy (`p=`) of the domain's DMARC record, once it has been found. | 
**LastError** | **string** | Why the domain isn't verified yet, or what to fix. | 
**VerifiedAt** | **DateTime** | When the domain was verified. | 
**CheckedAt** | **DateTime** | When DocSpring last checked the domain's DNS records. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

