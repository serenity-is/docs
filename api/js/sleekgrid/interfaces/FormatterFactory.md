[@serenity-is/sleekgrid](../README.md) / FormatterFactory

# Interface: FormatterFactory\<TItem\>

Defined in: [src/core/formatting.ts:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L128)

Factory that can provide formatters for columns, allowing centralized formatter resolution.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Methods

### getFormat()?

> `optional` **getFormat**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:134](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L134)

Returns the modern [ColumnFormat](../type-aliases/ColumnFormat.md) for the given column, if any.

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

Column to resolve a formatter for.

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Formatter function or `undefined`.

***

### getFormatter()?

> `optional` **getFormatter**(`column`): [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:140](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L140)

Returns the legacy [CompatFormatter](../type-aliases/CompatFormatter.md) for the given column, if any.

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

Column to resolve a formatter for.

#### Returns

[`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Legacy formatter or `undefined`.
