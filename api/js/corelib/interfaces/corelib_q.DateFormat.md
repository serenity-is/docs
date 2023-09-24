[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / DateFormat

# Interface: DateFormat

[corelib/q](../modules/corelib_q.md).DateFormat

Interface for date formatting, similar to .NET's DateFormatInfo

## Hierarchy

- **`DateFormat`**

  ↳ [`Locale`](corelib_q.Locale.md)

## Table of contents

### Properties

- [amDesignator](corelib_q.DateFormat.md#amdesignator)
- [dateFormat](corelib_q.DateFormat.md#dateformat)
- [dateOrder](corelib_q.DateFormat.md#dateorder)
- [dateSeparator](corelib_q.DateFormat.md#dateseparator)
- [dateTimeFormat](corelib_q.DateFormat.md#datetimeformat)
- [dayNames](corelib_q.DateFormat.md#daynames)
- [firstDayOfWeek](corelib_q.DateFormat.md#firstdayofweek)
- [minimizedDayNames](corelib_q.DateFormat.md#minimizeddaynames)
- [monthNames](corelib_q.DateFormat.md#monthnames)
- [pmDesignator](corelib_q.DateFormat.md#pmdesignator)
- [shortDayNames](corelib_q.DateFormat.md#shortdaynames)
- [shortMonthNames](corelib_q.DateFormat.md#shortmonthnames)
- [timeSeparator](corelib_q.DateFormat.md#timeseparator)

## Properties

### amDesignator

• `Optional` **amDesignator**: `string`

AM designator

#### Defined in

[src/q/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L36)

___

### dateFormat

• `Optional` **dateFormat**: `string`

Default date format string

#### Defined in

[src/q/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L30)

___

### dateOrder

• `Optional` **dateOrder**: `string`

Date order, like dmy, or ymd

#### Defined in

[src/q/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L32)

___

### dateSeparator

• `Optional` **dateSeparator**: `string`

Date separator

#### Defined in

[src/q/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L28)

___

### dateTimeFormat

• `Optional` **dateTimeFormat**: `string`

Default date time format string

#### Defined in

[src/q/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L34)

___

### dayNames

• `Optional` **dayNames**: `string`[]

Array of day names

#### Defined in

[src/q/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L44)

___

### firstDayOfWeek

• `Optional` **firstDayOfWeek**: `number`

First day of week, 0 = Sunday, 1 = Monday

#### Defined in

[src/q/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L42)

___

### minimizedDayNames

• `Optional` **minimizedDayNames**: `string`[]

Array of two letter day names

#### Defined in

[src/q/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L48)

___

### monthNames

• `Optional` **monthNames**: `string`[]

Array of month names

#### Defined in

[src/q/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L50)

___

### pmDesignator

• `Optional` **pmDesignator**: `string`

PM designator

#### Defined in

[src/q/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L38)

___

### shortDayNames

• `Optional` **shortDayNames**: `string`[]

Array of short day names

#### Defined in

[src/q/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L46)

___

### shortMonthNames

• `Optional` **shortMonthNames**: `string`[]

Array of short month names

#### Defined in

[src/q/formatting.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L52)

___

### timeSeparator

• `Optional` **timeSeparator**: `string`

Time separator

#### Defined in

[src/q/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L40)
