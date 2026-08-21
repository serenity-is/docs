[@serenity-is/corelib](../README.md) / getRemoteDataAsync

# Function: getRemoteDataAsync()

> **getRemoteDataAsync**\<`TData`\>(`key`): `Promise`\<`TData`\>

Defined in: [src/base/scriptdata.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L243)

Loads a `RemoteData` script by key.

## Type Parameters

### TData

`TData` = `any`

Expected payload type.

## Parameters

### key

`string`

Remote data key as registered server-side via `[RemoteDataScript]`.

## Returns

`Promise`\<`TData`\>

A promise resolving to the remote data payload.
