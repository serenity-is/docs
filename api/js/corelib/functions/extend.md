[@serenity-is/corelib](../README.md) / extend

# ~~Function: extend()~~

> **extend**\<`T`\>(`a`, `b`): `T`

Defined in: [src/compat/system-compat.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L39)

Shallow-copies properties from `b` onto `a`, mutating `a` — equivalent to `Object.assign(a, b)`.

## Type Parameters

### T

`T` = `any`

The common object type.

## Parameters

### a

`T`

The target object to extend (mutated and returned).

### b

`T`

The source object whose own properties are copied onto `a`.

## Returns

`T`

The mutated target object `a`.

## Deprecated

Use Object.assign directly.
