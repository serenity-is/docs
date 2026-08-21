[@serenity-is/sleekgrid](../README.md) / escapeHtml

# Function: escapeHtml()

> **escapeHtml**(`s`): `string`

Defined in: [src/core/util.tsx:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/util.tsx#L40)

Escapes a value for safe insertion as HTML when `enableHtmlRendering` is `true`.
When called as `ctx.escape()` (without arguments) inside a formatter, uses `this.value`.
When `this.enableHtmlRendering === false`, the value is returned as a plain string without escaping.

## Parameters

### s

`any`

Value to escape; when omitted and called with a `FormatterContext` as `this`, escapes `this.value`.

## Returns

`string`

HTML-escaped string (or plain string when HTML rendering is disabled).
