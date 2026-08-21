[@serenity-is/corelib](../../../../README.md) / [GridSelectAllButtonHelper](../README.md) / define

# Function: define()

> **define**(`getGrid`, `getId`, `getSelected`, `setSelected`, `text?`, `onClick?`): [`ToolButton`](../../../../interfaces/ToolButton.md)

Defined in: [src/ui/helpers/gridselectallbuttonhelper.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridselectallbuttonhelper.tsx#L38)

Defines a select-all toolbar button that selects or deselects all items.

## Parameters

### getGrid

() => [`IDataGrid`](../../../../interfaces/IDataGrid.md)

A function that returns the data grid.

### getId

(`p1`) => `any`

A function that returns the id of an item.

### getSelected

(`p1`) => `boolean`

A function that returns whether an item is selected.

### setSelected

(`p1`, `p2`) => `void`

A function that sets the selected state of an item.

### text?

`string`

Optional button title text. Defaults to the "Select All" text.

### onClick?

() => `void`

Optional callback invoked after the selection is updated.

## Returns

[`ToolButton`](../../../../interfaces/ToolButton.md)

The toolbar button definition.
