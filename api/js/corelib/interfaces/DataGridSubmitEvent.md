[@serenity-is/corelib](../README.md) / DataGridSubmitEvent

# Interface: DataGridSubmitEvent

Defined in: [src/ui/datagrid/datagrid.tsx:1875](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1875)

Event raised to determine whether the grid view submit should proceed.

## Extends

- [`DataGridEvent`](DataGridEvent.md)

## Properties

### cancel?

> `optional` **cancel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1877](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1877)

When true, the submit is cancelled.

***

### dataGrid

> **dataGrid**: [`DataGrid`](../classes/DataGrid.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1863](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1863)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)
