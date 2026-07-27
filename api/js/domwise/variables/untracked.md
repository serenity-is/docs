[@serenity-is/domwise](../README.md) / untracked

# Variable: untracked()

> `const` **untracked**: \<`T`\>(`fn`) => `T` = `signals.untracked`

Defined in: [src/signals.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L63)

Reads signal values without creating a dependency tracking context.
Re-exported from `@preact/signals-core`.

## Type Parameters

### T

`T`

The return type of the function.

## Parameters

### fn

() => `T`

A function that reads signals without tracking them.

## Returns

`T`

The return value of `fn`.
