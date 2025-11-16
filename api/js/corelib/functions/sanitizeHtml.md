[serenity-is/corelib](../README.md) / sanitizeHtml

# Function: sanitizeHtml()

> **sanitizeHtml**(`dirtyHtml`): `string`

Defined in: [src/base/html.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L296)

Sanitizes HTML by removing dangerous elements and attributes.
Need to duplicate basicDomSanitizer logic here as corelib does 
not bundle sleekgrid, and should work standalone with/without 
sleekgrid loaded.

## Parameters

### dirtyHtml

`string`

The HTML string to sanitize.

## Returns

`string`

The sanitized HTML string.
