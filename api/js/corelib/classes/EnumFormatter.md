[@serenity-is/corelib](../README.md) / EnumFormatter

# Class: EnumFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### new EnumFormatter()

> **new EnumFormatter**(`props`): [`EnumFormatter`](EnumFormatter.md)

#### Parameters

##### props

###### props.enumKey

`string`

#### Returns

[`EnumFormatter`](EnumFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L99)

## Properties

### props

> `readonly` **props**: `object` = `{}`

#### enumKey?

> `optional` **enumKey**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L99)

## Accessors

### enumKey

#### Get Signature

> **get** **enumKey**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **enumKey**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L116)

## Methods

### format()

> **format**(`ctx`): `string` \| `Element`

#### Parameters

##### ctx

`FormatterContext`\<`any`\>

#### Returns

`string` \| `Element`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L103)

***

### format()

> `static` **format**(`enumType`, `value`): `string`

#### Parameters

##### enumType

`any`

##### value

`any`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L119)

***

### getName()

> `static` **getName**(`enumType`, `value`): `string`

#### Parameters

##### enumType

`any`

##### value

`any`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L138)

***

### getText()

> `static` **getText**(`enumKey`, `name`): `string`

#### Parameters

##### enumKey

`string`

##### name

`string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L131)
