[@serenity-is/corelib](../README.md) / getColumnsScript

# Function: getColumnsScript()

> **getColumnsScript**(`key`): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/base/scriptdata.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L214)

Loads a `ColumnsScript` bundle for the given key.

## Parameters

### key

`string`

Columns key (usually the row type name, e.g. `"Administration.User"`).

## Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to a [PropertyItemsData](../interfaces/PropertyItemsData.md) containing `items` and `additionalItems` for grid columns.
