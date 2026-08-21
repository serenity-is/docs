[@serenity-is/corelib](../../../../README.md) / [AggregateFormatting](../README.md) / groupTotalsFormat

# Function: groupTotalsFormat()

> **groupTotalsFormat**(`ctx`): `FormatterResult`

Defined in: [src/slick/aggregateformatting.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregateformatting.tsx#L23)

Formats a group totals cell (aggregate badge/value) based on the column's summaryType.

## Parameters

### ctx

`FormatterContext`\<`IGroupTotals`\<`any`\>\>

Formatter context containing group totals item and column.

## Returns

`FormatterResult`

Rendered aggregate markup or empty string.
