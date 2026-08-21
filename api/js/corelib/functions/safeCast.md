[@serenity-is/corelib](../README.md) / safeCast

# Function: safeCast()

> **safeCast**(`instance`, `type`): `any`

Defined in: [src/compat/system-compat.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L245)

Attempts to cast `instance` to `type`, returning `null` on failure instead of throwing.

## Parameters

### instance

`any`

The value to cast.

### type

[`Type`](../type-aliases/Type.md)

The target [Type](../type-aliases/Type.md) to test against.

## Returns

`any`

`instance` if it is an instance of `type`; otherwise `null`.
