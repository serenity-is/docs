[@serenity-is/corelib](../README.md) / information

# ~~Variable: information()~~

> `const` **information**: (`message`, `onOk?`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `informationDialog`

Defined in: [src/compat/dialogs-compat.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L22)

Legacy `Q.information` alias.

Displays an informational dialog with a single OK button.

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
informationDialog("Operation complete", () => {
  // do something when OK is clicked
});
```

## Deprecated

Use [informationDialog](../functions/informationDialog.md) instead.

## See

[informationDialog](../functions/informationDialog.md)
