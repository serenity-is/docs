[@serenity-is/domwise](../README.md) / isWritableSignal

# Function: isWritableSignal()

> **isWritableSignal**\<`T`\>(`obj`): `obj is Signal<T>`

Defined in: [src/signal-util.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signal-util.ts#L28)

A type guard that checks if an object is a writable signal, meaning it passes the `isSignalLike` check
and the `value` property has a setter or is writable.

## Type Parameters

### T

`T`

## Parameters

### obj

`any`

The object to check.

## Returns

`obj is Signal<T>`

`true` if the object is a writable signal.
