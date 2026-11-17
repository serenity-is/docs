[@serenity-is/corelib](../README.md) / DataGridFilteringEvent

# Interface: DataGridFilteringEvent\<TItem\>

Defined in: [src/ui/datagrid/datagrid.tsx:1884](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1884)

Event raised while filtering items in the view.

## Extends

- [`DataGridEvent`](DataGridEvent.md)

## Type Parameters

### TItem

`TItem` = `any`

Row type displayed in the grid.

## Properties

### dataGrid

> **dataGrid**: [`DataGrid`](../classes/DataGrid.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1863](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1863)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)

***

### isMatch

> **isMatch**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1888](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1888)

Whether the item matches the filter; subscribers may change this.

***

### item

> **item**: `TItem`

Defined in: [src/ui/datagrid/datagrid.tsx:1886](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1886)

The item being filtered.
