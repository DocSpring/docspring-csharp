### 1.13.0 [October 10, 2019]

- Add permanent_download_url attribute to Submission model

### 1.12.0 [October 9, 2019]

- Add parent folder ID and path params to GET template response
- Add parent folder ID param when creating a new template, so you can upload a template into a folder

### 1.11.0 [July 31, 2019]
* Added Create Folder, List Folder, Move to Folder endpoints
* **BREAKING CHANGE** Added parent_folder_id query parameter to "List Templates".

### 1.10.0 [June 22, 2019]

- **BREAKING CHANGE** Renamed "Get Templates" endpoint to "List Templates". Added a search query parameter.

### 1.9.0 [April 11, 2019]

- Added support for editable PDFS (editable: true)

### 1.8.0 [December 23, 2018]

- Added CustomFiles, and combinePdf call to support many different types of source PDFs. Renamed a few models

### 1.7.0 [December 18, 2018]

- Updated API host to api.formapi.io

### 1.6.0 [December 13, 2018]

- Fix model name for newly created Templates (PendingTemplate)
- Added "actions" to submission and combined_submission responses. Includes information about custom S3 uploads

### 1.5.0 [December 1, 2018]

- Added Get Template Schema endpoint

### 1.4.0 [November 22, 2018]

- Added getTemplate(id) and createTemplate endpoints

### 1.3.0 [November 4, 2018]

- Initial changelog
