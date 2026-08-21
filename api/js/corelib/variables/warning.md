[@serenity-is/corelib](../README.md) / warning

# ~~Variable: warning()~~

> `const` **warning**: (`message`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `warningDialog`

Defined in: [src/compat/dialogs-compat.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L36)

Legacy `Q.warning` alias.

Displays a warning dialog with a single OK button.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Text or renderable content shown in the dialog body.

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional [MessageDialogOptions](../interfaces/MessageDialogOptions.md).

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to the native `alert()`).

## Example

```ts
warningDialog("Something is odd!");
```

## Deprecated

Use [warningDialog](../functions/warningDialog.md) instead.

## See

[warningDialog](../functions/warningDialog.md)
