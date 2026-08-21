[@serenity-is/corelib](../README.md) / coalesce

# ~~Function: coalesce()~~

> **coalesce**(`a`, `b`): `any`

Defined in: [src/compat/system-compat.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L17)

Returns the first argument if it is not `null`/`undefined`, otherwise the second argument.

## Parameters

### a

`any`

The preferred value; returned when it is not `null`/`undefined`.

### b

`any`

The fallback value returned when `a` is `null`/`undefined`.

## Returns

`any`

`a` if `a != null`, otherwise `b`.

## Deprecated

Use the nullish-coalescing operator `??` directly — e.g. `a ?? b`.
