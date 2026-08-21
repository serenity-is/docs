[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / addToggleButton

# Function: addToggleButton()

> **addToggleButton**(`toolDiv`, `cssClass`, `callback`, `hint`, `initial?`): `void`

Defined in: [src/ui/helpers/gridutils.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L20)

Adds a toggle button to a toolbar.

## Parameters

### toolDiv

The toolbar element (or array-like of elements).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### cssClass

`string`

The CSS class to add to the button.

### callback

(`p1`) => `void`

Callback invoked with the new pressed state when toggled.

### hint

`string`

The tooltip text for the button.

### initial?

`boolean`

Optional initial pressed state.

## Returns

`void`
