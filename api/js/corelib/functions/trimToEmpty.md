[@serenity-is/corelib](../README.md) / trimToEmpty

# Function: trimToEmpty()

> **trimToEmpty**(`s`): `string`

Defined in: [src/compat/strings-compat.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L104)

Trims leading and trailing whitespace, coercing `null`/`undefined` to an empty string.

## Parameters

### s

`string`

The input string; `null`/`undefined` is treated as `""`.

## Returns

`string`

The trimmed string, or `""` if the input is `null`/`undefined`.
