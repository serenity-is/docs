[@serenity-is/corelib](../../../../README.md) / [SlickFormatting](../README.md) / treeToggle

# Function: treeToggle()

> **treeToggle**(`getView`, `getId`, `formatter`): [`Format`](../../../../type-aliases/Format.md)

Defined in: [src/ui/helpers/slickformatting.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickformatting.tsx#L62)

Returns a formatter that renders a tree toggle (expand/collapse) control
with indentation based on the item's hierarchy.

## Parameters

### getView

() => [`IRemoteView`](../../../../interfaces/IRemoteView.md)\<`any`\>

A function that returns the remote view.

### getId

(`x`) => `any`

A function that returns the id of an item.

### formatter

[`Format`](../../../../type-aliases/Format.md)

The formatter used to render the item content.

## Returns

[`Format`](../../../../type-aliases/Format.md)

The tree toggle formatter.
