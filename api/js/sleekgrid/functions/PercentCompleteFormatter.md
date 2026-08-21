[@serenity-is/sleekgrid](../README.md) / PercentCompleteFormatter

# Function: PercentCompleteFormatter()

> **PercentCompleteFormatter**(`ctx`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/formatters/formatters.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/formatters/formatters.ts#L9)

Renders a numeric percent value as bold colored text (red < 50%, green otherwise).
Returns `"-"` when the value is empty/null.

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `value` is the numeric percentage (0–100).

## Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

A `<span>` element with colored text, or `"-"` for empty values.
