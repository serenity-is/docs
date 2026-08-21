[@serenity-is/corelib](../../../../README.md) / [SlickTreeHelper](../README.md) / toggleClick

# Function: toggleClick()

> **toggleClick**\<`TItem`\>(`e`, `row`, `cell`, `view`, `getId`): `void`

Defined in: [src/ui/helpers/slicktreehelper.tsx:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slicktreehelper.tsx#L125)

Handles a click on a tree toggle, expanding or collapsing the item and its
descendants when the shift key is held.

## Type Parameters

### TItem

`TItem`

The type of the item.

## Parameters

### e

`Event`

The click event.

### row

`number`

The row index of the clicked item.

### cell

`number`

The cell index of the clicked item.

### view

[`IRemoteView`](../../../../interfaces/IRemoteView.md)\<`TItem`\>

The remote view.

### getId

(`x`) => `any`

A function that returns the id of an item.

## Returns

`void`
