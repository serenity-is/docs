[@serenity-is/corelib](../README.md) / getFormDataAsync

# Variable: getFormDataAsync()

> `const` **getFormDataAsync**: (`key`) => `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\> = `getFormScript`

Defined in: [src/compat/scriptdata-compat.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L162)

Alias for [getFormScript](../functions/getFormScript.md). Compat shim for `Q.getFormDataAsync`.

Loads a `FormScript` bundle for the given key.

## Parameters

### key

`string`

Form key (usually the row/form type name, e.g. `"Administration.User"`).

## Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to a [PropertyItemsData](../interfaces/PropertyItemsData.md) describing the form fields.
