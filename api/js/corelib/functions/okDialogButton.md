[@serenity-is/corelib](../README.md) / okDialogButton

# Function: okDialogButton()

> **okDialogButton**(`opt?`): [`DialogButton`](../interfaces/DialogButton.md)

Defined in: [src/base/dialogs.tsx:733](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L733)

Creates an "OK" dialog button.

## Parameters

### opt?

[`DialogButton`](../interfaces/DialogButton.md)

Optional overrides for [DialogButton](../interfaces/DialogButton.md) properties. Only `text`, `cssClass`, `result`, and `click` are respected; unspecified fields fall back to localized defaults.

## Returns

[`DialogButton`](../interfaces/DialogButton.md)

A [DialogButton](../interfaces/DialogButton.md) with `text` defaulting to `DialogTexts.OkButton`, `cssClass` to `"btn-info"`, and `result` to `"ok"`.

## Example

```ts
new Dialog({ buttons: [okDialogButton({ click: () => save() })] });
```
