[corelib](../README.md) / parseDate

# Function: parseDate()

> **parseDate**(`s`, `dateOrder?`): `Date`

Defined in: [src/base/formatting.ts:856](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L856)

Parses a string to a date. If the string is empty or whitespace, returns null.
Returns a NaN Date if the string is not a valid date.

## Parameters

### s

`string`

The string to parse.

### dateOrder?

`string`

The order of the date parts in the string. Defaults to culture's default date order.

## Returns

`Date`
