[@serenity-is/corelib](../README.md) / warningDialog

# Function: warningDialog()

> **warningDialog**(`message`, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Display a warning dialog

## Parameters

### message

`string`

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

## Defined in

[src/base/dialogs.tsx:1084](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1084)
