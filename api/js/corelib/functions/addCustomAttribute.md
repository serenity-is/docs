[serenity-is/corelib](../README.md) / addCustomAttribute

# Function: addCustomAttribute()

> **addCustomAttribute**(`type`, `attr`): `void`

Defined in: [src/base/system.ts:469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L469)

Adds a custom attribute to a type. JavaScript does not have built-in support for attributes,
so Serenity uses a customAttributes array on typeInfo to store them. This is used by
decorators and some helper functions to add attributes to classes.

## Parameters

### type

`any`

### attr

[`CustomAttribute`](../classes/CustomAttribute.md)

## Returns

`void`
