[@serenity-is/corelib](../README.md) / IDataGrid

# Interface: IDataGrid

Defined in: [src/ui/datagrid/idatagrid.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/idatagrid.ts#L9)

Abstraction for data grids that expose the root element, underlying SlickGrid
instance, remote view, and filter store.

## Methods

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/idatagrid.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/idatagrid.ts#L14)

Returns the root DOM element of the grid widget.

#### Returns

`HTMLElement`

The grid container element.

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](../classes/FilterStore.md)

Defined in: [src/ui/datagrid/idatagrid.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/idatagrid.ts#L29)

Returns the filter store owned by the grid.

#### Returns

[`FilterStore`](../classes/FilterStore.md)

The current [FilterStore](../classes/FilterStore.md) instance.

***

### getGrid()

> **getGrid**(): `ISleekGrid`

Defined in: [src/ui/datagrid/idatagrid.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/idatagrid.ts#L19)

Returns the underlying SlickGrid / SleekGrid instance.

#### Returns

`ISleekGrid`

The grid instance used for rendering and interaction.

***

### getView()

> **getView**(): [`IRemoteView`](IRemoteView.md)\<`any`\>

Defined in: [src/ui/datagrid/idatagrid.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/idatagrid.ts#L24)

Returns the remote view that manages paging, sorting and server communication.

#### Returns

[`IRemoteView`](IRemoteView.md)\<`any`\>

The remote view instance.
