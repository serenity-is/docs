[@serenity-is/corelib](../README.md) / NumberFormat

# Interface: NumberFormat

Defined in: [src/base/formatting.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L5)

Locale settings for number formatting, mirroring .NET `NumberFormatInfo`.

## Remarks

Used by [formatNumber](../functions/formatNumber.md), [parseDecimal](../functions/parseDecimal.md), and [parseInteger](../functions/parseInteger.md) via [Culture](../variables/Culture.md).

## Extended by

- [`Locale`](Locale.md)

## Properties

### currencySymbol?

> `optional` **currencySymbol**: `string`

Defined in: [src/base/formatting.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L21)

Symbol appended for currency (`"c"`) formatting.

#### Default Value

`"$"`.

***

### decimalDigits?

> `optional` **decimalDigits**: `number`

Defined in: [src/base/formatting.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L11)

Default number of fractional digits for `"f"` / `"n"` / `"c"` / `"p"` formats.

#### Default Value

`2` (Invariant).

***

### decimalSeparator

> **decimalSeparator**: `string`

Defined in: [src/base/formatting.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L7)

Character used as the decimal separator (e.g. `"."` or `","`).

***

### groupSeparator?

> `optional` **groupSeparator**: `string`

Defined in: [src/base/formatting.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L9)

Character used to group thousands (e.g. `","` or `"."`).

***

### nanSymbol?

> `optional` **nanSymbol**: `string`

Defined in: [src/base/formatting.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L17)

String rendered for `NaN` values.

***

### negativeSign?

> `optional` **negativeSign**: `string`

Defined in: [src/base/formatting.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L15)

Symbol for negative numbers.

#### Default Value

`"-"`.

***

### percentSymbol?

> `optional` **percentSymbol**: `string`

Defined in: [src/base/formatting.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L19)

Symbol appended for percent (`"p"`) formatting.

#### Default Value

`"%"`.

***

### positiveSign?

> `optional` **positiveSign**: `string`

Defined in: [src/base/formatting.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L13)

Symbol for positive numbers (rarely displayed).

#### Default Value

`"+"`.
