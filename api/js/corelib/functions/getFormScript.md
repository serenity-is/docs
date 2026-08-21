[@serenity-is/corelib](../README.md) / getFormScript

# Function: getFormScript()

> **getFormScript**(`key`): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/base/scriptdata.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L223)

Loads a `FormScript` bundle for the given key.

## Parameters

### key

`string`

Form key (usually the row/form type name, e.g. `"Administration.User"`).

## Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to a [PropertyItemsData](../interfaces/PropertyItemsData.md) describing the form fields.
