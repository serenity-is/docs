[serenity-is/corelib](../README.md) / ensureScriptDataSync

# Function: ensureScriptDataSync()

> **ensureScriptDataSync**\<`TData`\>(`name`, `dynJS?`): `TData`

Defined in: [src/base/scriptdata.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L156)

Synchronous version of getScriptData for compatibility. Avoid this one where possible, 
as it will block the UI thread.

## Type Parameters

### TData

`TData` = `any`

## Parameters

### name

`string`

### dynJS?

`boolean`

## Returns

`TData`
