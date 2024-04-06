[@serenity-is/corelib](../README.md) / BooleanFormatter

# Class: BooleanFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Table of contents

### Constructors

- [constructor](BooleanFormatter.md#constructor)

### Properties

- [props](BooleanFormatter.md#props)

### Accessors

- [falseText](BooleanFormatter.md#falsetext)
- [trueText](BooleanFormatter.md#truetext)

### Methods

- [format](BooleanFormatter.md#format)

## Constructors

### constructor

• **new BooleanFormatter**(`props?`): [`BooleanFormatter`](BooleanFormatter.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.falseText?` | `string` |
| `props.trueText?` | `string` |

#### Returns

[`BooleanFormatter`](BooleanFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L19)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `falseText?` | `string` |
| `trueText?` | `string` |

#### Defined in

[src/ui/formatters/formatters.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L19)

## Accessors

### falseText

• `get` **falseText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L34)

• `set` **falseText**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L35)

___

### trueText

• `get` **trueText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L37)

• `set` **trueText**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L38)

## Methods

### format

▸ **format**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`\<`any`\> |

#### Returns

`string`

#### Implementation of

[Formatter](../interfaces/Formatter.md).[format](../interfaces/Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L23)
