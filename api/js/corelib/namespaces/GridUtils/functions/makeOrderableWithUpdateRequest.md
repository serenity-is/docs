[@serenity-is/corelib](../../../README.md) / [GridUtils](../README.md) / makeOrderableWithUpdateRequest

# Function: makeOrderableWithUpdateRequest()

> **makeOrderableWithUpdateRequest**\<`TItem`, `TId`\>(`grid`, `getId`, `getDisplayOrder`, `service`, `getUpdateRequest`): `void`

## Type Parameters

• **TItem** = `any`

• **TId** = `any`

## Parameters

### grid

[`IDataGrid`](../../../interfaces/IDataGrid.md)

### getId

(`item`) => `TId`

### getDisplayOrder

(`item`) => `any`

### service

`string`

### getUpdateRequest

(`id`, `order`) => [`SaveRequest`](../../../interfaces/SaveRequest.md)\<`TItem`\>

## Returns

`void`

## Defined in

[src/ui/helpers/slickhelpers.tsx:469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L469)
