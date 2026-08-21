[@serenity-is/corelib](../README.md) / cast

# Function: cast()

> **cast**(`instance`, `type`): `any`

Defined in: [src/compat/system-compat.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L231)

Casts `instance` to `type`, throwing if the instance is not assignable to the target type.

## Parameters

### instance

`any`

The value to cast; `null`/`undefined` is returned as-is.

### type

[`Type`](../type-aliases/Type.md)

The target [Type](../type-aliases/Type.md) to assert.

## Returns

`any`

`instance` typed as the target, if the runtime check passes.

## Throws

Error string when `instance` is not an instance of `type`.
