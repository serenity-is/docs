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

[../base/dist/index.d.ts:1112](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1112)

___

### currencySymbol

• `Optional` **currencySymbol**: `string`

Currency symbol

#### Inherited from

[NumberFormat](NumberFormat.md).[currencySymbol](NumberFormat.md#currencysymbol)

#### Defined in

[../base/dist/index.d.ts:1099](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1099)

___

### dateFormat

• `Optional` **dateFormat**: `string`

Default date format string

#### Inherited from

[DateFormat](DateFormat.md).[dateFormat](DateFormat.md#dateformat)

#### Defined in

[../base/dist/index.d.ts:1106](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1106)

___

### dateOrder

• `Optional` **dateOrder**: `string`

Date order, like dmy, or ymd

#### Inherited from

[DateFormat](DateFormat.md).[dateOrder](DateFormat.md#dateorder)

#### Defined in

[../base/dist/index.d.ts:1108](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1108)

___

### dateSeparator

• `Optional` **dateSeparator**: `string`

Date separator

#### Inherited from

[DateFormat](DateFormat.md).[dateSeparator](DateFormat.md#dateseparator)

#### Defined in

[../base/dist/index.d.ts:1104](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1104)

___

### dateTimeFormat

• `Optional` **dateTimeFormat**: `string`

Default date time format string

#### Inherited from

[DateFormat](DateFormat.md).[dateTimeFormat](DateFormat.md#datetimeformat)

#### Defined in

[../base/dist/index.d.ts:1110](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1110)

___

### dayNames

• `Optional` **dayNames**: `string`[]

Array of day names

#### Inherited from

[DateFormat](DateFormat.md).[dayNames](DateFormat.md#daynames)

#### Defined in

[../base/dist/index.d.ts:1120](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1120)

___

### decimalDigits

• `Optional` **decimalDigits**: `number`

Number of digits after decimal separator

#### Inherited from

[NumberFormat](NumberFormat.md).[decimalDigits](NumberFormat.md#decimaldigits)

#### Defined in

[../base/dist/index.d.ts:1089](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1089)

___

### decimalSeparator

• **decimalSeparator**: `string`

Decimal separator

#### Inherited from

[NumberFormat](NumberFormat.md).[decimalSeparator](NumberFormat.md#decimalseparator)

#### Defined in

[../base/dist/index.d.ts:1085](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1085)

___

### firstDayOfWeek

• `Optional` **firstDayOfWeek**: `number`

First day of week, 0 = Sunday, 1 = Monday

#### Inherited from

[DateFormat](DateFormat.md).[firstDayOfWeek](DateFormat.md#firstdayofweek)

#### Defined in

[../base/dist/index.d.ts:1118](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1118)

___

### groupSeparator

• `Optional` **groupSeparator**: `string`

Group separator

#### Inherited from

[NumberFormat](NumberFormat.md).[groupSeparator](NumberFormat.md#groupseparator)

#### Defined in

[../base/dist/index.d.ts:1087](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1087)

___

### minimizedDayNames

• `Optional` **minimizedDayNames**: `string`[]

Array of two letter day names

#### Inherited from

[DateFormat](DateFormat.md).[minimizedDayNames](DateFormat.md#minimizeddaynames)

#### Defined in

[../base/dist/index.d.ts:1124](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1124)

___

### monthNames

• `Optional` **monthNames**: `string`[]

Array of month names

#### Inherited from

[DateFormat](DateFormat.md).[monthNames](DateFormat.md#monthnames)

#### Defined in

[../base/dist/index.d.ts:1126](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1126)

___

### nanSymbol

• `Optional` **nanSymbol**: `string`

Zero symbol

#### Inherited from

[NumberFormat](NumberFormat.md).[nanSymbol](NumberFormat.md#nansymbol)

#### Defined in

[../base/dist/index.d.ts:1095](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1095)

___

### negativeSign

• `Optional` **negativeSign**: `string`

Negative sign

#### Inherited from

[NumberFormat](NumberFormat.md).[negativeSign](NumberFormat.md#negativesign)

#### Defined in

[../base/dist/index.d.ts:1093](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1093)

___

### percentSymbol

• `Optional` **percentSymbol**: `string`

Percentage symbol

#### Inherited from

[NumberFormat](NumberFormat.md).[percentSymbol](NumberFormat.md#percentsymbol)

#### Defined in

[../base/dist/index.d.ts:1097](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1097)

___

### pmDesignator

• `Optional` **pmDesignator**: `string`

PM designator

#### Inherited from

[DateFormat](DateFormat.md).[pmDesignator](DateFormat.md#pmdesignator)

#### Defined in

[../base/dist/index.d.ts:1114](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1114)

___

### positiveSign

• `Optional` **positiveSign**: `string`

Positive sign

#### Inherited from

[NumberFormat](NumberFormat.md).[positiveSign](NumberFormat.md#positivesign)

#### Defined in

[../base/dist/index.d.ts:1091](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1091)

___

### shortDayNames

• `Optional` **shortDayNames**: `string`[]

Array of short day names

#### Inherited from

[DateFormat](DateFormat.md).[shortDayNames](DateFormat.md#shortdaynames)

#### Defined in

[../base/dist/index.d.ts:1122](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1122)

___

### shortMonthNames

• `Optional` **shortMonthNames**: `string`[]

Array of short month names

#### Inherited from

[DateFormat](DateFormat.md).[shortMonthNames](DateFormat.md#shortmonthnames)

#### Defined in

[../base/dist/index.d.ts:1128](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1128)

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

[../base/dist/index.d.ts:1133](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1133)

___

### timeSeparator

• `Optional` **timeSeparator**: `string`

Time separator

#### Inherited from

[DateFormat](DateFormat.md).[timeSeparator](DateFormat.md#timeseparator)

#### Defined in

[../base/dist/index.d.ts:1116](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1116)

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

[../base/dist/index.d.ts:1135](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1135)
