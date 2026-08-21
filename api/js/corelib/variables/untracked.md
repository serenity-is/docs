[@serenity-is/corelib](../README.md) / untracked

# Variable: untracked()

> `const` **untracked**: \<`T`\>(`fn`) => `T`

Defined in: [../domwise/dist/index.d.ts:2954](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2954)

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
