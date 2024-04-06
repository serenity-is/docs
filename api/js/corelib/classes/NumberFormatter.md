[@serenity-is/corelib](../README.md) / NumberFormatter

# Class: NumberFormatter

## Table of contents

### Constructors

- [constructor](NumberFormatter.md#constructor)

### Properties

- [props](NumberFormatter.md#props)

### Accessors

- [displayFormat](NumberFormatter.md#displayformat)

### Methods

- [format](NumberFormatter.md#format)
- [format](NumberFormatter.md#format-1)

## Constructors

### constructor

• **new NumberFormatter**(`props?`): [`NumberFormatter`](NumberFormatter.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.displayFormat?` | `string` |

#### Returns

[`NumberFormatter`](NumberFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L218)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `displayFormat?` | `string` |

#### Defined in

[src/ui/formatters/formatters.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L218)

## Accessors

### displayFormat

• `get` **displayFormat**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L245)

• `set` **displayFormat**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L246)

## Methods

### format

▸ **format**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`\<`any`\> |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:222](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L222)

___

### format

▸ **format**(`value`, `format?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |
| `format?` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L226)
