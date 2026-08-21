[@serenity-is/corelib](../README.md) / DateTimeFormatter

# Class: DateTimeFormatter

Defined in: [src/ui/formatters/datetimeformatter.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/datetimeformatter.ts#L5)

Variant of [DateFormatter](DateFormatter.md) that defaults to `Culture.dateTimeFormat`.

## Extends

- [`DateFormatter`](DateFormatter.md)

## Constructors

### Constructor

> **new DateTimeFormatter**(`props`): `DateTimeFormatter`

Defined in: [src/ui/formatters/datetimeformatter.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/datetimeformatter.ts#L12)

Creates a new DateTimeFormatter.

#### Parameters

##### props

Formatter options.

###### displayFormat?

`string`

Date-time format string (default `Culture.dateTimeFormat`).

#### Returns

`DateTimeFormatter`

#### Overrides

[`DateFormatter`](DateFormatter.md).[`constructor`](DateFormatter.md#constructor)

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/dateformatter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L14)

Formatter options.

#### displayFormat?

> `optional` **displayFormat**: `string`

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`props`](DateFormatter.md#props)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/datetimeformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/datetimeformatter.ts#L6)

#### Overrides

[`DateFormatter`](DateFormatter.md).[`[typeInfo]`](DateFormatter.md#typeinfo)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`displayFormat`](DateFormatter.md#displayformat)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`format`](DateFormatter.md#format)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`format`](DateFormatter.md#format-2)
