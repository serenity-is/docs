[@serenity-is/corelib](../README.md) / informationDialog

# Function: informationDialog()

> **informationDialog**(`message`, `onOk`?, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Display an information dialog

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

ConfirmOptions

## Example

```ts
informationDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

## Defined in

[src/base/dialogs.tsx:1035](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1035)
