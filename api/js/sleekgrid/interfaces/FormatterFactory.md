[@serenity-is/sleekgrid](../README.md) / FormatterFactory

# Interface: FormatterFactory\<TItem\>

Defined in: [src/core/formatting.ts:96](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L96)

## Type Parameters

### TItem

`TItem` = `any`

## Methods

### getFormat()?

> `optional` **getFormat**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:97](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L97)

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

***

### getFormatter()?

> `optional` **getFormatter**(`column`): [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:98](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L98)

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>
