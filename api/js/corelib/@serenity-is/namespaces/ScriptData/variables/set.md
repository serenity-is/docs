[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / set

# ~~Variable: set()~~

> `const` **set**: (`name`, `value`) => `void` = `setScriptData`

Defined in: [src/compat/scriptdata-compat.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L18)

Alias for [setScriptData](../../../../functions/setScriptData.md).

Stores a script data value in the in-memory cache and dispatches a `scriptdatachange.<name>` DOM event.

## Parameters

### name

`string`

Dynamic script name.

### value

`any`

Value to cache (use `undefined` to clear).

## Returns

`void`

## Deprecated

Use `setScriptData` directly.
