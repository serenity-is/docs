[@serenity-is/corelib](../../../../README.md) / [SubDialogHelper](../README.md) / bubbleDataChange

# Function: bubbleDataChange()

> **bubbleDataChange**(`dialog`, `owner`, `useTimeout?`): `any`

Defined in: [src/ui/helpers/subdialoghelper.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L68)

Binds a dialog's data change event so it bubbles up to the owner widget.

## Parameters

### dialog

`any`

The dialog to bind to.

### owner

[`Widget`](../../../../classes/Widget.md)\<`any`\>

The owner widget to bubble the event to.

### useTimeout?

`boolean`

Whether to invoke the handler asynchronously via a timeout.

## Returns

`any`

The dialog.
