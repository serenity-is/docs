[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DateFormatter

# Class: DateFormatter

[corelib](../modules/corelib.md).DateFormatter

## Hierarchy

- **`DateFormatter`**

  ↳ [`DateTimeFormatter`](corelib.DateTimeFormatter.md)

## Implements

- [`Formatter`](../interfaces/slick.Formatter.md)

## Table of contents

### Constructors

- [constructor](corelib.DateFormatter.md#constructor)

### Properties

- [displayFormat](corelib.DateFormatter.md#displayformat)

### Methods

- [format](corelib.DateFormatter.md#format)
- [format](corelib.DateFormatter.md#format-1)

## Constructors

### constructor

• **new DateFormatter**()

#### Defined in

[src/ui/formatters/formatters.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L62)

## Properties

### displayFormat

• **displayFormat**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L91)

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

[src/ui/formatters/formatters.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L93)

___

### format

▸ `Static` **format**(`value`, `format?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |
| `format?` | `string` |

#### Returns

`any`

#### Defined in

[src/ui/formatters/formatters.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L66)
