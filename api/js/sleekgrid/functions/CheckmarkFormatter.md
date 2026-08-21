[@serenity-is/sleekgrid](../README.md) / CheckmarkFormatter

# Function: CheckmarkFormatter()

> **CheckmarkFormatter**(`ctx`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/formatters/formatters.ts:75](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/formatters/formatters.ts#L75)

Renders a boolean value as a checkmark icon; nothing when falsy.

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `value` is coerced to boolean.

## Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

An `<i>` with `slick-checkmark` when truthy, otherwise empty string.
