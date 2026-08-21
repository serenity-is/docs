[@serenity-is/sleekgrid](../README.md) / ColumnMetadata

# Interface: ColumnMetadata\<TItem\>

Defined in: [src/core/column.ts:112](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L112)

Per-cell metadata that can override column-level settings for a specific row.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Properties

### colspan?

> `optional` **colspan**: `number` \| `"*"`

Defined in: [src/core/column.ts:114](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L114)

Column span for this cell. Use `"*"` to span to the end of the row.

***

### cssClasses?

> `optional` **cssClasses**: `string`

Defined in: [src/core/column.ts:116](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L116)

Extra CSS classes applied to the cell node.

***

### editor?

> `optional` **editor**: [`EditorClass`](EditorClass.md)

Defined in: [src/core/column.ts:120](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L120)

Editor class override for this cell.

***

### focusable?

> `optional` **focusable**: `boolean`

Defined in: [src/core/column.ts:118](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L118)

Whether the cell can receive focus.

***

### format?

> `optional` **format**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/column.ts:122](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L122)

Formatter override for this cell.

***

### ~~formatter?~~

> `optional` **formatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/column.ts:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L127)

Legacy formatter override.

#### Deprecated

Use [ColumnMetadata.format](#format) instead.

***

### selectable?

> `optional` **selectable**: `boolean`

Defined in: [src/core/column.ts:129](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L129)

Whether the cell can be selected.

***

### tabbable?

> `optional` **tabbable**: `boolean`

Defined in: [src/core/column.ts:131](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L131)

Whether the cell participates in tab navigation.
