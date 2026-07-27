[@serenity-is/domwise](../README.md) / computed

# Variable: computed()

> `const` **computed**: \<`T`\>(`fn`, `options?`) => [`Computed`](../interfaces/Computed.md)\<`T`\>

Defined in: [src/signals.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L39)

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
