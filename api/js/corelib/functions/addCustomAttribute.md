[@serenity-is/corelib](../README.md) / addCustomAttribute

# Function: addCustomAttribute()

> **addCustomAttribute**(`type`, `attr`): `void`

Defined in: [src/base/system.ts:489](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L489)

Attaches a custom attribute instance to a type's metadata.
JavaScript has no native attribute support, so Serenity stores attributes on `typeInfo.customAttributes`.

## Parameters

### type

`any`

Target type (class / enum object) to attach the attribute to.

### attr

[`CustomAttribute`](../classes/CustomAttribute.md)

Attribute instance to add.

## Returns

`void`
