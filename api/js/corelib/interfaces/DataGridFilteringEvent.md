[@serenity-is/corelib](../README.md) / DataGridFilteringEvent

# Interface: DataGridFilteringEvent\<TItem\>

Defined in: [src/ui/datagrid/datagrid.tsx:1883](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1883)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1862)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)

***

### isMatch

> **isMatch**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1887)

Whether the item matches the filter; subscribers may change this.

***

### item

> **item**: `TItem`

Defined in: [src/ui/datagrid/datagrid.tsx:1885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1885)

The item being filtered.
