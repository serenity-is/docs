[@serenity-is/corelib](../README.md) / getTypeFullName

# Function: getTypeFullName()

> **getTypeFullName**(`type`): `string`

Defined in: [src/base/system.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L99)

Gets the full name of a type including its namespace if any.
Prefers the registered `typeInfo.typeName` when available, otherwise falls back to the function's `name` property.

## Parameters

### type

[`Type`](../type-aliases/Type.md)

Type to get the full name of.

## Returns

`string`

Fully-qualified type name (e.g. `"Serenity.StringEditor"`).
