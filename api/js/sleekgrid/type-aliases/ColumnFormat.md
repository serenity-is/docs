[@serenity-is/sleekgrid](../README.md) / ColumnFormat

# Type Alias: ColumnFormat()\<TItem\>

> **ColumnFormat**\<`TItem`\> = (`ctx`) => [`FormatterResult`](FormatterResult.md)

Defined in: [src/core/formatting.ts:97](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L97)

Modern formatter signature; receives a [FormatterContext](../interfaces/FormatterContext.md) and returns a [FormatterResult](FormatterResult.md).

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)\<`TItem`\>

Formatter context containing value, row/cell coordinates, column, grid and helpers.

## Returns

[`FormatterResult`](FormatterResult.md)

Renderable result for the cell.
