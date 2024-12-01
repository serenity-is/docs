[@serenity-is/corelib](../README.md) / groupBy

# Function: groupBy()

> **groupBy**\<`TItem`\>(`items`, `getKey`): [`GroupByResult`](../type-aliases/GroupByResult.md)\<`TItem`\>

Groups an array with keys determined by specified getKey() callback.
Resulting object contains group objects in order and a dictionary to access by key.
This is similar to LINQ's ToLookup function with some additional details like start index.

## Type Parameters

• **TItem**

## Parameters

### items

`TItem`[]

Array to group.

### getKey

(`x`) => `any`

Function that returns key for each item.

## Returns

[`GroupByResult`](../type-aliases/GroupByResult.md)\<`TItem`\>

GroupByResult object.

## Defined in

[src/q/arrays-compat.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L70)
