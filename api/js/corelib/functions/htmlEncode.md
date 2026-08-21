[@serenity-is/corelib](../README.md) / htmlEncode

# Function: htmlEncode()

> **htmlEncode**(`s`): `string`

Defined in: [src/base/html.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L33)

HTML-encodes a value by escaping `<`, `>`, `"`, `'`, and `&`.

## Parameters

### s

`any`

Value to encode. Non-string values are coerced to string; `null`/`undefined` yields an empty string.

## Returns

`string`

The HTML-escaped string, safe for interpolation into HTML markup.

## Example

```ts
htmlEncode('<a href="x">a & b</a>'); // "&lt;a href=&quot;x&quot;&gt;a &amp; b&lt;/a&gt;"
```
