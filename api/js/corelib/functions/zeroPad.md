[@serenity-is/corelib](../README.md) / zeroPad

# Function: zeroPad()

> **zeroPad**(`n`, `len`): `string`

Defined in: [src/compat/strings-compat.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L139)

Left-pads the decimal representation of `n` with `"0"` to reach `len` characters.

## Parameters

### n

`number`

The number to format; `null`/`undefined` yields `""`.

### len

`number`

The desired total length of the resulting string.

## Returns

`string`

The zero-padded string.
