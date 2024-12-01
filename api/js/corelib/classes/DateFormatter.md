[@serenity-is/corelib](../README.md) / DateFormatter

# Class: DateFormatter

## Extended by

- [`DateTimeFormatter`](DateTimeFormatter.md)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### new DateFormatter()

> **new DateFormatter**(`props`): [`DateFormatter`](DateFormatter.md)

#### Parameters

##### props

###### props.displayFormat

`string`

#### Returns

[`DateFormatter`](DateFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L52)

## Properties

### props

> `readonly` **props**: `object` = `{}`

#### displayFormat?

> `optional` **displayFormat**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L52)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **displayFormat**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L81)

## Methods

### format()

> **format**(`ctx`): `string`

#### Parameters

##### ctx

`FormatterContext`\<`any`\>

#### Returns

`string`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L84)

***

### format()

> `static` **format**(`value`, `format`?): `any`

#### Parameters

##### value

`any`

##### format?

`string`

#### Returns

`any`

#### Defined in

[src/ui/formatters/formatters.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L57)
