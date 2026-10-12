[@serenity-is/corelib](../README.md) / isWritableSignal

# Function: isWritableSignal()

> **isWritableSignal**\<`T`\>(`obj`): `obj is Signal<T>`

Defined in: [../domwise/dist/index.d.ts:2893](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2893)

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
