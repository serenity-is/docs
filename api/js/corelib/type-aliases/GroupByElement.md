[@serenity-is/corelib](../README.md) / GroupByElement

# Type Alias: GroupByElement\<TItem\>

> **GroupByElement**\<`TItem`\> = `object`

Defined in: [src/compat/arrays-compat.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L57)

Single group produced by [groupBy](../functions/groupBy.md).

## Example

```ts
const g = groupBy(users, u => u.department);
g.inOrder[0].key; // department key
```

## Type Parameters

### TItem

`TItem`

Element type of the source array.

## Properties

### items

> **items**: `TItem`[]

Defined in: [src/compat/arrays-compat.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L63)

Elements belonging to this group, in original encounter order.

***

### key

> **key**: `string`

Defined in: [src/compat/arrays-compat.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L61)

Group key as returned by the `getKey` callback (normalized to string).

***

### order

> **order**: `number`

Defined in: [src/compat/arrays-compat.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L59)

Zero-based position of this group in the [GroupByResult.inOrder](GroupByResult.md#inorder) array.

***

### start

> **start**: `number`

Defined in: [src/compat/arrays-compat.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L65)

Index of the first element of this group in the original source array.
