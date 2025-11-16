[corelib](../README.md) / information

# ~~Variable: information()~~

> `const` **information**: (`message`, `onOk?`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `informationDialog`

Defined in: [src/compat/dialogs-compat.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L10)

Display an information dialog

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

ConfirmOptions

## Example

```ts
informationDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

## Deprecated

use informationDialog
