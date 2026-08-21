[@serenity-is/corelib](../README.md) / parseDate

# Function: parseDate()

> **parseDate**(`s`, `dateOrder?`): `Date`

Defined in: [src/base/formatting.ts:900](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L900)

Parses a date string in ISO 8601, locale, or JS date format.

## Parameters

### s

`string`

String to parse; `null` / empty / whitespace yields `null`. ISO prefixes (`yyyy-MM-dd` / `yyyy-MM-ddTHH:mm:ss`) are delegated to [parseISODateTime](parseISODateTime.md); strings containing a space and colon are split into date + time halves. Numeric parts are validated and two-digit years are expanded using a 10-year sliding window.

### dateOrder?

`string`

Override for ambiguous numeric dates (`"dmy"` / `"mdy"` / `"ymd"`). Defaults to [Culture](../variables/Culture.md).`dateOrder`.

## Returns

`Date`

The parsed `Date`, `null` for empty input, or an invalid `Date` (`NaN`) when the string is not a valid date.
