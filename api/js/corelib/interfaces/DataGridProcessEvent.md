[@serenity-is/corelib](../README.md) / DataGridProcessEvent

# Interface: DataGridProcessEvent\<TItem\>

Defined in: [src/ui/datagrid/datagrid.tsx:1894](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1894)

Event raised when the view processes a list response.

## Extends

- [`DataGridEvent`](DataGridEvent.md)

## Type Parameters

### TItem

`TItem`

Row type displayed in the grid.

## Properties

### dataGrid

> **dataGrid**: [`DataGrid`](../classes/DataGrid.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1862)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)

***

### response

> **response**: [`ListResponse`](ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1896](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1896)

The list response being processed.
