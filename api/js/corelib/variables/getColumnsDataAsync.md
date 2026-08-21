[@serenity-is/corelib](../README.md) / getColumnsDataAsync

# Variable: getColumnsDataAsync()

> `const` **getColumnsDataAsync**: (`key`) => `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\> = `getColumnsScript`

Defined in: [src/compat/scriptdata-compat.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L127)

Alias for [getColumnsScript](../functions/getColumnsScript.md). Compat shim for `Q.getColumnsDataAsync`.

Loads a `ColumnsScript` bundle for the given key.

## Parameters

### key

`string`

Columns key (usually the row type name, e.g. `"Administration.User"`).

## Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to a [PropertyItemsData](../interfaces/PropertyItemsData.md) containing `items` and `additionalItems` for grid columns.
