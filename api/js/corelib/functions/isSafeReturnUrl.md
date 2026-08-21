[@serenity-is/corelib](../README.md) / isSafeReturnUrl

# Function: isSafeReturnUrl()

> **isSafeReturnUrl**(`url`): `boolean`

Defined in: [src/base/html.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L232)

Checks whether a return URL is safe for redirects.
A safe URL must be a relative path starting with exactly one `/`, contain no protocol (`:`), backslashes, control characters, or `//` after the leading slash, and use only `\w`, `-`, `.`, `/`, `?`, `&`, `=`, `%` characters.

## Parameters

### url

`string`

Candidate return URL to validate.

## Returns

`boolean`

`true` if the URL is safe to use as a redirect target, `false` otherwise.
