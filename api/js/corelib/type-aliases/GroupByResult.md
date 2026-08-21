[@serenity-is/corelib](../README.md) / GroupByResult

# Type Alias: GroupByResult\<TItem\>

> **GroupByResult**\<`TItem`\> = `object`

Defined in: [src/compat/arrays-compat.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L73)

Result returned by [groupBy](../functions/groupBy.md).

## Remarks

Provides both dictionary (`byKey`) and ordered (`inOrder`) access to groups.

## Type Parameters

### TItem

`TItem`

Element type of the source array.

## Properties

### byKey

> **byKey**: `object`

Defined in: [src/compat/arrays-compat.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L75)

Dictionary mapping stringified key to its [GroupByElement](GroupByElement.md).

#### Index Signature

\[`key`: `string`\]: [`GroupByElement`](GroupByElement.md)\<`TItem`\>

***

### inOrder

> **inOrder**: [`GroupByElement`](GroupByElement.md)\<`TItem`\>[]

Defined in: [src/compat/arrays-compat.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L77)

Groups in order of first encounter in the source array.
