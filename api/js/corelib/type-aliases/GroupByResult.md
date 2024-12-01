[@serenity-is/corelib](../README.md) / GroupByResult

# Type Alias: GroupByResult\<TItem\>

> **GroupByResult**\<`TItem`\>: `object`

Return type of the `groupBy` function.

## Type Parameters

• **TItem**

## Type declaration

### byKey

> **byKey**: `object`

#### Index Signature

 \[`key`: `string`\]: [`GroupByElement`](GroupByElement.md)\<`TItem`\>

### inOrder

> **inOrder**: [`GroupByElement`](GroupByElement.md)\<`TItem`\>[]

## Defined in

[src/q/arrays-compat.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L57)
