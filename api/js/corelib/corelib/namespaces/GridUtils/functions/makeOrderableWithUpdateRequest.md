[corelib](../../../../README.md) / [GridUtils](../README.md) / makeOrderableWithUpdateRequest

# Function: makeOrderableWithUpdateRequest()

> **makeOrderableWithUpdateRequest**\<`TItem`, `TId`\>(`dataGrid`, `getId`, `getDisplayOrder`, `service`, `getUpdateRequest`): `void`

Defined in: [src/ui/helpers/gridutils.tsx:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L141)

## Type Parameters

### TItem

`TItem` = `any`

### TId

`TId` = `any`

## Parameters

### dataGrid

[`IDataGrid`](../../../../interfaces/IDataGrid.md)

### getId

(`item`) => `TId`

### getDisplayOrder

(`item`) => `any`

### service

`string`

### getUpdateRequest

(`id`, `order`) => [`SaveRequest`](../../../../interfaces/SaveRequest.md)\<`TItem`\>

## Returns

`void`
