[corelib](../README.md) / Locale

# Interface: Locale

Defined in: [src/base/formatting.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L54)

Interface for a locale, similar to .NET's CultureInfo

## Extends

- [`NumberFormat`](NumberFormat.md).[`DateFormat`](DateFormat.md)

## Properties

### amDesignator?

> `optional` **amDesignator**: `string`

Defined in: [src/base/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L34)

AM designator

#### Inherited from

[`DateFormat`](DateFormat.md).[`amDesignator`](DateFormat.md#amdesignator)

***

### currencySymbol?

> `optional` **currencySymbol**: `string`

Defined in: [src/base/formatting.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L20)

Currency symbol

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`currencySymbol`](NumberFormat.md#currencysymbol)

***

### dateFormat?

> `optional` **dateFormat**: `string`

Defined in: [src/base/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L28)

Default date format string

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateFormat`](DateFormat.md#dateformat)

***

### dateOrder?

> `optional` **dateOrder**: `string`

Defined in: [src/base/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L30)

Date order, like dmy, or ymd

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateOrder`](DateFormat.md#dateorder)

***

### dateSeparator?

> `optional` **dateSeparator**: `string`

Defined in: [src/base/formatting.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L26)

Date separator

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateSeparator`](DateFormat.md#dateseparator)

***

### dateTimeFormat?

> `optional` **dateTimeFormat**: `string`

Defined in: [src/base/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L32)

Default date time format string

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateTimeFormat`](DateFormat.md#datetimeformat)

***

### dayNames?

> `optional` **dayNames**: `string`[]

Defined in: [src/base/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L42)

Array of day names

#### Inherited from

[`DateFormat`](DateFormat.md).[`dayNames`](DateFormat.md#daynames)

***

### decimalDigits?

> `optional` **decimalDigits**: `number`

Defined in: [src/base/formatting.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L10)

Number of digits after decimal separator

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`decimalDigits`](NumberFormat.md#decimaldigits)

***

### decimalSeparator

> **decimalSeparator**: `string`

Defined in: [src/base/formatting.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L6)

Decimal separator

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`decimalSeparator`](NumberFormat.md#decimalseparator)

***

### firstDayOfWeek?

> `optional` **firstDayOfWeek**: `number`

Defined in: [src/base/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L40)

First day of week, 0 = Sunday, 1 = Monday

#### Inherited from

[`DateFormat`](DateFormat.md).[`firstDayOfWeek`](DateFormat.md#firstdayofweek)

***

### groupSeparator?

> `optional` **groupSeparator**: `string`

Defined in: [src/base/formatting.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L8)

Group separator

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`groupSeparator`](NumberFormat.md#groupseparator)

***

### minimizedDayNames?

> `optional` **minimizedDayNames**: `string`[]

Defined in: [src/base/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L46)

Array of two letter day names

#### Inherited from

[`DateFormat`](DateFormat.md).[`minimizedDayNames`](DateFormat.md#minimizeddaynames)

***

### monthNames?

> `optional` **monthNames**: `string`[]

Defined in: [src/base/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L48)

Array of month names

#### Inherited from

[`DateFormat`](DateFormat.md).[`monthNames`](DateFormat.md#monthnames)

***

### nanSymbol?

> `optional` **nanSymbol**: `string`

Defined in: [src/base/formatting.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L16)

Zero symbol

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`nanSymbol`](NumberFormat.md#nansymbol)

***

### negativeSign?

> `optional` **negativeSign**: `string`

Defined in: [src/base/formatting.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L14)

Negative sign

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`negativeSign`](NumberFormat.md#negativesign)

***

### percentSymbol?

> `optional` **percentSymbol**: `string`

Defined in: [src/base/formatting.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L18)

Percentage symbol

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`percentSymbol`](NumberFormat.md#percentsymbol)

***

### pmDesignator?

> `optional` **pmDesignator**: `string`

Defined in: [src/base/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L36)

PM designator

#### Inherited from

[`DateFormat`](DateFormat.md).[`pmDesignator`](DateFormat.md#pmdesignator)

***

### positiveSign?

> `optional` **positiveSign**: `string`

Defined in: [src/base/formatting.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L12)

Positive sign

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`positiveSign`](NumberFormat.md#positivesign)

***

### shortDayNames?

> `optional` **shortDayNames**: `string`[]

Defined in: [src/base/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L44)

Array of short day names

#### Inherited from

[`DateFormat`](DateFormat.md).[`shortDayNames`](DateFormat.md#shortdaynames)

***

### shortMonthNames?

> `optional` **shortMonthNames**: `string`[]

Defined in: [src/base/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L50)

Array of short month names

#### Inherited from

[`DateFormat`](DateFormat.md).[`shortMonthNames`](DateFormat.md#shortmonthnames)

***

### stringCompare()?

> `optional` **stringCompare**: (`a`, `b`) => `number`

Defined in: [src/base/formatting.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L56)

Locale string comparison function, similar to .NET's StringComparer

#### Parameters

##### a

`string`

##### b

`string`

#### Returns

`number`

***

### timeSeparator?

> `optional` **timeSeparator**: `string`

Defined in: [src/base/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L38)

Time separator

#### Inherited from

[`DateFormat`](DateFormat.md).[`timeSeparator`](DateFormat.md#timeseparator)

***

### toUpper()?

> `optional` **toUpper**: (`a`) => `string`

Defined in: [src/base/formatting.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L58)

Locale string to upper case function

#### Parameters

##### a

`string`

#### Returns

`string`
