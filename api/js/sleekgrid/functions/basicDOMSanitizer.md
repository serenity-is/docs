[@serenity-is/sleekgrid](../README.md) / basicDOMSanitizer

# Function: basicDOMSanitizer()

> **basicDOMSanitizer**(`dirtyHtml`): `string`

Defined in: [src/core/util.tsx:66](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/util.tsx#L66)

Lightweight HTML sanitizer using `DOMParser`. Strips scripts, iframes, event handlers
and dangerous URL protocols; falls back to [escapeHtml](escapeHtml.md) when `DOMParser` is unavailable.
Prefer the grid's injected `sanitizer` (DOMPurify when present) for production; this is a safe default.

## Parameters

### dirtyHtml

`string`

Raw HTML string to sanitize.

## Returns

`string`

Sanitized HTML string safe to assign to `innerHTML`.
