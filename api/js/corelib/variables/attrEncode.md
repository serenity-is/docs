[@serenity-is/corelib](../README.md) / attrEncode

# ~~Variable: attrEncode()~~

> `const` **attrEncode**: (`s`) => `string` = `htmlEncode`

Defined in: [src/compat/html-compat.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L31)

Legacy alias for [htmlEncode](../functions/htmlEncode.md).

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

## Deprecated

Use [htmlEncode](../functions/htmlEncode.md) directly (it also encodes quotes). Retained as `Q.attrEncode` compat shim.

## See

[htmlEncode](../functions/htmlEncode.md)
