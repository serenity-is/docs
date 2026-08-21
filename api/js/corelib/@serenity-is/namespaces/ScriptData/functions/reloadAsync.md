[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / reloadAsync

# ~~Function: reloadAsync()~~

> **reloadAsync**\<`TData`\>(`name`): `Promise`\<`TData`\>

Defined in: [src/compat/scriptdata-compat.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L56)

Asynchronously reloads a dynamic script, bypassing the cache.

## Type Parameters

### TData

`TData` = `any`

## Parameters

### name

`string`

Dynamic script name.

## Returns

`Promise`\<`TData`\>

A promise resolving to the reloaded script data.

## Deprecated

Prefer `getScriptData(name, true)` directly.
