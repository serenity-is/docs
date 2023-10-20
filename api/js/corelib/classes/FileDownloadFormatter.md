[@serenity-is/corelib](../README.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Table of contents

### Constructors

- [constructor](FileDownloadFormatter.md#constructor)

### Properties

- [displayFormat](FileDownloadFormatter.md#displayformat)
- [iconClass](FileDownloadFormatter.md#iconclass)
- [originalNameProperty](FileDownloadFormatter.md#originalnameproperty)

### Methods

- [format](FileDownloadFormatter.md#format)
- [initializeColumn](FileDownloadFormatter.md#initializecolumn)
- [dbFileUrl](FileDownloadFormatter.md#dbfileurl)

## Constructors

### constructor

• **new FileDownloadFormatter**()

## Properties

### displayFormat

• **displayFormat**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L184)

___

### iconClass

• **iconClass**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L190)

___

### originalNameProperty

• **originalNameProperty**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L187)

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

[src/ui/formatters/formatters.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L147)

___

### initializeColumn

▸ **initializeColumn**(`column`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`<`any`\> |

#### Returns

`void`

#### Implementation of

[IInitializeColumn](IInitializeColumn.md).[initializeColumn](IInitializeColumn.md#initializecolumn)

#### Defined in

[src/ui/formatters/formatters.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L175)

___

### dbFileUrl

▸ `Static` **dbFileUrl**(`filename`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filename` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L170)
