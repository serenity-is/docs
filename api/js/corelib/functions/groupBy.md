[@serenity-is/corelib](../README.md) / groupBy

# ~~Function: groupBy()~~

> **groupBy**\<`TItem`\>(`items`, `getKey`): [`GroupByResult`](../type-aliases/GroupByResult.md)\<`TItem`\>

Defined in: [src/compat/arrays-compat.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L94)

Groups an array with keys determined by specified getKey() callback.
Resulting object contains group objects in order and a dictionary to access by key.
This is similar to LINQ's ToLookup function with some additional details like start index.

## Type Parameters

### TItem

`TItem`

## Parameters

### items

`TItem`[]

Array to group.
Groups an array by keys derived from each element.

### getKey

(`x`) => `any`

Callback returning the group key for an element; `null`/`undefined` is normalized to `""`.

## Returns

[`GroupByResult`](../type-aliases/GroupByResult.md)\<`TItem`\>

A [GroupByResult](../type-aliases/GroupByResult.md) with `byKey` dictionary and `inOrder` array. Each group records its `order`, `key`, `items`, and `start` index.

## Remarks

Similar to LINQ `ToLookup` with extra `order`/`start` metadata. Uses `Object.create(null)` so prototype keys are safe.

## Deprecated

Kept as a `Q.groupBy` compat shim; for new code consider `Map`-based grouping or `toGrouping`.

## Example

```ts
groupBy([{k:'a'}, {k:'b'}, {k:'a'}], x => x.k).inOrder.length; // 2
```
