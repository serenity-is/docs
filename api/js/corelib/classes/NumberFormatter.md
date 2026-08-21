[@serenity-is/corelib](../README.md) / NumberFormatter

# Class: NumberFormatter

Defined in: [src/ui/formatters/numberformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L6)

Formats numeric values via [formatNumber](../functions/formatNumber.md) (default `"0.##"`).

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new NumberFormatter**(`props`): `NumberFormatter`

Defined in: [src/ui/formatters/numberformatter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L14)

Creates a new NumberFormatter.

#### Parameters

##### props

Formatter options.

###### displayFormat?

`string`

Number format string (default `"0.##"`).

#### Returns

`NumberFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/numberformatter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L14)

Formatter options.

#### displayFormat?

> `optional` **displayFormat**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/numberformatter.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L7)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/numberformatter.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L53)

Gets the number display format.

##### Returns

`string`

The display format string.

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/numberformatter.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L58)

Sets the number display format.

##### Parameters

###### value

`string`

The display format string.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/numberformatter.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L23)

Formats the cell value as a number string.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the cell value.

#### Returns

`string`

Formatted number string.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`value`, `format?`): `string`

Defined in: [src/ui/formatters/numberformatter.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L33)

Static helper to format any numeric-like value.

#### Parameters

##### value

`any`

Number or numeric string.

##### format?

`string`

Format string (default `"0.##"`).

#### Returns

`string`

Formatted string.
