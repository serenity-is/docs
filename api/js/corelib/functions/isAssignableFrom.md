[@serenity-is/corelib](../README.md) / isAssignableFrom

# Function: isAssignableFrom()

> **isAssignableFrom**(`target`, `fromType`): `any`

Defined in: [src/base/system.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L134)

Check if a type is assignable from another type. A type is
assignable from another type if they are the same or if the other type
is derived from it. This also works for interfaces if they are registered
via registerInterface function or decorators.

## Parameters

### target

`any`

Target type or interface

### fromType

[`Type`](../type-aliases/Type.md)

Type to check assignability from

## Returns

`any`

true if target is assignable from type
