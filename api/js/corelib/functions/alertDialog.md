[@serenity-is/corelib](../README.md) / alertDialog

# Function: alertDialog()

> **alertDialog**(`message`, `options?`): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Defined in: [src/base/dialogs.tsx:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1083)

Displays a modal alert dialog with a single OK button.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Text or renderable content shown in the dialog body.

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional [MessageDialogOptions](../interfaces/MessageDialogOptions.md).

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to the native `alert()`), whose `result` is `"ok"`.

## Remarks

Falls back to the native `alert()` when neither Bootstrap modal nor jQuery UI dialog is available.

## Example

```ts
alertDialog("An error occurred!");
```
