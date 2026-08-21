[@serenity-is/domwise](../README.md) / useSignal

# Function: useSignal()

> **useSignal**\<`T`\>(`initialValue`): [`Signal`](../interfaces/Signal.md)\<`T`\>

Defined in: [src/signals.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L94)

Creates a writable signal with the given initial value.
Convenience wrapper around [signal](../variables/signal.md).

## Type Parameters

### T

`T`

Type of the signal's value.

## Parameters

### initialValue

`T`

Initial value for the signal.

## Returns

[`Signal`](../interfaces/Signal.md)\<`T`\>

A `Signal<T>` instance.

## Example

```ts
const name = useSignal("Alice");
name.value = "Bob";
```
