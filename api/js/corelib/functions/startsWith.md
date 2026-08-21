[@serenity-is/corelib](../README.md) / startsWith

# ~~Function: startsWith()~~

> **startsWith**(`s`, `prefix`): `boolean`

Defined in: [src/compat/strings-compat.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L56)

Determines whether a string starts with the specified prefix.

## Parameters

### s

`string`

The string to test.

### prefix

`string`

The prefix to look for at the start of `s`.

## Returns

`boolean`

`true` if `s` starts with `prefix`; otherwise `false`.

## Deprecated

Use String.prototype.startsWith directly — e.g. `s.startsWith(prefix)`.
