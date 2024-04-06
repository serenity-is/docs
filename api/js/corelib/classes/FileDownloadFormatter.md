[@serenity-is/corelib](../README.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Table of contents

### Constructors

- [constructor](FileDownloadFormatter.md#constructor)

### Properties

- [props](FileDownloadFormatter.md#props)

### Accessors

- [displayFormat](FileDownloadFormatter.md#displayformat)
- [iconClass](FileDownloadFormatter.md#iconclass)
- [originalNameProperty](FileDownloadFormatter.md#originalnameproperty)

### Methods

- [format](FileDownloadFormatter.md#format)
- [initializeColumn](FileDownloadFormatter.md#initializecolumn)
- [dbFileUrl](FileDownloadFormatter.md#dbfileurl)

## Constructors

### constructor

• **new FileDownloadFormatter**(`props?`): [`FileDownloadFormatter`](FileDownloadFormatter.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.displayFormat?` | `string` |
| `props.iconClass?` | `string` |
| `props.originalNameProperty?` | `string` |

#### Returns

[`FileDownloadFormatter`](FileDownloadFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L141)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `displayFormat?` | `string` |
| `iconClass?` | `string` |
| `originalNameProperty?` | `string` |

#### Defined in

[src/ui/formatters/formatters.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L141)

## Accessors

### displayFormat

• `get` **displayFormat**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L177)

• `set` **displayFormat**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L178)

___

### iconClass

• `get` **iconClass**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L183)

• `set` **iconClass**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L184)

___

### originalNameProperty

• `get` **originalNameProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L180)

• `set` **originalNameProperty**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L181)

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

[src/ui/formatters/formatters.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L145)

___

### initializeColumn

▸ **initializeColumn**(`column`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`\<`any`\> |

#### Returns

`void`

#### Implementation of

[IInitializeColumn](IInitializeColumn.md).[initializeColumn](IInitializeColumn.md#initializecolumn)

#### Defined in

[src/ui/formatters/formatters.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L169)

___

### dbFileUrl

▸ **dbFileUrl**(`filename`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filename` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L164)
