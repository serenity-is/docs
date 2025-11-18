[@serenity-is/corelib](../README.md) / hasCustomAttribute

# Function: hasCustomAttribute()

> **hasCustomAttribute**\<`TAttr`\>(`type`, `attrType`, `inherit`): `boolean`

Defined in: [src/base/system.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L508)

Get whether a type has a specific custom attribute.

## Type Parameters

### TAttr

`TAttr` *extends* [`CustomAttribute`](../classes/CustomAttribute.md)

## Parameters

### type

`any`

Type to check

### attrType

(...`args`) => `TAttr`

Attribute type to check

### inherit

`boolean` = `true`

Indicates whether to search in base types

## Returns

`boolean`

True if the type has the attribute
