[@serenity-is/corelib](../README.md) / getCustomAttribute

# Function: getCustomAttribute()

> **getCustomAttribute**\<`TAttr`\>(`type`, `attrType`, `inherit`): `TAttr`

Defined in: [src/base/system.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L485)

Get a custom attribute of a type.

## Type Parameters

### TAttr

`TAttr` *extends* [`CustomAttribute`](../classes/CustomAttribute.md)

## Parameters

### type

`any`

Type to get the attribute from

### attrType

(...`args`) => `TAttr`

Attribute type to get

### inherit

`boolean` = `true`

Indicates whether to search in base types

## Returns

`TAttr`

The custom attribute or null if not found
