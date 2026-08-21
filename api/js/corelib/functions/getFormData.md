[@serenity-is/corelib](../README.md) / getFormData

# ~~Function: getFormData()~~

> **getFormData**(`key`): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/compat/scriptdata-compat.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L157)

Synchronously retrieves the full form data object for a key.
Compat shim for `Q.getFormData`; delegates to `ScriptData.ensure('Form.' + key)`.

## Parameters

### key

`string`

Form key.

## Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

The [PropertyItemsData](../interfaces/PropertyItemsData.md) containing `items` and related metadata.

## Deprecated

Prefer `getFormDataAsync` / `getFormScript`.
