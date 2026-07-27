[@serenity-is/domwise](../README.md) / isSignalLike

# Function: isSignalLike()

> **isSignalLike**\<`T`\>(`obj`): `obj is SignalLike<T>`

Defined in: [src/signal-util.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signal-util.ts#L10)

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
