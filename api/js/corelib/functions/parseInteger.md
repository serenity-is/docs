[corelib](../README.md) / parseInteger

# Function: parseInteger()

> **parseInteger**(`s`): `number`

Defined in: [src/base/formatting.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L519)

Converts a string to an integer. The difference between parseInt and parseInteger 
is that parseInteger will return null if the string is empty or null, whereas
parseInt will return NaN and parseInteger will use the current culture's group
and decimal separators.

## Parameters

### s

`string`

the string to parse

## Returns

`number`
