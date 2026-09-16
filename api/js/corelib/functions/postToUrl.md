[@serenity-is/corelib](../README.md) / postToUrl

# Function: postToUrl()

> **postToUrl**(`options`): `void`

Defined in: [src/compat/services-compat.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L85)

Posts arbitrary parameters to a URL by creating and submitting a hidden form.
Compat shim for `postToUrl`. Each key in `options.params` becomes a hidden input field.

## Parameters

### options

[`PostToUrlOptions`](../interfaces/PostToUrlOptions.md)

Post options including target URL, params map, and optional target window/frame.
[DEPRECATED] Prefer `fetch` or programmatic form construction. Kept for legacy export / report flows.

## Returns

`void`
