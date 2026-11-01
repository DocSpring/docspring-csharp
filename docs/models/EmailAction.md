# DocSpring.Client.Model.EmailAction
Emails each submission's files (its PDF, and a Word template's Word document and OpenDocument file) to people when the submission has been processed. An email action belongs to a template's draft, or to your account (an account email action, with no `template_id`), which sends for every template or for the templates and folders it lists. Each template can turn an account email action off or change its settings for that template only (`customization`). Email actions email anyone on a paid plan (Starter or higher); without one, they only email your team (test emails, and test submissions). They send from DocSpring's shared address or from one of your verified email domains.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The email action's ID. | 
**TemplateIds** | **List&lt;string&gt;** | For an account email action: the IDs of the templates it sends for. With `folder_ids`, it sends for a template that either list includes. Both empty sends for every template. Always empty for a template's own email action. | 
**FolderIds** | **List&lt;string&gt;** | For an account email action: the IDs of folders whose templates it sends for, including the templates in the folders inside them. Always empty for a template's own email action. | 
**Enabled** | **bool** | Whether it sends emails. DocSpring turns an email action off after 3 days of failed emails, or straight away when one of the addresses in `to`, `cc` or `bcc` (not one from a field or metadata) bounces or marks an email as spam. | 
**To** | **List&lt;string&gt;** | Who gets each email: email addresses, and tags for an address that each submission gives, from one of the template's text or email fields (`{{ data.client_email }}`, or `{{ data["client email"] }}` for a name with spaces) or from its metadata (`{{ metadata.agent_email }}`, or `{{ metadata.agent.email }}` for a value in an object). A tag whose value is blank or isn't a valid address is skipped for that submission, and so is a field an account email action names that the template doesn't have. `{{ signer.email }}` sends each of the submission's signers their own email, to them alone, and everyone else in `to`, `cc` and `bcc` one email together, without the signers. An email needs at least one entry in `to`, `cc` or `bcc`, and at most 10 across them. | 
**Cc** | **List&lt;string&gt;** | Who is copied on each email, as in `to` (but not `{{ signer.email }}`). | 
**Bcc** | **List&lt;string&gt;** | Who is blind-copied on each email, as in `to` (but not `{{ signer.email }}`). | 
**FileFormats** | **EmailActionFileFormats** | Which of the submission's files the email sends: `all` sends every file the submission made (its PDF, and a Word template's Word document and OpenDocument file when it made them), and `docx`, `odt` or `pdf` sends only that file. A submission that made none of them sends nothing, and its email shows as skipped. Only Word templates make Word documents and OpenDocument files, so another template's email action takes `pdf` or `all`. | 
**Delivery** | **EmailActionDelivery** | `attachment` attaches the files, or sends a download link when together they're larger than `max_attachment_mb`. `link` sends a download link, which works for 7 days. Accounts with a BAA start with `link`. | 
**MaxAttachmentMb** | **int** | With `delivery` `attachment`, files larger than this many megabytes in all (1 MB is 1,000,000 bytes) are sent as a download link instead. Emailing a file makes it about 38% larger, and many company mail servers refuse emails over 10 MB, so the default is 7. Raise it only when every recipient's mail server accepts larger emails, such as Microsoft 365 (up to 36 MB) or Gmail (50 MB). | 
**SubmissionType** | **EmailActionSubmissionType** | Which submissions send emails: `live`, `test` or `all`. Test submissions only email your team's members, and skip every other recipient. | 
**FailureNotificationsEnabled** | **bool** | Whether the account's owner gets an email when the email action's emails keep failing. | 
**ConsecutiveFailures** | **int** | How many emails in a row have failed. | 
**CreatedAt** | **DateTime** | When the email action was created. | 
**UpdatedAt** | **DateTime** | When the email action was last changed. | 
**TemplateId** | **string** | The ID of the template it belongs to. Null for an account email action, which sends for many templates. | 
**Name** | **string** | A name for the email action, shown in the dashboard. Null shows its recipients instead. | 
**FromName** | **string** | The sender's name. Null uses your account's name. From DocSpring's shared address, the name is followed by "via DocSpring". | 
**FromAddress** | **string** | The sender's address, at one of your verified email domains. Null sends from DocSpring's shared address. | 
**ReplyTo** | **string** | Where replies go: a team member's email address, or an address at one of your verified email domains. Null sends without a reply address. | 
**Subject** | **string** | The subject line, a Liquid template with the variables `account.name`, `template.name`, `template.id`, `submission.id`, the submission's values as `data.&lt;field name&gt;` (`data["field name"]` for a name with spaces) and its metadata as `metadata.&lt;key&gt;`, such as `Your {{ template.name }}`. Null uses the template's name followed by the file it sends, such as "Lease PDF", or by "files" when it sends several. | 
**Message** | **string** | The email's text, a Liquid template with the same variables as `subject`. `if`, `unless` and `case` tags work. Line breaks are kept. Null uses a short message that says the files are attached or ready to download. | 
**FileName** | **string** | The attached files' name, a Liquid template with the same variables as `subject`, such as `{{ data.last_name }} lease`. Each file's extension (`.pdf`, `.docx` or `.odt`) is added. Null uses the submission's `pdf_filename` metadata when it has one, and otherwise the template's name. A download link's files have the names their other downloads have: the submission's `pdf_filename`, or its ID. | 
**SendWhen** | [**EmailActionConditions**](EmailActionConditions.md) | Sends the email only when the submission's values meet these conditions, which work as a conditional logic rule's do. The values are the ones the PDF has: formulas worked out, and blank for a field that a rule hides. A field the template doesn't have (in an account email action's conditions) counts as blank. A submission that doesn't meet them sends nothing, and its email shows as skipped. Null sends for every submission. | 
**FailingSince** | **DateTime** | When the current run of failures started. Null when the last email was sent. | 
**LastFailureAt** | **DateTime** | When an email last failed. | 
**LastFailureMessage** | **string** | Why the last failed email failed. | 
**DisabledAt** | **DateTime** | When the email action was turned off. Null while it is on. | 
**DisabledReason** | **string** | Why DocSpring turned the email action off, such as after 3 days of failed emails or an address that bounced. | 
**Customization** | [**EmailActionCustomization**](EmailActionCustomization.md) | In a template's list of email actions, its changes to an account email action, or null when it changes nothing. The email action's settings are then the ones it sends for that template. Null everywhere else. | 

[[Back to Model list]](../../README.md#methods) [[Back to API list]](../../README.md#methods) [[Back to README]](../../README.md)

