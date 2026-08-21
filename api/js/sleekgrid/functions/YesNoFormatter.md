[@serenity-is/sleekgrid](../README.md) / YesNoFormatter

# Function: YesNoFormatter()

> **YesNoFormatter**(`ctx`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/formatters/formatters.ts:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/formatters/formatters.ts#L53)

Renders a boolean value as `"Yes"` or `"No"`.

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `value` is coerced to boolean.

## Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

`"Yes"` when truthy, `"No"` otherwise.
