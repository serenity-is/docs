[@serenity-is/corelib](../README.md) / isEmptyOrNull

# ~~Function: isEmptyOrNull()~~

> **isEmptyOrNull**(`s`): `boolean`

Defined in: [src/compat/strings-compat.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L18)

Determines whether a string is `null`, `undefined`, or empty (`""`).

## Parameters

### s

`string`

The string to test; may be `null` or `undefined`.

## Returns

`boolean`

`true` if `s` is `null`/`undefined` or has zero length.

## Deprecated

Prefer a direct falsy check `!s` or `s == null || s.length === 0` over this shim.
