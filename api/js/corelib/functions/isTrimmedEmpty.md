[@serenity-is/corelib](../README.md) / isTrimmedEmpty

# ~~Function: isTrimmedEmpty()~~

> **isTrimmedEmpty**(`s`): `boolean`

Defined in: [src/compat/strings-compat.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L28)

Determines whether a string is `null`, `undefined`, empty, or whitespace-only.

## Parameters

### s

`string`

The string to test; may be `null` or `undefined`.

## Returns

`boolean`

`true` if `s` is `null`/`undefined`, empty, or contains only whitespace.

## Deprecated

Prefer `!s?.trim()` over this shim.
