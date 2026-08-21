[@serenity-is/corelib](../README.md) / cssEscape

# Function: cssEscape()

> **cssEscape**(`selector`): `string`

Defined in: [src/base/html.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L288)

Escapes a string for safe use as a CSS identifier/selector.
Delegates to `CSS.escape` when available; otherwise implements the CSSOM spec polyfill.

## Parameters

### selector

`string`

Raw selector/identifier to escape.

## Returns

`string`

The escaped selector string safe for `querySelector` and CSS rules.
