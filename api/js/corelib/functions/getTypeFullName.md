[serenity-is/corelib](../README.md) / getTypeFullName

# Function: getTypeFullName()

> **getTypeFullName**(`type`): `string`

Defined in: [src/base/system.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L90)

Get the full name of a type (including namespace if any).
This returns the name from typeInfo.typeName if available (e.g. registered via decorators), 
otherwise tries to get the name from function's name property.

## Parameters

### type

[`Type`](../type-aliases/Type.md)

Type to get the name of

## Returns

`string`
