[@serenity-is/corelib](../../../../README.md) / [SubDialogHelper](../README.md) / bindToDataChange

# Function: bindToDataChange()

> **bindToDataChange**(`dialog`, `owner`, `dataChange`, `useTimeout?`): `any`

Defined in: [src/ui/helpers/subdialoghelper.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L20)

Binds a data change handler to a dialog so it is invoked when the dialog
raises a data change event.

## Parameters

### dialog

`any`

The dialog to bind to.

### owner

[`Widget`](../../../../classes/Widget.md)\<`any`\>

The owner widget.

### dataChange

(`ev`) => `void`

The handler invoked on data change.

### useTimeout?

`boolean`

Whether to invoke the handler asynchronously via a timeout.

## Returns

`any`

The dialog.
