[@serenity-is/sleekgrid](../README.md) / applyFormatterResultToCellNode

# Function: applyFormatterResultToCellNode()

> **applyFormatterResultToCellNode**(`ctx`, `fmtResult`, `node`, `opt?`): `void`

Defined in: [src/core/formatting.ts:216](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L216)

Applies a formatter result to a DOM cell node, handling content, CSS classes,
attributes and tooltips tracked via the formatter context.

## Parameters

### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Active formatter context carrying `addClass`/`addAttrs`/`tooltip` and sanitizer flags.

### fmtResult

[`FormatterResult`](../type-aliases/FormatterResult.md)

Value returned by the formatter.

### node

`HTMLElement`

Cell DOM node to update.

### opt?

When `contentOnly` is `true`, only the inner content is updated; decoration cleanup is skipped.

#### contentOnly?

`boolean`

## Returns

`void`
