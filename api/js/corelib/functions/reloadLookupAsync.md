[@serenity-is/corelib](../README.md) / reloadLookupAsync

# Function: reloadLookupAsync()

> **reloadLookupAsync**\<`TItem`\>(`key`): `Promise`\<[`Lookup`](../classes/Lookup.md)\<`TItem`\>\>

Defined in: [src/base/scriptdata.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L328)

Forces a reload of a lookup from the server, bypassing the client-side cache.
Note this only clears the browser cache entry; it does not invalidate server-side caches.

## Type Parameters

### TItem

`TItem` = `any`

Row type of the lookup items.

## Parameters

### key

`string`

Lookup key to reload.

## Returns

`Promise`\<[`Lookup`](../classes/Lookup.md)\<`TItem`\>\>

A promise resolving to the freshly loaded [Lookup](../classes/Lookup.md).
