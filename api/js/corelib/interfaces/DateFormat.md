[@serenity-is/corelib](../README.md) / DateFormat

# Interface: DateFormat

Interface for date formatting, similar to .NET's DateFormatInfo

## Hierarchy

- **`DateFormat`**

  ↳ [`Locale`](Locale.md)

## Table of contents

### Properties

- [amDesignator](DateFormat.md#amdesignator)
- [dateFormat](DateFormat.md#dateformat)
- [dateOrder](DateFormat.md#dateorder)
- [dateSeparator](DateFormat.md#dateseparator)
- [dateTimeFormat](DateFormat.md#datetimeformat)
- [dayNames](DateFormat.md#daynames)
- [firstDayOfWeek](DateFormat.md#firstdayofweek)
- [minimizedDayNames](DateFormat.md#minimizeddaynames)
- [monthNames](DateFormat.md#monthnames)
- [pmDesignator](DateFormat.md#pmdesignator)
- [shortDayNames](DateFormat.md#shortdaynames)
- [shortMonthNames](DateFormat.md#shortmonthnames)
- [timeSeparator](DateFormat.md#timeseparator)

## Properties

### amDesignator

• `Optional` **amDesignator**: `string`

AM designator

#### Defined in

[src/base/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L34)

___

### dateFormat

• `Optional` **dateFormat**: `string`

Default date format string

#### Defined in

[src/base/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L28)

___

### dateOrder

• `Optional` **dateOrder**: `string`

Date order, like dmy, or ymd

#### Defined in

[src/base/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L30)

___

### dateSeparator

• `Optional` **dateSeparator**: `string`

Date separator

#### Defined in

[src/base/formatting.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L26)

___

### dateTimeFormat

• `Optional` **dateTimeFormat**: `string`

Default date time format string

#### Defined in

[src/base/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L32)

___

### dayNames

• `Optional` **dayNames**: `string`[]

Array of day names

#### Defined in

[src/base/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L42)

___

### firstDayOfWeek

• `Optional` **firstDayOfWeek**: `number`

First day of week, 0 = Sunday, 1 = Monday

#### Defined in

[src/base/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L40)

___

### minimizedDayNames

• `Optional` **minimizedDayNames**: `string`[]

Array of two letter day names

#### Defined in

[src/base/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L46)

___

### monthNames

• `Optional` **monthNames**: `string`[]

Array of month names

#### Defined in

[src/base/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L48)

___

### pmDesignator

• `Optional` **pmDesignator**: `string`

PM designator

#### Defined in

[src/base/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L36)

___

### shortDayNames

• `Optional` **shortDayNames**: `string`[]

Array of short day names

#### Defined in

[src/base/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L44)

___

### shortMonthNames

• `Optional` **shortMonthNames**: `string`[]

Array of short month names

#### Defined in

[src/base/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L50)

___

### timeSeparator

• `Optional` **timeSeparator**: `string`

Time separator

#### Defined in

[src/base/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L38)
