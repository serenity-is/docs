[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / ensure

# Variable: ensure()

> `const` **ensure**: \<`TData`\>(`name`, `dynJS?`) => `TData` = `ensureScriptDataSync`

Defined in: [src/compat/scriptdata-compat.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L8)

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
