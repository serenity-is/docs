[@serenity-is/corelib](../README.md) / Locale

# Interface: Locale

Interface for a locale, similar to .NET's CultureInfo

## Hierarchy

- [`NumberFormat`](NumberFormat.md)

- [`DateFormat`](DateFormat.md)

  ↳ **`Locale`**

## Table of contents

### Properties

- [amDesignator](Locale.md#amdesignator)
- [currencySymbol](Locale.md#currencysymbol)
- [dateFormat](Locale.md#dateformat)
- [dateOrder](Locale.md#dateorder)
- [dateSeparator](Locale.md#dateseparator)
- [dateTimeFormat](Locale.md#datetimeformat)
- [dayNames](Locale.md#daynames)
- [decimalDigits](Locale.md#decimaldigits)
- [decimalSeparator](Locale.md#decimalseparator)
- [firstDayOfWeek](Locale.md#firstdayofweek)
- [groupSeparator](Locale.md#groupseparator)
- [minimizedDayNames](Locale.md#minimizeddaynames)
- [monthNames](Locale.md#monthnames)
- [nanSymbol](Locale.md#nansymbol)
- [negativeSign](Locale.md#negativesign)
- [percentSymbol](Locale.md#percentsymbol)
- [pmDesignator](Locale.md#pmdesignator)
- [positiveSign](Locale.md#positivesign)
- [shortDayNames](Locale.md#shortdaynames)
- [shortMonthNames](Locale.md#shortmonthnames)
- [stringCompare](Locale.md#stringcompare)
- [timeSeparator](Locale.md#timeseparator)
- [toUpper](Locale.md#toupper)

## Properties

### amDesignator

• `Optional` **amDesignator**: `string`

AM designator

#### Inherited from

[DateFormat](DateFormat.md).[amDesignator](DateFormat.md#amdesignator)

#### Defined in

[src/base/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L34)

___

### currencySymbol

• `Optional` **currencySymbol**: `string`

Currency symbol

#### Inherited from

[NumberFormat](NumberFormat.md).[currencySymbol](NumberFormat.md#currencysymbol)

#### Defined in

[src/base/formatting.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L20)

___

### dateFormat

• `Optional` **dateFormat**: `string`

Default date format string

#### Inherited from

[DateFormat](DateFormat.md).[dateFormat](DateFormat.md#dateformat)

#### Defined in

[src/base/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L28)

___

### dateOrder

• `Optional` **dateOrder**: `string`

Date order, like dmy, or ymd

#### Inherited from

[DateFormat](DateFormat.md).[dateOrder](DateFormat.md#dateorder)

#### Defined in

[src/base/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L30)

___

### dateSeparator

• `Optional` **dateSeparator**: `string`

Date separator

#### Inherited from

[DateFormat](DateFormat.md).[dateSeparator](DateFormat.md#dateseparator)

#### Defined in

[src/base/formatting.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L26)

___

### dateTimeFormat

• `Optional` **dateTimeFormat**: `string`

Default date time format string

#### Inherited from

[DateFormat](DateFormat.md).[dateTimeFormat](DateFormat.md#datetimeformat)

#### Defined in

[src/base/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L32)

___

### dayNames

• `Optional` **dayNames**: `string`[]

Array of day names

#### Inherited from

[DateFormat](DateFormat.md).[dayNames](DateFormat.md#daynames)

#### Defined in

[src/base/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L42)

___

### decimalDigits

• `Optional` **decimalDigits**: `number`

Number of digits after decimal separator

#### Inherited from

[NumberFormat](NumberFormat.md).[decimalDigits](NumberFormat.md#decimaldigits)

#### Defined in

[src/base/formatting.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L10)

___

### decimalSeparator

• **decimalSeparator**: `string`

Decimal separator

#### Inherited from

[NumberFormat](NumberFormat.md).[decimalSeparator](NumberFormat.md#decimalseparator)

#### Defined in

[src/base/formatting.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L6)

___

### firstDayOfWeek

• `Optional` **firstDayOfWeek**: `number`

First day of week, 0 = Sunday, 1 = Monday

#### Inherited from

[DateFormat](DateFormat.md).[firstDayOfWeek](DateFormat.md#firstdayofweek)

#### Defined in

[src/base/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L40)

___

### groupSeparator

• `Optional` **groupSeparator**: `string`

Group separator

#### Inherited from

[NumberFormat](NumberFormat.md).[groupSeparator](NumberFormat.md#groupseparator)

#### Defined in

[src/base/formatting.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L8)

___

### minimizedDayNames

• `Optional` **minimizedDayNames**: `string`[]

Array of two letter day names

#### Inherited from

[DateFormat](DateFormat.md).[minimizedDayNames](DateFormat.md#minimizeddaynames)

#### Defined in

[src/base/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L46)

___

### monthNames

• `Optional` **monthNames**: `string`[]

Array of month names

#### Inherited from

[DateFormat](DateFormat.md).[monthNames](DateFormat.md#monthnames)

#### Defined in

[src/base/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L48)

___

### nanSymbol

• `Optional` **nanSymbol**: `string`

Zero symbol

#### Inherited from

[NumberFormat](NumberFormat.md).[nanSymbol](NumberFormat.md#nansymbol)

#### Defined in

[src/base/formatting.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L16)

___

### negativeSign

• `Optional` **negativeSign**: `string`

Negative sign

#### Inherited from

[NumberFormat](NumberFormat.md).[negativeSign](NumberFormat.md#negativesign)

#### Defined in

[src/base/formatting.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L14)

___

### percentSymbol

• `Optional` **percentSymbol**: `string`

Percentage symbol

#### Inherited from

[NumberFormat](NumberFormat.md).[percentSymbol](NumberFormat.md#percentsymbol)

#### Defined in

[src/base/formatting.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L18)

___

### pmDesignator

• `Optional` **pmDesignator**: `string`

PM designator

#### Inherited from

[DateFormat](DateFormat.md).[pmDesignator](DateFormat.md#pmdesignator)

#### Defined in

[src/base/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L36)

___

### positiveSign

• `Optional` **positiveSign**: `string`

Positive sign

#### Inherited from

[NumberFormat](NumberFormat.md).[positiveSign](NumberFormat.md#positivesign)

#### Defined in

[src/base/formatting.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L12)

___

### shortDayNames

• `Optional` **shortDayNames**: `string`[]

Array of short day names

#### Inherited from

[DateFormat](DateFormat.md).[shortDayNames](DateFormat.md#shortdaynames)

#### Defined in

[src/base/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L44)

___

### shortMonthNames

• `Optional` **shortMonthNames**: `string`[]

Array of short month names

#### Inherited from

[DateFormat](DateFormat.md).[shortMonthNames](DateFormat.md#shortmonthnames)

#### Defined in

[src/base/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L50)

___

### stringCompare

• `Optional` **stringCompare**: (`a`: `string`, `b`: `string`) => `number`

Locale string comparison function, similar to .NET's StringComparer

#### Type declaration

▸ (`a`, `b`): `number`

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |
| `b` | `string` |

##### Returns

`number`

#### Defined in

[src/base/formatting.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L56)

___

### timeSeparator

• `Optional` **timeSeparator**: `string`

Time separator

#### Inherited from

[DateFormat](DateFormat.md).[timeSeparator](DateFormat.md#timeseparator)

#### Defined in

[src/base/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L38)

___

### toUpper

• `Optional` **toUpper**: (`a`: `string`) => `string`

Locale string to upper case function

#### Type declaration

▸ (`a`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |

##### Returns

`string`

#### Defined in

[src/base/formatting.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L58)
