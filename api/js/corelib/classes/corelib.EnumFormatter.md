[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / EnumFormatter

# Class: EnumFormatter

[corelib](../modules/corelib.md).EnumFormatter

## Implements

- [`Formatter`](../interfaces/slick.Formatter.md)

## Table of contents

### Constructors

- [constructor](corelib.EnumFormatter.md#constructor)

### Properties

- [enumKey](corelib.EnumFormatter.md#enumkey)

### Methods

- [format](corelib.EnumFormatter.md#format)
- [format](corelib.EnumFormatter.md#format-1)
- [getName](corelib.EnumFormatter.md#getname)
- [getText](corelib.EnumFormatter.md#gettext)

## Constructors

### constructor

• **new EnumFormatter**()

## Properties

### enumKey

• **enumKey**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L114)

## Methods

### format

▸ **format**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`<`any`\> |

#### Returns

`string`

#### Implementation of

[Formatter](../interfaces/slick.Formatter.md).[format](../interfaces/slick.Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L109)

___

### format

▸ `Static` **format**(`enumType`, `value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumType` | `any` |
| `value` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L116)

___

### getName

▸ `Static` **getName**(`enumType`, `value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumType` | `any` |
| `value` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L136)

___

### getText

▸ `Static` **getText**(`enumKey`, `name`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumKey` | `string` |
| `name` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L128)
