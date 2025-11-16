[serenity-is/corelib](../README.md) / warningDialog

# Function: warningDialog()

> **warningDialog**(`message`, `options?`): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Defined in: [src/base/dialogs.tsx:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1105)

Display a warning dialog

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

MessageDialogOptions

## Example

```ts
warningDialog("Something is odd!");
```
