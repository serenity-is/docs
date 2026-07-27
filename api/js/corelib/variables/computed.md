[@serenity-is/corelib](../README.md) / computed

# Variable: computed()

> `const` **computed**: \<`T`\>(`fn`, `options?`) => [`Computed`](../interfaces/Computed.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2541](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2541)

Creates a computed (derived) signal that re-computes when its dependencies change.
Re-exported from `@preact/signals-core`.

## Type Parameters

### T

`T`

The type of the computed value.

## Parameters

### fn

() => `T`

A computation function that returns the derived value.

### options?

[`SignalOptions`](../interfaces/SignalOptions.md)\<`T`\>

Optional signal options.

## Returns

[`Computed`](../interfaces/Computed.md)\<`T`\>

A read-only `Computed<T>` signal.
