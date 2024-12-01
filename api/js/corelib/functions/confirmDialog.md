[@serenity-is/corelib](../README.md) / confirmDialog

# Function: confirmDialog()

> **confirmDialog**(`message`, `onYes`, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Display a confirmation dialog

## Parameters

### message

`string`

The message to display

### onYes

() => `void`

Callback for Yes button click

### options?

[`ConfirmDialogOptions`](../interfaces/ConfirmDialogOptions.md)

Additional options.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

## See

ConfirmOptions

## Example

```ts
confirmDialog("Are you sure you want to delete?", () => { 
    // do something when yes is clicked
}
```

## Defined in

[src/base/dialogs.tsx:998](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L998)
