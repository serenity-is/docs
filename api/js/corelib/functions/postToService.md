[@serenity-is/corelib](../README.md) / postToService

# Function: postToService()

> **postToService**(`options`): `void`

Defined in: [src/compat/services-compat.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L73)

Posts a service request by creating and submitting a hidden form.
Compat shim for `postToService`. Resolves the URL from `options.url` or `options.service`, injects a CSRF token when same-origin, and auto-removes the form after submission.

## Parameters

### options

[`PostToServiceOptions`](../interfaces/PostToServiceOptions.md)

Post options including service/url, request payload, and optional target.
[DEPRECATED] Prefer `serviceCall` / `fetch` with JSON. Kept for legacy file-download and export scenarios that require form POST.

## Returns

`void`
