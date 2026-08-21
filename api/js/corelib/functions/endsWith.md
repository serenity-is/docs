[@serenity-is/corelib](../README.md) / endsWith

# ~~Function: endsWith()~~

> **endsWith**(`s`, `suffix`): `boolean`

Defined in: [src/compat/strings-compat.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L8)

Determines whether a string ends with the specified suffix.

## Parameters

### s

`string`

The string to test.

### suffix

`string`

The suffix to look for at the end of `s`.

## Returns

`boolean`

`true` if `s` ends with `suffix`; otherwise `false`.

## Deprecated

Use String.prototype.endsWith directly — e.g. `s.endsWith(suffix)`.
