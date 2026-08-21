[@serenity-is/corelib](../README.md) / getColumnsData

# ~~Function: getColumnsData()~~

> **getColumnsData**(`key`): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/compat/scriptdata-compat.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L122)

Synchronously retrieves the full columns data object for a key.
Compat shim for `Q.getColumnsData`; delegates to `ScriptData.ensure('Columns.' + key)`.

## Parameters

### key

`string`

Columns key.

## Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

The [PropertyItemsData](../interfaces/PropertyItemsData.md) containing `items` and related metadata.

## Deprecated

Prefer `getColumnsDataAsync` / `getColumnsScript`.
