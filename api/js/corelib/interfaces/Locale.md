[@serenity-is/corelib](../README.md) / Locale

# Interface: Locale

Interface for a locale, similar to .NET's CultureInfo

## Extends

- [`NumberFormat`](NumberFormat.md).[`DateFormat`](DateFormat.md)

## Properties

### amDesignator?

> `optional` **amDesignator**: `string`

AM designator

#### Inherited from

[`DateFormat`](DateFormat.md).[`amDesignator`](DateFormat.md#amdesignator)

#### Defined in

[src/base/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L34)

***

### currencySymbol?

> `optional` **currencySymbol**: `string`

Currency symbol

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`currencySymbol`](NumberFormat.md#currencysymbol)

#### Defined in

[src/base/formatting.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L20)

***

### dateFormat?

> `optional` **dateFormat**: `string`

Default date format string

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateFormat`](DateFormat.md#dateformat)

#### Defined in

[src/base/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L28)

***

### dateOrder?

> `optional` **dateOrder**: `string`

Date order, like dmy, or ymd

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateOrder`](DateFormat.md#dateorder)

#### Defined in

[src/base/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L30)

***

### dateSeparator?

> `optional` **dateSeparator**: `string`

Date separator

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateSeparator`](DateFormat.md#dateseparator)

#### Defined in

[src/base/formatting.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L26)

***

### dateTimeFormat?

> `optional` **dateTimeFormat**: `string`

Default date time format string

#### Inherited from

[`DateFormat`](DateFormat.md).[`dateTimeFormat`](DateFormat.md#datetimeformat)

#### Defined in

[src/base/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L32)

***

### dayNames?

> `optional` **dayNames**: `string`[]

Array of day names

#### Inherited from

[`DateFormat`](DateFormat.md).[`dayNames`](DateFormat.md#daynames)

#### Defined in

[src/base/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L42)

***

### decimalDigits?

> `optional` **decimalDigits**: `number`

Number of digits after decimal separator

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`decimalDigits`](NumberFormat.md#decimaldigits)

#### Defined in

[src/base/formatting.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L10)

***

### decimalSeparator

> **decimalSeparator**: `string`

Decimal separator

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`decimalSeparator`](NumberFormat.md#decimalseparator)

#### Defined in

[src/base/formatting.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L6)

***

### firstDayOfWeek?

> `optional` **firstDayOfWeek**: `number`

First day of week, 0 = Sunday, 1 = Monday

#### Inherited from

[`DateFormat`](DateFormat.md).[`firstDayOfWeek`](DateFormat.md#firstdayofweek)

#### Defined in

[src/base/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L40)

***

### groupSeparator?

> `optional` **groupSeparator**: `string`

Group separator

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`groupSeparator`](NumberFormat.md#groupseparator)

#### Defined in

[src/base/formatting.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L8)

***

### minimizedDayNames?

> `optional` **minimizedDayNames**: `string`[]

Array of two letter day names

#### Inherited from

[`DateFormat`](DateFormat.md).[`minimizedDayNames`](DateFormat.md#minimizeddaynames)

#### Defined in

[src/base/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L46)

***

### monthNames?

> `optional` **monthNames**: `string`[]

Array of month names

#### Inherited from

[`DateFormat`](DateFormat.md).[`monthNames`](DateFormat.md#monthnames)

#### Defined in

[src/base/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L48)

***

### nanSymbol?

> `optional` **nanSymbol**: `string`

Zero symbol

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`nanSymbol`](NumberFormat.md#nansymbol)

#### Defined in

[src/base/formatting.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L16)

***

### negativeSign?

> `optional` **negativeSign**: `string`

Negative sign

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`negativeSign`](NumberFormat.md#negativesign)

#### Defined in

[src/base/formatting.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L14)

***

### percentSymbol?

> `optional` **percentSymbol**: `string`

Percentage symbol

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`percentSymbol`](NumberFormat.md#percentsymbol)

#### Defined in

[src/base/formatting.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L18)

***

### pmDesignator?

> `optional` **pmDesignator**: `string`

PM designator

#### Inherited from

[`DateFormat`](DateFormat.md).[`pmDesignator`](DateFormat.md#pmdesignator)

#### Defined in

[src/base/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L36)

***

### positiveSign?

> `optional` **positiveSign**: `string`

Positive sign

#### Inherited from

[`NumberFormat`](NumberFormat.md).[`positiveSign`](NumberFormat.md#positivesign)

#### Defined in

[src/base/formatting.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L12)

***

### shortDayNames?

> `optional` **shortDayNames**: `string`[]

Array of short day names

#### Inherited from

[`DateFormat`](DateFormat.md).[`shortDayNames`](DateFormat.md#shortdaynames)

#### Defined in

[src/base/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L44)

***

### shortMonthNames?

> `optional` **shortMonthNames**: `string`[]

Array of short month names

#### Inherited from

[`DateFormat`](DateFormat.md).[`shortMonthNames`](DateFormat.md#shortmonthnames)

#### Defined in

[src/base/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L50)

***

### stringCompare()?

> `optional` **stringCompare**: (`a`, `b`) => `number`

Locale string comparison function, similar to .NET's StringComparer

#### Parameters

##### a

`string`

##### b

`string`

#### Returns

`number`

#### Defined in

[src/base/formatting.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L56)

***

### timeSeparator?

> `optional` **timeSeparator**: `string`

Time separator

#### Inherited from

[`DateFormat`](DateFormat.md).[`timeSeparator`](DateFormat.md#timeseparator)

#### Defined in

[src/base/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L38)

***

### toUpper()?

> `optional` **toUpper**: (`a`) => `string`

Locale string to upper case function

#### Parameters

##### a

`string`

#### Returns

`string`

#### Defined in

[src/base/formatting.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L58)
