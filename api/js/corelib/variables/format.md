[@serenity-is/corelib](../README.md) / format

# ~~Variable: format()~~

> **format**: (`format`, ...`prm`) => `string` = `stringFormat`

Defined in: [src/compat/formatting-compat.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L44)

Legacy alias for [stringFormat](../functions/stringFormat.md) (`Q.format`).

Formats a string by replacing `{index[:format]}` placeholders with the supplied arguments, using [Culture](Culture.md) for locale-aware value formatting.

## Parameters

### format

`string`

Composite format string (e.g. `"Hello {0}, you have {1:n2} messages"`). `{{` / `}}` are escaped to a single brace.

### prm

...`any`[]

Values to substitute; each may be a number, `Date`, or any object with a `format(formatSpec, locale)` method. Nullish values render as empty strings.

## Returns

`string`

The formatted string.

## Example

```ts
stringFormat("Hello {0}, balance {1:c}", "Alice", 1234.5); // uses Culture currency symbol
```

## Deprecated

Use [stringFormat](../functions/stringFormat.md) directly.

## See

[stringFormat](../functions/stringFormat.md)
