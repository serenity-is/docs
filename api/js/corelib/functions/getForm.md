[@serenity-is/corelib](../README.md) / getForm

# ~~Function: getForm()~~

> **getForm**(`key`): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/compat/scriptdata-compat.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L136)

Synchronously retrieves form metadata for a key.
Compat shim for `Q.getForm`; delegates to `getFormData(key).items`.

## Parameters

### key

`string`

Form key (usually a form type name).

## Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The array of [PropertyItem](../interfaces/PropertyItem.md) form field definitions, or an empty array if not found.

## Deprecated

Prefer `getFormAsync` / `getFormScript` for async loading.
