[@serenity-is/corelib](../README.md) / usePropBinding

# Function: usePropBinding()

> **usePropBinding**\<`T`\>(`initialValue?`): [`PropBinding`](../interfaces/PropBinding.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2354](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2354)

Creates a two-way prop binding hook that synchronizes a value to an element's attribute.
The returned function can be used as a JSX prop hook and automatically assigns the value
to the bound element's property/attribute when it changes.

## Type Parameters

### T

`T`

## Parameters

### initialValue?

Optional initial value for the binding.

`false` | `T`

## Returns

[`PropBinding`](../interfaces/PropBinding.md)\<`T`\>

A `PropBinding<T>` callable that gets/sets the bound value.
