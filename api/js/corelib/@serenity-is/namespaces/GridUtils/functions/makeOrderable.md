[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / makeOrderable

# Function: makeOrderable()

> **makeOrderable**(`grid`, `handleMove`): `void`

Defined in: [src/ui/helpers/gridutils.tsx:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L196)

Makes the rows of a grid reorderable by dragging.

## Parameters

### grid

`ISleekGrid`

The sleek grid.

### handleMove

(`rows`, `insertBefore`) => `void`

Callback invoked with the moved row indexes and the insert-before index.

## Returns

`void`
