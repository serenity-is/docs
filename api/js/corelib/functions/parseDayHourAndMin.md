[@serenity-is/corelib](../README.md) / parseDayHourAndMin

# Function: parseDayHourAndMin()

> **parseDayHourAndMin**(`s`): `number`

Parses a string in the format "d.hh:mm" into a number containing number of minutes.
Returns NaN if the hours not in range 0-23 or minutes not in range 0-59.
Returns NULL if the string is empty or whitespace.

## Parameters

### s

`string`

## Returns

`number`

## Defined in

[src/q/formatting-compat.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L89)
