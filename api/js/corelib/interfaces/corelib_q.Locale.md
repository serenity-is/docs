[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / Locale

# Interface: Locale

[corelib/q](../modules/corelib_q.md).Locale

## Hierarchy

- [`NumberFormat`](corelib_q.NumberFormat.md)

- [`DateFormat`](corelib_q.DateFormat.md)

  ↳ **`Locale`**

## Table of contents

### Properties

- [amDesignator](corelib_q.Locale.md#amdesignator)
- [currencySymbol](corelib_q.Locale.md#currencysymbol)
- [dateFormat](corelib_q.Locale.md#dateformat)
- [dateOrder](corelib_q.Locale.md#dateorder)
- [dateSeparator](corelib_q.Locale.md#dateseparator)
- [dateTimeFormat](corelib_q.Locale.md#datetimeformat)
- [dayNames](corelib_q.Locale.md#daynames)
- [decimalDigits](corelib_q.Locale.md#decimaldigits)
- [decimalSeparator](corelib_q.Locale.md#decimalseparator)
- [firstDayOfWeek](corelib_q.Locale.md#firstdayofweek)
- [groupSeparator](corelib_q.Locale.md#groupseparator)
- [minimizedDayNames](corelib_q.Locale.md#minimizeddaynames)
- [monthNames](corelib_q.Locale.md#monthnames)
- [nanSymbol](corelib_q.Locale.md#nansymbol)
- [negativeSign](corelib_q.Locale.md#negativesign)
- [percentSymbol](corelib_q.Locale.md#percentsymbol)
- [pmDesignator](corelib_q.Locale.md#pmdesignator)
- [positiveSign](corelib_q.Locale.md#positivesign)
- [shortDayNames](corelib_q.Locale.md#shortdaynames)
- [shortMonthNames](corelib_q.Locale.md#shortmonthnames)
- [stringCompare](corelib_q.Locale.md#stringcompare)
- [timeSeparator](corelib_q.Locale.md#timeseparator)
- [toUpper](corelib_q.Locale.md#toupper)

## Properties

### amDesignator

• `Optional` **amDesignator**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[amDesignator](corelib_q.DateFormat.md#amdesignator)

#### Defined in

[src/q/formatting.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;20)

___

### currencySymbol

• `Optional` **currencySymbol**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[currencySymbol](corelib_q.NumberFormat.md#currencysymbol)

#### Defined in

[src/q/formatting.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;12)

___

### dateFormat

• `Optional` **dateFormat**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[dateFormat](corelib_q.DateFormat.md#dateformat)

#### Defined in

[src/q/formatting.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;17)

___

### dateOrder

• `Optional` **dateOrder**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[dateOrder](corelib_q.DateFormat.md#dateorder)

#### Defined in

[src/q/formatting.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;18)

___

### dateSeparator

• `Optional` **dateSeparator**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[dateSeparator](corelib_q.DateFormat.md#dateseparator)

#### Defined in

[src/q/formatting.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;16)

___

### dateTimeFormat

• `Optional` **dateTimeFormat**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[dateTimeFormat](corelib_q.DateFormat.md#datetimeformat)

#### Defined in

[src/q/formatting.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;19)

___

### dayNames

• `Optional` **dayNames**: `string`[]

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[dayNames](corelib_q.DateFormat.md#daynames)

#### Defined in

[src/q/formatting.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;24)

___

### decimalDigits

• `Optional` **decimalDigits**: `number`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[decimalDigits](corelib_q.NumberFormat.md#decimaldigits)

#### Defined in

[src/q/formatting.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;7)

___

### decimalSeparator

• **decimalSeparator**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[decimalSeparator](corelib_q.NumberFormat.md#decimalseparator)

#### Defined in

[src/q/formatting.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;5)

___

### firstDayOfWeek

• `Optional` **firstDayOfWeek**: `number`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[firstDayOfWeek](corelib_q.DateFormat.md#firstdayofweek)

#### Defined in

[src/q/formatting.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;23)

___

### groupSeparator

• `Optional` **groupSeparator**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[groupSeparator](corelib_q.NumberFormat.md#groupseparator)

#### Defined in

[src/q/formatting.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;6)

___

### minimizedDayNames

• `Optional` **minimizedDayNames**: `string`[]

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[minimizedDayNames](corelib_q.DateFormat.md#minimizeddaynames)

#### Defined in

[src/q/formatting.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;26)

___

### monthNames

• `Optional` **monthNames**: `string`[]

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[monthNames](corelib_q.DateFormat.md#monthnames)

#### Defined in

[src/q/formatting.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;27)

___

### nanSymbol

• `Optional` **nanSymbol**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[nanSymbol](corelib_q.NumberFormat.md#nansymbol)

#### Defined in

[src/q/formatting.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;10)

___

### negativeSign

• `Optional` **negativeSign**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[negativeSign](corelib_q.NumberFormat.md#negativesign)

#### Defined in

[src/q/formatting.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;9)

___

### percentSymbol

• `Optional` **percentSymbol**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[percentSymbol](corelib_q.NumberFormat.md#percentsymbol)

#### Defined in

[src/q/formatting.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;11)

___

### pmDesignator

• `Optional` **pmDesignator**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[pmDesignator](corelib_q.DateFormat.md#pmdesignator)

#### Defined in

[src/q/formatting.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;21)

___

### positiveSign

• `Optional` **positiveSign**: `string`

#### Inherited from

[NumberFormat](corelib_q.NumberFormat.md).[positiveSign](corelib_q.NumberFormat.md#positivesign)

#### Defined in

[src/q/formatting.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;8)

___

### shortDayNames

• `Optional` **shortDayNames**: `string`[]

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[shortDayNames](corelib_q.DateFormat.md#shortdaynames)

#### Defined in

[src/q/formatting.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;25)

___

### shortMonthNames

• `Optional` **shortMonthNames**: `string`[]

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[shortMonthNames](corelib_q.DateFormat.md#shortmonthnames)

#### Defined in

[src/q/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;28)

___

### stringCompare

• `Optional` **stringCompare**: (`a`: `string`, `b`: `string`) => `number`

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

[src/q/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;32)

___

### timeSeparator

• `Optional` **timeSeparator**: `string`

#### Inherited from

[DateFormat](corelib_q.DateFormat.md).[timeSeparator](corelib_q.DateFormat.md#timeseparator)

#### Defined in

[src/q/formatting.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;22)

___

### toUpper

• `Optional` **toUpper**: (`a`: `string`) => `string`

#### Type declaration

▸ (`a`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |

##### Returns

`string`

#### Defined in

[src/q/formatting.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#line&#x3D;33)
