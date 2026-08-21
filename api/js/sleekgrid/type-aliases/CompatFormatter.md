[@serenity-is/sleekgrid](../README.md) / CompatFormatter

# Type Alias: CompatFormatter()\<TItem\>

> **CompatFormatter**\<`TItem`\> = (`row`, `cell`, `value`, `column`, `item`, `grid?`) => `string` \| [`CompatFormatterResult`](../interfaces/CompatFormatterResult.md)

Defined in: [src/core/formatting.ts:122](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L122)

Legacy formatter signature kept for backward compatibility.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Parameters

### row

`number`

Row index.

### cell

`number`

Cell/column index.

### value

`any`

Raw cell value.

### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

Column definition.

### item

`TItem`

Row data item.

### grid?

[`ISleekGrid`](../interfaces/ISleekGrid.md)

Grid instance, if available.

## Returns

`string` \| [`CompatFormatterResult`](../interfaces/CompatFormatterResult.md)

Plain string or structured result with classes/tooltip.
