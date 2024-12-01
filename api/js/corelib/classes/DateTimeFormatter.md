[@serenity-is/corelib](../README.md) / DateTimeFormatter

# Class: DateTimeFormatter

## Extends

- [`DateFormatter`](DateFormatter.md)

## Constructors

### new DateTimeFormatter()

> **new DateTimeFormatter**(`props`): [`DateTimeFormatter`](DateTimeFormatter.md)

#### Parameters

##### props

###### props.displayFormat

`string`

#### Returns

[`DateTimeFormatter`](DateTimeFormatter.md)

#### Overrides

[`DateFormatter`](DateFormatter.md).[`constructor`](DateFormatter.md#constructors)

#### Defined in

[src/ui/formatters/formatters.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L91)

## Properties

### props

> `readonly` **props**: `object` = `{}`

#### displayFormat?

> `optional` **displayFormat**: `string`

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`props`](DateFormatter.md#props)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`displayFormat`](DateFormatter.md#displayformat-1)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`format`](DateFormatter.md#format)

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

#### Inherited from

[`DateFormatter`](DateFormatter.md).[`format`](DateFormatter.md#format-1)

#### Defined in

[src/ui/formatters/formatters.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L57)
