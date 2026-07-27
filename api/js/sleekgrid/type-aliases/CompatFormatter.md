[@serenity-is/sleekgrid](../README.md) / CompatFormatter

# Type Alias: CompatFormatter()\<TItem\>

> **CompatFormatter**\<`TItem`\> = (`row`, `cell`, `value`, `column`, `item`, `grid?`) => `string` \| [`CompatFormatterResult`](../interfaces/CompatFormatterResult.md)

Defined in: [src/core/formatting.ts:94](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L94)

## Type Parameters

### TItem

`TItem` = `any`

## Parameters

### row

`number`

### cell

`number`

### value

`any`

### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

### item

`TItem`

### grid?

[`ISleekGrid`](../interfaces/ISleekGrid.md)

## Returns

`string` \| [`CompatFormatterResult`](../interfaces/CompatFormatterResult.md)
