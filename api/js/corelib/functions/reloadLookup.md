[@serenity-is/corelib](../README.md) / reloadLookup

# ~~Function: reloadLookup()~~

> **reloadLookup**\<`TItem`\>(`key`): [`Lookup`](../classes/Lookup.md)\<`TItem`\>

Defined in: [src/compat/scriptdata-compat.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L90)

Synchronously reloads a lookup by key.
Compat shim for `Q.reloadLookup`; delegates to `ScriptData.reload('Lookup.' + key)`.

## Type Parameters

### TItem

`TItem` = `any`

## Parameters

### key

`string`

Lookup key.

## Returns

[`Lookup`](../classes/Lookup.md)\<`TItem`\>

The reloaded [Lookup](../classes/Lookup.md) instance.

## Deprecated

Prefer `reloadLookupAsync` or `getScriptData(key, true)`.
