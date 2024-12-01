[@serenity-is/corelib](../README.md) / GroupByElement

# Type Alias: GroupByElement\<TItem\>

> **GroupByElement**\<`TItem`\>: `object`

A group item returned by `groupBy()`.

## Type Parameters

• **TItem**

## Type declaration

### items

> **items**: `TItem`[]

the items in the group

### key

> **key**: `string`

key of the group

### order

> **order**: `number`

index of the item in `inOrder` array

### start

> **start**: `number`

index of the first item of this group in the original array

## Defined in

[src/q/arrays-compat.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L43)
