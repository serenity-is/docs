[@serenity-is/sleekgrid](../README.md) / CheckBoxFormatter

# Function: CheckBoxFormatter()

> **CheckBoxFormatter**(`ctx`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/formatters/formatters.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/formatters/formatters.ts#L64)

Renders a boolean value as a styled checkbox icon (`<i>` with
`slick-checkbox` / `checked` classes).

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `value` is coerced to boolean.

## Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

An `<i>` element representing the checkbox state.
