[@serenity-is/corelib](../README.md) / warningDialog

# Function: warningDialog()

> **warningDialog**(`message`, `options?`): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Defined in: [src/base/dialogs.tsx:1216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1216)

Displays a warning dialog with a single OK button.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Text or renderable content shown in the dialog body.

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional [MessageDialogOptions](../interfaces/MessageDialogOptions.md).

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to the native `alert()`).

## Example

```ts
warningDialog("Something is odd!");
```
