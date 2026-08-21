[@serenity-is/corelib](../README.md) / toGrouping

# ~~Function: toGrouping()~~

> **toGrouping**\<`TItem`\>(`items`, `getKey`): [`Grouping`](../type-aliases/Grouping.md)\<`TItem`\>

Defined in: [src/compat/arrays-compat.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L214)

Groups an array into a dictionary keyed by `getKey`.

## Type Parameters

### TItem

`TItem`

## Parameters

### items

`TItem`[]

Array to group.

### getKey

(`x`) => `any`

Callback returning the group key for an element; `null`/`undefined` is normalized to `""`.

## Returns

[`Grouping`](../type-aliases/Grouping.md)\<`TItem`\>

A [Grouping](../type-aliases/Grouping.md) dictionary whose values are arrays of matching elements. Uses a null-prototype object.

## Remarks

Lighter alternative to [groupBy](groupBy.md) when ordered metadata is not needed.

## Deprecated

Retained as a `Q.toGrouping` compat shim; new code may prefer `Map`-grouping.

## Example

```ts
toGrouping([1, 2, 3], x => x % 2 == 0 ? "even" : "odd"); // { odd: [1, 3], even: [2] }
```
