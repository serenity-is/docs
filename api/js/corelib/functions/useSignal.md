[@serenity-is/corelib](../README.md) / useSignal

# Function: useSignal()

> **useSignal**\<`T`\>(`initialValue`): [`Signal`](../interfaces/Signal.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2967](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2967)

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
