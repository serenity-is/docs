[@serenity-is/corelib](../README.md) / EnumFormatter

# Class: EnumFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Table of contents

### Constructors

- [constructor](EnumFormatter.md#constructor)

### Properties

- [props](EnumFormatter.md#props)

### Accessors

- [enumKey](EnumFormatter.md#enumkey)

### Methods

- [format](EnumFormatter.md#format)
- [format](EnumFormatter.md#format-1)
- [getName](EnumFormatter.md#getname)
- [getText](EnumFormatter.md#gettext)

## Constructors

### constructor

• **new EnumFormatter**(`props?`): [`EnumFormatter`](EnumFormatter.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.enumKey?` | `string` |

#### Returns

[`EnumFormatter`](EnumFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L100)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `enumKey?` | `string` |

#### Defined in

[src/ui/formatters/formatters.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L100)

## Accessors

### enumKey

• `get` **enumKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L108)

• `set` **enumKey**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L109)

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

[src/ui/formatters/formatters.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L104)

___

### format

▸ **format**(`enumType`, `value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumType` | `any` |
| `value` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L111)

___

### getName

▸ **getName**(`enumType`, `value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumType` | `any` |
| `value` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L130)

___

### getText

▸ **getText**(`enumKey`, `name`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumKey` | `string` |
| `name` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L123)
