[@serenity-is/corelib](../README.md) / DateTimeFormatter

# Class: DateTimeFormatter

Defined in: [src/ui/formatters/datetimeformatter.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/datetimeformatter.ts#L4)

## Extends

- [`DateFormatter`](DateFormatter.md)

## Constructors

### Constructor

> **new DateTimeFormatter**(`props`): `DateTimeFormatter`

Defined in: [src/ui/formatters/datetimeformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/datetimeformatter.ts#L6)

#### Parameters

##### props

###### displayFormat?

`string`

#### Returns

`DateTimeFormatter`

#### Overrides

[`DateFormatter`](DateFormatter.md).[`constructor`](DateFormatter.md#constructor)

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/dateformatter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L8)

#### displayFormat?

> `optional` **displayFormat**: `string`

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`props`](DateFormatter.md#props)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/datetimeformatter.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/datetimeformatter.ts#L5)

#### Overrides

[`DateFormatter`](DateFormatter.md).[`[typeInfo]`](DateFormatter.md#typeinfo)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`displayFormat`](DateFormatter.md#displayformat)

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/dateformatter.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/dateformatter.ts#L40)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`string`

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`format`](DateFormatter.md#format)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`format`](DateFormatter.md#format-2)
