### 3.1.0 [March 22, 2025]

- Added support for Template Versioning parameters:
  - Optional version parameter in submission requests (e.g., 1.2.3, draft, latest)
  - New API methods: publish_template_version, restore_template_version
  - Updated copy_template and delete_template methods to accept template version strings

### 3.0.1 [February 26, 2025]

- Fixed User-Agent header: docspring-csharp-x.x.x

### 3.0.0 [February 23, 2025]

- **BREAKING CHANGE**: Updated default host to our new synchronous API subdomain: sync.api.docspring.com. (EU customers should use sync.api-eu.docspring.com). Removed all custom polling code from library since this logic is now handled by the API service running on our sync subdomain

### 2.0.0 [Jan 30, 2025]

- Initial support for template versioning (before we decided to release the synchronous API first.)

### 1.4.3 [November 28, 2021]

- Added 'password' parameter to Generate PDF and Combine PDF API endpoints. You can now encrypt each generated PDF with a unique password.

### 1.4.1 [November 19, 2020]

- Added "sort_order" property for Submission Data Requests

### 1.4.0 [September 26, 2020]

- Updated OpenAPI Generator to v3.3.0

### 1.3.1 [September 24, 2020]

- Fixed the "include_data=true" option for the "Get Submission" API endpoint. Added the "data" property to the Submission model so that this is parsed and returned correctly when requested

### 1.3.0 [September 21, 2020]

- Renamed some internal models for template creation API endpoints. (CreateTemplateData / CreateTemplateData1 renamed to CreateHtmlTemplateData and CreateTemplateFromUploadData)

### 1.2.0 [September 12, 2020]

- **BREAKING CHANGE**: Renamed createTemplate operation to createPDFTemplate
- Added createHTMLTemplate operation. (This uses the same API endpoint as createPDFTemplate, but the example shows how to set html, scss, etc. fields)
- Added updateTemplate operation, to update a PDF or HTML template

### 1.1.0 [July 7, 2020]

- Update to use latest API schema

### 1.0.0 [May 20, 2019]

- Renamed FormAPI to DocSpring. (View the CHANGELOG in the original FormAPI API client for prior releases.)
