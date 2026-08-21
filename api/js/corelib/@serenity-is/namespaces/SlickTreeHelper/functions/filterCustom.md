[@serenity-is/corelib](../../../../README.md) / [SlickTreeHelper](../README.md) / filterCustom

# Function: filterCustom()

> **filterCustom**\<`TItem`\>(`item`, `getParent`): `boolean`

Defined in: [src/ui/helpers/slicktreehelper.tsx:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slicktreehelper.tsx#L16)

Returns whether an item should be visible given the collapsed state of its
ancestors.

## Type Parameters

### TItem

`TItem`

The type of the item.

## Parameters

### item

`TItem`

The item to check.

### getParent

(`x`) => `any`

A function that returns the parent of an item.

## Returns

`boolean`

True if the item is visible, otherwise false.
