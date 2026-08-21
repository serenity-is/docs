[@serenity-is/corelib](../README.md) / getColumns

# ~~Function: getColumns()~~

> **getColumns**(`key`): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/compat/scriptdata-compat.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L101)

Synchronously retrieves column metadata for a row/form key.
Compat shim for `Q.getColumns`; delegates to `getColumnsData(key).items`.

## Parameters

### key

`string`

Columns key (usually a row or entity type name).

## Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The array of [PropertyItem](../interfaces/PropertyItem.md) column definitions, or an empty array if not found.

## Deprecated

Prefer `getColumnsAsync` / `getColumnsScript` for async loading. Kept for legacy synchronous callers.
