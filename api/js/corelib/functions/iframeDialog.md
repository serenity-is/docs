[@serenity-is/corelib](../README.md) / iframeDialog

# Function: iframeDialog()

> **iframeDialog**(`options`): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

Defined in: [src/base/dialogs.tsx:1245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1245)

Displays a dialog whose content is an `iframe` rendering arbitrary HTML.

## Parameters

### options

[`IFrameDialogOptions`](../interfaces/IFrameDialogOptions.md)

Configuration containing the HTML to display.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

A [Dialog](../classes/Dialog.md) handle (partial when falling back to `alert` without modal support).

## Remarks

Falls back to `window.alert` with sanitized HTML when neither Bootstrap modal nor jQuery UI dialog is available.
