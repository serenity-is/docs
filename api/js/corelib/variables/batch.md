[@serenity-is/corelib](../README.md) / batch

# Variable: batch()

> `const` **batch**: \<`T`\>(`fn`) => `T`

Defined in: [../domwise/dist/index.d.ts:2557](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2557)

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
