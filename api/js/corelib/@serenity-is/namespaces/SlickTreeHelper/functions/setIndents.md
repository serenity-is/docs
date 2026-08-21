[@serenity-is/corelib](../../../../README.md) / [SlickTreeHelper](../README.md) / setIndents

# Function: setIndents()

> **setIndents**\<`TItem`\>(`items`, `getId`, `getParentId`, `setCollapsed?`): `void`

Defined in: [src/ui/helpers/slicktreehelper.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slicktreehelper.tsx#L84)

Computes and sets the indent level of each item based on its parent chain.

## Type Parameters

### TItem

`TItem`

The type of the item.

## Parameters

### items

`TItem`[]

The items to update.

### getId

(`x`) => `any`

A function that returns the id of an item.

### getParentId

(`x`) => `any`

A function that returns the parent id of an item.

### setCollapsed?

`boolean`

Optional collapsed state to set on each item.

## Returns

`void`
