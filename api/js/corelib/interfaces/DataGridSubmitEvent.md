[@serenity-is/corelib](../README.md) / DataGridSubmitEvent

# Interface: DataGridSubmitEvent

Defined in: [src/ui/datagrid/datagrid.tsx:1874](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1874)

Event raised to determine whether the grid view submit should proceed.

## Extends

- [`DataGridEvent`](DataGridEvent.md)

## Properties

### cancel?

> `optional` **cancel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1876)

When true, the submit is cancelled.

***

### dataGrid

> **dataGrid**: [`DataGrid`](../classes/DataGrid.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1862)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)
