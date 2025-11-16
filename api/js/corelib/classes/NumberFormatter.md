[corelib](../README.md) / NumberFormatter

# Class: NumberFormatter

Defined in: [src/ui/formatters/numberformatter.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L5)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new NumberFormatter**(`props`): `NumberFormatter`

Defined in: [src/ui/formatters/numberformatter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L8)

#### Parameters

##### props

###### displayFormat?

`string`

#### Returns

`NumberFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/numberformatter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L8)

#### displayFormat?

> `optional` **displayFormat**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/numberformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L6)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/numberformatter.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L35)

##### Returns

`string`

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/numberformatter.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L36)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/numberformatter.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L12)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`string`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`value`, `format?`): `string`

Defined in: [src/ui/formatters/numberformatter.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/numberformatter.ts#L16)

#### Parameters

##### value

`any`

##### format?

`string`

#### Returns

`string`
