[@serenity-is/corelib](../README.md) / alert

# ~~Variable: alert()~~

> `const` **alert**: (`message`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `alertDialog`

Defined in: [src/compat/dialogs-compat.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L8)

Legacy `Q.alert` alias.

Displays a modal alert dialog with a single OK button.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Text or renderable content shown in the dialog body.

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional [MessageDialogOptions](../interfaces/MessageDialogOptions.md).

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to the native `alert()`), whose `result` is `"ok"`.

## Remarks

Falls back to the native `alert()` when neither Bootstrap modal nor jQuery UI dialog is available.

## Example

```ts
alertDialog("An error occurred!");
```

## Deprecated

Use [alertDialog](../functions/alertDialog.md) from `"@serenity-is/corelib"` instead. This re-export is retained for compat with code that imports `Q.alert` / `Serenity.alert`.

## See

[alertDialog](../functions/alertDialog.md)
