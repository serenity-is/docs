[@serenity-is/corelib](../README.md) / getColumnsAsync

# Function: getColumnsAsync()

> **getColumnsAsync**(`key`): `Promise`\<[`PropertyItem`](../interfaces/PropertyItem.md)[]\>

Defined in: [src/compat/scriptdata-compat.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L111)

Asynchronously retrieves column metadata for a row/form key.
Compat shim for `Q.getColumnsAsync`; delegates to `getColumnsScript(key)`.

## Parameters

### key

`string`

Columns key.

## Returns

`Promise`\<[`PropertyItem`](../interfaces/PropertyItem.md)[]\>

A promise resolving to the array of [PropertyItem](../interfaces/PropertyItem.md) column definitions.
