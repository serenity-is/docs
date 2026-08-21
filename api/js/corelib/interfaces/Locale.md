[@serenity-is/corelib](../README.md) / Locale

# Interface: Locale

Defined in: [src/base/formatting.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L61)

Combined locale settings, mirroring .NET `CultureInfo`.

## Remarks

Extends both [NumberFormat](NumberFormat.md) and [DateFormat](DateFormat.md) with string comparison helpers.

## Extends

- [`NumberFormat`](NumberFormat.md).[`DateFormat`](DateFormat.md)

## Properties

### amDesignator?

> `optional` **amDesignator**: `string`

Defined in: [src/base/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L38)

Designator for AM hours (used with `t`/`tt` tokens).

#### Default Value

`"AM"`.

#### Inherited from

[`DateFormat`](DateFormat.md).[`amDesignator`](DateFormat.md#amdesignator)

***

### currencySymbol?

> `optional` **currencySymbol**: `string`

Defined in: [src/base/formatting.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L21)

Symbol appended for currency (`"c"`) formatting.

#### Default Value

`"$"`.

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`currencySymbol`](NumberFormat.md#currencysymbol)

***

### dateFormat?

> `optional` **dateFormat**: `string`

Defined in: [src/base/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L32)

Default date-only format string (e.g. `"dd/MM/yyyy"`).

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateFormat`](DateFormat.md#dateformat)

***

### dateOrder?

> `optional` **dateOrder**: `string`

Defined in: [src/base/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L34)

Token order for parsing ambiguous numeric dates: `"dmy"`, `"mdy"`, or `"ymd"`.

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateOrder`](DateFormat.md#dateorder)

***

### dateSeparator?

> `optional` **dateSeparator**: `string`

Defined in: [src/base/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L30)

Character separating date parts (e.g. `"/"` or `"."`).

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateSeparator`](DateFormat.md#dateseparator)

***

### dateTimeFormat?

> `optional` **dateTimeFormat**: `string`

Defined in: [src/base/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L36)

Default combined date+time format string (e.g. `"dd/MM/yyyy HH:mm:ss"`).

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateTimeFormat`](DateFormat.md#datetimeformat)

***

### dayNames?

> `optional` **dayNames**: `string`[]

Defined in: [src/base/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L46)

Full day names starting with Sunday — 7 entries.

#### Inherited from

[`DateFormat`](DateFormat.md).[`dayNames`](DateFormat.md#daynames)

***

### decimalDigits?

> `optional` **decimalDigits**: `number`

Defined in: [src/base/formatting.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L11)

Default number of fractional digits for `"f"` / `"n"` / `"c"` / `"p"` formats.

#### Default Value

`2` (Invariant).

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`decimalDigits`](NumberFormat.md#decimaldigits)

***

### decimalSeparator

> **decimalSeparator**: `string`

Defined in: [src/base/formatting.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L7)

Character used as the decimal separator (e.g. `"."` or `","`).

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`decimalSeparator`](NumberFormat.md#decimalseparator)

***

### firstDayOfWeek?

> `optional` **firstDayOfWeek**: `number`

Defined in: [src/base/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L44)

Index of the first day of the week (`0` = Sunday, `1` = Monday).

#### Inherited from

[`DateFormat`](DateFormat.md).[`firstDayOfWeek`](DateFormat.md#firstdayofweek)

***

### groupSeparator?

> `optional` **groupSeparator**: `string`

Defined in: [src/base/formatting.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L9)

Character used to group thousands (e.g. `","` or `"."`).

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`groupSeparator`](NumberFormat.md#groupseparator)

***

### minimizedDayNames?

> `optional` **minimizedDayNames**: `string`[]

Defined in: [src/base/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L50)

Two-letter day names (e.g. `"Su"`, `"Mo"`). — 7 entries.

#### Inherited from

[`DateFormat`](DateFormat.md).[`minimizedDayNames`](DateFormat.md#minimizeddaynames)

***

### monthNames?

> `optional` **monthNames**: `string`[]

Defined in: [src/base/formatting.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L52)

Full month names starting with January — 12 entries plus a trailing empty slot for compatibility.

#### Inherited from

[`DateFormat`](DateFormat.md).[`monthNames`](DateFormat.md#monthnames)

***

### nanSymbol?

> `optional` **nanSymbol**: `string`

Defined in: [src/base/formatting.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L17)

String rendered for `NaN` values.

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`nanSymbol`](NumberFormat.md#nansymbol)

***

### negativeSign?

> `optional` **negativeSign**: `string`

Defined in: [src/base/formatting.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L15)

Symbol for negative numbers.

#### Default Value

`"-"`.

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`negativeSign`](NumberFormat.md#negativesign)

***

### percentSymbol?

> `optional` **percentSymbol**: `string`

Defined in: [src/base/formatting.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L19)

Symbol appended for percent (`"p"`) formatting.

#### Default Value

`"%"`.

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`percentSymbol`](NumberFormat.md#percentsymbol)

***

### pmDesignator?

> `optional` **pmDesignator**: `string`

Defined in: [src/base/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L40)

Designator for PM hours (used with `t`/`tt` tokens).

#### Default Value

`"PM"`.

#### Inherited from

[`DateFormat`](DateFormat.md).[`pmDesignator`](DateFormat.md#pmdesignator)

***

### positiveSign?

> `optional` **positiveSign**: `string`

Defined in: [src/base/formatting.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L13)

Symbol for positive numbers (rarely displayed).

#### Default Value

`"+"`.

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`positiveSign`](NumberFormat.md#positivesign)

***

### shortDayNames?

> `optional` **shortDayNames**: `string`[]

Defined in: [src/base/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L48)

Abbreviated day names (e.g. `"Sun"`, `"Mon"`). — 7 entries.

#### Inherited from

[`DateFormat`](DateFormat.md).[`shortDayNames`](DateFormat.md#shortdaynames)

***

### shortMonthNames?

> `optional` **shortMonthNames**: `string`[]

Defined in: [src/base/formatting.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L54)

Abbreviated month names (e.g. `"Jan"`, `"Feb"`). — 12 entries plus a trailing empty slot.

#### Inherited from

[`DateFormat`](DateFormat.md).[`shortMonthNames`](DateFormat.md#shortmonthnames)

***

### stringCompare()?

> `optional` **stringCompare**: (`a`, `b`) => `number`

Defined in: [src/base/formatting.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L68)

Locale-aware string comparator, analogous to `String.Compare`.

#### Parameters

##### a

`string`

First string to compare (may be `null`).

##### b

`string`

Second string to compare (may be `null`).

#### Returns

`number`

Negative if `a < b`, positive if `a > b`, `0` if equal.

***

### timeSeparator?

> `optional` **timeSeparator**: `string`

Defined in: [src/base/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L42)

Character separating time parts.

#### Default Value

`":"`.

#### Inherited from

[`DateFormat`](DateFormat.md).[`timeSeparator`](DateFormat.md#timeseparator)

***

### toUpper()?

> `optional` **toUpper**: (`a`) => `string`

Defined in: [src/base/formatting.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L74)

Locale-aware upper-casing function.

#### Parameters

##### a

`string`

String to convert.

#### Returns

`string`

The upper-cased string.
