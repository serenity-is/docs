[@serenity-is/corelib](../README.md) / sanitizeHtml

# Function: sanitizeHtml()

> **sanitizeHtml**(`dirtyHtml`): `string`

Defined in: [src/base/html.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L339)

Sanitizes an HTML string by stripping dangerous elements and attributes.
Preference order: SleekGrid sanitizer (`sleekgrid.formatterContext()?.sanitizer` or `sleekgrid.gridDefaults.sanitizer`), `DOMPurify.sanitize` if present, otherwise a built-in `DOMParser` implementation that removes `script`/`iframe`/`object`/`embed`/`form`/`style`/`link` and event-handler / unsafe-URL attributes.
Falls back to [htmlEncode](htmlEncode.md) if `DOMParser` is unavailable or parsing throws.

## Parameters

### dirtyHtml

`string`

Untrusted HTML markup to sanitize. Falsy values return an empty string; strings without HTML tags/entities are returned as-is (fast path).

## Returns

`string`

The sanitized HTML string safe for insertion via `innerHTML`.

## Remarks

This duplicates the basic DOM sanitizer logic so corelib works standalone with or without SleekGrid loaded.
