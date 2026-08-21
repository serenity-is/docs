[@serenity-is/corelib](../README.md) / padLeft

# ~~Function: padLeft()~~

> **padLeft**(`s`, `len`, `ch`): `any`

Defined in: [src/compat/strings-compat.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L40)

Pads the string representation of `s` on the left to reach `len` characters.

## Parameters

### s

The value to pad; `null`/`undefined` is treated as an empty string.

`string` | `number`

### len

`number`

The desired total length after padding.

### ch

`string` = `' '`

The character to pad with. Defaults to a single space.

## Returns

`any`

The left-padded string; already-longer strings are returned unchanged.

## Deprecated

Use String.prototype.padStart directly — e.g. `String(s ?? "").padStart(len, ch)`.
