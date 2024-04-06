[@serenity-is/corelib](../README.md) / Uploader

# Class: Uploader

## Table of contents

### Constructors

- [constructor](Uploader.md#constructor)

### Properties

- [defaults](Uploader.md#defaults)
- [requestDefaults](Uploader.md#requestdefaults)

### Methods

- [uploadBatch](Uploader.md#uploadbatch)
- [errorHandler](Uploader.md#errorhandler)

## Constructors

### constructor

• **new Uploader**(`opt`): [`Uploader`](Uploader.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`UploaderOptions`](../interfaces/UploaderOptions.md) |

#### Returns

[`Uploader`](Uploader.md)

#### Defined in

[src/base/uploader.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L80)

## Properties

### defaults

▪ `Static` **defaults**: `Partial`\<[`UploaderOptions`](../interfaces/UploaderOptions.md)\>

#### Defined in

[src/base/uploader.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L131)

___

### requestDefaults

▪ `Static` **requestDefaults**: `Partial`\<[`UploaderRequest`](../interfaces/UploaderRequest.md)\>

#### Defined in

[src/base/uploader.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L137)

## Methods

### uploadBatch

▸ **uploadBatch**(`batch`, `request?`): `Promise`\<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `batch` | [`UploaderBatch`](../interfaces/UploaderBatch.md) |
| `request?` | [`UploaderRequest`](../interfaces/UploaderRequest.md) |

#### Returns

`Promise`\<`void`\>

#### Defined in

[src/base/uploader.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L332)

___

### errorHandler

▸ **errorHandler**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`UploaderErrorData`](../interfaces/UploaderErrorData.md) |

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L440)
