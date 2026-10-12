[@serenity-is/corelib](../README.md) / isReadonlySignal

# Function: isReadonlySignal()

> **isReadonlySignal**\<`T`\>(`obj`): `obj is Computed<T>`

Defined in: [../domwise/dist/index.d.ts:2900](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2900)

A type guard that checks if an object is a readonly (computed) signal, meaning it passes the `isSignalLike` check
but the `value` property is not writable.

## Type Parameters

### T

`T` = `any`

## Parameters

### obj

`any`

The object to check.

## Returns

`obj is Computed<T>`

`true` if the object is a readonly signal.
