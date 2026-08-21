[@serenity-is/corelib](../README.md) / getRemoteData

# Function: getRemoteData()

> **getRemoteData**\<`TData`\>(`key`): `TData`

Defined in: [src/base/scriptdata.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L253)

Synchronous version of [getRemoteDataAsync](getRemoteDataAsync.md) for legacy compatibility. Blocks the UI thread.

## Type Parameters

### TData

`TData` = `any`

Expected payload type.

## Parameters

### key

`string`

Remote data key.

## Returns

`TData`

The remote data payload.
