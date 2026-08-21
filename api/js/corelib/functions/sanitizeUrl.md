[@serenity-is/corelib](../README.md) / sanitizeUrl

# Function: sanitizeUrl()

> **sanitizeUrl**(`url`): `string`

Defined in: [src/base/html.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L143)

Sanitizes a URL for safe use in `href`/`src` attributes.
Allows `http`, `https`, `mailto`, `ftp`, `tel`, `file`, `sms`, safe relative URLs, and safe `data:` image/video/audio URLs.
Preserves `about:blank` and `javascript:void(0)` idioms; otherwise prefixes unsafe values with `unsafe:`.

## Parameters

### url

`string`

URL string to sanitize; trimmed before validation.

## Returns

`string`

A safe URL string, or `unsafe:<original>` if the input fails validation.

## Example

```ts
sanitizeUrl("javascript:alert(1)"); // "unsafe:javascript:alert(1)"
sanitizeUrl("/app/page?x=1"); // "/app/page?x=1"
```
