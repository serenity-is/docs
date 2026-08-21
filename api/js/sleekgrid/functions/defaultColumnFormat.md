[@serenity-is/sleekgrid](../README.md) / defaultColumnFormat

# Function: defaultColumnFormat()

> **defaultColumnFormat**(`ctx`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/formatting.ts:172](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L172)

Default column formatter; escapes or returns the value based on `enableHtmlRendering`.
Use as a safe fallback when no custom formatter is provided.

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `value` is rendered.

## Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

Escaped or raw string representation of `ctx.value`.
