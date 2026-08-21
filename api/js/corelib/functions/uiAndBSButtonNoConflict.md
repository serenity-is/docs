[@serenity-is/corelib](../README.md) / uiAndBSButtonNoConflict

# Function: uiAndBSButtonNoConflict()

> **uiAndBSButtonNoConflict**(): `void`

Defined in: [src/base/dialogs.tsx:683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L683)

Resolves the jQuery UI / Bootstrap button name collision.

## Returns

`void`

## Remarks

When both `$.fn.button` (Bootstrap) and `$.ui.button` (jQuery UI) are present, this moves Bootstrap's implementation to `$.fn.btn` via `noConflict()` so jQuery UI dialogs keep their button widget. Invoked automatically on module load.
