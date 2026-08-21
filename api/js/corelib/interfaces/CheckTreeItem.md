[@serenity-is/corelib](../README.md) / CheckTreeItem

# Interface: CheckTreeItem\<TSource\>

Defined in: [src/ui/editors/checktreeeditor.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L22)

A single item in a check tree editor.

## Type Parameters

### TSource

`TSource`

The source item type.

## Properties

### children?

> `optional` **children**: `CheckTreeItem`\<`TSource`\>[]

Defined in: [src/ui/editors/checktreeeditor.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L36)

Child items.

***

### hideCheckBox?

> `optional` **hideCheckBox**: `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L26)

Whether to hide the checkbox for this item.

***

### id?

> `optional` **id**: `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L30)

Unique identifier of the tree item, used as the node key and selection value.

***

### isAllDescendantsSelected?

> `optional` **isAllDescendantsSelected**: `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L28)

Whether all descendants are selected.

***

### isSelected?

> `optional` **isSelected**: `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L24)

Whether the item is selected.

***

### parentId?

> `optional` **parentId**: `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L34)

Parent item id.

***

### source?

> `optional` **source**: `TSource`

Defined in: [src/ui/editors/checktreeeditor.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L38)

The source item.

***

### text?

> `optional` **text**: `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L32)

Display text.
