[@serenity-is/corelib](../README.md) / isSignalLike

# Function: isSignalLike()

> **isSignalLike**\<`T`\>(`obj`): `obj is SignalLike<T>`

Defined in: [../domwise/dist/index.d.ts:2444](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2444)

A type guard that checks if an object is signal-like, meaning it has `subscribe` and `peek` methods,
and a `value` property.

## Type Parameters

### T

`T` = `any`

## Parameters

### obj

`any`

The object to check.

## Returns

`obj is SignalLike<T>`

`true` if the object is signal-like.
