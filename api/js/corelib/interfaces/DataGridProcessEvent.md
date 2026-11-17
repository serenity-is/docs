[@serenity-is/corelib](../README.md) / DataGridProcessEvent

# Interface: DataGridProcessEvent\<TItem\>

Defined in: [src/ui/datagrid/datagrid.tsx:1895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1895)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1863](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1863)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)

***

### response

> **response**: [`ListResponse`](ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1897](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1897)

The list response being processed.
