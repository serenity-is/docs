[@serenity-is/sleekgrid](../README.md) / ItemMetadata

# Interface: ItemMetadata\<TItem\>

Defined in: [src/core/column.ts:149](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L149)

Row-level metadata that can influence rendering and interaction.
Returned by `DataView.getItemMetadata(row)`.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Properties

### columns?

> `optional` **columns**: `object`

Defined in: [src/core/column.ts:153](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L153)

Per-column metadata overrides for this row.

#### Index Signature

\[`key`: `string`\]: [`ColumnMetadata`](ColumnMetadata.md)\<`TItem`\>

***

### cssClasses?

> `optional` **cssClasses**: `string`

Defined in: [src/core/column.ts:151](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L151)

Extra CSS classes applied to the row node.

***

### focusable?

> `optional` **focusable**: `boolean`

Defined in: [src/core/column.ts:155](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L155)

Whether any cell in the row can receive focus.

***

### format?

> `optional` **format**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/column.ts:157](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L157)

Default formatter for all cells in the row.

***

### ~~formatter?~~

> `optional` **formatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/column.ts:162](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L162)

Legacy default formatter for the row.

#### Deprecated

Use [ItemMetadata.format](#format) instead.

***

### selectable?

> `optional` **selectable**: `boolean`

Defined in: [src/core/column.ts:164](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L164)

Whether any cell in the row can be selected.

***

### tabbable?

> `optional` **tabbable**: `boolean`

Defined in: [src/core/column.ts:166](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L166)

Whether any cell in the row participates in tab navigation.
