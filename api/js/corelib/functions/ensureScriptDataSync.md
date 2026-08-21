[@serenity-is/corelib](../README.md) / ensureScriptDataSync

# Function: ensureScriptDataSync()

> **ensureScriptDataSync**\<`TData`\>(`name`, `dynJS?`): `TData`

Defined in: [src/base/scriptdata.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L163)

Synchronous (blocking) version of [getScriptData](getScriptData.md) for legacy compatibility.
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

The script data (wrapped as [Lookup](../classes/Lookup.md) for `Lookup.*` keys).

## Throws

If the hook returns a promise in sync mode or the HTTP request fails.
