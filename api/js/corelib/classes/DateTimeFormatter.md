[@serenity-is/corelib](../README.md) / DateTimeFormatter

# Class: DateTimeFormatter

## Hierarchy

- [`DateFormatter`](DateFormatter.md)

  ↳ **`DateTimeFormatter`**

## Table of contents

### Constructors

- [constructor](DateTimeFormatter.md#constructor)

### Properties

- [props](DateTimeFormatter.md#props)

### Accessors

- [displayFormat](DateTimeFormatter.md#displayformat)

### Methods

- [format](DateTimeFormatter.md#format)
- [format](DateTimeFormatter.md#format-1)

## Constructors

### constructor

• **new DateTimeFormatter**(): [`DateTimeFormatter`](DateTimeFormatter.md)

#### Returns

[`DateTimeFormatter`](DateTimeFormatter.md)

#### Overrides

[DateFormatter](DateFormatter.md).[constructor](DateFormatter.md#constructor)

#### Defined in

[src/ui/formatters/formatters.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L91)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `displayFormat?` | `string` |

#### Inherited from

[DateFormatter](DateFormatter.md).[props](DateFormatter.md#props)

#### Defined in

[src/ui/formatters/formatters.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L52)

## Accessors

### displayFormat

• `get` **displayFormat**(): `string`

#### Returns

`string`

#### Inherited from

DateFormatter.displayFormat

#### Defined in

[src/ui/formatters/formatters.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L81)

• `set` **displayFormat**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

DateFormatter.displayFormat

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

#### Inherited from

[DateFormatter](DateFormatter.md).[format](DateFormatter.md#format)

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

#### Inherited from

[DateFormatter](DateFormatter.md).[format](DateFormatter.md#format-1)

#### Defined in

[src/ui/formatters/formatters.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L57)
