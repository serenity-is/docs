[serenity-is/corelib](../README.md) / getNested

# Function: getNested()

> **getNested**(`from`, `name`): `any`

Defined in: [src/base/system.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L51)

Get a nested property from an object. Can be used to get nested properties from global object for example by separating names with dots.

## Parameters

### from

`any`

Object to get the property from

### name

`string`

Name of the property (dot-separated for nested properties)

## Returns

`any`

Value of the property or null if not found
