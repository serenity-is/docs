[corelib](../README.md) / isArrayLike

# Function: isArrayLike()

> **isArrayLike**(`obj`): `obj is ArrayLike<any>`

Defined in: [src/base/system.ts:401](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L401)

Check if an object is array-like. An object is considered array-like if it is
not null, is of type object, has a numeric length property and does not have
a nodeType property (to exclude DOM nodes).

## Parameters

### obj

`any`

Object to check

## Returns

`obj is ArrayLike<any>`

True if the object is array-like
