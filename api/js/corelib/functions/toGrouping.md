[serenity-is/corelib](../README.md) / toGrouping

# Function: toGrouping()

> **toGrouping**\<`TItem`\>(`items`, `getKey`): [`Grouping`](../type-aliases/Grouping.md)\<`TItem`\>

Defined in: [src/compat/arrays-compat.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L179)

Maps an array into a dictionary with keys determined by specified getKey() callback,
and values that are arrays containing elements for a particular key.

## Type Parameters

### TItem

`TItem`

## Parameters

### items

`TItem`[]

Array to map.

### getKey

(`x`) => `any`

Function that returns key for each item.

## Returns

[`Grouping`](../type-aliases/Grouping.md)\<`TItem`\>

Grouping object.

## Example

```ts
toGrouping([1, 2, 3], x => x % 2 == 0 ? "even" : "odd"); // { odd: [1, 3], even: [2] }
```
