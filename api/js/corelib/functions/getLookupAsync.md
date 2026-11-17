[@serenity-is/corelib](../README.md) / getLookupAsync

# Function: getLookupAsync()

> **getLookupAsync**\<`TItem`\>(`key`): `Promise`\<[`Lookup`](../classes/Lookup.md)\<`TItem`\>\>

Defined in: [src/base/scriptdata.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L246)

Loads a lookup by key.

## Type Parameters

### TItem

`TItem`

Row type of the lookup items.

## Parameters

### key

`string`

Lookup key as registered server-side via `[LookupScript]` (e.g. `"Administration.User"`).

## Returns

`Promise`\<[`Lookup`](../classes/Lookup.md)\<`TItem`\>\>

A promise resolving to the [Lookup](../classes/Lookup.md) instance.
