[@serenity-is/sleekgrid](../README.md) / PercentCompleteBarFormatter

# Function: PercentCompleteBarFormatter()

> **PercentCompleteBarFormatter**(`ctx`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/formatters/formatters.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/formatters/formatters.ts#L28)

Renders a numeric percent value as a horizontal bar whose color varies by
threshold (red < 30, silver < 70, green otherwise).

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `value` is the numeric percentage (0–100).

## Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

A `<span>` bar element, or empty string for empty values.
