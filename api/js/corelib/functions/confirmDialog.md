[@serenity-is/corelib](../README.md) / confirmDialog

# Function: confirmDialog()

> **confirmDialog**(`message`, `onYes`, `options?`): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Defined in: [src/base/dialogs.tsx:1124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1124)

Displays a confirmation dialog with Yes / No (and optional Cancel) buttons.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Text or renderable content shown in the dialog body.

### onYes

() => `void`

Callback invoked when the Yes button is clicked.

### options?

[`ConfirmDialogOptions`](../interfaces/ConfirmDialogOptions.md)

Additional [ConfirmDialogOptions](../interfaces/ConfirmDialogOptions.md).

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to the native `confirm()`), whose `result` is `"yes"`, `"no"`, or `"cancel"`.

## Remarks

Falls back to the native `confirm()` when neither Bootstrap modal nor jQuery UI dialog is available.

## Example

```ts
confirmDialog("Are you sure you want to delete?", () => {
  // do something when yes is clicked
});
```
