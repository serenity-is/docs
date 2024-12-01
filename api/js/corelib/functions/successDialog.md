[@serenity-is/corelib](../README.md) / successDialog

# Function: successDialog()

> **successDialog**(`message`, `onOk`?, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Display a success dialog

## Parameters

### message

`string`

The message to display

### onOk?

() => `void`

Callback for OK button click

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional options.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

## See

MessageDialogOptions

## Example

```ts
successDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

## Defined in

[src/base/dialogs.tsx:1061](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1061)
