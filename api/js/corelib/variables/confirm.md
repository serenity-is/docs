[corelib](../README.md) / confirm

# ~~Variable: confirm()~~

> `const` **confirm**: (`message`, `onYes`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `confirmDialog`

Defined in: [src/compat/dialogs-compat.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L7)

Display a confirmation dialog

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

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

## Deprecated

use confirmDialog
