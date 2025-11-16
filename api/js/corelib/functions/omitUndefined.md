[corelib](../README.md) / omitUndefined

# Function: omitUndefined()

> **omitUndefined**(`x`): `any`

Defined in: [src/base/system.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L32)

Omit undefined properties from an object. Does not modify the original object.
This is useful when using Object.assign to avoid overwriting existing values with undefined
just like jQuery $.extend does.

## Parameters

### x

Object to omit undefined properties from

## Returns

`any`

New object without undefined properties
