[@serenity-is/corelib](../README.md) / getScriptData

# Function: getScriptData()

> **getScriptData**\<`TData`\>(`name`, `reload?`): `Promise`\<`TData`\>

Defined in: [src/base/scriptdata.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L140)

Returns cached script data if available, otherwise fetches it via `~/DynamicData/` and caches the result.

## Type Parameters

### TData

`TData` = `any`

Expected payload type.

## Parameters

### name

`string`

Dynamic script name.

### reload?

`boolean`

When true, busts the hash cache, clears the in-memory entry and forces a fresh fetch.

## Returns

`Promise`\<`TData`\>

A promise resolving to the script data.
