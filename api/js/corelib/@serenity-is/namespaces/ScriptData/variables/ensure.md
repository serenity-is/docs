[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / ensure

# ~~Variable: ensure()~~

> `const` **ensure**: \<`TData`\>(`name`, `dynJS?`) => `TData` = `ensureScriptDataSync`

Defined in: [src/compat/scriptdata-compat.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L16)

Alias for [ensureScriptDataSync](../../../../functions/ensureScriptDataSync.md).

Synchronous (blocking) version of [getScriptData](../../../../functions/getScriptData.md) for legacy compatibility.
Avoid in new code — it performs a synchronous XHR and blocks the UI thread.

## Type Parameters

### TData

`TData` = `any`

Expected payload type.

## Parameters

### name

`string`

Dynamic script name.

### dynJS?

`boolean`

When true loads via `~/DynJS.axd/*.js` and evaluates the returned script instead of JSON. Legacy path only.

## Returns

`TData`

The script data (wrapped as [Lookup](../../../../classes/Lookup.md) for `Lookup.*` keys).

## Throws

If the hook returns a promise in sync mode or the HTTP request fails.

## Deprecated

Use `ensureScriptDataSync` directly.
