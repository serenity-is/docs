[@serenity-is/corelib](../../../../README.md) / [SlickTreeHelper](../README.md) / filterById

# Function: filterById()

> **filterById**\<`TItem`\>(`item`, `view`, `getParentId`): `boolean`

Defined in: [src/ui/helpers/slicktreehelper.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slicktreehelper.tsx#L41)

Returns whether an item should be visible by resolving its parent chain
through the view.

## Type Parameters

### TItem

`TItem`

The type of the item.

## Parameters

### item

`TItem`

The item to check.

### view

[`IRemoteView`](../../../../interfaces/IRemoteView.md)\<`TItem`\>

The remote view used to resolve parents.

### getParentId

(`x`) => `any`

A function that returns the parent id of an item.

## Returns

`boolean`

True if the item is visible, otherwise false.
