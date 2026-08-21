[@serenity-is/corelib](../README.md) / parseInteger

# Function: parseInteger()

> **parseInteger**(`s`): `number`

Defined in: [src/base/formatting.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L571)

Parses a string as an integer using [Culture](../variables/Culture.md) grouping rules.

## Parameters

### s

`string`

String to parse; `null` or whitespace yields `null`. Group separators for the current culture are stripped before validation.

## Returns

`number`

The parsed integer, `null` for empty/null input, or `NaN` when the string is not a valid integer.

## Remarks

Unlike `parseInt`, only strings matching `^[+-]?\d+$` (after group-separator removal) are accepted; trailing characters cause `NaN`.
