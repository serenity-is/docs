[@serenity-is/corelib](../README.md) / parseDecimal

# Function: parseDecimal()

> **parseDecimal**(`s`): `number`

Defined in: [src/base/formatting.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L592)

Parses a string as a decimal number using [Culture](../variables/Culture.md) group and decimal separators.

## Parameters

### s

`string`

String to parse; `null` or whitespace yields `null`. Group separators are stripped and the locale decimal separator is normalized to `"."` before `parseFloat`.

## Returns

`number`

The parsed number, `null` for empty/null input, or `NaN` when the string is not a valid decimal.

## Remarks

Only patterns matching `^\s*[+-]?(\d*)[decimalSep]?(\d*)\s*$` are accepted.
