[@serenity-is/corelib](../README.md) / alertDialog

# Function: alertDialog()

> **alertDialog**(`message`, `options?`): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Defined in: [src/base/dialogs.tsx:984](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L984)

Displays an alert dialog

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

The message to display

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional options.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

## See

AlertOptions

## Example

```ts
alertDialog("An error occured!"); }
```
