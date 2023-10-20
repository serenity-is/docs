[@serenity-is/corelib](../README.md) / EnumFormatter

# Class: EnumFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Table of contents

### Constructors

- [constructor](EnumFormatter.md#constructor)

### Properties

- [enumKey](EnumFormatter.md#enumkey)

### Methods

- [format](EnumFormatter.md#format)
- [format](EnumFormatter.md#format-1)
- [getName](EnumFormatter.md#getname)
- [getText](EnumFormatter.md#gettext)

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

[Formatter](../interfaces/Formatter.md).[format](../interfaces/Formatter.md#format)

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
