[@serenity-is/corelib](../README.md) / stringFormatLocale

# Function: stringFormatLocale()

> **stringFormatLocale**(`l`, `format`, ...`prm`): `string`

Defined in: [src/base/formatting.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L262)

Locale-specific variant of [stringFormat](stringFormat.md).

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
