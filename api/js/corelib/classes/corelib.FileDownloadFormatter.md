[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

[corelib](../modules/corelib.md).FileDownloadFormatter

## Implements

- [`Formatter`](../interfaces/corelib_slick.Formatter.md)
- [`IInitializeColumn`](corelib.IInitializeColumn.md)

## Table of contents

### Constructors

- [constructor](corelib.FileDownloadFormatter.md#constructor)

### Properties

- [displayFormat](corelib.FileDownloadFormatter.md#displayformat)
- [iconClass](corelib.FileDownloadFormatter.md#iconclass)
- [originalNameProperty](corelib.FileDownloadFormatter.md#originalnameproperty)

### Methods

- [format](corelib.FileDownloadFormatter.md#format)
- [initializeColumn](corelib.FileDownloadFormatter.md#initializecolumn)
- [dbFileUrl](corelib.FileDownloadFormatter.md#dbfileurl)

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

[Formatter](../interfaces/corelib_slick.Formatter.md).[format](../interfaces/corelib_slick.Formatter.md#format)

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

[IInitializeColumn](corelib.IInitializeColumn.md).[initializeColumn](corelib.IInitializeColumn.md#initializecolumn)

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
