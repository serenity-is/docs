[@serenity-is/corelib](../README.md) / success

# ~~Variable: success()~~

> `const` **success**: (`message`, `onOk?`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `successDialog`

Defined in: [src/compat/dialogs-compat.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L29)

Legacy `Q.success` alias.

Displays a success dialog with a single OK button.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Text or renderable content shown in the dialog body.

### onOk?

() => `void`

Optional callback invoked when OK is clicked.

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional [MessageDialogOptions](../interfaces/MessageDialogOptions.md).

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to the native `alert()`).

## Example

```ts
successDialog("Operation complete", () => {
  // do something when OK is clicked
});
```

## Deprecated

Use [successDialog](../functions/successDialog.md) instead.

## See

[successDialog](../functions/successDialog.md)
