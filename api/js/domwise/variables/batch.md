[@serenity-is/domwise](../README.md) / batch

# Variable: batch()

> `const` **batch**: \<`T`\>(`fn`) => `T` = `signals.batch`

Defined in: [src/signals.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L55)

Batches multiple signal updates into a single notification.
Re-exported from `@preact/signals-core`.

## Type Parameters

### T

`T`

The return type of the batch function.

## Parameters

### fn

() => `T`

A function that performs batched signal updates.

## Returns

`T`

The return value of `fn`.
