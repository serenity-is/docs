[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / canLoad

# ~~Variable: canLoad()~~

> `const` **canLoad**: (`name`) => `boolean` = `canLoadScriptData`

Defined in: [src/compat/scriptdata-compat.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L14)

Alias for [canLoadScriptData](../../../../functions/canLoadScriptData.md).

Checks whether a dynamic script with the given name is available in the cache or is a registered script name.
Compat shim for the legacy `Q.canLoadScriptData` global; delegates to `peekScriptData` and `getScriptDataHash`.

## Parameters

### name

`string`

Dynamic script name (e.g., `"Lookup.Administration.User"`).

## Returns

`boolean`

`true` if the script is already cached or its hash is registered; otherwise `false`.

## Deprecated

Prefer `peekScriptData` / `getScriptDataHash` checks or `getScriptData` directly.

## Deprecated

Use [canLoadScriptData](../../../../functions/canLoadScriptData.md) or `peekScriptData` / `getScriptDataHash` directly.
