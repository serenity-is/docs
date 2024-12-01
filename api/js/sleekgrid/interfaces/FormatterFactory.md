[@serenity-is/sleekgrid](../README.md) / FormatterFactory

# Interface: FormatterFactory\<TItem\>

## Type Parameters

• **TItem** = `any`

## Methods

### getFormat()?

> `optional` **getFormat**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Defined in

[core/formatting.ts:73](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L73)

***

### getFormatter()?

> `optional` **getFormatter**(`column`): [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

#### Defined in

[core/formatting.ts:74](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L74)
