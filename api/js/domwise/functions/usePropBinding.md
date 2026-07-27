[@serenity-is/domwise](../README.md) / usePropBinding

# Function: usePropBinding()

> **usePropBinding**\<`T`\>(`initialValue?`): [`PropBinding`](../interfaces/PropBinding.md)\<`T`\>

Defined in: [src/hooks.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/hooks.ts#L111)

Creates a two-way prop binding hook that synchronizes a value to an element's attribute.
The returned function can be used as a JSX prop hook and automatically assigns the value
to the bound element's property/attribute when it changes.

## Type Parameters

### T

`T`

## Parameters

### initialValue?

Optional initial value for the binding.

`false` | `T` | `null`

## Returns

[`PropBinding`](../interfaces/PropBinding.md)\<`T`\>

A `PropBinding<T>` callable that gets/sets the bound value.
