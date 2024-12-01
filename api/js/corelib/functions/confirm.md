[@serenity-is/corelib](../README.md) / confirm

# Function: ~~confirm()~~

> **confirm**(`message`, `onYes`, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

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

## Deprecated

use confirmDialog

## See

ConfirmOptions

## Example

```ts
confirmDialog("Are you sure you want to delete?", () => { 
    // do something when yes is clicked
}
```

## Defined in

[src/q/dialogs-compat.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L7)
