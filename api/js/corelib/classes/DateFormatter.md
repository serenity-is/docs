[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / DateFormatter

# Class: DateFormatter

## Hierarchy

- **`DateFormatter`**

  ↳ [`DateTimeFormatter`](DateTimeFormatter.md)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Table of contents

### Constructors

- [constructor](DateFormatter.md#constructor)

### Properties

- [displayFormat](DateFormatter.md#displayformat)

### Methods

- [format](DateFormatter.md#format)
- [format](DateFormatter.md#format-1)

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

[Formatter](../interfaces/Formatter.md).[format](../interfaces/Formatter.md#format)

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
