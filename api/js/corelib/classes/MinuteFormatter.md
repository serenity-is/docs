[@serenity-is/corelib](../README.md) / MinuteFormatter

# Class: MinuteFormatter

Defined in: [src/ui/formatters/minuteformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/minuteformatter.ts#L6)

Formats an integer minute count as `HH:mm` (e.g. 90 → `"01:30"`).

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new MinuteFormatter**(): `MinuteFormatter`

#### Returns

`MinuteFormatter`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/minuteformatter.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/minuteformatter.ts#L7)

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/minuteformatter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/minuteformatter.ts#L14)

Formats the cell value as `HH:mm`.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the minute value.

#### Returns

`string`

`HH:mm` string.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`value`): `string`

Defined in: [src/ui/formatters/minuteformatter.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/minuteformatter.ts#L23)

Static helper to format minutes.

#### Parameters

##### value

`number`

Total minutes.

#### Returns

`string`

`HH:mm` string or empty if invalid.
