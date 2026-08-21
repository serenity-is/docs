[@serenity-is/corelib](../README.md) / isValue

# ~~Function: isValue()~~

> **isValue**(`a`): `boolean`

Defined in: [src/compat/system-compat.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L27)

Determines whether a value is neither `null` nor `undefined`.

## Parameters

### a

`any`

The value to test.

## Returns

`boolean`

`true` if `a` is not `null` and not `undefined`.

## Deprecated

Use `a != null` (or `a !== null && a !== undefined`) directly.
