# AGENTS.md

Notes for AI coding agents working with the DocSpring C# SDK (`DocSpring.Client`): integrating it into an
app, or working in this repository.

## This code is generated

Every file here is generated from DocSpring's OpenAPI spec by
[DocSpring's fork of OpenAPI Generator](https://github.com/DocSpring/openapi-generator/tree/docspring/all_patches), and each release replaces
all of it. Don't patch an installed copy: the next release overwrites the change. Issues and pull requests are welcome
at https://github.com/DocSpring/docspring-csharp (or email support@docspring.com), and DocSpring makes the fix in the generator so that every release
keeps it.

## Where to look

- [README.md](README.md): install, configuration, an example and how errors and API changes are handled.
- [docs/apis/Client.md](https://github.com/DocSpring/docspring-csharp/blob/main/docs/apis/Client.md): every method, with its parameters and return type.
- [docs/models/](https://github.com/DocSpring/docspring-csharp/tree/main/docs/models): every model and its fields.
- https://docspring.com/docs/llms.txt: DocSpring's documentation for LLMs (`llms-small.txt`, `llms-full.txt`).
- https://docspring.com/docs/: the guides. https://docspring.com/docs/api/: the API reference, with C# code
  for every method.
- https://docspring.com/api-docs/v2/openapi.json: the OpenAPI spec this SDK is generated from.

## Set up

- Credentials come from `DOCSPRING_TOKEN_ID` and `DOCSPRING_TOKEN_SECRET` (an API token from
  https://app.docspring.com/api_tokens). Keep them in the environment or a secret store, never in code. An account in
  the EU region also needs `DOCSPRING_REGION=EU`.
- Call DocSpring from your server. The token secret gives full access to the account, so it must never reach a browser
  or a mobile app. Signers use signing links or the embedded signing form instead (see Signature requests).
- `TestAuthentication` checks the credentials.

## Generate PDFs

- Read a template's data shape before writing the request: `GetTemplateSchema` returns the
  JSON Schema of its submission data (its field names and types), and `GetTemplateModelCode`
  generates typed code for it. The keys of `data` are the template's field names. Date fields take `YYYY-MM-DD`.
- Template IDs look like `tpl_...` and submission IDs like `sub_...`. Store the submission ID with your own record.
- Pass `test: true` while you build: test PDFs are free and watermarked. Live PDFs use credits.
- A submission uses the template's latest published version (its draft when nothing has been published yet). Pass
  `version` (`draft`, `1.2.0`, or `1` for the latest 1.x.x) to use another one.
- `CreateSubmission` waits for the PDF, for up to 95 seconds, and returns the submission in
  its final state: check its `state` (`processed`, or a failure state with an `error_message`). If the PDF takes longer,
  the call fails with a 504 `polling_timeout` error that has the submission's ID. The submission exists and is still
  being made, so don't send the request again (that makes a second one): get it with
  `GetSubmission` until its state isn't `pending`. For slow templates or many PDFs, set
  `wait` to false and use webhooks (https://docspring.com/docs/api-guide/synchronous-requests/).
  `CreateSubmissionBatch` sends up to 50 submissions in one request.
- `files.pdf.download_url` is a temporary link. Keep the submission ID (or `files.pdf.permanent_url`, which needs your
  API token) and get a fresh link when someone downloads the PDF.
- Submission data is often personal data: don't log request or response bodies. `expires_in` deletes a submission's PDF
  and data that many seconds after it's created, and `ExpireSubmission` deletes them now.

## Errors

- Methods return a response object rather than throwing for an error status. `IsCreated`, `IsUnprocessableContent` and the other `Is...` properties say which documented response came back, and `Created()` or `TryCreated(out var result)` give you its body.
- Every error response has one body: `{"error": {"code", "message", "details", "request_id"}}`. Branch on `code`, not
  on the message. Each detail has a `pointer` to the request body value it's about, or the query `parameter`.
- 422 `invalid_data`: the data doesn't match the template. The submission is saved anyway, as `invalid_data`, and the
  error has its `submission_id`.
- 402 `insufficient_credits`: the submission is saved and is made automatically once the account has credits. Don't
  send it again (https://docspring.com/docs/api-guide/credits-and-rate-limits/).
- 429 `rate_limited`: wait for the seconds in the `Retry-After` header, then retry.
- Requests are checked against the API's request schemas before they're sent. A request the API would reject throws a `DocSpring.Client.Client.ValidationException` (an `ArgumentException`), whose `Details` are `ErrorDetail`s with a `Code`, a `Message` and a `Pointer` into the body (or a `Parameter`). Turn the check off with `client.ValidateRequests = false`.

## Webhooks

- Webhooks tell your server when a submission is processed or fails, instead of polling
  (https://docspring.com/docs/webhooks/overview/). A webhook created with API v2 sends events in API v2's format
  (version 4).
- Verify each request's `X-DocSpring-Signature` header before acting on it: an HMAC-SHA256 of `{t}.{raw body}` with the
  webhook's signing secret, where `t` must be within 5 minutes
  (https://docspring.com/docs/webhooks/verifying-signatures/). Pass the raw body exactly as received, not parsed JSON,
  to `DocSpring.Webhooks.VerifyWebhookSignature(payload, signatureHeader, secret)`, which returns true or false.
- No webhook is sent when a submission starts waiting for credits.

## Signature requests

- To have people fill in fields and sign before the PDF is made, create the submission with `signature_requests`. Each
  one has the `fields` its signer fills in (a field belongs to one signature request), and their `name` and `email`.
  The PDF is made when every signer has finished
  (https://docspring.com/docs/api-guide/create-signature-requests/).
- Send a signer to the `signature_request_url` of a token from
  `CreateSignatureRequestToken`. An `api` token's link opens the form for 24 hours and an
  `email` token's for 7 days (`expires_at`), so create a new token when a signer comes back later.
- To show the signing form on your own site, use Signature Requests JS, and add the site's domain to the template's
  Embed Domains (https://docspring.com/docs/guides/embedded-forms/embedded-signature-requests/).

## Responses

- List methods return `data` and `next_cursor`: pass `next_cursor` as `cursor` to get the next page.
- Responses can be newer than this SDK, because DocSpring adds fields and enum values to API v2 without a new
  version. The model leaves out a response field added to the API after this release (models have an `AdditionalProperties` dictionary, but the generated JSON converters don't fill it). Enum values in responses are strings, so a
  value added after this release comes back as it is: handle values you don't recognize.
