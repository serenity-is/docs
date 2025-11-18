[@serenity-is/corelib](../README.md) / round

# Function: round()

> **round**(`num`, `d?`): `number`

Defined in: [src/base/formatting.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L253)

Rounds a number to specified digits or an integer number if digits are not specified.
Uses away from zero rounding (e.g. 1.5 rounds to 2, -1.5 rounds to -2) unlike Math.round.

## Parameters

### num

`number`

the number to round

### d?

`number`

the number of digits to round to. default is zero.

## Returns

`number`

the rounded number
