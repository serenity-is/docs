[@serenity-is/corelib](../README.md) / success

# ~~Variable: success()~~

> `const` **success**: (`message`, `onOk?`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `successDialog`

Defined in: [src/compat/dialogs-compat.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L13)

Display a success dialog

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

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

## Deprecated

use successDialog
