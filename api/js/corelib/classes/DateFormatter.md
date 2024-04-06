[@serenity-is/corelib](../README.md) / DateFormatter

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

- [props](DateFormatter.md#props)

### Accessors

- [displayFormat](DateFormatter.md#displayformat)

### Methods

- [format](DateFormatter.md#format)
- [format](DateFormatter.md#format-1)

## Constructors

### constructor

• **new DateFormatter**(`props?`): [`DateFormatter`](DateFormatter.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.displayFormat?` | `string` |

#### Returns

[`DateFormatter`](DateFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L52)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `displayFormat?` | `string` |

#### Defined in

[src/ui/formatters/formatters.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L52)

## Accessors

### displayFormat

• `get` **displayFormat**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L81)

• `set` **displayFormat**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L82)

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

[src/ui/formatters/formatters.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L84)

___

### format

▸ **format**(`value`, `format?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |
| `format?` | `string` |

#### Returns

`any`

#### Defined in

[src/ui/formatters/formatters.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L57)
