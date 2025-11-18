[@serenity-is/corelib](../README.md) / getCustomAttributes

# Function: getCustomAttributes()

> **getCustomAttributes**\<`TAttr`\>(`type`, `attrType`, `inherit`): `TAttr`[]

Defined in: [src/base/system.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L519)

Get all custom attributes of a type.

## Type Parameters

### TAttr

`TAttr`

## Parameters

### type

`any`

Type to get the attributes from

### attrType

(...`args`) => `TAttr`

Attribute type to get. If not specified, all attributes are returned.

### inherit

`boolean` = `true`

Indicates whether to search in base types

## Returns

`TAttr`[]

An array of custom attributes
