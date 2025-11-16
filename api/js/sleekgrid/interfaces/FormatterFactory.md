[sleekgrid](../README.md) / FormatterFactory

# Interface: FormatterFactory\<TItem\>

Defined in: [src/core/formatting.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L93)

## Type Parameters

### TItem

`TItem` = `any`

## Methods

### getFormat()?

> `optional` **getFormat**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:94](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L94)

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

***

### getFormatter()?

> `optional` **getFormatter**(`column`): [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L95)

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>
