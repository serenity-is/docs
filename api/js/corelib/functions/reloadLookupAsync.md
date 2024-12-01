[@serenity-is/corelib](../README.md) / reloadLookupAsync

# Function: reloadLookupAsync()

> **reloadLookupAsync**\<`TItem`\>(`key`): `Promise`\<[`Lookup`](../classes/Lookup.md)\<`TItem`\>\>

Forces reload of a lookup from the server. Note that only the
client side cache is cleared. This does not force reloading in the server-side.

## Type Parameters

• **TItem** = `any`

## Parameters

### key

`string`

Lookup key

## Returns

`Promise`\<[`Lookup`](../classes/Lookup.md)\<`TItem`\>\>

Lookup

## Defined in

[src/base/scriptdata.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L248)
