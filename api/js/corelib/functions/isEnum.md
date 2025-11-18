[@serenity-is/corelib](../README.md) / isEnum

# Function: isEnum()

> **isEnum**(`type`): `boolean`

Defined in: [src/base/system.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L355)

Check if a type is an enum. A type is considered an enum if it is not a function
and it's [Symbol.typeInfo].typeKind is "enum".

## Parameters

### type

`any`

Type to check

## Returns

`boolean`

True if the type is an enum
