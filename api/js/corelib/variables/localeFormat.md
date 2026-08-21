[@serenity-is/corelib](../README.md) / localeFormat

# ~~Variable: localeFormat()~~

> **localeFormat**: (`l`, `format`, ...`prm`) => `string` = `stringFormatLocale`

Defined in: [src/compat/formatting-compat.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L51)

Legacy alias for [stringFormatLocale](../functions/stringFormatLocale.md).

Locale-specific variant of [stringFormat](../functions/stringFormat.md).

## Parameters

### l

[`Locale`](../interfaces/Locale.md)

Locale whose settings are applied when formatting each argument.

### format

`string`

Composite format string with `{index[:format]}` placeholders.

### prm

...`any`[]

Values to substitute. Numbers and Dates are formatted with `l`; objects with a `format` method are delegated to that method.

## Returns

`string`

The formatted string.

## Deprecated

Use [stringFormatLocale](../functions/stringFormatLocale.md) directly.

## See

[stringFormatLocale](../functions/stringFormatLocale.md)
