[@serenity-is/corelib](../README.md) / getLookup

# Function: getLookup()

> **getLookup**\<`TItem`\>(`key`): [`Lookup`](../classes/Lookup.md)\<`TItem`\>

Defined in: [src/compat/scriptdata-compat.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L79)

Synchronously retrieves a lookup by key.
Compat shim for `getLookup`; delegates to `ScriptData.ensure('Lookup.' + key)`.
[DEPRECATED] Prefer `getLookupAsync` or direct `getScriptData` usage. Kept for legacy synchronous callers.

## Type Parameters

### TItem

`TItem`

## Parameters

### key

`string`

Lookup key (e.g., `"Administration.User"`).

## Returns

[`Lookup`](../classes/Lookup.md)\<`TItem`\>

The [Lookup](../classes/Lookup.md) instance for the key.
