[serenity-is/corelib](../README.md) / isPromiseLike

# Function: isPromiseLike()

> **isPromiseLike**(`obj`): `obj is PromiseLike<any>`

Defined in: [src/base/system.ts:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L411)

Check if an object is Promise-like, meaning it is either a native Promise
or an object with then and catch methods (like jQuery Deferred).

## Parameters

### obj

`any`

Object to check

## Returns

`obj is PromiseLike<any>`

True if the object is Promise-like
