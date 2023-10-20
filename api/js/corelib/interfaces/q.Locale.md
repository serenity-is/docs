[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / Locale

# Interface: Locale

[q](../modules/q.md).Locale

Interface for a locale, similar to .NET's CultureInfo

## Hierarchy

- [`NumberFormat`](q.NumberFormat.md)

- [`DateFormat`](q.DateFormat.md)

  ↳ **`Locale`**

## Table of contents

### Properties

- [amDesignator](q.Locale.md#amdesignator)
- [currencySymbol](q.Locale.md#currencysymbol)
- [dateFormat](q.Locale.md#dateformat)
- [dateOrder](q.Locale.md#dateorder)
- [dateSeparator](q.Locale.md#dateseparator)
- [dateTimeFormat](q.Locale.md#datetimeformat)
- [dayNames](q.Locale.md#daynames)
- [decimalDigits](q.Locale.md#decimaldigits)
- [decimalSeparator](q.Locale.md#decimalseparator)
- [firstDayOfWeek](q.Locale.md#firstdayofweek)
- [groupSeparator](q.Locale.md#groupseparator)
- [minimizedDayNames](q.Locale.md#minimizeddaynames)
- [monthNames](q.Locale.md#monthnames)
- [nanSymbol](q.Locale.md#nansymbol)
- [negativeSign](q.Locale.md#negativesign)
- [percentSymbol](q.Locale.md#percentsymbol)
- [pmDesignator](q.Locale.md#pmdesignator)
- [positiveSign](q.Locale.md#positivesign)
- [shortDayNames](q.Locale.md#shortdaynames)
- [shortMonthNames](q.Locale.md#shortmonthnames)
- [stringCompare](q.Locale.md#stringcompare)
- [timeSeparator](q.Locale.md#timeseparator)
- [toUpper](q.Locale.md#toupper)

## Properties

### amDesignator

• `Optional` **amDesignator**: `string`

AM designator

#### Inherited from

[DateFormat](q.DateFormat.md).[amDesignator](q.DateFormat.md#amdesignator)

#### Defined in

[src/q/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L36)

___

### currencySymbol

• `Optional` **currencySymbol**: `string`

Currency symbol

#### Inherited from

[NumberFormat](q.NumberFormat.md).[currencySymbol](q.NumberFormat.md#currencysymbol)

#### Defined in

[src/q/formatting.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L22)

___

### dateFormat

• `Optional` **dateFormat**: `string`

Default date format string

#### Inherited from

[DateFormat](q.DateFormat.md).[dateFormat](q.DateFormat.md#dateformat)

#### Defined in

[src/q/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L30)

___

### dateOrder

• `Optional` **dateOrder**: `string`

Date order, like dmy, or ymd

#### Inherited from

[DateFormat](q.DateFormat.md).[dateOrder](q.DateFormat.md#dateorder)

#### Defined in

[src/q/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L32)

___

### dateSeparator

• `Optional` **dateSeparator**: `string`

Date separator

#### Inherited from

[DateFormat](q.DateFormat.md).[dateSeparator](q.DateFormat.md#dateseparator)

#### Defined in

[src/q/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L28)

___

### dateTimeFormat

• `Optional` **dateTimeFormat**: `string`

Default date time format string

#### Inherited from

[DateFormat](q.DateFormat.md).[dateTimeFormat](q.DateFormat.md#datetimeformat)

#### Defined in

[src/q/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L34)

___

### dayNames

• `Optional` **dayNames**: `string`[]

Array of day names

#### Inherited from

[DateFormat](q.DateFormat.md).[dayNames](q.DateFormat.md#daynames)

#### Defined in

[src/q/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L44)

___

### decimalDigits

• `Optional` **decimalDigits**: `number`

Number of digits after decimal separator

#### Inherited from

[NumberFormat](q.NumberFormat.md).[decimalDigits](q.NumberFormat.md#decimaldigits)

#### Defined in

[src/q/formatting.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L12)

___

### decimalSeparator

• **decimalSeparator**: `string`

Decimal separator

#### Inherited from

[NumberFormat](q.NumberFormat.md).[decimalSeparator](q.NumberFormat.md#decimalseparator)

#### Defined in

[src/q/formatting.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L8)

___

### firstDayOfWeek

• `Optional` **firstDayOfWeek**: `number`

First day of week, 0 = Sunday, 1 = Monday

#### Inherited from

[DateFormat](q.DateFormat.md).[firstDayOfWeek](q.DateFormat.md#firstdayofweek)

#### Defined in

[src/q/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L42)

___

### groupSeparator

• `Optional` **groupSeparator**: `string`

Group separator

#### Inherited from

[NumberFormat](q.NumberFormat.md).[groupSeparator](q.NumberFormat.md#groupseparator)

#### Defined in

[src/q/formatting.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L10)

___

### minimizedDayNames

• `Optional` **minimizedDayNames**: `string`[]

Array of two letter day names

#### Inherited from

[DateFormat](q.DateFormat.md).[minimizedDayNames](q.DateFormat.md#minimizeddaynames)

#### Defined in

[src/q/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L48)

___

### monthNames

• `Optional` **monthNames**: `string`[]

Array of month names

#### Inherited from

[DateFormat](q.DateFormat.md).[monthNames](q.DateFormat.md#monthnames)

#### Defined in

[src/q/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L50)

___

### nanSymbol

• `Optional` **nanSymbol**: `string`

Zero symbol

#### Inherited from

[NumberFormat](q.NumberFormat.md).[nanSymbol](q.NumberFormat.md#nansymbol)

#### Defined in

[src/q/formatting.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L18)

___

### negativeSign

• `Optional` **negativeSign**: `string`

Negative sign

#### Inherited from

[NumberFormat](q.NumberFormat.md).[negativeSign](q.NumberFormat.md#negativesign)

#### Defined in

[src/q/formatting.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L16)

___

### percentSymbol

• `Optional` **percentSymbol**: `string`

Percentage symbol

#### Inherited from

[NumberFormat](q.NumberFormat.md).[percentSymbol](q.NumberFormat.md#percentsymbol)

#### Defined in

[src/q/formatting.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L20)

___

### pmDesignator

• `Optional` **pmDesignator**: `string`

PM designator

#### Inherited from

[DateFormat](q.DateFormat.md).[pmDesignator](q.DateFormat.md#pmdesignator)

#### Defined in

[src/q/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L38)

___

### positiveSign

• `Optional` **positiveSign**: `string`

Positive sign

#### Inherited from

[NumberFormat](q.NumberFormat.md).[positiveSign](q.NumberFormat.md#positivesign)

#### Defined in

[src/q/formatting.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L14)

___

### shortDayNames

• `Optional` **shortDayNames**: `string`[]

Array of short day names

#### Inherited from

[DateFormat](q.DateFormat.md).[shortDayNames](q.DateFormat.md#shortdaynames)

#### Defined in

[src/q/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L46)

___

### shortMonthNames

• `Optional` **shortMonthNames**: `string`[]

Array of short month names

#### Inherited from

[DateFormat](q.DateFormat.md).[shortMonthNames](q.DateFormat.md#shortmonthnames)

#### Defined in

[src/q/formatting.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L52)

___

### stringCompare

• `Optional` **stringCompare**: (`a`: `string`, `b`: `string`) => `number`

#### Type declaration

▸ (`a`, `b`): `number`

Locale string comparison function, similar to .NET's StringComparer

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |
| `b` | `string` |

##### Returns

`number`

#### Defined in

[src/q/formatting.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L58)

___

### timeSeparator

• `Optional` **timeSeparator**: `string`

Time separator

#### Inherited from

[DateFormat](q.DateFormat.md).[timeSeparator](q.DateFormat.md#timeseparator)

#### Defined in

[src/q/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L40)

___

### toUpper

• `Optional` **toUpper**: (`a`: `string`) => `string`

#### Type declaration

▸ (`a`): `string`

Locale string to upper case function

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |

##### Returns

`string`

#### Defined in

[src/q/formatting.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L60)
