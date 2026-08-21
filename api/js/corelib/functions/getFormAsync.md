[@serenity-is/corelib](../README.md) / getFormAsync

# Function: getFormAsync()

> **getFormAsync**(`key`): `Promise`\<[`PropertyItem`](../interfaces/PropertyItem.md)[]\>

Defined in: [src/compat/scriptdata-compat.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L146)

Asynchronously retrieves form metadata for a key.
Compat shim for `Q.getFormAsync`; delegates to `getFormScript(key)`.

## Parameters

### key

`string`

Form key.

## Returns

`Promise`\<[`PropertyItem`](../interfaces/PropertyItem.md)[]\>

A promise resolving to the array of [PropertyItem](../interfaces/PropertyItem.md) form field definitions.
