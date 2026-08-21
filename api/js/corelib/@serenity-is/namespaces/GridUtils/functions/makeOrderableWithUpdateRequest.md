[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / makeOrderableWithUpdateRequest

# Function: makeOrderableWithUpdateRequest()

> **makeOrderableWithUpdateRequest**\<`TItem`, `TId`\>(`dataGrid`, `getId`, `getDisplayOrder`, `service`, `getUpdateRequest`): `void`

Defined in: [src/ui/helpers/gridutils.tsx:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L234)

Makes the rows of a data grid reorderable and persists the new order by
sending update requests to the server.

## Type Parameters

### TItem

`TItem` = `any`

The type of the row items.

### TId

`TId` = `any`

The type of the item id.

## Parameters

### dataGrid

[`IDataGrid`](../../../../interfaces/IDataGrid.md)

The data grid.

### getId

(`item`) => `TId`

A function that returns the id of an item.

### getDisplayOrder

(`item`) => `any`

A function that returns the display order of an item.

### service

`string`

The service URL to send update requests to.

### getUpdateRequest

(`id`, `order`) => [`SaveRequest`](../../../../interfaces/SaveRequest.md)\<`TItem`\>

A function that builds an update request for an item id and order.

## Returns

`void`
