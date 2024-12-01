[@serenity-is/corelib](../README.md) / parseDecimal

# Function: parseDecimal()

> **parseDecimal**(`s`): `number`

Converts a string to a decimal. The difference between parseFloat and parseDecimal
is that parseDecimal will return null if the string is empty or null, whereas
parseFloat will return NaN and parseDecimal will use the current culture's group
and decimal separators.

## Parameters

### s

`string`

the string to parse

## Returns

`number`

## Defined in

[src/base/formatting.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L525)
