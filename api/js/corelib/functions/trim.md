[@serenity-is/corelib](../README.md) / trim

# ~~Function: trim()~~

> **trim**(`s`): `string`

Defined in: [src/compat/strings-compat.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L95)

Removes leading and trailing whitespace from a string.

## Parameters

### s

`string`

The input string; `null`/`undefined` yields `undefined` (optional-chain semantics).

## Returns

`string`

The trimmed string, or `undefined` if `s` is `null`/`undefined`.

## Deprecated

Use String.prototype.trim directly — this shim exists only for legacy `Q.trim` call sites.
