[@serenity-is/corelib](../README.md) / UploaderOptions

# Interface: UploaderOptions

Inspired from https://github.com/silverwind/uppie and https://github.com/GoogleChromeLabs/file-drop/blob/master/lib/filedrop.ts

## Table of contents

### Properties

- [accept](UploaderOptions.md#accept)
- [autoClear](UploaderOptions.md#autoclear)
- [batchHandler](UploaderOptions.md#batchhandler)
- [batchProgress](UploaderOptions.md#batchprogress)
- [batchSize](UploaderOptions.md#batchsize)
- [batchStart](UploaderOptions.md#batchstart)
- [batchStop](UploaderOptions.md#batchstop)
- [batchSuccess](UploaderOptions.md#batchsuccess)
- [changeCallback](UploaderOptions.md#changecallback)
- [dropZone](UploaderOptions.md#dropzone)
- [errorHandler](UploaderOptions.md#errorhandler)
- [ignoreType](UploaderOptions.md#ignoretype)
- [input](UploaderOptions.md#input)
- [multiple](UploaderOptions.md#multiple)
- [name](UploaderOptions.md#name)

## Properties

### accept

• `Optional` **accept**: `string`

Accept. If not specified, read from the passed input

#### Defined in

[../base/dist/index.d.ts:1606](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1606)

___

### autoClear

• `Optional` **autoClear**: `boolean`

Auto clear input value after selection, so when same file selected it works. Default is true

#### Defined in

[../base/dist/index.d.ts:1608](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1608)

___

### batchHandler

• `Optional` **batchHandler**: (`batch`: [`UploaderBatch`](UploaderBatch.md), `uploader`: [`Uploader`](../classes/Uploader.md)) => `void` \| `Promise`\<`void`\>

Callback to handle a batch. If not specified, a default handler is used.

#### Type declaration

▸ (`batch`, `uploader`): `void` \| `Promise`\<`void`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `batch` | [`UploaderBatch`](UploaderBatch.md) |
| `uploader` | [`Uploader`](../classes/Uploader.md) |

##### Returns

`void` \| `Promise`\<`void`\>

#### Defined in

[../base/dist/index.d.ts:1630](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1630)

___

### batchProgress

• `Optional` **batchProgress**: (`data`: \{ `batch`: [`UploaderBatch`](UploaderBatch.md) ; `loaded`: `number` ; `total`: `number`  }) => `void`

Progress event that is called during upload

#### Type declaration

▸ (`data`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `Object` |
| `data.batch` | [`UploaderBatch`](UploaderBatch.md) |
| `data.loaded` | `number` |
| `data.total` | `number` |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1624](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1624)

___

### batchSize

• `Optional` **batchSize**: `number`

Only used for multiple, default is 1 to upload multiple files in batches of size 1

#### Defined in

[../base/dist/index.d.ts:1610](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1610)

___

### batchStart

• `Optional` **batchStart**: (`data`: \{ `batch`: [`UploaderBatch`](UploaderBatch.md)  }) => `void`

Progress event that is called when a batch is about to be uploaded

#### Type declaration

▸ (`data`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `Object` |
| `data.batch` | [`UploaderBatch`](UploaderBatch.md) |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1614](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1614)

___

### batchStop

• `Optional` **batchStop**: (`data`: \{ `batch`: [`UploaderBatch`](UploaderBatch.md)  }) => `void`

Progress event that is called when a batch is ended uploading or failed

#### Type declaration

▸ (`data`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `Object` |
| `data.batch` | [`UploaderBatch`](UploaderBatch.md) |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1618](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1618)

___

### batchSuccess

• `Optional` **batchSuccess**: (`data`: [`UploaderSuccessData`](UploaderSuccessData.md)) => `void`

Called after batch is uploaded successfully

#### Type declaration

▸ (`data`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`UploaderSuccessData`](UploaderSuccessData.md) |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1622](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1622)

___

### changeCallback

• `Optional` **changeCallback**: (`e`: `Event`) => `void`

Only called when a change/drop event occurs, but files can't be determined

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1632](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1632)

___

### dropZone

• `Optional` **dropZone**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

An optional list of dropzones.

#### Defined in

[../base/dist/index.d.ts:1612](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1612)

___

### errorHandler

• `Optional` **errorHandler**: (`data`: [`UploaderErrorData`](UploaderErrorData.md)) => `void`

Error handler, if not specified Uploader.errorHandler is used

#### Type declaration

▸ (`data`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`UploaderErrorData`](UploaderErrorData.md) |

##### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1634](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1634)

___

### ignoreType

• `Optional` **ignoreType**: `boolean`

Ignore file types, e.g. don't check accept property of input or this options

#### Defined in

[../base/dist/index.d.ts:1636](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1636)

___

### input

• `Optional` **input**: `HTMLInputElement`

Target input. If null, dropZone should be specified.

#### Defined in

[../base/dist/index.d.ts:1638](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1638)

___

### multiple

• `Optional` **multiple**: `boolean`

Allow multiple files. If not specified is read from the input

#### Defined in

[../base/dist/index.d.ts:1640](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1640)

___

### name

• `Optional` **name**: `string`

The field name to use in FormData object. Default is files[]

#### Defined in

[../base/dist/index.d.ts:1642](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1642)
