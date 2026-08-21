[@serenity-is/corelib](../README.md) / DateFormatter

# Class: DateFormatter

Defined in: [src/ui/formatters/dateformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L6)

Formats date values using [formatDate](../functions/formatDate.md) / [Culture.dateFormat](../interfaces/DateFormat.md#dateformat).

## Extended by

- [`DateTimeFormatter`](DateTimeFormatter.md)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new DateFormatter**(`props`): `DateFormatter`

Defined in: [src/ui/formatters/dateformatter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L14)

Creates a new DateFormatter.

#### Parameters

##### props

Formatter options.

###### displayFormat?

`string`

Date format string (default `Culture.dateFormat`).

#### Returns

`DateFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/dateformatter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L14)

Formatter options.

#### displayFormat?

> `optional` **displayFormat**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/dateformatter.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L7)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/dateformatter.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L50)

Gets the date display format.

##### Returns

`string`

The display format string.

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/dateformatter.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L55)

Sets the date display format.

##### Parameters

###### value

`string`

The display format string.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/dateformatter.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L62)

Formats the cell value as a date string.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the cell value.

#### Returns

`string`

HTML-encoded formatted date string.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`value`, `format?`): `any`

Defined in: [src/ui/formatters/dateformatter.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L25)

Static helper to format any date-like value.

#### Parameters

##### value

`any`

Date instance or ISO string.

##### format?

`string`

Format string (defaults to culture format).

#### Returns

`any`

HTML-encoded formatted string.
