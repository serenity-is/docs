[corelib](../README.md) / formatNumber

# Function: formatNumber()

> **formatNumber**(`num`, `format?`, `decOrLoc?`, `grp?`): `string`

Defined in: [src/base/formatting.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L285)

Formats a number using the current `Culture` locale (or the passed locale) settings.
It supports format specifiers similar to .NET numeric formatting strings.

## Parameters

### num

`number`

the number to format

### format?

`string`

the format specifier. default is 'g'.
See .NET numeric formatting strings documentation for more information.

### decOrLoc?

`string` | [`NumberFormat`](../interfaces/NumberFormat.md)

### grp?

`string`

## Returns

`string`
