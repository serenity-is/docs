[@serenity-is/corelib](../README.md) / trimToNull

# Function: trimToNull()

> **trimToNull**(`s`): `string`

Defined in: [src/compat/strings-compat.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L113)

Trims leading and trailing whitespace, returning `null` for empty or whitespace-only results.

## Parameters

### s

`string`

The input string; `null`/`undefined` yields `null` directly.

## Returns

`string`

The trimmed string, or `null` if the input is `null`/`undefined` or trims to `""`.
