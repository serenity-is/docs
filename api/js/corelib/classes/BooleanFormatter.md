[@serenity-is/corelib](../README.md) / BooleanFormatter

# Class: BooleanFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### new BooleanFormatter()

> **new BooleanFormatter**(`props`): [`BooleanFormatter`](BooleanFormatter.md)

#### Parameters

##### props

###### props.falseText

`string`

###### props.trueText

`string`

#### Returns

[`BooleanFormatter`](BooleanFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L19)

## Properties

### props

> `readonly` **props**: `object` = `{}`

#### falseText?

> `optional` **falseText**: `string`

#### trueText?

> `optional` **trueText**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L19)

## Accessors

### falseText

#### Get Signature

> **get** **falseText**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **falseText**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L34)

***

### trueText

#### Get Signature

> **get** **trueText**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **trueText**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L37)

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

[src/ui/formatters/formatters.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L23)
