[@serenity-is/corelib](../README.md) / parseISODateTime

# Function: parseISODateTime()

> **parseISODateTime**(`s`): `Date`

Defined in: [src/base/formatting.ts:878](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L878)

Parses a string that is expected to be in ISO 8601 UTC date/time format.

## Parameters

### s

`string`

String to parse; `null` yields `null`, empty string yields `null`, and non-ISO strings yield an invalid `Date` (`NaN`). Bare dates (`yyyy-MM-dd`, length 10) are normalized to midnight UTC.

## Returns

`Date`

The parsed `Date`, `null` for null/empty input, or an invalid `Date` when the string does not match the ISO pattern.
