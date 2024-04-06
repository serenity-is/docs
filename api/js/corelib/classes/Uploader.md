[@serenity-is/corelib](../README.md) / Uploader

# Class: Uploader

## Table of contents

### Constructors

- [constructor](Uploader.md#constructor)

### Properties

- [addToBatch](Uploader.md#addtobatch)
- [arrayApi](Uploader.md#arrayapi)
- [batch](Uploader.md#batch)
- [endBatch](Uploader.md#endbatch)
- [entriesApi](Uploader.md#entriesapi)
- [getMatchingItems](Uploader.md#getmatchingitems)
- [getTypePredicate](Uploader.md#gettypepredicate)
- [isMultiple](Uploader.md#ismultiple)
- [newBatch](Uploader.md#newbatch)
- [opt](Uploader.md#opt)
- [watchDropZone](Uploader.md#watchdropzone)
- [watchInput](Uploader.md#watchinput)
- [defaults](Uploader.md#defaults)
- [errorHandler](Uploader.md#errorhandler)
- [requestDefaults](Uploader.md#requestdefaults)

### Methods

- [uploadBatch](Uploader.md#uploadbatch)

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

[../base/dist/index.d.ts:1675](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1675)

## Properties

### addToBatch

• `Private` **addToBatch**: `any`

#### Defined in

[../base/dist/index.d.ts:1677](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1677)

___

### arrayApi

• `Private` **arrayApi**: `any`

#### Defined in

[../base/dist/index.d.ts:1686](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1686)

___

### batch

• `Private` **batch**: `any`

#### Defined in

[../base/dist/index.d.ts:1674](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1674)

___

### endBatch

• `Private` **endBatch**: `any`

#### Defined in

[../base/dist/index.d.ts:1678](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1678)

___

### entriesApi

• `Private` **entriesApi**: `any`

#### Defined in

[../base/dist/index.d.ts:1687](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1687)

___

### getMatchingItems

• `Private` **getMatchingItems**: `any`

#### Defined in

[../base/dist/index.d.ts:1683](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1683)

___

### getTypePredicate

• `Private` **getTypePredicate**: `any`

#### Defined in

[../base/dist/index.d.ts:1682](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1682)

___

### isMultiple

• `Private` **isMultiple**: `any`

#### Defined in

[../base/dist/index.d.ts:1681](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1681)

___

### newBatch

• `Private` **newBatch**: `any`

#### Defined in

[../base/dist/index.d.ts:1676](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1676)

___

### opt

• `Private` **opt**: `any`

#### Defined in

[../base/dist/index.d.ts:1673](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1673)

___

### watchDropZone

• `Private` **watchDropZone**: `any`

#### Defined in

[../base/dist/index.d.ts:1685](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1685)

___

### watchInput

• `Private` **watchInput**: `any`

#### Defined in

[../base/dist/index.d.ts:1684](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1684)

___

### defaults

▪ `Static` **defaults**: `Partial`\<[`UploaderOptions`](../interfaces/UploaderOptions.md)\>

#### Defined in

[../base/dist/index.d.ts:1679](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1679)

___

### errorHandler

▪ `Static` **errorHandler**: (`data`: [`UploaderErrorData`](../interfaces/UploaderErrorData.md)) => `void`

#### Type declaration

▸ (`data`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`UploaderErrorData`](../interfaces/UploaderErrorData.md) |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1689](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1689)

___

### requestDefaults

▪ `Static` **requestDefaults**: `Partial`\<[`UploaderRequest`](../interfaces/UploaderRequest.md)\>

#### Defined in

[../base/dist/index.d.ts:1680](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1680)

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

[../base/dist/index.d.ts:1688](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1688)
