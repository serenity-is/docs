[corelib](../README.md) / DateFormatter

# Class: DateFormatter

Defined in: [src/ui/formatters/dateformatter.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L5)

## Extended by

- [`DateTimeFormatter`](DateTimeFormatter.md)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new DateFormatter**(`props`): `DateFormatter`

Defined in: [src/ui/formatters/dateformatter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L8)

#### Parameters

##### props

###### displayFormat?

`string`

#### Returns

`DateFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/dateformatter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L8)

#### displayFormat?

> `optional` **displayFormat**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/dateformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L6)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/dateformatter.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L37)

##### Returns

`string`

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/dateformatter.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L38)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/dateformatter.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L40)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`string`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`value`, `format?`): `any`

Defined in: [src/ui/formatters/dateformatter.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L13)

#### Parameters

##### value

`any`

##### format?

`string`

#### Returns

`any`
