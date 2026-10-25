[@serenity-is/corelib](../README.md) / getCookie

# Function: getCookie()

> **getCookie**(`name`): `any`

Defined in: [src/base/services.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L52)

Reads a cookie value by name.
Prefers jQuery's `$.cookie` when available, otherwise parses `document.cookie`.

## Parameters

### name

`string`

Cookie name to look up.

## Returns

`any`

The cookie value, or `undefined` / empty string when not found.
