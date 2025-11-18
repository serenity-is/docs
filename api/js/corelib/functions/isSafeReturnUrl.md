[@serenity-is/corelib](../README.md) / isSafeReturnUrl

# Function: isSafeReturnUrl()

> **isSafeReturnUrl**(`url`): `boolean`

Defined in: [src/base/html.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L195)

Checks whether a return URL is safe for redirects. Must be relative, start with a single slash,
and contain only allowed characters (no protocol, no backslashes, no control chars, etc).

## Parameters

### url

`string`

## Returns

`boolean`
