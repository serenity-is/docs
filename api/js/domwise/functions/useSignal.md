[@serenity-is/domwise](../README.md) / useSignal

# Function: useSignal()

> **useSignal**\<`T`\>(`initialValue`): [`Signal`](../interfaces/Signal.md)\<`T`\>

Defined in: [src/signals.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L72)

Creates a writable signal with the given initial value.
Convenience wrapper around the `signal()` function.

## Type Parameters

### T

`T`

The type of the signal's value.

## Parameters

### initialValue

`T`

The initial value.

## Returns

[`Signal`](../interfaces/Signal.md)\<`T`\>

A `Signal<T>` instance.
