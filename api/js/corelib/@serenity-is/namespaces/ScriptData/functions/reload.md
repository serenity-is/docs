[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / reload

# ~~Function: reload()~~

> **reload**\<`TData`\>(`name`, `dynJS?`): `TData`

Defined in: [src/compat/scriptdata-compat.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L44)

Synchronously reloads a dynamic script by clearing its cache and re-ensuring it.

## Type Parameters

### TData

`TData` = `any`

## Parameters

### name

`string`

Dynamic script name.

### dynJS?

`boolean`

When `true`, passed through to the underlying `ensure` call (legacy flag).

## Returns

`TData`

The reloaded script data.

## Deprecated

Prefer `getScriptData(name, true)` or `getScriptDataAsync`. Kept for legacy callers.
